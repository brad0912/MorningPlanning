using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morning_Planning
{
    class WeeklyProjectItem 
    {
        private CheckBox _checkbox;
        private TextBox _textbox;
        public WeeklyProjectItem()
        {

        }

        public void Set_CheckBox(CheckBox Temp_CheckBox)
        {
            _checkbox = Temp_CheckBox;
        }

        public CheckBox Get_CheckBox()
        {
            return _checkbox;
        }

        public void Set_TextBox(TextBox Temp_TextkBox)
        {
            _textbox = Temp_TextkBox;
        }

        public TextBox Get_TextkBox()
        {
            return _textbox;
        }
    }
}
