using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Imaging;

namespace Flying_Bird_C_._3_Player
{
    internal class Player_Handler
    {
        #region Fields

        #endregion
        //-------------------------------------------------------------------------------------------------------------
        public void set_Player_Dimension()
        {
            Globals.player.Width = Globals.player_W;
            Globals.player.Height = Globals.player_H;
            
        }
        //-------------------------------------------------------------------------------------------------------------
        public void get_Image_From_Assets_For_The_Player()
        {
            string str_Player_Image_Path = "./Assets/Photos/bird.png";
            BitmapImage bitmap =
                new BitmapImage(new Uri(str_Player_Image_Path, UriKind.RelativeOrAbsolute));

            Globals.player.Source = bitmap;
        }
        //-------------------------------------------------------------------------------------------------------------
        public void add_The_Player_To_The_GameArea()
        {
            //----
            Globals.gameArea.Children.Add(Globals.player);
            //----
            double centerX = (Globals.gameArea.ActualWidth - Globals.player.Width) / 2;
            double centerY = (Globals.gameArea.ActualHeight - Globals.player.Height) / 2;
            //----
            Canvas.SetLeft(Globals.player, centerX);
            Canvas.SetTop(Globals.player, centerY);
            //----
        }
    }
}
