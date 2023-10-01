
namespace TiMakWinApp
{
    public partial class TiMakV1 : Form
    {
        string[] FileNames;
        string[] SafeFileNames;

        private Rectangle originalFormSize;
        private Rectangle textBoxOriginalRectangle;
        private Rectangle listBoxOriginalRectangle;
        private Rectangle reSelectDesignsButtonOriginalRectangle;
        private Rectangle printButtonOriginalRectangle;
        private Rectangle sharpGLOriginalRectangle;

        public TiMakV1(string[] FileNames, string[] SafeFileNames)
        {
            this.FileNames = FileNames;
            this.SafeFileNames = SafeFileNames;
            InitializeComponent();
        }

        private void TiMakV1_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(820, 490);

            originalFormSize = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
            textBoxOriginalRectangle = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            listBoxOriginalRectangle = new Rectangle(listBox1.Location.X, listBox1.Location.Y, listBox1.Width, listBox1.Height);
            reSelectDesignsButtonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            printButtonOriginalRectangle = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            sharpGLOriginalRectangle = new Rectangle(openglControl1.Location.X, openglControl1.Location.Y, openglControl1.Width, openglControl1.Height);

            foreach (var SafeFileName in SafeFileNames)
            {
                listBox1.Items.Add(SafeFileName);
            }


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
        private void TiMakV1_Resize(object sender, EventArgs e)
        {
            resizeControl(textBoxOriginalRectangle, textBox1);
            resizeControl(listBoxOriginalRectangle, listBox1);
            resizeControl(reSelectDesignsButtonOriginalRectangle, button1);
            resizeControl(printButtonOriginalRectangle, button2);
            resizeControl(sharpGLOriginalRectangle, openglControl1);
        }
    }
}
