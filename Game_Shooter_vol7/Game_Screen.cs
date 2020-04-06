using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;
using System.Windows.Forms;

namespace Game_Shooter_vol7
{
    public partial class Game_Screen : UserControl
    {
        private static Game_Screen inGameScreen;

        public static Game_Screen InGameScreen
        {
            get
            {
                if(inGameScreen == null)
                {
                    inGameScreen = new Game_Screen();
                }
                return inGameScreen;
            }
        }

        public int[] PossibleLocationsAlien = { 0, 100, 200, 300, 400, 500, 600, 700, 800};
        public List<Alien> AllAliens = new List<Alien>();
        public static Player player;
        public static Laser laser;
     
        public Game_Screen()
        {
            InitializeComponent();
            this.Width = 1200;
            this.Height = 800;
            this.Location = new Point(0, 0);
            this.BackgroundImage = Game_Shooter_vol7.Properties.Resources.Background;
           
        }


        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }

        public void Game_Screen_Load(object sender, EventArgs e)
        {
            player = new Player(this.Size.Width / 2 - 30, this.Size.Height - 150);
            this.Controls.Add(player);

            laser = new Laser(this.Size.Width / 2 - 30, this.Size.Height - 150);
            this.Controls.Add(laser);
            laser.SendToBack();

            timerSpawn = new System.Windows.Forms.Timer();
            timerSpawn.Tick += new EventHandler(timerSpawn_Tick);
            timerSpawn.Interval = 3000;
            timerSpawn.Start();

            Given_Commands.Click += new EventHandler(OnGivenCommandsClicked);
        }

        private void OnGivenCommandsClicked(object sender, EventArgs e)
        {
            InGameScreen.Select();
            this.Given_Commands.Select();
            this.Given_Commands.Focus();
        }

        private void timerSpawn_Tick(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + (MyVariables.CountHittedAliensByLaser * 50).ToString();



            if (timerSpawn.Interval > 1000)
            {
                timerSpawn.Interval -= 50;
            }

            Random random = new Random(Guid.NewGuid().GetHashCode());
            int indexPossibleLocationsAlien1 = random.Next(0, PossibleLocationsAlien.Length - 1);

            Alien newAlien = new Alien(PossibleLocationsAlien[indexPossibleLocationsAlien1], 0);
            this.Controls.Add(newAlien);
            newAlien.MoveAlienDown();
            newAlien.Name = "Alien" + MyVariables.CountHittedAliensByLaser.ToString();
            AllAliens.Add(newAlien);
        }

        private delegate void SafeCallDelegateTop(int location, int locationTop);

        private void MovePlayerTop (int location, int locationPlayerTop)
        {
            if(this.InvokeRequired)
            {
                SafeCallDelegateTop my_delegate = new SafeCallDelegateTop(MovePlayerTop);
                this.Invoke(my_delegate, new object[] { location });
            }
            else
            {
                player.Top += locationPlayerTop;
                player.Refresh();
            }
        }

        private void MoveLaserTop(int location, int locationLaserTop)
        {
            if (this.InvokeRequired)
            {
                SafeCallDelegateTop my_delegate = new SafeCallDelegateTop(MoveLaserTop);
                this.Invoke(my_delegate, new object[] { location });
            }
            else
            {
                laser.Top += locationLaserTop;
            }
        }

        private delegate void SafeCallDelegateLeft(int location, int locationLeft);

        private void MovePlayerLeft (int location, int locationPlayerLeft)
        {
            if(this.InvokeRequired)
            {
                SafeCallDelegateLeft my_delegate = new SafeCallDelegateLeft(MovePlayerLeft);
                this.Invoke(my_delegate, new object[] { location });
            }
            else
            {
                player.Left += locationPlayerLeft;
                player.Refresh();
            }
        }

        private void MoveLaserLeft(int location, int locationLaserLeft)
        {
            if (this.InvokeRequired)
            {
                SafeCallDelegateLeft my_delegate = new SafeCallDelegateLeft(MoveLaserLeft);
                this.Invoke(my_delegate, new object[] { location });
            }
            else
            {
                laser.Left += locationLaserLeft;
            }
        }

        private delegate void SafeCallDelegateMovementLaser(int location);

        private void MoveLaser (int location)
        {
            if(this.InvokeRequired)
            {
                SafeCallDelegateMovementLaser my_delegate = new SafeCallDelegateMovementLaser(MoveLaser);
                this.Invoke(my_delegate, new object[] { location });
            }
            else
            {
                laser.Top -= 50;
                laser.Refresh();
            }
        }

        private void Given_Commands_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyValue == (char)Keys.W || e.KeyData == Keys.Up) && player.Top > 0 && laser.Top > 0)
            {
                MovePlayerTop(player.Top, -50);
                MoveLaserTop(laser.Top, -50);
            }

            if ((e.KeyValue == (char)Keys.S || e.KeyData == Keys.Down) && player.Top < 600 && laser.Top < 600)
            {
                MovePlayerTop(player.Top, 50);
                MoveLaserTop(laser.Top, 50);
            }

            if ((e.KeyValue == (char)Keys.A || e.KeyData == Keys.Left) && player.Left > 20 && laser.Left > 20)
            {
                MovePlayerLeft(player.Left, -50);
                MoveLaserLeft(laser.Left, -50);
            }

            if ((e.KeyValue == (char)Keys.D || e.KeyData == Keys.Right) && player.Left < 770 && laser.Left < 770)
            {
                MovePlayerLeft(player.Left, 50);
                MoveLaserLeft(laser.Left, 50);
            }

            if(e.KeyCode == Keys.Space)
            {
               

                laser.BringToFront();
                while (true)
                {
                    foreach (var alien in AllAliens)
                    {
                        if (laser.Bounds.IntersectsWith(alien.Bounds) && alien.Visible == true)
                        {
                            laser.SendToBack();
                            laser.Location = new Point(player.Location.X, player.Location.Y);
                            alien.Image = Game_Shooter_vol7.Properties.Resources.Explosion;
                            alien.Refresh();
                            alien.Refresh();
                            alien.Visible = false;
                            MyVariables.CountHittedAliensByLaser++;
                            return;
                        }
                    }
                    if(laser.Top >= -50)
                    {
                        MoveLaser(laser.Top);
                    }
                    else if (laser.Top < -50)
                    {
                        laser.SendToBack();
                        laser.Location = new Point(player.Location.X, player.Location.Y);
                        break;
                    }   
                }
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
        }

    }
}
