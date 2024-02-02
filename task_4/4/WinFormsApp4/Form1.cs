namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public string SolData
        {
            get
            { return textBox1.Text; }
            set
            { textBox1.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(this);
        }
    }
}