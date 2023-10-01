namespace TiMakWinApp
{
    partial class TiMakV1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Tabladaki Tasarımlar";
            textBox1.TabStop = false;
            textBox1.ReadOnly = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(124, 244);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 366);
            button1.Name = "button1";
            button1.Size = new Size(124, 51);
            button1.TabIndex = 2;
            button1.Text = "Tasarımları Yeniden Seç";
            button1.UseVisualStyleBackColor = true;
            // 
            // TiMakV1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 55, 77);
            ClientSize = new Size(804, 451);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "TiMakV1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TiMakV1";
            Load += TiMakV1_Load;
            Resize += TiMakV1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
    }
}