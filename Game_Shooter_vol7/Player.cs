using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Shooter_vol7
{
    public class Player : PictureBox
    {
        private int coordinateX;
        private int coordinateY;

        public Player(int x, int y)
        {
            this.Size = new Size(50, 70);
            this.Location = new Point(x, y);
            this.Image = Game_Shooter_vol7.Properties.Resources.Player;

            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
        }

        public int CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public int CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }
    }
}
