
namespace Ex04.Menus.Interfaces
{
    public class ExecuteMenuItem : MenuItem
    {
        private IExecutable m_Executable;

        public ExecuteMenuItem(string i_ItemTitle, IExecutable i_Executable) :
            base(i_ItemTitle)
        {
            m_Executable = i_Executable;
        }

        public void Execute()
        {
            m_Executable.PerformAction();
        }
    }
}
