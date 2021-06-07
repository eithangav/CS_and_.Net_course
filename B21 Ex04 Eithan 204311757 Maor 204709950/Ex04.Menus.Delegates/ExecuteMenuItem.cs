
namespace Ex04.Menus.Delegates
{
    public class ExecuteMenuItem : MenuItem
    {
        private event ExecutableDelegate ActionToExecute;

        public ExecuteMenuItem(string i_ItemTitle, ExecutableDelegate i_Executable) :
            base(i_ItemTitle)
        {
            ActionToExecute += i_Executable;
        }

        public void Execute()
        {
            if(ActionToExecute != null)
            {
                ActionToExecute.Invoke();
            }
        }
    }

    public delegate void ExecutableDelegate();
}
