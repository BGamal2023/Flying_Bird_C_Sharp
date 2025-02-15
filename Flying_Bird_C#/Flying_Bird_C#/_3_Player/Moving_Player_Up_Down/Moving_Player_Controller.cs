using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._A_10_General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flying_Bird_C_._3_Player.Moving_Player_Up_Down
{
    internal class Moving_Player_Controller
    {
        #region Fields
        private Moving_Player_Down obj_Moving_Player_Down = new Moving_Player_Down();
        private Moving_Player_Up obj_Moving_Player_Up = new Moving_Player_Up();
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------
        public void handle_Moving_The_Player()
        {

            Thread player_Moving_Thread = new Thread(() =>
            {

                if (Globals_Player.should_I_Move_Player_Down)
                {
                    Globals_Player.I_Player_Current_Movin = obj_Moving_Player_Down;
                    Globals_Player.I_Player_Current_Movin.Run();
                }
                else if (Globals_Player.should_I_Move_Player_Up)
                {
                    Globals_Player.I_Player_Current_Movin = obj_Moving_Player_Up;
                    Globals_Player.I_Player_Current_Movin.Run();
                }
                else
                {

                }


                Log.log("Should i move player down = " + Globals_Player.should_I_Move_Player_Down);
                Log.log("Should i move player up = " + Globals_Player.should_I_Move_Player_Up);
            });
            player_Moving_Thread.Start();
            Globals_Player.player_Moving_Thread=player_Moving_Thread;   


        }
        //---------------------------------------------------------------------------------------------------------------------------

    }
}
