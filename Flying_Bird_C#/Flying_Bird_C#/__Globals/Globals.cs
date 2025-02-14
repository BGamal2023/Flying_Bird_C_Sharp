using Flying_Bird_C_._0_Main.Game_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.TextFormatting;

namespace Flying_Bird_C_.__Globals
{
    internal class Globals
    {
        /// MainWindow And GameArea
        public static int mWindow_H =800;
        public static int mWindow_W = 600;

        public static Canvas gameArea = new Canvas();
        ///Score
        public static int Score = 0;
        public static int Score_Lable_W = 30;
        public static int Score_Lable_H = 20;
        public static TextBlock scoreTextBlock;

        ///Player
        public static Image player=new Image();
        public static int player_W = 30;
        public static int player_H = 30;

        /// Game Controller
        public static I_Game_Controller_Runnable current_Game_State = new C_Game_Controller();
    }
}
