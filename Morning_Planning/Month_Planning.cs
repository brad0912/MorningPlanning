using System;
using System.Collections;
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
  
    public partial class Month_Planning : Form
    {
        int Cnt_MonPlan, Cnt_YearPlan;
        List<MorningPlanningButton> Mon_RevBnt = new List<MorningPlanningButton>();
        List<MorningPlanningButton> Year_RevBnt = new List<MorningPlanningButton>();
        string[] YearProjectList = new string[1];
        string[] MonProjectList = new string[1];
        string Mon_name;

        private void AddProjectItem(ref Button _button, ref List<MorningPlanningButton> _RevBnt, ref int _counter)
        {
            _button.Location = new Point(_button.Location.X, _button.Location.Y + 25);
            _RevBnt.Add(new MorningPlanningButton());
            _RevBnt[_counter].index = _counter;
            _RevBnt[_counter].SetInitBntLocation(_RevBnt[_counter - 1].GetInitBntLocation());
            _RevBnt[_counter].SetInitLabLocation(_RevBnt[_counter - 1].GetInitLabLocation());
            _RevBnt[_counter].SetInitTextBoxLocation(_RevBnt[_counter - 1].GetInitTextBoxLocation());

            //Add label.
            _RevBnt[_counter].label.Location = new Point(_RevBnt[_counter - 1].label.Location.X, _RevBnt[_counter-1].label.Location.Y +25);
            _RevBnt[_counter].label.Font = _RevBnt[_counter - 1].label.Font;
            _RevBnt[_counter].label.ForeColor = _RevBnt[_counter - 1].label.ForeColor;
            _RevBnt[_counter].label.Text = (_counter + 1).ToString() + '.';
            _RevBnt[_counter].label.Size = _RevBnt[_counter - 1].label.Size;
            _RevBnt[_counter].label.AutoSize = false;
            this.Controls.Add(_RevBnt[_counter].label);

            //Add textbox.
            _RevBnt[_counter].Textbox.Location = new Point(_RevBnt[_counter - 1].Textbox.Location.X, _RevBnt[_counter - 1].Textbox.Location.Y + 25);
            _RevBnt[_counter].Textbox.Font = _RevBnt[_counter - 1].Textbox.Font;
            _RevBnt[_counter].Textbox.ForeColor = _RevBnt[_counter - 1].Textbox.ForeColor;
            _RevBnt[_counter].Textbox.Text = "Project";
            _RevBnt[_counter].Textbox.BorderStyle = _RevBnt[_counter - 1].Textbox.BorderStyle;
            _RevBnt[_counter].Textbox.Enabled = true;
            
            this.Controls.Add(_RevBnt[_counter].Textbox);
            
            //Add remove button. 
            _RevBnt[_counter - 1].Location = new Point(_button.Location.X, _button.Location.Y - 25);
            _RevBnt[_counter - 1].Font = _button.Font;
            _RevBnt[_counter - 1].ForeColor = _button.ForeColor;
            _RevBnt[_counter - 1].Text = "-";
            _RevBnt[_counter - 1].Size = _button.Size;
            _RevBnt[_counter - 1].BackColor = _button.BackColor;
            _RevBnt[_counter - 1].FlatStyle = _button.FlatStyle;
            _RevBnt[_counter - 1].Click += new System.EventHandler(RevButton_Click);
            this.Controls.Add(_RevBnt[_counter-1]);
            _counter++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProjectItem( ref button1, ref Mon_RevBnt, ref Cnt_MonPlan);
            Mon_RevBnt[Cnt_MonPlan - 1].Textbox.TextChanged += new System.EventHandler(MonTextBox_TextChange);
            MonTextBox_TextChange(null, null);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddProjectItem(ref button2,ref Year_RevBnt, ref Cnt_YearPlan);
            groupBox1.SendToBack();

            Year_RevBnt[Cnt_YearPlan-1].Textbox.TextChanged+= new System.EventHandler(YearTextBox_TextChange);
            YearTextBox_TextChange(null, null);
        }

        private void RevButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(((MorningPlanningButton)sender).label);
            this.Controls.Remove(((MorningPlanningButton)sender).Textbox);
            this.Controls.Remove(((MorningPlanningButton)sender));
            ((MorningPlanningButton)sender).index = -1;
            RefreshProjectList(Mon_RevBnt, button1,ref Cnt_MonPlan);
            RefreshProjectList(Year_RevBnt, button2,ref Cnt_YearPlan);
        }

        private void RefreshProjectList(List<MorningPlanningButton> _mBnt, Button _button,ref int _counter)
        {
            bool _flag = false;
            for (int i = 0; i < _mBnt.Count; i++)
                Console.WriteLine(_mBnt[i].label.Text);

            _mBnt.RemoveAll(DetectList);

            for (int i = 0; i < _mBnt.Count; i++)
                Console.WriteLine(_mBnt[i].label.Text);

            for (int i = 0; i < _mBnt.Count; i++)
            {
                if (_mBnt[i].label.Location != new Point(_mBnt[i].GetInitLabLocation().X, _mBnt[i].GetInitLabLocation().Y + (25 * i)))
                {
                    _mBnt[i].label.Location = new Point (_mBnt[i].GetInitLabLocation().X, _mBnt[i].GetInitLabLocation().Y + (25 * i));
            _mBnt[i].Textbox.Location = new Point(_mBnt[0].GetInitTextBoxLocation().X, _mBnt[0].GetInitTextBoxLocation().Y + (25 * i));
                    if(i < _mBnt.Count -1)
                        _mBnt[i].Location = new Point(_mBnt[0].GetInitBntLocation().X, _mBnt[0].GetInitBntLocation().Y + (25 * i));
                    _mBnt[i].label.Text = (i+1).ToString() + '.';
                    _flag = true;
                }        
            }
            if (_flag)
            {
                _button.Location = new Point(_button.Location.X, _button.Location.Y - 25);
                _counter--;
            }
        }

        private static bool DetectList(MorningPlanningButton _mBnt)
        {
            if (_mBnt.index == -1)
                return true;
            else
                return false;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox _Textbox = (TextBox)sender;
            if(e.KeyCode == Keys.Enter)
            {
                if (_Textbox.Text == "")
                    _Textbox.Text = "Project";

                label1.Focus();
            }
        }

        private void YearTextBox_TextChange(object sender, EventArgs e)
        {
            Array.Resize(ref YearProjectList, Cnt_YearPlan);
            SaveProject _SaveYear = new SaveProject();

            for(int i = 0; i<Cnt_YearPlan;i++)
            { 
                YearProjectList[i] = (Year_RevBnt[i].Textbox.Text);
            }
            _SaveYear.YearProject_Record(YearProjectList);
        }

        private void MonTextBox_TextChange(object sender, EventArgs e)
        {
            Array.Resize(ref MonProjectList, Cnt_MonPlan);
            string _file_path = Mon_name + "_Project.txt"; 
            SaveProject _SaveYear = new SaveProject(_file_path);

            for (int i = 0; i < Cnt_MonPlan; i++)
            {
                MonProjectList[i] = (Mon_RevBnt[i].Textbox.Text);
            }
            _SaveYear.Project_Record(MonProjectList);
        }

        public Month_Planning(string _month)
        {
            InitializeComponent();

            N_Month.Text = _month + " Plan";
            Mon_name = _month;
            InitProject();
  
        }

        private void CopyObjectProperties(ref MorningPlanningButton Target, MorningPlanningButton Source)
        {
            Target.label.Location = new Point(Source.label.Location.X, Source.label.Location.Y);
            Target.label.Font = Source.label.Font;
            Target.label.ForeColor = Source.label.ForeColor;
            Target.label.Size = Source.label.Size;
            Target.label.Text = Source.label.Text;
            Target.label.AutoSize = false;

            Target.Textbox.Location = new Point(Source.Textbox.Location.X, Source.Textbox.Location.Y);
            Target.Textbox.Font = Source.Textbox.Font;
            Target.Textbox.ForeColor = Source.Textbox.ForeColor;
            Target.Textbox.BorderStyle = Source.Textbox.BorderStyle;
            Target.Textbox.Text = Source.Textbox.Text;
            Target.Textbox.Enabled = true;
        }

        private void InitProject()
        {
            Cnt_MonPlan = 0;
            Cnt_YearPlan = 0;
            Mon_RevBnt.Add(new MorningPlanningButton());
            Year_RevBnt.Add(new MorningPlanningButton());

            MorningPlanningButton InitialMbnt = new MorningPlanningButton();
            MorningPlanningButton Mbnt = new MorningPlanningButton();
            InitialMbnt.label = label4;
            InitialMbnt.Textbox = textBox2;
            CopyObjectProperties(ref Mbnt, InitialMbnt);
            Mon_RevBnt[0].index = 0;
            Mon_RevBnt[0] = Mbnt;
            Mon_RevBnt[0].SetInitBntLocation(button1.Location);
            Mon_RevBnt[0].SetInitLabLocation(label4.Location);
            Mon_RevBnt[0].SetInitTextBoxLocation(textBox2.Location);
            Mon_RevBnt[0].Textbox.TextChanged += new System.EventHandler(MonTextBox_TextChange);
            this.Controls.Remove(label4);
            this.Controls.Remove(textBox2);
            this.Controls.Add(Mbnt.label);
            this.Controls.Add(Mbnt.Textbox);

            Year_RevBnt[0].label = label2;
            Year_RevBnt[0].Textbox = textBox1;
            Year_RevBnt[0].Textbox.TextChanged += new System.EventHandler(YearTextBox_TextChange);
            Year_RevBnt[0].index = 0;
            Year_RevBnt[0].SetInitBntLocation(button2.Location);
            Year_RevBnt[0].SetInitLabLocation(label2.Location);
            Year_RevBnt[0].SetInitTextBoxLocation(textBox1.Location);

            Cnt_MonPlan++;
            Cnt_YearPlan++;

            //Read Year txt
            SaveProject _SaveProject = new SaveProject();
            string[] str = _SaveProject.Read_YearProject();
            for (int i = 0; i < str.Length; i++)
            {
                if (i > Cnt_YearPlan - 1)
                    button2_Click(null, null);

                Year_RevBnt[i].Textbox.Text = str[i];              
            }

            //Read Mon txt
            string _file_path = Mon_name + "_Project.txt";
            _SaveProject = new SaveProject(_file_path);
            str = _SaveProject.Read_Project();
            for(int i = 0; i<str.Length; i++)
            {
                if (i > Cnt_MonPlan - 1)
                    button1_Click(null, null);

                Mon_RevBnt[i].Textbox.Text = str[i];
            }
            
        }
    }
    
}
