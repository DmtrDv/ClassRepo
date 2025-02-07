namespace FirstWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Images = new System.Windows.Forms.ListBox();
            this.AddPeople = new System.Windows.Forms.Button();
            this.PictureArea = new System.Windows.Forms.PictureBox();
            this.SelectedImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ChangeName = new System.Windows.Forms.Button();
            this.СhangeableName_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Images
            // 
            this.Images.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Images.FormattingEnabled = true;
            this.Images.ItemHeight = 16;
            this.Images.Location = new System.Drawing.Point(0, -5);
            this.Images.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(352, 356);
            this.Images.TabIndex = 0;
            this.Images.SelectedIndexChanged += new System.EventHandler(this.Images_SelectedIndexChanged);
            this.Images.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Peoples_PreviewKeyDown);
            // 
            // AddPeople
            // 
            this.AddPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPeople.Location = new System.Drawing.Point(4, 407);
            this.AddPeople.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPeople.Name = "AddPeople";
            this.AddPeople.Size = new System.Drawing.Size(100, 28);
            this.AddPeople.TabIndex = 1;
            this.AddPeople.Text = "Добавить";
            this.AddPeople.UseVisualStyleBackColor = true;
            this.AddPeople.Click += new System.EventHandler(this.AddPeople_Click);
            // 
            // PictureArea
            // 
            this.PictureArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureArea.Location = new System.Drawing.Point(0, 0);
            this.PictureArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureArea.Name = "PictureArea";
            this.PictureArea.Size = new System.Drawing.Size(615, 442);
            this.PictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureArea.TabIndex = 3;
            this.PictureArea.TabStop = false;
            // 
            // SelectedImageFileDialog
            // 
            this.SelectedImageFileDialog.Filter = "Image files|*.jpg;*.bmp";
            this.SelectedImageFileDialog.Multiselect = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.СhangeableName_TextBox);
            this.panel1.Controls.Add(this.button_ChangeName);
            this.panel1.Controls.Add(this.Images);
            this.panel1.Controls.Add(this.AddPeople);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 442);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PictureArea);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(353, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 442);
            this.panel2.TabIndex = 5;
            // 
            // button_ChangeName
            // 
            this.button_ChangeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ChangeName.Location = new System.Drawing.Point(186, 365);
            this.button_ChangeName.Margin = new System.Windows.Forms.Padding(4);
            this.button_ChangeName.Name = "button_ChangeName";
            this.button_ChangeName.Size = new System.Drawing.Size(134, 28);
            this.button_ChangeName.TabIndex = 2;
            this.button_ChangeName.Text = "Изменить имя";
            this.button_ChangeName.UseVisualStyleBackColor = true;
            this.button_ChangeName.Click += new System.EventHandler(this.button_ChangeName_Click);
            // 
            // СhangeableName_TextBox
            // 
            this.СhangeableName_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.СhangeableName_TextBox.Location = new System.Drawing.Point(4, 368);
            this.СhangeableName_TextBox.Name = "СhangeableName_TextBox";
            this.СhangeableName_TextBox.Size = new System.Drawing.Size(175, 22);
            this.СhangeableName_TextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(968, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Заголовок главной формы";
            ((System.ComponentModel.ISupportInitialize)(this.PictureArea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Images;
        private System.Windows.Forms.Button AddPeople;
        private System.Windows.Forms.PictureBox PictureArea;
        private System.Windows.Forms.OpenFileDialog SelectedImageFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ChangeName;
        private System.Windows.Forms.TextBox СhangeableName_TextBox;
    }
}

