namespace WinGrafSinLine
{
    public partial class Form1 : Form
    {
        public double a, b;
        public string DataA
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public string DataB
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
            a = 0.1;
            b = 0.04;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            Pen p = new Pen(Color.Red, 1);
            Point p1, p2;
            double t = 0;
            int w = (int)panel1.Width;
            int h = (int)panel1.Height;
            int y = h / 2;
            for (int x = 0; x < w; x++)
            {
                p1 = new Point(x, y);
                t = Operation.SummSin(x, a, b);
                y = (int)(t * h / 5);
                y = y + h / 2;
                p2 = new Point(x, y);
                dc.DrawLine(p, p1, p2);
            }
        }

        private void buttonCalculation_Click(object sender, EventArgs e)
        {
            Edit editF = new();

            if (editF.ShowDialog() != DialogResult.OK)
                return;

            try {
                a = editF.a;
                b = editF.b;
                DataA = editF.DataA;
                DataB = editF.DataB;
                panel1.Refresh();
            } catch (Exception er) {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + er.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}