﻿using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = "Текст из конструктора";
            string hexValue = "#FF0000";
            Color color = ColorTranslator.FromHtml(hexValue);
            this.BackColor = color;
        }

        private bool stringIsSpaces(string str)
        {
            for(int i = 0; i < str.Length; i++) 
            {
                char symbol = str[i];
                if(symbol != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        // ДЗ: добавить проверку на пробелы в конце
        private void AddPeople_Click(object sender, System.EventArgs e)
        {
            string inputText = PeopleTextBox.Text;
            if(inputText == string.Empty)
            {
                MessageBox.Show("Пустые значения недопустимы");
                return;
            }

            if(stringIsSpaces(inputText))
            {
                MessageBox.Show("Извините, у Вас одни пробелы");
                return;
            }       

            // используется метод TrimEnd, который удаляет все конечные пробелы из текущей строки
            inputText = inputText.TrimEnd();
            
            Peoples.Items.Add(inputText);
            File.WriteAllText("D:\\ert.txt", inputText);
        }

        private void Peoples_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selectedIndex = Peoples.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Peoples.Items.RemoveAt(selectedIndex);
                }
            }
        }
    }
}
