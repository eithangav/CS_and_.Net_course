
namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            createMenuWithInterfaces().Show();
            createMenuWithDelegates().Show();
        }

        private static Interfaces.MainMenu createMenuWithInterfaces()
        {
            // Main menu layer:

            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Main menu (using interfaces)");

            // Second menu layers:

            Interfaces.MultichoiceMenuItem subMenuVersionAndSpaces = new Interfaces.MultichoiceMenuItem("Version and Spaces", mainMenu);
            Interfaces.MultichoiceMenuItem subMenuDateTime = new Interfaces.MultichoiceMenuItem("Show Date/Time", mainMenu);

            mainMenu.AddMenuItem(subMenuVersionAndSpaces);
            mainMenu.AddMenuItem(subMenuDateTime);

            // Third menu layers:

            Interfaces.ExecuteMenuItem itemShowVersion = new Interfaces.ExecuteMenuItem("Show Version", new ShowVersion());
            Interfaces.ExecuteMenuItem itemCountSpaces = new Interfaces.ExecuteMenuItem("Count Spaces", new CountSpaces());

            subMenuVersionAndSpaces.AddMenuItem(itemShowVersion);
            subMenuVersionAndSpaces.AddMenuItem(itemCountSpaces);

            Interfaces.ExecuteMenuItem itemShowTime = new Interfaces.ExecuteMenuItem("Show Time", new ShowTime());
            Interfaces.ExecuteMenuItem itemShowDate = new Interfaces.ExecuteMenuItem("Show Date", new ShowDate());

            subMenuDateTime.AddMenuItem(itemShowTime);
            subMenuDateTime.AddMenuItem(itemShowDate);

            return mainMenu;
        }

        private static Delegates.MainMenu createMenuWithDelegates()
        {
            // Main menu layer:

            Delegates.MainMenu mainMenu = new Delegates.MainMenu("Main menu (using delegates)");

            // Second menu layers:

            Delegates.MultichoiceMenuItem subMenuVersionAndSpaces = new Delegates.MultichoiceMenuItem("Version and Spaces", mainMenu);
            Delegates.MultichoiceMenuItem subMenuDateTime = new Delegates.MultichoiceMenuItem("Show Date/Time", mainMenu);

            mainMenu.AddMenuItem(subMenuVersionAndSpaces);
            mainMenu.AddMenuItem(subMenuDateTime);

            // Third menu layers:

            Delegates.ExecuteMenuItem itemShowVersion = new Delegates.ExecuteMenuItem("Show Version", new ShowVersion().PerformAction);
            Delegates.ExecuteMenuItem itemCountSpaces = new Delegates.ExecuteMenuItem("Count Spaces", new CountSpaces().PerformAction);

            subMenuVersionAndSpaces.AddMenuItem(itemShowVersion);
            subMenuVersionAndSpaces.AddMenuItem(itemCountSpaces);

            Delegates.ExecuteMenuItem itemShowTime = new Delegates.ExecuteMenuItem("Show Time", new ShowTime().PerformAction);
            Delegates.ExecuteMenuItem itemShowDate = new Delegates.ExecuteMenuItem("Show Date", new ShowDate().PerformAction);

            subMenuDateTime.AddMenuItem(itemShowTime);
            subMenuDateTime.AddMenuItem(itemShowDate);

            return mainMenu;
        }
    }
}
