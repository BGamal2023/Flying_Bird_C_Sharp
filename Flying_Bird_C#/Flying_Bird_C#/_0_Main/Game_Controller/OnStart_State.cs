﻿using Flying_Bird;
using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._1_MainWindow_Handler;
using Flying_Bird_C_._2_GameArea_Handler;
using Flying_Bird_C_._3_Player;
using Flying_Bird_C_._4_Ground;
using Flying_Bird_C_._5_Pipes.Creating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Flying_Bird_C_._0_Main.Game_Controller
{
    internal class OnStart_State : I_Game_Controller_Runnable
    {
        ///bug #0 ...remove locals field and add it to run of the interface....
        #region Fields
        private Land_Creating obj_Land_Creating=new Land_Creating();
        private Pipes_Creating obj_Pipes_Creating=new Pipes_Creating(); 
        #endregion
        //-------------------------------------------------------------------------------------------------------
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
            obj_MWindow_Handler.handle_The_MainWindow(mWindow);
            //----
            obj_GameArea_Handler.handle_The_GameArea(mWindow);
            //----
            obj_Player_Creating.set_Player_Dimension();
            obj_Player_Creating.get_Image_From_Assets_For_The_Player();
            obj_Player_Creating.add_The_Player_To_The_GameArea();
            //----
            obj_Land_Creating.set_Land_Dimension();
            obj_Land_Creating.get_Image_From_Assets_For_The_Ground();
            obj_Land_Creating.add_The_Ground_To_The_GameArea();
            //-----
            obj_Pipes_Creating.handle_Creating_And_Adding_The_Pipes_To_GameArea();
            //----
            Globals.current_Game_State = obj_OnRun_Controller;
            Globals.current_Game_State.Run(
                mWindow,
             obj_MWindow_Handler,
             obj_GameArea_Handler,
            obj_Player_Creating,
              obj_OnStart_State,
            obj_OnRun_Controller,
            obj_onRestart_Controller,
             obj_OnPause_Contorller);
            //----
        }
        //-------------------------------------------------------------------------------------------------------

    }

}
