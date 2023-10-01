using System.Threading;

namespace TiMakWinApp
{
    public partial class SelectDesign : Form
    {
        private Rectangle buttonOriginalRectangle;
        private Rectangle textBoxOriginalRectangle;
        private Rectangle originalFormSize;

        Thread th;
        string[] fileNames;
        string[] safeFileNames;


        public SelectDesign()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.Font;
            MinimumSize = new Size(720, 360);
            originalFormSize = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
            buttonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            textBoxOriginalRectangle = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "STL|*.stl";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "STL Dosyalarını Seçiniz..";
            file.Multiselect = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                fileNames = file.FileNames;
                safeFileNames = file.SafeFileNames;
                this.Close();

                th = new Thread(openApplication);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void openApplication()
        {
            Application.Run(new TiMakV1(fileNames, safeFileNames));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void SelectDesign_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonOriginalRectangle, button1);
            resizeControl(textBoxOriginalRectangle, textBox1);
        }
    }
}