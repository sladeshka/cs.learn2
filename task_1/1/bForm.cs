namespace WinFormsApp1
{
    public partial class bForm : Form
    {
        nForm form;

        public bForm()
        {
            InitializeComponent();
            form = new nForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                form.Show();
                form.Activate();
            }
            catch (Exception)
            {
                form = new nForm();
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                form.Show();
                form.Activate();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}