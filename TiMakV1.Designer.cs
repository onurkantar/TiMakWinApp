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
            openglControl1 = new SharpGL.OpenGLControl();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)openglControl1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(39, 55, 77);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(237, 237, 237);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(124, 16);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Tabladaki Tasarımlar";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(39, 55, 77);
            listBox1.ForeColor = Color.FromArgb(237, 237, 237);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(124, 244);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(237, 237, 237);
            button1.Location = new Point(12, 343);
            button1.Name = "button1";
            button1.Size = new Size(124, 45);
            button1.TabIndex = 2;
            button1.Text = "Tasarımları Yeniden Seç";
            button1.UseVisualStyleBackColor = false;
            // 
            // openglControl1
            // 
            openglControl1.DrawFPS = false;
            openglControl1.Location = new Point(143, 12);
            openglControl1.Margin = new Padding(4, 3, 4, 3);
            openglControl1.Name = "openglControl1";
            openglControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            openglControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            openglControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            openglControl1.Size = new Size(648, 427);
            openglControl1.TabIndex = 3;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(237, 237, 237);
            button2.Location = new Point(12, 394);
            button2.Name = "button2";
            button2.Size = new Size(124, 45);
            button2.TabIndex = 4;
            button2.Text = "Yazdır";
            button2.UseVisualStyleBackColor = false;
            // 
            // TiMakV1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 55, 77);
            ClientSize = new Size(804, 451);
            Controls.Add(button2);
            Controls.Add(openglControl1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "TiMakV1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TiMakV1";
            Load += TiMakV1_Load;
            Resize += TiMakV1_Resize;
            ((System.ComponentModel.ISupportInitialize)openglControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private SharpGL.OpenGLControl openglControl1;
        private Button button2;
    }
}