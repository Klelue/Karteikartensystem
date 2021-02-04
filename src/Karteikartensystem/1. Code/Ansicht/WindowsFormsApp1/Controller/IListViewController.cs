using System.Windows.Forms;

namespace AnsichtsFenster.Controller
{
    public interface IListViewController
    {
        ListView CreateView(ListView listView);

        ListView UpdateView(ListView listView);

        ListView ClearView(ListView listView);
    }
}