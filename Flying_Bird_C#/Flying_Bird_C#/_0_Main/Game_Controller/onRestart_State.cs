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
    internal class onRestart_State : I_Game_Controller_Runnable
    {
        #region The Fields
        #endregion
        //------------------------------------------------------------------------------------------------------------
        public void Run(
            Window mWindow,
            MainWindow_Handler obj_MWindow_Handler,
            GameArea_Handler obj_GameArea_Handler,
            Player_Creating obj_Player_Creating,
             OnStart_State obj_OnStart_State,
            onRun_State obj_OnRun_Controller,
            onRestart_State obj_onRestart_Controller,
            onPause_State obj_OnPause_Contorller)
        {
            //----
            Globals.gameArea.Children.Clear();
            Globals.Score = 0;
            Globals_Pipes.li_Of_Pipes.Clear();
            Globals_Player.should_I_Move_Player_Up = false;
            Globals_Player.should_I_Move_Player_Down = true;
          //  remove_All_Pipes();

            Globals.current_Game_State = obj_OnStart_State;
            Globals.current_Game_State.Run(
                    mWindow,
                 obj_MWindow_Handler,
                 obj_GameArea_Handler,
                obj_Player_Creating,
                  obj_OnStart_State,
                obj_OnRun_Controller,
                obj_onRestart_Controller,
                 obj_OnPause_Contorller);
            // remove all childeren in the game Area....
            // reset all counters and lists
            //restart the level by:-....make the Runnable equal to onCreate_Controller...

            //----
        }
    }
}
