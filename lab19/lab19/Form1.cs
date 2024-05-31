using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;


namespace lab19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFetchInfo_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();

            DisplayHardwareInfo("Процесор:", "Win32_Processor", "Name");
            DisplayHardwareInfo("Виробник:", "Win32_Processor", "Manufacturer");
            DisplayHardwareInfo("Опис:", "Win32_Processor", "Description");
            textBoxOutput.AppendText(Environment.NewLine);

            DisplayHardwareInfo("Відеокарта:", "Win32_VideoController", "Name");
            DisplayHardwareInfo("Відеопроцесор:", "Win32_VideoController", "VideoProcessor");
            DisplayHardwareInfo("Версія драйвера:", "Win32_VideoController", "DriverVersion");
            DisplayHardwareInfo("Обсяг пам'яті (в байтах):", "Win32_VideoController", "AdapterRAM");
            textBoxOutput.AppendText(Environment.NewLine);

            DisplayHardwareInfo("Назва DVD:", "Win32_CDROMDrive", "Name");
            DisplayHardwareInfo("Буква DVD:", "Win32_CDROMDrive", "Drive");
            textBoxOutput.AppendText(Environment.NewLine);

            DisplayHardwareInfo("Жорсткий диск:", "Win32_DiskDrive", "Caption");
            DisplayHardwareInfo("Обсяг (у байтах):", "Win32_DiskDrive", "Size");
            textBoxOutput.AppendText(Environment.NewLine);

            // Дополнительная информация
            DisplayHardwareInfo("Материнська плата:", "Win32_BaseBoard", "Product");
            DisplayHardwareInfo("Мережеве обладнання:", "Win32_NetworkAdapter", "Name");
            DisplayHardwareInfo("Версія BIOS:", "Win32_BIOS", "Version");
            DisplayHardwareInfo("Виробник BIOS:", "Win32_BIOS", "Manufacturer");
            DisplayHardwareInfo("Серійний номер BIOS:", "Win32_BIOS", "SerialNumber");
        }

        private void DisplayHardwareInfo(string info, string win32Class, string classItemField)
        {
            List<string> result = GetHardwareInfo(win32Class, classItemField);
            OutputResult(info, result);
        }

        private List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField]?.ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                result.Add("Помилка: " + ex.Message);
            }
            return result;
        }

        private void OutputResult(string info, List<string> result)
        {
            if (!string.IsNullOrEmpty(info))
            {
                textBoxOutput.AppendText(info + Environment.NewLine);
            }
            if (result.Count > 0)
            {
                foreach (string item in result)
                {
                    textBoxOutput.AppendText(item + Environment.NewLine);
                }
            }
            textBoxOutput.AppendText(Environment.NewLine);
        }
    }
}
