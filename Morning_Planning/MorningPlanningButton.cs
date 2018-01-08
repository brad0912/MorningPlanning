using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Morning_Planning
{
    class MorningPlanningButton : Button
    {
        public Label label;
        public TextBox Textbox;
        public int index;
        Point InitBntLocation, InitLabLocation, InitTextBoxLocation;
        public MorningPlanningButton()
        {
            label = new Label();
            Textbox = new TextBox();
        }
        public void SetInitBntLocation(Point _point)
        {
            InitBntLocation = _point;
        }
        public void SetInitLabLocation(Point _point)
        {
            InitLabLocation = _point;
        }
        public void SetInitTextBoxLocation(Point _point)
        {
            InitTextBoxLocation = _point;
        }

        public Point GetInitBntLocation()
        {
            return InitBntLocation;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        public Point GetInitLabLocation()
        {
            return InitLabLocation;
        }
        public Point GetInitTextBoxLocation()
        {
            return InitTextBoxLocation;
        }
    }
}
