using System.Collections;
using System.Windows.Forms;

namespace AnsichtsFenster.Fenster
{
    internal class ListViewItemComparer : IComparer
    {
        private int column;

        public ListViewItemComparer(int column)
        {
            this.column = column;
        }

        public int Compare(object x, object y)
        {
            return string.Compare(((ListViewItem)x).SubItems[column].Text, ((ListViewItem)y).SubItems[column].Text);
        }
    }
}