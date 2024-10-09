using System;
using System.Windows.Forms;
namespace _2024_10_08
{
    public partial class NewCatForm : Form
    {
        public Cat cat = new Cat();
        public NewCatForm()
        {
            InitializeComponent();
        }
        public NewCatForm(Cat catToEdit)
        {
            InitializeComponent();
            nameField.Text = catToEdit.Name;
            ageField.Value = catToEdit.Age;
            cat.Id = catToEdit.Id;
            Text = $"Edit cat with id {catToEdit.Id}";
            okButton.Text = "Save";
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void okButton_Click(object sender, EventArgs e) => OK();
        private void nameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ageField.Focus();
        }
        private void ageField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) OK();
        }
        public void OK()
        {
            cat.Name = nameField.Text;
            cat.Age = (int)ageField.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
