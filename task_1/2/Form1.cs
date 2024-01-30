namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new ();
            path.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(0, this.Width) });
            Region region= new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}