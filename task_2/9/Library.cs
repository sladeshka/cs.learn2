using MyClass;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BiblWorm
{
    public partial class Library : Form
    {
        public string BooksAuthor
        {
            get { return textBoxBooksAuthor.Text; }
            set { textBoxBooksAuthor.Text = value; }
        }
        public string BooksTitle
        {
            get { return textBoxBooksTitle.Text; }
            set { textBoxBooksTitle.Text = value; }
        }
        public string BooksPublisher
        {
            get { return textBoxBooksPublisher.Text; }
            set { textBoxBooksPublisher.Text = value; }
        }
        public int BooksPages
        {
            get { return (int)numericUpDownBooksPages.Value; }
            set { numericUpDownBooksPages.Value = value; }
        }
        public int BooksPublished
        {
            get { return (int)numericUpDownBooksPublished.Value; }
            set { numericUpDownBooksPublished.Value = value; }
        }
        public int BooksInventory
        {
            get { return (int)numericUpDownBooksInventory.Value; }
            set { numericUpDownBooksInventory.Value = value; }
        }
        public int BooksPeriod
        {
            get { return (int)numericUpDownBooksPeriod.Value; }
            set { numericUpDownBooksPeriod.Value = value; }
        }
        public bool BooksAvailability
        {
            get { return checkBoxBooksAvailability.Checked; }
            set { checkBoxBooksAvailability.Checked = value; }
        }
        public bool SortInvNumber
        {
            get { return checkBoxSort.Checked; }
            set { checkBoxSort.Checked = value; }
        }
        public bool BooksReturn
        {
            get { return checkBoxBooksReturn.Checked; }
            set { checkBoxBooksReturn.Checked = value; }
        }
        public string MagazinesTitle
        {
            get { return textBoxMagazinesTitle.Text; }
            set { textBoxMagazinesTitle.Text = value; }
        }
        public string MagazinesValume
        {
            get { return textBoxMagazinesVolume.Text; }
            set { textBoxMagazinesVolume.Text = value; }
        }
        public int MagazinesNumber
        {
            get { return (int)numericUpDownMagazinesNumber.Value; }
            set { numericUpDownMagazinesNumber.Value = value; }
        }
        public int MagazinesPublished
        {
            get { return (int)numericUpDownMagazinesPublished.Value; }
            set { numericUpDownMagazinesPublished.Value = value; }
        }
        public int MagazinesInventory
        {
            get { return (int)numericUpDownMagazinesInventory.Value; }
            set { numericUpDownMagazinesInventory.Value = value; }
        }
        public bool MagazinesSubscription
        {
            get { return checkBoxMagazinesSubscription.Checked; }
            set { checkBoxMagazinesSubscription.Checked = value; }
        }

        List<Item> its = new List<Item>();
        public Library()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book book = new(BooksAuthor, BooksTitle, BooksPublisher, BooksPages, BooksPublished, BooksInventory, BooksAvailability);
            if (BooksReturn)
                book.ReturnSrok();
            book.PriceBook(BooksPeriod);
            its.Add(book);
            BooksAuthor = BooksTitle = BooksPublisher = "";
            BooksPages = 1;
            BooksInventory = 1;
            BooksPublished = 1000;
            BooksAvailability = BooksReturn = false;
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

        private void buttonMagazinesAdd_Click(object sender, EventArgs e)
        {
            Magazine magazine = new(MagazinesValume, MagazinesNumber, MagazinesTitle, MagazinesPublished, MagazinesInventory, true);
            magazine.IfSubs = MagazinesSubscription;
            its.Add(magazine);
            MagazinesTitle = MagazinesValume = "";
            MagazinesInventory = MagazinesNumber = 1;
            MagazinesPublished = 1000;
            MagazinesSubscription = false;
        }
    }
}