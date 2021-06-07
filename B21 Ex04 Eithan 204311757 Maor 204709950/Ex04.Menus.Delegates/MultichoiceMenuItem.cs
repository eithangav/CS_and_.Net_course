using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MultichoiceMenuItem : MenuItem
    {
        private MultichoiceMenuItem m_Previous;
        private List<MenuItem> m_MenuItems;

        public MultichoiceMenuItem(string i_ItemTitle, MultichoiceMenuItem i_Previous) : 
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

        public void Show()
        {
            PrintMenuItem();

            int selection = ReadAndValidateMenuInput();

            Console.Clear();

            if (selection == 0)
            {
                if(m_Previous != null)
                {
                    m_Previous.Show();
                }
                // (else: need to exit -> method ends)
            }
            else
            {
                MenuItem item = m_MenuItems[selection-1];

                if (item is ExecuteMenuItem executableItem)
                {
                    executableItem.Execute();
                    this.Show();
                }
                else if(item is MultichoiceMenuItem subMenuItem)
                {
                    subMenuItem.Show();
                }
            }
        }

        public void PrintMenuItem()
        {
            StringBuilder menuContent = new StringBuilder();

            string backOrExit = m_Previous == null ? "Exit" : "Go back" ;

            menuContent.Append("\n----- ");
            menuContent.Append(this.ItemTitle);
            menuContent.Append(": -----\n\n");

            int index = 1;

            foreach (MenuItem item in m_MenuItems)
            {
                menuContent.Append(index);
                menuContent.Append(". ");
                menuContent.Append(item.ItemTitle);
                menuContent.Append("\n");
                index++;
            }

            menuContent.Append("0. ");
            menuContent.Append(backOrExit);
            menuContent.Append(string.Format("\n\nSelect an option (1-{0}) or enter 0 to {1}", m_MenuItems.Count, backOrExit));

            Console.WriteLine(menuContent.ToString());
        }

        public int ReadAndValidateMenuInput()
        {
            string userChoice;
            int userChoiceNum = -1;
            int numOfItems = m_MenuItems.Count;

            string invalidInputMsg = string.Format("Invalid input. Please enter a number in range (0-{0})", numOfItems);

            while (userChoiceNum == -1)
            {
                try
                {
                    userChoice = Console.ReadLine();

                    bool parsingSucceded = int.TryParse(userChoice, out userChoiceNum);

                    if (!parsingSucceded || userChoiceNum < 0 || userChoiceNum > numOfItems)
                    {
                        userChoiceNum = -1;
                        Console.WriteLine(invalidInputMsg);
                    }
                }
                catch
                {
                    Console.WriteLine("IO (read/write) error occured. Please try again...");
                }
            }

            return userChoiceNum;
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
