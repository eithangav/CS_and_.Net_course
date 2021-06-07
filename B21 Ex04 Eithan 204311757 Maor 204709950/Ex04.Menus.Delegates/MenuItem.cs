
namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private string m_ItemTitle;

        public MenuItem(string i_ItemTitle)
        {
            m_ItemTitle = i_ItemTitle;
        }

        public string ItemTitle
        {
            get
            {
                return m_ItemTitle;
            }

            set
            {
                m_ItemTitle = value;
            }
        }

        public bool Equals(MenuItem i_MenuItem)
        {
            return m_ItemTitle == i_MenuItem.ItemTitle;
        }
    }
}
