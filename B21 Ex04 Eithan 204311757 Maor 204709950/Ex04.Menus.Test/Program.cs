
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
            // TODO: Implement Delegates project and then this method

            return new Delegates.MainMenu("Main menu (using delegates)");
        }
    }
}
