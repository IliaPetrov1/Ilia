using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Game_Shooter_vol7
{
    static class InputBlocker
    {
        [DllImport("users32.dll")]
        static extern bool BlockInput(bool fBlockIt);

        private static Timer timerInputBlocker = new Timer();

        static InputBlocker()
        {
            timerInputBlocker.Tick += new EventHandler(timerInputBlocker_Tick);
        }

        public static void BlockInut(int milliseconds)
        {
            BlockInput(true);
            timerInputBlocker.Interval = milliseconds;
            timerInputBlocker.Start();
        }

        private static void timerInputBlocker_Tick(object sender, EventArgs e)
        {
            BlockInput(false);
            timerInputBlocker.Stop();
        }
    }
}
