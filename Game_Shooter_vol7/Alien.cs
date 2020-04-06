using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Timers;

namespace Game_Shooter_vol7
{
    public class Alien : PictureBox
    {
        private int coordinateX;
        private int coordinateY;
        private Timer timerMovement;
        private Timer timerExplosion;
        private int speedAlien = 50;
        private int counterForMakingExplosionWorkingGood = 1;

        public Alien(int x, int y)
        {
            this.Size = new Size(100, 75);
            this.Location = new Point(x, y);
            this.Image = Game_Shooter_vol7.Properties.Resources.Alien;
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

        public void MoveAlienDown()
        {
            timerMovement = new Timer(500);
            timerMovement.Elapsed += TimerOnElapsedMovementDown;
            timerMovement.AutoReset = true;
            timerMovement.Enabled = true;
        }

        private void TimerOnElapsedMovementDown(object sender, ElapsedEventArgs e)
        {
            if (this.Top < 550)
            {
                PlaceAlienSafeDown(this.Top);
            }
            else if (this.Top == 550)
            { 
                if (this.Visible == true)
                {
                    MyVariables.CountHittedAliensByGround++;
                    PlaceAlienSafeDown(this.Top);
                    this.ExplodeAlien();
                }
                timerMovement.Stop();
            }
        }

        public void ExplodeAlien()
        {
            timerExplosion = new Timer(500);
            timerExplosion.Elapsed += TimerOnElapsedExplode;
            timerExplosion.AutoReset = true;
            timerExplosion.Enabled = true;

        }

        private void TimerOnElapsedExplode(object sender, ElapsedEventArgs e)
        {
            this.Image = Game_Shooter_vol7.Properties.Resources.Explosion;
            if (counterForMakingExplosionWorkingGood == 2)
            {
                counterForMakingExplosionWorkingGood = 1;
                PlaceAlienSafeDown(this.Top);
            }
            if (counterForMakingExplosionWorkingGood == 1)
            {
                counterForMakingExplosionWorkingGood++;
            }
            
        }

        private delegate void SafeCallDelegate(int location);

        private void PlaceAlienSafeDown(int location)
        {
            if (this.InvokeRequired)
            {
                var d = new SafeCallDelegate(PlaceAlienSafeDown);
                this.Invoke(d, new object[] { location });
            }
            else
            {
                this.Top += speedAlien;
            }
        }
    }
}
