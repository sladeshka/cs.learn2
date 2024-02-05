namespace Balls
{
    public partial class BallForm : Form
    {
        public Point location;
        public Point speed;

        public BallForm()
        {
            InitializeComponent();
            this.location = new Point(50, 50);
            this.speed = new Point(5, 5);
        }

        public void Go()
        {
            this.location = new Point(this.location.X + this.speed.X, this.location.Y + this.speed.Y);
            if (this.location.X > Size.Width || this.location.X < 0)
                speed = new Point(- this.speed.X, this.speed.Y);
            if (this.location.Y + 10 > Size.Height || this.location.Y < 10)
                this.speed = new Point(this.speed.X, - this.speed.Y);
        }

        public void Ball()
        {
            Graphics gr = Graphics.FromHwnd(this.Handle);
            gr.FillEllipse(Brushes.Cyan, this.location.X, this.location.Y, 10, 10);
            Go();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Ball();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Point location = new(50, 50);
            Point speed = new(5, 5);
            if (checkGo.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGo.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }
    }
}