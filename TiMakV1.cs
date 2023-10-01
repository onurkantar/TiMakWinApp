using SharpGL.SceneGraph.Assets;
using SharpGL;
using SharpGLTexturesSample;
using STL_Tools;
using SharpGL.SceneGraph;

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
        private Rectangle openGLOriginalRectangle;
        private List<ShapeRenderer> listShape = new List<ShapeRenderer>();

        Camera cam;
        Texture texture = new Texture();


        public TiMakV1(string[] FileNames, string[] SafeFileNames)
        {
            this.FileNames = FileNames;
            this.SafeFileNames = SafeFileNames;
            InitializeComponent();

            STLReader stlReader = new STLReader(FileNames[0]);
            TriangleMesh[] meshArray = stlReader.ReadFile();

            //  Get the OpenGL object, for quick access.
            SharpGL.OpenGL gl = openglControl1.OpenGL;

            //  A bit of extra initialisation here, we have to enable textures.
            gl.Enable(OpenGL.GL_TEXTURE_2D);

            //Camera numbers set up
            float fov = 70.0f,
                aspect = (float)openglControl1.Width / (float)openglControl1.Height,
                zNear = 0.1f,
                zFar = 100.0f;
            Vertex eyeVertex = new Vertex(2.0f, 2.0f, 2.0f);
            Vertex centerVertex = new Vertex(0.0f, 0.0f, 0.0f);
            Vertex upVertex = new Vertex(0.0f, 1.0f, 0.0f);

            cam = new Camera(gl, fov, aspect, zNear, zFar, eyeVertex, centerVertex, upVertex);
        }

        private void TiMakV1_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(820, 490);

            originalFormSize = new Rectangle(Location.X, Location.Y, Size.Width, Size.Height);
            textBoxOriginalRectangle = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            listBoxOriginalRectangle = new Rectangle(listBox1.Location.X, listBox1.Location.Y, listBox1.Width, listBox1.Height);
            reSelectDesignsButtonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            printButtonOriginalRectangle = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            openGLOriginalRectangle = new Rectangle(openglControl1.Location.X, openglControl1.Location.Y, openglControl1.Width, openglControl1.Height);

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
            resizeControl(openGLOriginalRectangle, openglControl1);
        }

        private void openglControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            //  Get the OpenGL object, for quick access.
            SharpGL.OpenGL gl = openglControl1.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);


            gl.Color(1.0f, 1.0f, 1.0f);

            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();

            cam.Look();

            gl.Disable(OpenGL.GL_TEXTURE_2D);
            PlaneSurfaceRenderer psr = new PlaneSurfaceRenderer(16);
            psr.render(gl);


            texture.Bind(gl);
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            foreach (ShapeRenderer shape in listShape)
            {
                shape.render(gl);
            }
        }

        private void openglControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.X:
                    cam.ZoomIn();
                    break;
                case Keys.Z:
                    cam.ZoomOut();
                    break;
                case Keys.A:
                    cam.GoLeft();
                    break;
                case Keys.D:
                    cam.GoRight();
                    break;
                case Keys.W:
                    cam.GoUp();
                    break;
                case Keys.S:
                    cam.GoDown();
                    break;
                default:
                    break;
            }
            cam.Look();
        }
    }
}
