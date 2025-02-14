using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Media.Imaging;
using Flying_Bird_C_._A_10_General;
using System.Windows;

namespace Flying_Bird_C_._3_Player
{
    internal class Player_Handler
    {
        #region Fields

        #endregion
        //-------------------------------------------------------------------------------------------------------------
        public void set_Player_Dimension()
        {
            Globals.img_Player.Width = Globals.player_W;
            Globals.img_Player.Height = Globals.player_H;
            
        }
        //-------------------------------------------------------------------------------------------------------------
        public void get_Image_From_Assets_For_The_Player()
        {
            
            try
            {
                string str_Player_Image_Path = "pack://application:,,,/Assets/Photos/bird.png"; 
                BitmapImage bitmap = new BitmapImage(new Uri(str_Player_Image_Path, UriKind.Absolute));
                Globals.img_Player.Source = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        public void add_The_Player_To_The_GameArea()
        {
            //----
            Globals.gameArea.Children.Add(Globals.img_Player);
            //----
            double centerX =Globals.gameArea.Width*0.25;
            double centerY = (Globals.gameArea.Height - Globals.img_Player.Height) / 2;
            //----
            Canvas.SetLeft(Globals.img_Player, centerX);
            Canvas.SetTop(Globals.img_Player, centerY);
     
            Log.log("*************************************************************");
            Log.log("the center x = " + centerX);
            Log.log("the center y= "+centerY);
            Log.log("*************************************************************");
            //----
        }
    }
}
