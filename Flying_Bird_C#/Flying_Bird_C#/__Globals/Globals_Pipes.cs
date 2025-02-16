using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Flying_Bird_C_.__Globals
{
    internal class Globals_Pipes
    {
       
        public static List<Image> li_Of_Pipes= new List<Image>();   
        public static int num_Of_Pipes = 4;
        public static int width_Of_Pipe = 50;
        public static int height_Of_Pipe = 50;
        /// bug # 0 return the canceld line again 
        //public static int width_Bet_Pipes = 300;
        public static int width_Bet_Pipes = 100;

        public static List<int> li_Of_Heights_Of_Pipes=new List<int>();

        public static double starting_Left = 0;

       // public static double starting_Left = Globals.gameArea.Width + 200;
       
        
    }
}
