using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace Flying_Bird_C_.__Globals
{
    internal class Globals_Land
    {
        public static Image img_Land_1 = new Image();
        public static int land_W_1 = Globals.gameArea_W;
        public static int land_H_1 = 200;
        public static double left_Ground_1 = 0;

        public static int ground_Hight = 200;

        public static Image img_Land_2 = new Image();
        public static int land_W_2 = Globals.gameArea_W ;
        public static int land_H_2 = 200;
        public static double left_Ground_2 = left_Ground_1+land_W_1;

        public static Image img_Land_3 = new Image();
        public static int land_W_3 = Globals.gameArea_W;
        public static int land_H_3 = 200;
        public static double left_Ground_3 = left_Ground_2+land_W_2;

        public static double ground_Top = Globals.gameArea_H - ground_Hight;

        public static int land_Moving_Step = 10;
        public static Thread ground_Moving_Thread = new Thread(() =>
        {
        
        });

    }
}
