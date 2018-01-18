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
        List<WeeklyProjectItem> CBList_WeeklyProject = new List<WeeklyProjectItem>();
        List<string> Str_WeeklyProjtect = new List<string>();
        string _file_name;
        int Object_distance;
        public WeeklyPlanning(string month)
        {
            InitializeComponent();
            CBList_WeeklyProject.Add(new WeeklyProjectItem());
            CBList_WeeklyProject[0].Set_CheckBox(CheckBox_WeekProject);
            CBList_WeeklyProject[0].Set_TextBox(textBox1);
            Object_distance = CheckBox_WeekProject.Location.X - textBox1.Location.X;
            CBList_WeeklyProject[0].Get_TextkBox().TextChanged += ProjectTextBox_Changed;
            CBList_WeeklyProject[0].Get_TextkBox().KeyDown += ProjectKeyDown_Enter;

            _file_name = month + "//Weekly_Project.txt";
            SaveProject _Save = new SaveProject(_file_name);
            string[] str = _Save.Read_Project();

            CBList_WeeklyProject[0].Get_TextkBox().Text = str[0];
            Str_WeeklyProjtect.Add(str[0]);
            for (int i = 1; i<str.Length; i++)
            {
                Str_WeeklyProjtect.Add(str[i]);
                Add_Checkbox();
                CBList_WeeklyProject[CBList_WeeklyProject.Count - 1].Get_TextkBox().Text = str[i];
            }
            
        }

        private void WeekAndDayPlanning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_Checkbox();
            CBList_WeeklyProject[CBList_WeeklyProject.Count - 1].Get_TextkBox().Text = "Project";
            Str_WeeklyProjtect.Add("Project");
            SaveProject _Save = new SaveProject(_file_name);
            _Save.Project_Record(Str_WeeklyProjtect.ToArray());
        }

        private void Add_Checkbox()
        {
            CBList_WeeklyProject.Add(new WeeklyProjectItem());
            CBList_WeeklyProject[CBList_WeeklyProject.Count - 1].Set_TextBox(new TextBox());
            CBList_WeeklyProject[CBList_WeeklyProject.Count - 1].Set_CheckBox(new CheckBox());

            TextBox Temp1 = CBList_WeeklyProject[CBList_WeeklyProject.Count - 1].Get_TextkBox(), Temp2 = CBList_WeeklyProject[CBList_WeeklyProject.Count - 2].Get_TextkBox();
            CopyWeeklyItemProtries(ref Temp1, Temp2);
            Temp1.Location = new Point(Temp2.Location.X, Temp2.Location.Y + 25);
            Temp1.TextChanged += ProjectTextBox_Changed;
            Temp1.KeyDown += ProjectKeyDown_Enter;
            CBList_WeeklyProject[CBList_WeeklyProject.Count - 1].Get_CheckBox().Location = new Point(Temp1.Location.X + Object_distance, Temp1.Location.Y);
            this.Controls.Add(Temp1);
            this.Controls.Add(CBList_WeeklyProject[CBList_WeeklyProject.Count - 1].Get_CheckBox());

        }

        private void ProjectTextBox_Changed(object sender, EventArgs e)
        {
            SaveProject _Save = new SaveProject(_file_name);
            Str_WeeklyProjtect.Clear();
            for (int i = 0; i< CBList_WeeklyProject.Count;i++){
                Str_WeeklyProjtect.Add(CBList_WeeklyProject[i].Get_TextkBox().Text);
            }
            _Save.Project_Record(Str_WeeklyProjtect.ToArray());
        }

        private void ProjectKeyDown_Enter(object sender, KeyEventArgs e)
        {
            TextBox _Textbox = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (_Textbox.Text == "")
                    _Textbox.Text = "Project";

                button1.Focus();
            }
        }

        private void CopyWeeklyItemProtries(ref TextBox Target, TextBox Source)
        {
            Target.Location = new Point(Source.Location.X, Source.Location.Y);
            Target.Font = Source.Font;
            Target.ForeColor = Source.ForeColor;
            Target.BorderStyle = Source.BorderStyle;
            Target.Text = Source.Text;
            Target.Enabled = true;
        }

    }
}
