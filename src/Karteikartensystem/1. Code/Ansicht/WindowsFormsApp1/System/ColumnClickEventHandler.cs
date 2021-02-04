using System;
using System.Windows.Forms;

namespace AnsichtsFenster.System
{
    internal class ColumnClickEventHandler
    {
        private Action<object, ColumnClickEventArgs> listViewColumnClick;

        public ColumnClickEventHandler(Action<object, ColumnClickEventArgs> listViewColumnClick)
        {
            this.listViewColumnClick = listViewColumnClick;
        }
    }
}