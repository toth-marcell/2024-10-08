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
            catsTable.Items.Clear();
            foreach (Cat cat in Database.GetCats()) catsTable.Items.Add(cat.ToListViewItem());
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
            Database.DeleteAll();
            updateTable();
        }
    }
}
