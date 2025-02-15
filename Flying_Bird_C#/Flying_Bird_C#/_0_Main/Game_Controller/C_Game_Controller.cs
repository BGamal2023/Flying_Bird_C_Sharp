using Flying_Bird;
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
    internal class C_Game_Controller : I_Game_Controller_Runnable
    {

        public void Run(
            Window mWindow,
            MainWindow_Handler obj_MWindow_Handler,
            GameArea_Handler obj_GameArea_Handler,
            Player_Creating obj_Player_Creating,
            onRun_Controller obj_OnRun_Controller,
            onRestart_Controller obj_onRestart_Controller,
            onPause_Controller obj_OnPause_Contorller)
        {
         //   throw new NotImplementedException();
        }

        //---------------------------------------------------------------------------------------------------
    }
}
