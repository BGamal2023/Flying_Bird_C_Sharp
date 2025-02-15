using Flying_Bird_C_._3_Player.Moving_Player_Up_Down;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flying_Bird_C_.__Globals
{
    internal class Globals_Player
    {
        public static I_Moving_Player_Up_Down_Runnable I_Player_Current_Movin=new C_Moving_Player_Up_Down();
        public static Thread player_Moving_Thread = new Thread(() =>
        {

        });
        public static bool should_I_Move_Player_Up=false;
        public static bool should_I_Move_Player_Down=true;  
    }
}
