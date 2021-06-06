using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Clear();

            m_Executable.PerformAction();
        }
    }
}
