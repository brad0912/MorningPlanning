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
    public partial class WeeklyPlanning : Form
    {
        List<CheckBox> CBList_WeeklyProject = new List<CheckBox>();
        List<string> Str_WeeklyProjtect = new List<string>();
        string _file_name;
        public WeeklyPlanning(string month)
        {
            InitializeComponent();

            _file_name = month + "//Weekly_Project.txt";
            CBList_WeeklyProject.Add(CheckBox_WeekProject);
            //Str_WeeklyProjtect.Add(CheckBox_WeekProject.Text);

            SaveProject _Save = new SaveProject(_file_name);
            string[] str = _Save.Read_Project();
            for(int i = 0; i<str.Length; i++)
            {
                Str_WeeklyProjtect.Add(str[i]);
                Add_Click(null, null);
            }
            
        }

        private void WeekAndDayPlanning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_Checkbox();
            SaveProject _Save = new SaveProject(_file_name);
            _Save.Project_Record(Str_WeeklyProjtect.ToArray());
        }

        private void Add_Checkbox()
        {
            CBList_WeeklyProject.Add(new CheckBox());
            CheckBox CB_Temp1 = CBList_WeeklyProject[CBList_WeeklyProject.Count - 1], CB_Temp2 = CBList_WeeklyProject[CBList_WeeklyProject.Count - 2];
            CB_Temp1.Font = CB_Temp2.Font;
            CB_Temp1.BackColor = CB_Temp2.BackColor;
            CB_Temp1.Location = new Point(CB_Temp2.Location.X, CB_Temp2.Location.Y + 25);
        //  CB_Temp1.Text = "Project";
        //  Str_WeeklyProjtect.Add(CB_Temp1.Text);
            this.Controls.Add(CB_Temp1);
        }

        TextBox CheckBox_Input;
        private void CheckBox_WeekProject_Click(object sender, EventArgs e)
        {
            CheckBox _checkbox = (CheckBox)sender;
            CheckBox_Input = new TextBox();
            CheckBox_Input.Size = _checkbox.Size;
            CheckBox_Input.Location = _checkbox.Location;
        }
    }
}
