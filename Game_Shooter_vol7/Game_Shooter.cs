using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Shooter_vol7
{
    public partial class Game_Shooter : Form
    {
        public Game_Shooter()
        {
            InitializeComponent();

            if(!this.Controls.Contains(Home_Screen.InHomeScreen))
            {
                this.Controls.Add(Home_Screen.InHomeScreen);
                Home_Screen.InHomeScreen.Dock = DockStyle.Fill;
            }
            if(!this.Controls.Contains(Game_Screen.InGameScreen))
            {
                this.Controls.Add(Game_Screen.InGameScreen);
                Game_Screen.InGameScreen.Dock = DockStyle.Fill;
            }
            if(!this.Controls.Contains(Game_Over_Screen.InGameOverScreen))
            {
                this.Controls.Add(Game_Over_Screen.InGameOverScreen);
                Game_Over_Screen.InGameOverScreen.Dock = DockStyle.Fill;
            }
            if(!this.Controls.Contains(Leader_Board_Screen.InLeaderBoardScreen))
            {
                this.Controls.Add(Leader_Board_Screen.InLeaderBoardScreen);
                Leader_Board_Screen.InLeaderBoardScreen.Dock = DockStyle.Fill;
            }

            Home_Screen.InHomeScreen.BringToFront();


        }

       
    }
}
