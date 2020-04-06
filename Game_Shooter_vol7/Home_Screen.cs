using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Shooter_vol7
{
    public partial class Home_Screen : UserControl
    {
        private static Home_Screen inHomeScreen;

        public static Home_Screen InHomeScreen
        {
            get
            {
                if(inHomeScreen == null)
                {
                    inHomeScreen = new Home_Screen();
                }
                return inHomeScreen;
            }
        }

        public Home_Screen()
        {
            InitializeComponent();
            this.BackgroundImage = Game_Shooter_vol7.Properties.Resources.Background;
            this.Size = new Size(1100, 800);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Game_Screen.InGameScreen.BringToFront();
          
        }

        private void buttonLeaderBoard_Click(object sender, EventArgs e)
        {
            Leader_Board_Screen.InLeaderBoardScreen.BringToFront();
        }
    }
}
