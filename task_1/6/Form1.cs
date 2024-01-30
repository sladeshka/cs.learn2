namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.FillPolygon(Brushes.Green, new Point[] { new Point(165, 0), new Point(330, 165), new Point(165, 330), new Point(0, 165) });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}