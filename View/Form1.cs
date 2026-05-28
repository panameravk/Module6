using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module6.Server;
using Module6.Test;
using Word = Microsoft.Office.Interop.Word;

namespace Module6
{
    public partial class Form1 : Form
    {                
        private string mobilePhonePattern = @"^\+7 \d{3} \d{3}-\d{2}-\d{2}$";        
        public Form1()
        {
            InitializeComponent();
        }

        private async void getDataButton_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:4444/TransferSimulator/mobilePhone";

            string data = await ServerRequest.GetRequest(url);

            if(data != null)
            {
                dataTextBox.Text = GetDataFromJSON(data);
            }            
        }

        private string GetDataFromJSON(string data)
        {
            return data.Substring(data.IndexOf(":") + 2)
                .Replace("\"", "")
                .Replace("}", "");
        }

        private void sendResultButton_Click(object sender, EventArgs e)
        {
            if(dataTextBox.Text.Equals(""))
            {
                MessageBox.Show("Данные с сервера ещё не получены",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            else
            {
                CheckData(dataTextBox.Text, mobilePhonePattern);
            }
        }

        private void CheckData(string data, string pattern)
        {
            if(!Regex.IsMatch(data, pattern))
            {
                WordWriter.WriteToWord(
                    "C:\\Users\\User\\source\\repos\\Module6\\ТестКейс.docx",
                    1,
                    1,
                    "Не успешно",
                    "Не успешно",
                    data);
                resultTextBox.Text = "Данные провалили валидацию";
                resultTextBox.ForeColor = Color.Red;
            }
            else
            {
                WordWriter.WriteToWord(
                    "C:\\Users\\User\\source\\repos\\Module6\\ТестКейс.docx",
                    1,
                    1,
                    "Успешно", 
                    "Успешно",
                    data);
                resultTextBox.Text = "Данные успешно прошли валидацию";
                resultTextBox.ForeColor = Color.Green;
            }
        }
    }
}
