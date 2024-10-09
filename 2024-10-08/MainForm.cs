using System;
using System.Windows.Forms;
namespace _2024_10_08
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Database.OpenConnection();
            updateTable();
        }
        void updateTable()
        {
            catsTable.BeginUpdate();
            catsTable.Items.Clear();
            foreach (Cat cat in Database.GetCats()) catsTable.Items.Add(cat.ToListViewItem());
            catsTable.EndUpdate();
        }
        private void deleteSelectedToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem item in catsTable.SelectedItems)
            {
                Database.DeleteById(Convert.ToInt32(item.SubItems[0].Text));
                updateTable();
            }
        }
        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really delete everything?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Database.DeleteAll();
                updateTable();
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCatForm newCatForm = new NewCatForm();
            if (newCatForm.ShowDialog() == DialogResult.OK)
            {
                Database.InsertCat(newCatForm.cat);
                updateTable();
            }
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catsTable.BeginUpdate();
            foreach (ListViewItem item in catsTable.Items) item.Selected = true;
            catsTable.EndUpdate();
        }
        private void editSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (catsTable.SelectedItems.Count == 0) MessageBox.Show("No cat selected");
            else if (catsTable.SelectedItems.Count > 1) MessageBox.Show("Only one cat can be edited at a time.");
            else
            {
                ListViewItem selected = catsTable.SelectedItems[0];
                NewCatForm newCatForm = new NewCatForm(new Cat
                {
                    Id = Convert.ToInt32(selected.SubItems[0].Text),
                    Age = Convert.ToInt32(selected.SubItems[1].Text),
                    Name = selected.SubItems[2].Text,
                });
                if (newCatForm.ShowDialog() == DialogResult.OK)
                {
                    Database.UpdateCat(newCatForm.cat);
                    updateTable();
                }
            }
        }
        private void duplicateSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in catsTable.SelectedItems)
            {
                Database.InsertCat(new Cat
                {
                    Age = Convert.ToInt32(item.SubItems[1].Text),
                    Name = item.SubItems[2].Text,
                });
            }
            updateTable();
        }
    }
}
