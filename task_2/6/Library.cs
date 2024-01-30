using MyClass;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BiblWorm
{
    public partial class Library : Form
    {
        public string Author
        {
            get { return textBoxAuthor.Text; }
            set { textBoxAuthor.Text = value; }
        }
        public string Title
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }
        public string PublishHouse
        {
            get { return textBoxPublisher.Text; }
            set { textBoxPublisher.Text = value; }
        }
        public int Page
        {
            get { return (int)numericUpDownPages.Value; }
            set { numericUpDownPages.Value = value; }
        }
        public int Year
        {
            get { return (int)numericUpDownPublished.Value; }
            set { numericUpDownPublished.Value = value; }
        }
        public int InvNumber
        {
            get { return (int)numericUpDownInventory.Value; }
            set { numericUpDownInventory.Value = value; }
        }
        public bool Existence
        {
            get { return checkBoxAvailability.Checked; }
            set { checkBoxAvailability.Checked = value; }
        }
        public bool SortInvNumber
        {
            get { return checkBoxSort.Checked; }
            set { checkBoxSort.Checked = value; }
        }
        public bool ReturnTime
        {
            get { return checkBoxReturn.Checked; }
            set { checkBoxReturn.Checked = value; }
        }
        public int PeriodUse
        {
            get { return (int)numericUpDownPeriod.Value; }
            set { numericUpDownPeriod.Value = value; }
        }
        List<Item> its = new List<Item>();
        public Library()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book book = new(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                book.ReturnSrok();
            book.PriceBook(PeriodUse);
            its.Add(book);
            Author = Title = PublishHouse = "";
            Page = 1;
            InvNumber = 1;
            PeriodUse = 1;
            Year = 1000;
            Existence = ReturnTime = false;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}