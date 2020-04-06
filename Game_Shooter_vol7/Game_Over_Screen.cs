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
    public partial class Game_Over_Screen : UserControl
    {
        private static Game_Over_Screen inGameOverScreen;

        public static Game_Over_Screen InGameOverScreen
        {
            get
            {
                if (inGameOverScreen == null)
                {
                    inGameOverScreen = new Game_Over_Screen();
                }
                return inGameOverScreen;
            }
        }

        public Game_Over_Screen()
        {
            InitializeComponent();
        }
    }
}
