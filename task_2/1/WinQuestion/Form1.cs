namespace WinQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We have no doubt that you think so!");
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNo_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonNo.Top -= e.Y;
            ButtonNo.Left += e.X;
            if (ButtonNo.Top < -10 || ButtonNo.Top > 100)
                ButtonNo.Top = 60;
            if (ButtonNo.Left < -80 || ButtonNo.Left > 250)
                ButtonNo.Left = 120;
        }
    }
}