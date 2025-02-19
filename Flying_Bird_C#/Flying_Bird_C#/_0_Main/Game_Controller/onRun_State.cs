using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._1_MainWindow_Handler;
using Flying_Bird_C_._2_GameArea_Handler;
using Flying_Bird_C_._3_Player;
using Flying_Bird_C_._3_Player.Moving_Player_Up_Down;
using Flying_Bird_C_._4_Ground.Land_Moving;
using Flying_Bird_C_._5_Pipes.Moving;
using Flying_Bird_C_._6_Collision;
using Flying_Bird_C_._8_Pop_Up_Menus;
using Flying_Bird_C_._A_10_General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Flying_Bird_C_._0_Main.Game_Controller
{
    internal class onRun_State : I_Game_Controller_Runnable
    {
        ///bug # 0 remove local variables and deliver it to run of the runnable
        #region Fields
        private Moving_Player_Controller obj_Moving_Player_Controller = new Moving_Player_Controller();
        private Land_Moving_Controller obj_Land_Moving_Controller = new Land_Moving_Controller();
        private Pipes_Moving_Handler obj_Pipes_Moving_Handler = new Pipes_Moving_Handler();
        private Collision_Handler obj_Collision_Handler = new Collision_Handler();
        private Loss_LIfe_Popup_Menu obj_Loss_Life_Popup_Menu=new Loss_LIfe_Popup_Menu();
        #endregion
        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        public void Run(
            Window mWindow,
            MainWindow_Handler obj_MWindow_Handler,
            GameArea_Handler obj_GameArea_Handler,
            Player_Creating obj_Player_Handler,
             OnStart_State obj_OnStart_State,
            onRun_State obj_OnRun_Controller,
            onRestart_State obj_onRestart_Controller,
            onPause_State obj_OnPause_Contorller)
        {
            //----
            Thread running_Thread = new Thread(() =>
            {
                //----
                while (true)
                {
                    //----
                    DateTime start = DateTime.Now;
                    // moving the player
                    obj_Moving_Player_Controller.handle_Moving_The_Player();
                    //----
                    obj_Land_Moving_Controller.moving_The_Ground();
                    //----
                    obj_Pipes_Moving_Handler.handl_The_Moving_Of_The_Pipes();
                    //---
                    // collison handling
                    obj_Collision_Handler.handle_The_Collision();
                    //----
                    obj_Loss_Life_Popup_Menu.handle_Showing_Message(
                          mWindow,
             obj_MWindow_Handler,
             obj_GameArea_Handler,
            obj_Player_Handler,
              obj_OnStart_State,
            obj_OnRun_Controller,
            obj_onRestart_Controller,
             obj_OnPause_Contorller);
                    /// bug #0 here join all running threads.............
                    Globals_Player.player_Moving_Thread.Join();
                    Globals_Land.ground_Moving_Thread.Join();
                    //----

                    DateTime end = DateTime.Now;
                    TimeSpan diff = end - start;
                    Log.log(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    Log.log("The Total Time = " + diff.TotalMilliseconds);
                    //----
                    if (diff.TotalMilliseconds < Globals.minimum_Time_For_One_Loop_Of_The_Game)
                    {
                        Thread.Sleep((int)(Globals.minimum_Time_For_One_Loop_Of_The_Game - diff.TotalMilliseconds));

                    }
                    //----
                    DateTime end_2 = DateTime.Now;
                    TimeSpan diff_2 = end_2 - start;
                    //----
                    Log.log(" total time after sleeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeep= " + diff_2.TotalMilliseconds);
                }
                //----
            });
            //----
            running_Thread.Start();
            //----
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
