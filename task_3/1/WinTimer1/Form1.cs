namespace WinTimer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            userControlTimer1.TimeEnabled = !userControlTimer1.TimeEnabled;
            if (!userControlTimer1.TimeEnabled) {
                buttonChange.Text = "Start";
            } else {
                buttonChange.Text = "Stop";
            }
        }
    }
}