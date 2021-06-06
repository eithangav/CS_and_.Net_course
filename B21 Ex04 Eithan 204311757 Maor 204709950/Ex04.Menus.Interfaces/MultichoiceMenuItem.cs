using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MultichoiceMenuItem : MenuItem
    {
        private MultichoiceMenuItem m_Previous;
        private List<MenuItem> m_MenuItems;

        public MultichoiceMenuItem(string i_ItemTitle, MultichoiceMenuItem i_Previous = null) : 
            base(i_ItemTitle)
        {
            m_Previous = i_Previous;
            m_MenuItems = new List<MenuItem>();
        }

        public bool AddMenuItem(MenuItem i_MenuItem)
        {
            bool success = false;

            if(i_MenuItem != null)
            {
                m_MenuItems.Add(i_MenuItem);
                success = true;
            }

            return success;
        }

        public bool RemoveMenuItem(string i_ItemTitle)
        {
            bool success = false;

            foreach(MenuItem item in m_MenuItems)
            {
                if(i_ItemTitle == item.ItemTitle)
                {
                    m_MenuItems.Remove(item);
                    success = true;
                    break;
                }
            }

            return success;
        }

        public virtual void Show()
        {
            // TODO: Implement
        }

        private byte readAndValidateMenuInput()
        {
            // TODO: Implement

            return 1;
        }

        public MultichoiceMenuItem Previous
        {
            get
            {
                return m_Previous;
            }

            set
            {
                m_Previous = value;
            }
        }
    }
}
