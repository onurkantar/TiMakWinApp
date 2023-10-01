using System.Windows.Forms;

namespace TiMakWinApp
{
    public partial class SelectDesign : Form
    {
        public SelectDesign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "STL|*.stl";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "STL Dosyası Seçiniz..";
            file.Multiselect = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}