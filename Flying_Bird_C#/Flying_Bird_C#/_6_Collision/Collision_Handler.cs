using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._A_10_General;

namespace Flying_Bird_C_._6_Collision
{
    internal class Collision_Handler
    {
        #region The Fields
        #endregion
        //---------------------------------------------------------------------------------------------------------------
        public void handle_The_Collision()
        {
            //----
            bool ground_Collision =
                does_Ground_Collison_Happend();
            bool pipe_Collision =
                does_Pipe_Collision_Happend();
            //----
            if (ground_Collision || pipe_Collision)
            {
                Globals_Collision.does_Collision_Happend = true;
            }
            //----

        }
        //---------------------------------------------------------------------------------------------------------------
        private bool does_Ground_Collison_Happend()
        {
            //----
            bool collision_1 =
                does_Collision_Happend(Globals.img_Player, Globals_Land.img_Land_1);
            bool collision_2 =
                does_Collision_Happend(Globals.img_Player, Globals_Land.img_Land_2);
            bool collision_3 =
                does_Collision_Happend(Globals.img_Player, Globals_Land.img_Land_3);
            //----
            if (collision_1 ||
                 collision_2 ||
                 collision_3)
            {
                return true;
            }
            //----
            return false;
            //----
        }
        //---------------------------------------------------------------------------------------------------------------
        private bool does_Pipe_Collision_Happend()
        {
            //----
            if (Globals.img_Player == null)
            {
                return false;
            }
            //----
            ///bug #6 ...i added .ToList().....
            //----
            foreach (Image i_Pipe in Globals_Pipes.li_Of_Pipes.ToList())
            {
                bool collision = does_Collision_Happend(Globals.img_Player, i_Pipe);
                if (collision)
                {
                    return true;
                }
            }
            //----
            return false;
            //----
        }
        //----------------------------------------------------------------------------------------------------------------
        private bool does_Collision_Happend(Image image1, Image image2)
        {
            //----
            bool does_Thread_Finished = false;
            Rect rect1;
            Rect rect2;
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                rect1 = new Rect(Canvas.GetLeft(image1), Canvas.GetTop(image1), image1.ActualWidth, image1.ActualHeight);
                rect2 = new Rect(Canvas.GetLeft(image2), Canvas.GetTop(image2), image2.ActualWidth, image2.ActualHeight);

                does_Thread_Finished = true;
            });
            //----
            while (!does_Thread_Finished)
            {
                Thread.Sleep(50);
            }
            //----
            return rect1.IntersectsWith(rect2);
            //----
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}
