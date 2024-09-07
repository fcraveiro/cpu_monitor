using LibreHardwareMonitor.Hardware;
using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Management;

#pragma warning disable CA1050 // Declare types in namespaces
public partial class Form1 : Form
#pragma warning restore CA1050 // Declare types in namespaces
{
    private readonly Computer _computer;
    private readonly System.Windows.Forms.Timer _timer;

    public Form1()
    {
        InitializeComponent();

        _computer = new Computer
        {
            IsCpuEnabled = true,
            IsMotherboardEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsStorageEnabled = true
        };
        _computer.Open();

        _timer = new System.Windows.Forms.Timer
        {
            Interval = 10
        };
        _timer.Tick += Timer_Tick;
        _timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        UpdateHardwareInfo();
    }

    private void UpdateHardwareInfo()
    {
        StringBuilder sb = new StringBuilder();

        try
        {
            string motherboardInfo = GetMotherboardInfo();
            string processorInfo = GetProcessorInfo();
            string cpuTemperature = GetCpuTemperature();
            string cpuUsage = GetCpuUsage();
            string storageInfo = GetStorageInfo();

            sb.AppendLine($"Placa Mãe: {motherboardInfo}");
            sb.AppendLine($"Processador: {processorInfo}");
            sb.AppendLine($"Temperatura da CPU: {cpuTemperature}");
            sb.AppendLine($"Uso da CPU: {cpuUsage}");
            sb.AppendLine($"Armazenamento:\n{storageInfo}");

            textBoxInfo.Text = sb.ToString();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Erro ao atualizar informações de hardware: {ex.Message}");
            textBoxInfo.Text = "Erro ao obter informações de hardware. Verifique o log para mais detalhes.";
        }
    }

    private string GetMotherboardInfo()
    {
        foreach (var hardware in _computer.Hardware)
        {
            if (hardware.HardwareType == HardwareType.Motherboard)
            {
                return hardware.Name;
            }
        }
        return "Desconhecida";
    }

    private string GetProcessorInfo()
    {
        foreach (var hardware in _computer.Hardware)
        {
            if (hardware.HardwareType == HardwareType.Cpu)
            {
                return hardware.Name;
            }
        }
        return "Desconhecido";
    }

    private string GetCpuTemperature()
    {
        foreach (var hardware in _computer.Hardware)
        {
            if (hardware.HardwareType == HardwareType.Cpu)
            {
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        return sensor.Value.HasValue ? $"{sensor.Value.Value:F1} °C" : "Desconhecida";
                    }
                }
            }
        }
        return "Desconhecida";
    }

    private string GetCpuUsage()
    {
        foreach (var hardware in _computer.Hardware)
        {
            if (hardware.HardwareType == HardwareType.Cpu)
            {
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Load)
                    {
                        return sensor.Value.HasValue ? $"{sensor.Value.Value:F1}%" : "Desconhecido";
                    }
                }
            }
        }
        return "Desconhecido";
    }

private string GetStorageInfo()
{
    StringBuilder sb = new StringBuilder();
    bool storageFound = false;

    foreach (var hardware in _computer.Hardware)
    {
        if (hardware.HardwareType == HardwareType.Storage)
        {
            storageFound = true;
            sb.AppendLine($"  - {hardware.Name}");

            double? temperature = null;
            hardware.Update();

            foreach (var sensor in hardware.Sensors)
            {
                if (sensor.SensorType == SensorType.Temperature)
                {
                    temperature = sensor.Value;
                    break;
                }
            }

            sb.AppendLine($"    Temperatura: {(temperature.HasValue ? $"{temperature.Value:F1} °C" : "Desconhecida")}");

            // Tenta obter informações de espaço usando WMI
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DriveType=3");
                foreach (ManagementObject disk in searcher.Get().Cast<ManagementObject>())
                {
                    string? driveLetter = disk["DeviceID"]?.ToString();
                    long freeSpace = Convert.ToInt64(disk["FreeSpace"]);
                    long totalSpace = Convert.ToInt64(disk["Size"]);
                    long usedSpace = totalSpace - freeSpace;

                    sb.AppendLine($"    Unidade: {driveLetter}");
                    sb.AppendLine($"    Espaço Total: {FormatBytes(totalSpace)}");
                    sb.AppendLine($"    Espaço Usado: {FormatBytes(usedSpace)}");
                    sb.AppendLine($"    Espaço Disponível: {FormatBytes(freeSpace)}");
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine($"    Erro ao obter informações de espaço: {ex.Message}");
            }

            sb.AppendLine();
        }
    }

    return storageFound ? sb.ToString() : "Nenhum dispositivo de armazenamento encontrado.";
}

private static string FormatBytes(long bytes)
{
    string[] suffixes = ["B", "KB", "MB", "GB", "TB", "PB"];
    int counter = 0;
    decimal number = (decimal)bytes;
    while (Math.Round(number / 1024) >= 1)
    {
        number /= 1024;
        counter++;
    }
    return string.Format("{0:n1} {1}", number, suffixes[counter]);
}

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _timer.Stop();
        _computer.Close();
        base.OnFormClosing(e);
    }
}