using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._A_10_General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;

namespace Flying_Bird_C_._4_Land
{
    internal class Land_Creating
    {
        ///bug #0 i copied all code from player .....should remove all what related to player and add land
        #region Fields
        ///bug #0 change name of land to ground
        #endregion
        //-------------------------------------------------------------------------------------------------------------
        public void set_Land_Dimension()
        {
            Globals_Land.img_Land_1.Width = Globals_Land.land_W_1;
            Globals_Land.img_Land_1.Height = Globals_Land.land_H_1;

            Globals_Land.img_Land_2.Width = Globals_Land.land_W_2;
            Globals_Land.img_Land_2.Height = Globals_Land.land_H_2;

        }
        //-------------------------------------------------------------------------------------------------------------
        public void get_Image_From_Assets_For_The_Ground()
        {


            string str_Land_Image_Path = "pack://application:,,,/Assets/Photos/ground.png";
            BitmapImage bitmap = new BitmapImage(new Uri(str_Land_Image_Path, UriKind.Absolute));
            Globals_Land.img_Land_1.Source = bitmap;
            Globals_Land.img_Land_2.Source = bitmap;
            Globals_Land.img_Land_3.Source = bitmap;


        }
        //-------------------------------------------------------------------------------------------------------------
        public void add_The_Ground_To_The_GameArea()
        {
            //----
            Globals.gameArea.Children.Add(Globals_Land.img_Land_1);
            Globals.gameArea.Children.Add(Globals_Land.img_Land_2);
         

            //----
            
            double top_Ground_1= Globals.gameArea.Height - Globals_Land.img_Land_1.Height;

          
            double top_Ground_2 = Globals.gameArea.Height - Globals_Land.img_Land_2.Height;

           
          

            //----
            Canvas.SetLeft(Globals_Land.img_Land_1, Globals_Land.left_Ground_1);
            Canvas.SetTop(Globals_Land.img_Land_1, top_Ground_1);

            Canvas.SetLeft(Globals_Land.img_Land_2, Globals_Land.left_Ground_2);
            Canvas.SetTop(Globals_Land.img_Land_2, top_Ground_2);

          
            Log.log("*************************************************************");
            //Log.log("the center x = " + left_Ground_1);
            Log.log("the center y= " + top_Ground_1);
            Log.log("*************************************************************");
            //----
        }
    }
}
