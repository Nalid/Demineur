using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int time;

        public Form1()
        {
            InitializeComponent();
            time = 0;
        }

       

        private void timUp_Tick(object sender, EventArgs e)
        {
            time += 1;
            lblHorlogeUp.Text = time.ToString();
        }

        private void lblHorlogeUp_Click(object sender, EventArgs e)
        {

        }
    }
}
