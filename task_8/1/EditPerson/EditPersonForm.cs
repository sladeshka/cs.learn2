using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class EditPersonForm : Form
    {
        public Person person;
        public string Name
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }
        public string Surname
        {
            get { return textBoxSurname.Text; }
            set { textBoxSurname.Text = value; }
        }
        public int Age
        {
            get { return (int)numericUpDownAge.Value; }
            set { numericUpDownAge.Value = value; }
        }
        public EditPersonForm()
        {
            InitializeComponent();
        }
        public EditPersonForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            this.Name = person.Name;
            this.Surname = person.Surname;
            this.Age = person.Age;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            person.Name = this.Name;
            person.Surname = this.Surname;
            person.Age = this.Age;
            MessageBox.Show("Сотрудник: " + person.ToString());
        }
    }
}
