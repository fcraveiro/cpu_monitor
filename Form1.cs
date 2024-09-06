using LibreHardwareMonitor.Hardware;
using System;
using System.Text;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private readonly Computer _computer; // Objeto para monitoramento
    private readonly System.Windows.Forms.Timer _timer; // Timer para atualizar as informações

    public Form1()
    {
        InitializeComponent(); // Inicializa os componentes visuais

        _computer = new Computer
        {
            IsCpuEnabled = true,
            IsMotherboardEnabled = true,
            IsGpuEnabled = true, // Habilitar monitoramento de GPU (se necessário)
            IsStorageEnabled = true // Habilitar monitoramento de armazenamento
        };
        _computer.Open();

        _timer = new System.Windows.Forms.Timer
        {
            Interval = 1000 // Atualizar a cada 1 segundo
        };
        _timer.Tick += Timer_Tick;
        _timer.Start();
    }

    // Método com assinatura correspondente ao delegado EventHandler
    private void Timer_Tick(object? sender, EventArgs e)
    {
        UpdateHardwareInfo();
    }

    private void UpdateHardwareInfo()
    {
        string cpuTemperature = "Desconhecida";
        string cpuUsage = "Desconhecido";
        string motherboardInfo = "Desconhecida";
        string processorInfo = "Desconhecido";
        string storageInfo = "Desconhecido";
        
        bool storageFound = false;
        StringBuilder sb = new StringBuilder();

        foreach (var hardware in _computer.Hardware)
        {
            if (hardware.HardwareType == HardwareType.Cpu)
            {
                processorInfo = hardware.Name; // Nome do processador

                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        cpuTemperature = sensor.Value.HasValue ? $"{sensor.Value.Value} °C" : "Desconhecida";
                    }
                    else if (sensor.SensorType == SensorType.Load)
                    {
                        cpuUsage = sensor.Value.HasValue ? $"{sensor.Value.Value}%" : "Desconhecido";
                    }
                }
            }
            else if (hardware.HardwareType == HardwareType.Motherboard)
            {
                motherboardInfo = hardware.Name; // Nome da placa-mãe
            }
            else if (hardware.HardwareType == HardwareType.Storage)
            {
                storageFound = true;
                sb.AppendLine("Armazenamento: " + hardware.Name);
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Data)
                    {
                        string name = sensor.Name;
                        if (name.Contains("Used"))
                        {
                            sb.AppendLine("Espaço Usado: " + FormatValue(sensor.Value) + " GB");
                        }
                        else if (name.Contains("Available"))
                        {
                            sb.AppendLine("Espaço Disponível: " + FormatValue(sensor.Value) + " GB");
                        }
                    }
                }
            }
        }

        storageInfo = storageFound ? sb.ToString() : "Nenhum armazenamento encontrado.";

        // Atualiza os labels com as informações corretas
        label1.Text = $"Placa Mãe: {motherboardInfo}";
        label2.Text = $"Processador: {processorInfo}";
        label3.Text = $"Temperatura da CPU: {cpuTemperature}";
        label4.Text = $"Uso da CPU: {cpuUsage}";
        label5.Text = $"Armazenamento: {storageInfo}";
    }

    private string FormatValue(double? value)
    {
        return value.HasValue ? $"{value.Value:F2}" : "Desconhecido";
    }
}
