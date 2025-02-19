using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Flying_Bird_C_._4_Ground
{
    internal class The_Game_Ground
    {
        Image ground_Image;
        double left;
        double top;
        int width;
        int height;
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        public The_Game_Ground(Image ground_Image, double left, double top, int width, int height)
        {
            this.ground_Image = ground_Image;
            this.left = left;
            this.top = top;
            this.width = width;
            this.height = height;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------
    }
}


