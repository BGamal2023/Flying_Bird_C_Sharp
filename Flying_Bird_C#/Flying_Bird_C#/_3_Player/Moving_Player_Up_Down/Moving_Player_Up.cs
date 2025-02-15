using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Flying_Bird_C_._3_Player.Moving_Player_Up_Down
{
    internal class Moving_Player_Up:I_Moving_Player_Up_Down_Runnable
    {
        #region Fields
        #endregion
        //-----------------------------------------------------------------------------------------------------------------------------
        public void Run()
        {
            moving_player_Up();
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void moving_player_Up()
        {
            //remove the player from 
            // update the place
            // re add again

            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                Globals.gameArea.Children.Remove(Globals.img_Player);
                //----
                double top = Canvas.GetTop(Globals.img_Player);
                //----
                Globals.gameArea.Children.Add(Globals.img_Player);
                Canvas.SetTop(Globals.img_Player, top - Globals.player_Moving_Step);
                //----
            });

        }

    }
}
