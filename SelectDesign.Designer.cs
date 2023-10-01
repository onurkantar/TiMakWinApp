namespace TiMakWinApp
{
    partial class SelectDesign
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(39, 55, 77);
            button1.FlatAppearance.BorderColor = Color.FromArgb(237, 237, 237);
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(237, 237, 237);
            button1.Location = new Point(230, 210);
            button1.Name = "button1";
            button1.Size = new Size(260, 60);
            button1.TabIndex = 0;
            button1.Text = "Dizayn Dosyaları Seçin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(39, 55, 77);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(237, 237, 237);
            textBox1.Location = new Point(230, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 86);
            textBox1.TabIndex = 1;
            textBox1.Text = "TiMak V1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.ReadOnly = true;

            // 
            // SelectDesign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(39, 55, 77);
            ClientSize = new Size(704, 321);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "SelectDesign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TiMak";
            Load += Form1_Load;
            Resize += SelectDesign_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
    }
}