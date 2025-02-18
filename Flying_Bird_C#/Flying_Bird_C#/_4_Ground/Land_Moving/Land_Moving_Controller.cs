using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Flying_Bird_C_._4_Ground.Land_Moving
{
    internal class Land_Moving_Controller
    {
        //--------------------------------------------------------------------------------------------------------------------------------------------
        ///bug #0 complet land moving code....
        public void moving_The_Ground()
        {
            //----
            Thread ground_Moving_Thread = new Thread(() =>
            {
                //----
                Application.Current.Dispatcher.Invoke(() =>
                {
                    //----
                    Globals.gameArea.Children.Remove(Globals_Land.img_Land_1);
                    Globals.gameArea.Children.Remove(Globals_Land.img_Land_2);
                    //----
                    Globals_Land.left_Ground_1 = Canvas.GetLeft(Globals_Land.img_Land_1);
                    Globals_Land.left_Ground_2 = Canvas.GetLeft(Globals_Land.img_Land_2);
                    //----
                    if (Globals_Land.left_Ground_1 <= -Globals.gameArea_W)
                    {
                        Globals_Land.left_Ground_1 = Globals.gameArea_W;
                    }
                    if (Globals_Land.left_Ground_2 <= -Globals.gameArea_W)
                    {
                        Globals_Land.left_Ground_2 = Globals.gameArea_W;
                    }
                    //----
                    Globals.gameArea.Children.Add(Globals_Land.img_Land_1);
                    Globals.gameArea.Children.Add(Globals_Land.img_Land_2);
                    //----
                    Canvas.SetLeft(Globals_Land.img_Land_1, Globals_Land.left_Ground_1 - Globals_Land.land_Moving_Step);
                    Canvas.SetLeft(Globals_Land.img_Land_2, Globals_Land.left_Ground_2 - Globals_Land.land_Moving_Step);
                    //----
                });
                //----
            });
            //----
            ground_Moving_Thread.Start();
            //----
            Globals_Land.ground_Moving_Thread = ground_Moving_Thread;
            //----
        }
      
        //--------------------------------------------------------------------------------------------------------------------------------------------
    }


}
