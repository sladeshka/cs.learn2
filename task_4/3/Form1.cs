using System;
using System.Drawing;
using System.Text;

namespace EditPerson
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            EditPersonForm editForm = new EditPersonForm(person);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            persons.Add(person);
            listView1.VirtualListSize = persons.Count;
            listView1.Invalidate();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
                return;
            Person person = persons[listView1.SelectedIndices[0]];
            EditPersonForm editForm = new EditPersonForm(person);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listView1.Invalidate();
            }
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < persons.Count)
            {
                e.Item = new ListViewItem(persons[e.ItemIndex].Name);
                e.Item.SubItems.Add(persons[e.ItemIndex].Surname);
                e.Item.SubItems.Add(persons[e.ItemIndex].Age.ToString());
            }
        }

        private void buttonViewList_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in persons)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}