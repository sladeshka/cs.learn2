using System.Xml;
namespace TestList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else
            {
                MessageBox.Show("Select an item from the list or enter a new one");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (memberList.CheckedIndices.Count > 0)
            {
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peopleList.Items.Clear();
            FileStream fileStream = new("..\\..\\..\\XMLData.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmlDoc = new();
            xmlDoc.Load(fileStream);
            for(int i = 0;i< xmlDoc.DocumentElement.ChildNodes.Count;i++)
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            }
            fileStream.Close();
        }
    }
}