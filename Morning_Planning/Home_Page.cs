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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Initial Home Page label and button.
            String Date = DateTime.Now.ToString("yyyy");
            YearButton.Text = Date;
            YearButton.Font = new Font("Arial", 20);

            ////Debug
            //SaveProject _testSvae = new SaveProject("2018\\Jen\\Test_File.txt");
            //string[] _str = new string[1];
            //for(int i = 0; i<100; i++)
            //{
            //    Array.Resize(ref _str, i + 1);
            //    _str[i] = i.ToString();
            //}
            //_testSvae.YearProject_Record(_str);

        }
        Month_Select _Month_Select = new Month_Select();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _Month_Select.Get_PrePage(this);
            _Month_Select.ShowDialog();
        }
    }
}
