using LibreHardwareMonitor.Hardware;
using System;
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
            IsMotherboardEnabled = true // Habilitar monitoramento da placa-mãe
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

        foreach (var hardware in _computer.Hardware)
        {
            if (hardware.HardwareType == HardwareType.Cpu)
            {
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
        }

        label1.Text = $"Temperatura da CPU: {cpuTemperature}";
        label2.Text = $"Uso da CPU: {cpuUsage}";
        label3.Text = $"Placa Mãe: {motherboardInfo}";
    }
}
