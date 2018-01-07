using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morning_Planning
{
    public partial class Month_Select : Form
    {
        Form1 _PrePage;
        bool close_PrePage = false;
        public Month_Select()
        {
            InitializeComponent();
            //Chagne Button Font
            Font _Font = January.Font;
            February.Font = _Font;
            March.Font = _Font;
            April.Font = _Font;
            May.Font = _Font;
            June.Font = _Font;
            July.Font = _Font;
            August.Font = _Font;
            September.Font = _Font;
            October.Font = _Font;
            November.Font = _Font;
            December.Font = _Font;
            close_PrePage = true;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;      
            if(close_PrePage)
                _PrePage.Close();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _PrePage.Visible = true;
            close_PrePage = false;
            this.Close();
        }

        public void Get_PrePage(object sender)
        {
            _PrePage = (Form1)sender;
        }

        private void January_Click(object sender, EventArgs e)
        {
            Month_Planning _JanuaryPlan = new Month_Planning("January");
            this.Visible = false;
            _JanuaryPlan.ShowDialog();
        }

        private void June_Click(object sender, EventArgs e)
        {

        }
    }
}
