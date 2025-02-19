using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._1_MainWindow_Handler;
using Flying_Bird_C_._2_GameArea_Handler;
using Flying_Bird_C_._3_Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Flying_Bird_C_._0_Main.Game_Controller
{
    internal class Game_Controller
    {
        #region Fields
        private MainWindow_Handler obj_MWindow_Handler = new MainWindow_Handler();
        private GameArea_Handler obj_GameArea_Handler = new GameArea_Handler();
        private OnStart_State obj_OnStart_State = new OnStart_State();
        private onRun_State obj_OnRun_Controller = new onRun_State();
        private onPause_State obj_OnPause_Contorller = new onPause_State();    
        private onRestart_State obj_onRestart_Controller = new onRestart_State();
        private Player_Creating obj_Player_Creating=new Player_Creating();
        #endregion
        //----------------------------------------------------------------------------------------------------------------------
        public void start_The_Game(
             Window mWindow)
        {
            Globals.current_Game_State = obj_OnStart_State;
            Globals.current_Game_State.Run(
                mWindow,
             obj_MWindow_Handler,
             obj_GameArea_Handler,
            obj_Player_Creating,
            obj_OnStart_State,
            obj_OnRun_Controller,
            obj_onRestart_Controller,
             obj_OnPause_Contorller);



        }
        //----------------------------------------------------------------------------------------------------------------------

    }
}
