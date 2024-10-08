using System.Windows.Forms;
namespace _2024_10_08
{
    public class Cat
    {
        public int Id;
        public string Name;
        public int Age;
        public ListViewItem ToListViewItem()
        {
            ListViewItem item = new ListViewItem(Id.ToString());
            item.SubItems.AddRange(new string[] {
                Age.ToString(), 
                Name,
            });
            return item;
        }
    }
}
