using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._1_MainWindow_Handler;
using Flying_Bird_C_._2_GameArea_Handler;
using Flying_Bird_C_._3_Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Flying_Bird_C_._0_Main.Game_Controller
{
    internal class Game_Controller
    {
        #region Fields
        private MainWindow_Handler obj_MWindow_Handler = new MainWindow_Handler();
        private GameArea_Handler obj_GameArea_Handler = new GameArea_Handler();
        private OnCreate_Controller obj_OnCreate_Controller = new OnCreate_Controller();
        private Player_Handler obj_Player_Creating=new Player_Handler();
        #endregion
        //----------------------------------------------------------------------------------------------------------------------
        public void start_The_Game(
             Window mWindow)
        {
            Globals.current_Game_State = obj_OnCreate_Controller;
            obj_OnCreate_Controller.Run(
               mWindow,
              obj_MWindow_Handler,
              obj_GameArea_Handler,
              obj_Player_Creating);

        }
        //----------------------------------------------------------------------------------------------------------------------

    }
}
