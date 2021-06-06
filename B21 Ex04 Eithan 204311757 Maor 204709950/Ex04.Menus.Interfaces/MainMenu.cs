using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MultichoiceMenuItem
    {
        public MainMenu(string i_MenuTitle) :
            base(i_MenuTitle)
        {
        }

        public override void Show()
        {
            // TODO: Implement with Exit instead of Back
        }
    }
}
