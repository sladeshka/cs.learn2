using System.Windows.Forms;

namespace DataValidationForm
{
    public partial class DataValidationForm : UserControl
    {
        public DataValidationForm()
        {
            InitializeComponent();
        }

        public bool ValidateData()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                errorProvider1.SetError(nameTextBox, "Name is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(nameTextBox, "");
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "Email is required.");
                isValid = false;
            }
            else if (!IsValidEmail(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "Email is not valid.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(emailTextBox, "");
            }

            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                errorProvider1.SetError(phoneTextBox, "Phone number is required.");
                isValid = false;
            }
            else if (!IsValidPhoneNumber(phoneTextBox.Text))
            {
                errorProvider1.SetError(phoneTextBox, "Phone number is not valid.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(phoneTextBox, "");
            }

            return isValid;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                // Create a new user object
                var user = new User
                {
                    Name = nameTextBox.Text,
                    Email = emailTextBox.Text,
                    Phone = phoneTextBox.Text
                };

                // Display the user information in the label
                userInfoLabel.Text = $"Name: {user.Name}\nEmail: {user.Email}\nPhone: {user.Phone}";
            }
        }

        private void DataValidationForm_Load(object sender, EventArgs e)
        {
            // Hide the user information label initially
            userInfoLabel.Visible = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTextBox, "");
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(emailTextBox, "");
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(phoneTextBox, "");
        }

        private void phonelabel_Click(object sender, EventArgs e)
        {

        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

}
