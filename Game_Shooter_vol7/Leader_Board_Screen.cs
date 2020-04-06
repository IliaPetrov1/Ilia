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
    public partial class Leader_Board_Screen : UserControl
    {
        private static Leader_Board_Screen inLeaderBoardScreen;

        public static Leader_Board_Screen InLeaderBoardScreen
        {
            get
            {
                if (inLeaderBoardScreen == null)
                {
                    inLeaderBoardScreen = new Leader_Board_Screen();
                }
                return inLeaderBoardScreen;
            }
        }

        public Leader_Board_Screen()
        {
            InitializeComponent();
        }
    }
}
