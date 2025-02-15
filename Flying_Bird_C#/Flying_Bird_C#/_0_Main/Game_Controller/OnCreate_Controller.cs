using Flying_Bird;
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
using System.Windows.Controls;

namespace Flying_Bird_C_._0_Main.Game_Controller
{
    internal class OnCreate_Controller : I_Game_Controller_Runnable
    {
        #region Fields

        #endregion
        //-------------------------------------------------------------------------------------------------------
        public void Run(
            Window mWindow,
            MainWindow_Handler obj_MWindow_Handler,
            GameArea_Handler obj_GameArea_Handler,
            Player_Creating obj_Player_Creating,
            onRun_Controller obj_OnRun_Controller,
            onRestart_Controller obj_onRestart_Controller,
            onPause_Controller obj_OnPause_Contorller)
        {
            obj_MWindow_Handler.handle_The_MainWindow(mWindow);
            //----
            obj_GameArea_Handler.handle_The_GameArea(mWindow);
            //----
            obj_Player_Creating.set_Player_Dimension();
            obj_Player_Creating.get_Image_From_Assets_For_The_Player();
            obj_Player_Creating.add_The_Player_To_The_GameArea();
            //----
            Globals.current_Game_State = obj_OnRun_Controller;
            Globals.current_Game_State.Run(
                mWindow,
             obj_MWindow_Handler,
             obj_GameArea_Handler,
            obj_Player_Creating,
            obj_OnRun_Controller,
            obj_onRestart_Controller,
             obj_OnPause_Contorller);
            //----
        }
        //-------------------------------------------------------------------------------------------------------

    }

}
