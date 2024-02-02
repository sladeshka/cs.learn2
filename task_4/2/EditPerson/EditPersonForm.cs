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
    }
}
