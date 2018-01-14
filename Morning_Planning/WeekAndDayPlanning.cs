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
    public partial class WeekAndDayPlanning : Form
    {
        public WeekAndDayPlanning()
        {
            InitializeComponent();
           
        }

        private void WeekAndDayPlanning_Paint(object sender, PaintEventArgs e)
        {
            WeekAndDayPlanning _this = (WeekAndDayPlanning)sender;
            Pen _pen = new Pen(Color.FromArgb(255, 172, 172, 172));
            e.Graphics.DrawLine(_pen, _this.Width/2, 0, _this.Width/2, _this.Height);
        }
    }
}
