using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Flying_Bird_C_._6_Collision
{
    internal class Getting_X_And_Y_For_Image
    {
        #region Fields
        #endregion
        //----------------------------------------------------------------------------------------------------------------
        public static bool does_Collision_Happend(Image image1, Image image2)
        {
            Rect rect1 = new Rect(Canvas.GetLeft(image1), Canvas.GetTop(image1), image1.ActualWidth, image1.ActualHeight);
            Rect rect2 = new Rect(Canvas.GetLeft(image2), Canvas.GetTop(image2), image2.ActualWidth, image2.ActualHeight);

            return rect1.IntersectsWith(rect2);

        }
        //----------------------------------------------------------------------------------------------------------------
    }
}
