namespace EditPerson
{
    public partial class Form1 : Form
    {
        public ListViewItem personsListView;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditPersonForm editForm = new EditPersonForm();
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            personsListView.SubItems.Add(editForm.Name);
            personsListView.SubItems.Add(editForm.Surname);
            personsListView.SubItems.Add(editForm.Age.ToString());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedItems.Count == 0)
                return;
            ListViewItem item = personsListView.SelectedItems[0];
            EditPersonForm editForm = new EditPersonForm();
            editForm.Name = item.Text;
            editForm.Surname = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            item.Text = editForm.Name;
            item.SubItems[1].Text = editForm.Name;
            item.SubItems[2].Text = editForm.Age.ToString();
        }
    }
}