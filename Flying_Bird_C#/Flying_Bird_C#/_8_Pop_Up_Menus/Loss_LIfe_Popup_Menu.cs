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

namespace Flying_Bird_C_._8_Pop_Up_Menus
{
    internal class Loss_LIfe_Popup_Menu
    {
        #region The Fields
        #endregion
        //--------------------------------------------------------------------------------------------------
        public void handle_Showing_Message()
        {
            if (Globals_Collision.does_Collision_Happend)
            {
                show_Message();
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        private void show_Message()
        {
            MessageBoxResult result = MessageBox.Show("You lost a life! Do you want to restart?",
                                                     "Game Over",
                                                     MessageBoxButton.YesNo,
                                                     MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                RestartGame();
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
        private void RestartGame()
        {
            Globals_Collision.does_Collision_Happend = false;
            MessageBox.Show("Game Restarting...");
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}
