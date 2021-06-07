
namespace Ex04.Menus.Delegates
{
    public class ExecuteMenuItem : MenuItem
    {
        private event Executable m_Exe;

        public ExecuteMenuItem(string i_ItemTitle, Executable i_Executable) :
            base(i_ItemTitle)
        {
            m_Exe += i_Executable;
        }

        public void Execute()
        {
            if(m_Exe != null)
            {
                m_Exe.Invoke();
            }
        }
    }

    public delegate void Executable();
}
