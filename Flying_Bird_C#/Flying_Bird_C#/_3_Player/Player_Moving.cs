using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Flying_Bird_C_._3_Player
{
    internal class Player_Moving
    {
        #region Fields
        #endregion
        //-----------------------------------------------------------------------------------------------------------------------------
        public void move_The_Player()
        {
            Thread player_Moving_Thread = new Thread(() =>
            {
                moving_player_Down();
            });
            player_Moving_Thread.Start();
            Globals.moving_Player_Thread = player_Moving_Thread;
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void moving_player_Down()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                double top = Canvas.GetTop(Globals.img_Player);
                Canvas.SetTop(Globals.img_Player, top + Globals.player_Moving_Step);
            });
          
        }
    }
}
