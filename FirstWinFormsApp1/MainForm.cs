﻿using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<string> fullPaths_ = new List<string>();
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

        private bool isExistsPath(string path)
        {
            foreach(string p in fullPaths_)
            {
                if(p == path)
                {
                    return true;
                }
            }

            return false;
        }

        private void AddPeople_Click(object sender, System.EventArgs e)
        {
            if (SelectedImageFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл            
            foreach (string fullPathToFile in SelectedImageFileDialog.FileNames)
            {
                string fileName = Path.GetFileName(fullPathToFile);
                if (isExistsPath(fullPathToFile))
                {
                    MessageBox.Show(
                        $"Извините, но такая картинка добавлена с именем {fileName}, " +
                        $"под индексом: {fullPaths_.IndexOf(fullPathToFile)}"
                        );

                    return;
                }
                fullPaths_.Add(fullPathToFile);
                Images.Items.Add(fileName);
            }
        }

        private void Peoples_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selectedIndex = Images.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    Images.Items.RemoveAt(selectedIndex);
                }
            }
        }

        private void Images_SelectedIndexChanged(object sender, System.EventArgs e)
        {            
            int selectedIndex = Images.SelectedIndex;
            if(selectedIndex < 0)
            {
                return;
            }
            string fullPath = fullPaths_[selectedIndex];

            PictureArea.Load(fullPath);
        }

        private void button_ChangeName_Click(object sender, System.EventArgs e)
        {
            int selectedIndex = Images.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("не выбран элемент");
            }
            if (selectedIndex >= 0)
            {
                Images.Items[selectedIndex] = СhangeableName_TextBox.Text;
            }
        }

        private void button_EditPath_Click(object sender, System.EventArgs e)
        {
            int selectedIndex = Images.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("не выбран элемент");
            }
            if (selectedIndex >= 0)
            {
                SelectedImageFileDialog.ShowDialog();
                string newPath = SelectedImageFileDialog.FileName;
                fullPaths_[selectedIndex] = newPath;
                Images.Items[selectedIndex] = Images.Items[selectedIndex];
            }
        }
    }
}
