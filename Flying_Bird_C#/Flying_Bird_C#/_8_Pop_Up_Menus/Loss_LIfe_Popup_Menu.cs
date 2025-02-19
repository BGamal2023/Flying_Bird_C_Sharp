using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Windows;
using System.Diagnostics;
using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._0_Main.Game_Controller;
using Flying_Bird_C_._1_MainWindow_Handler;
using Flying_Bird_C_._2_GameArea_Handler;
using Flying_Bird_C_._3_Player;

namespace Flying_Bird_C_._8_Pop_Up_Menus
{
    internal class Loss_LIfe_Popup_Menu
    {
        #region The Fields
        private bool isMessageBoxOpen = false;
        #endregion
        //--------------------------------------------------------------------------------------------------
        public void handle_Showing_Message(
             Window mWindow,
            MainWindow_Handler obj_MWindow_Handler,
            GameArea_Handler obj_GameArea_Handler,
            Player_Creating obj_Player_Creating,
             OnStart_State obj_OnStart_State,
            onRun_State obj_OnRun_Controller,
            onRestart_State obj_onRestart_Controller,
            onPause_State obj_OnPause_Contorller)
        {
            if (Globals_Collision.does_Collision_Happend)
            {
                if (isMessageBoxOpen)
                {
                    return;
                }


                    isMessageBoxOpen = true; // Mark as open

                show_Message(
                      mWindow,
             obj_MWindow_Handler,
             obj_GameArea_Handler,
            obj_Player_Creating,
              obj_OnStart_State,
            obj_OnRun_Controller,
            obj_onRestart_Controller,
             obj_OnPause_Contorller);

                Globals_Collision.does_Collision_Happend = false;


                isMessageBoxOpen = false; // Reset flag after MessageBox is closed
                
                    



            }
        }
        //---------------------------------------------------------------------------------------------------------------
        private void show_Message(
            Window mWindow,
            MainWindow_Handler obj_MWindow_Handler,
            GameArea_Handler obj_GameArea_Handler,
            Player_Creating obj_Player_Creating,
             OnStart_State obj_OnStart_State,
            onRun_State obj_OnRun_Controller,
            onRestart_State obj_onRestart_Controller,
            onPause_State obj_OnPause_Contorller)
        {
            MessageBoxResult result = MessageBox.Show("You lost a life! Do you want to restart?",
                                                     "Game Over",
                                                     MessageBoxButton.YesNo,
                                                     MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                RestartGame(
                      mWindow,
             obj_MWindow_Handler,
             obj_GameArea_Handler,
            obj_Player_Creating,
              obj_OnStart_State,
            obj_OnRun_Controller,
            obj_onRestart_Controller,
             obj_OnPause_Contorller);
            }
            else
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Application.Current.Shutdown();

                });
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        private void RestartGame(
            Window mWindow,
            MainWindow_Handler obj_MWindow_Handler,
            GameArea_Handler obj_GameArea_Handler,
            Player_Creating obj_Player_Creating,
             OnStart_State obj_OnStart_State,
            onRun_State obj_OnRun_Controller,
            onRestart_State obj_onRestart_Controller,
            onPause_State obj_OnPause_Contorller)
        {
            Globals_Collision.does_Collision_Happend = false;
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
            //  MessageBox.Show("Game Restarting...");
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}
