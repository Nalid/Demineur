using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Demineur
{
    class Cases : Button
    {
        private bool _bombe;
        public int id; 

        public bool Bombe
        {
            get { return _bombe; }
            set { _bombe = value; }
        }

        public Cases(Form1 parent, Image image)
        {
            this.Parent = parent;
            Width = 20;
            Height = 20;
            Bombe = false;
            this.BackgroundImage = image;
            BackgroundImageLayout = ImageLayout.Stretch;
            Text = Convert.ToString(id);
        }
    }
}
