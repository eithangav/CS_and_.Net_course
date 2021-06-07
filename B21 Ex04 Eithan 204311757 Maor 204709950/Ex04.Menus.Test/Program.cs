using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            createMenuWithInterfaces().Show();
            createMenuWithDelegates().Show();
        }

        private static MainMenu createMenuWithInterfaces()
        {
            // Main menu layer:

            MainMenu mainMenu = new MainMenu("Main menu (using interfaces)");

            // Second menu layers:

            MultichoiceMenuItem subMenuVersionAndSpaces = new MultichoiceMenuItem("Version and Spaces", mainMenu);
            MultichoiceMenuItem subMenuDateTime = new MultichoiceMenuItem("Show Date/Time", mainMenu);

            mainMenu.AddMenuItem(subMenuVersionAndSpaces);
            mainMenu.AddMenuItem(subMenuDateTime);

            // Third menu layers:

            ExecuteMenuItem itemShowVersion = new ExecuteMenuItem("Show Version", new ShowVersion());
            ExecuteMenuItem itemCountSpaces = new ExecuteMenuItem("Count Spaces", new CountSpaces());

            subMenuVersionAndSpaces.AddMenuItem(itemShowVersion);
            subMenuVersionAndSpaces.AddMenuItem(itemCountSpaces);

            ExecuteMenuItem itemShowTime = new ExecuteMenuItem("Show Time", new ShowTime());
            ExecuteMenuItem itemShowDate = new ExecuteMenuItem("Show Date", new ShowDate());

            subMenuDateTime.AddMenuItem(itemShowTime);
            subMenuDateTime.AddMenuItem(itemShowDate);

            return mainMenu;
        }

        private static MainMenu createMenuWithDelegates()
        {
            // TODO: Implement Delegates project and then this method

            return new MainMenu("Main menu (using delegates)");
        }
    }
}
