using Flying_Bird_C_._0_Main.Game_Controller;
using System.Windows.Controls;

namespace Flying_Bird_C_.__Globals
{
    internal class Globals
    {
        ///bug#0 move every static variable to its position
        /// MainWindow And GameArea
        public static int mWindow_H =800;
        public static int mWindow_W = 600;

        public static int gameArea_H=mWindow_H;
        public static int gameArea_W=mWindow_W;

        public static Canvas gameArea;
        ///Score
        public static int Score = 0;
        public static int Score_Lable_W = 30;
        public static int Score_Lable_H = 20;
        public static int score_Lable_Left = 5;
        public static int score_Lable_Top = 10;

        public static TextBlock scoreTextBlock;
        public static int score_TextBlock_FontSize = 25;
        public static int score_TextBlock_Left = 90;
        public static int score_TextBlock_Top = 20;

        public static int zIndex_Score_Lable = 5;
        public static int zIndex_Score_TextBlock = 5;

        ///Player
        public static Image img_Player;
        public static int player_W = 50;
        public static int player_H = 50;
        public static int player_Moving_Step = 10;

        /// Game Controller
        public static I_Game_Controller_Runnable current_Game_State = new C_Game_Controller();

        ///Threads

        public static int minimum_Time_For_One_Loop_Of_The_Game = 40;

    }
}
