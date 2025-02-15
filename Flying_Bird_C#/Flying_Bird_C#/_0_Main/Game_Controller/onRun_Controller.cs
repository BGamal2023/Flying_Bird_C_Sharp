﻿using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._1_MainWindow_Handler;
using Flying_Bird_C_._2_GameArea_Handler;
using Flying_Bird_C_._3_Player;
using Flying_Bird_C_._3_Player.Moving_Player_Up_Down;
using Flying_Bird_C_._A_10_General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Flying_Bird_C_._0_Main.Game_Controller
{
    internal class onRun_Controller : I_Game_Controller_Runnable
    {
        private Moving_Player_Controller obj_Moving_Player_Controller=new Moving_Player_Controller();
        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        public void Run(
            Window mWindow,
            MainWindow_Handler obj_MWindow_Handler,
            GameArea_Handler obj_GameArea_Handler,
            Player_Creating obj_Player_Handler,
            onRun_Controller obj_OnRun_Controller,
            onRestart_Controller obj_onRestart_Controller,
            onPause_Controller obj_OnPause_Contorller)
        {
            Thread running_Thread = new Thread(() =>
            {
                while (true)
                {
                    DateTime start = DateTime.Now;

                    // moving the player
                    //    obj_Player_Moving.hadle_The_Moving_Of_The_Player();
                    obj_Moving_Player_Controller.handle_Moving_The_Player();
                    //----
                    // moving the land
                    //----
                    //moving the pipes
                    //----




                    /// bug #0 here join all running threads.............
                    Globals_Player.player_Moving_Thread.Join();

                    DateTime end = DateTime.Now;
                    TimeSpan diff = end - start;
                    Log.log(")))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))");
                    Log.log("The Total Time = "+diff.TotalMilliseconds);


                    if(diff.TotalMilliseconds < Globals.minimum_Time_For_One_Loop_Of_The_Game  ) 
                    {
                        Thread.Sleep((int)(Globals.minimum_Time_For_One_Loop_Of_The_Game - diff.TotalMilliseconds));
                    
                    }
                    DateTime end_2= DateTime.Now;

                    TimeSpan diff_2 = end_2 - start;
                    Log.log(" total time after sleeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeep= " + diff_2.TotalMilliseconds);
                }

            });
            running_Thread.Start();





        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
