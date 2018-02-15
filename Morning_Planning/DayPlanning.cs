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
    public partial class DayPlanning : Form
    {
        List<WeeklyProjectItem> CBList_TodayProject = new List<WeeklyProjectItem>();
        List<string> Str_TodayProjtect = new List<string>();
        int Object_distance;
        string _file_name;
        bool close_PrePage;
        WeeklyPlanning PrePage;

        public DayPlanning(string month)
        {
            InitializeComponent();
            close_PrePage = true;
            CBList_TodayProject.Add(new WeeklyProjectItem());
            CBList_TodayProject[0].Set_CheckBox(CheckBox_TodayProject);
            CBList_TodayProject[0].Set_TextBox(textBox1);
            Object_distance = CheckBox_TodayProject.Location.X - textBox1.Location.X;
            CBList_TodayProject[0].Get_TextkBox().TextChanged += ProjectTextBox_Changed;
            CBList_TodayProject[0].Get_TextkBox().KeyDown += ProjectKeyDown_Enter;
            String Date = DateTime.Now.ToString("dd");
           this._file_name = month + "//"+Date + ".txt";
            SaveProject _Save = new SaveProject(_file_name);
            string[] str = _Save.Read_Project();

            if (str.Length == 0)
            {
                CBList_TodayProject[0].Get_TextkBox().Text = "Project";
                Str_TodayProjtect.Add("Project");
                Str_TodayProjtect.Add("Unchecked");
            }
            else
            {
                CBList_TodayProject[0].Get_TextkBox().Text = str[0];
                if (string.Compare("Checked", str[1], true) == 0)
                    CBList_TodayProject[0].Get_CheckBox().Checked = true;
                else
                    CBList_TodayProject[0].Get_CheckBox().Checked = false;
                Str_TodayProjtect.Add(str[0]);
                Str_TodayProjtect.Add(str[1]);
            }

            for (int i = 2; i < str.Length; i = i + 2)
            {
                Str_TodayProjtect.Add(str[i]);
                Str_TodayProjtect.Add(str[i + 1]);
                Add_ObjectItem();
                CBList_TodayProject[CBList_TodayProject.Count - 1].Get_TextkBox().Text = str[i];
                if (string.Compare("Checked", str[i + 1], true) == 0)
                    CBList_TodayProject[CBList_TodayProject.Count - 1].Get_CheckBox().Checked = true;
                else
                    CBList_TodayProject[CBList_TodayProject.Count - 1].Get_CheckBox().Checked = false;
            }
        }

        private void ProjectTextBox_Changed(object sender, EventArgs e)
        {
            SaveProject _Save = new SaveProject(_file_name);
            Str_TodayProjtect.Clear();
            for (int i = 0; i < CBList_TodayProject.Count; i++)
            {
                Str_TodayProjtect.Add(CBList_TodayProject[i].Get_TextkBox().Text);
                Str_TodayProjtect.Add(CBList_TodayProject[i].Get_CheckBox().CheckState.ToString());
            }
            _Save.Project_Record(Str_TodayProjtect.ToArray());
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

        private void Add_ObjectItem()
        {
            CBList_TodayProject.Add(new WeeklyProjectItem());
            CBList_TodayProject[CBList_TodayProject.Count - 1].Set_TextBox(new TextBox());
            CBList_TodayProject[CBList_TodayProject.Count - 1].Set_CheckBox(new CheckBox());

            TextBox Temp1 = CBList_TodayProject[CBList_TodayProject.Count - 1].Get_TextkBox(), Temp2 = CBList_TodayProject[CBList_TodayProject.Count - 2].Get_TextkBox();
            CopyItemProtries(ref Temp1, Temp2);
            Temp1.Location = new Point(Temp2.Location.X, Temp2.Location.Y + 25);
            Temp1.TextChanged += ProjectTextBox_Changed;
            Temp1.KeyDown += ProjectKeyDown_Enter;
            CBList_TodayProject[CBList_TodayProject.Count - 1].Get_CheckBox().Location = new Point(Temp1.Location.X + Object_distance, Temp1.Location.Y);
            CBList_TodayProject[CBList_TodayProject.Count - 1].Get_CheckBox().CheckedChanged += new System.EventHandler(CheckBox_TodayProject_CheckedChanged);
            this.Controls.Add(Temp1);
            this.Controls.Add(CBList_TodayProject[CBList_TodayProject.Count - 1].Get_CheckBox());

        }

        private void CopyItemProtries(ref TextBox Target, TextBox Source)
        {
            Target.Location = new Point(Source.Location.X, Source.Location.Y);
            Target.Size = Source.Size;
            Target.Font = Source.Font;
            Target.ForeColor = Source.ForeColor;
            Target.BorderStyle = Source.BorderStyle;
            Target.Text = Source.Text;
            Target.Enabled = true;
        }

        private void CheckBox_TodayProject_CheckedChanged(object sender, EventArgs e)
        {
            SaveProject _Save = new SaveProject(_file_name);
            CheckBox _check = (CheckBox)sender;
            Str_TodayProjtect.Clear();
            for (int i = 0; i < CBList_TodayProject.Count; i++)
            {
                Str_TodayProjtect.Add(CBList_TodayProject[i].Get_TextkBox().Text);
                Str_TodayProjtect.Add(CBList_TodayProject[i].Get_CheckBox().CheckState.ToString());
            }
            _Save.Project_Record(Str_TodayProjtect.ToArray());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_ObjectItem();
            CBList_TodayProject[CBList_TodayProject.Count - 1].Get_TextkBox().Text = "Project";
            CBList_TodayProject[CBList_TodayProject.Count - 1].Get_CheckBox().Checked = false;
            Str_TodayProjtect.Add("Project");
            Str_TodayProjtect.Add("Unchecked");
            SaveProject _Save = new SaveProject(_file_name);
            _Save.Project_Record(Str_TodayProjtect.ToArray());
        }

        public void Set_PrePage(object sender)
        {
            PrePage = (WeeklyPlanning)sender;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrePage.Visible = true;
            close_PrePage = false;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (close_PrePage)
            {
                PrePage.close_PrePage = true;
                PrePage.Close();
            }
        }
    }
}
