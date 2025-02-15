using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._0_Main.Game_Controller;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Flying_Bird
{

    public partial class MainWindow : Window
    {
        #region Fields
        private Game_Controller obj_Game_Controller = new Game_Controller();
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MainWindow()
        {
            InitializeComponent();
            obj_Game_Controller.start_The_Game(this);


            this.KeyDown += onKeyDown;
            this.KeyUp += onKeyUp;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void onKeyUp(object sender, KeyEventArgs e)
        {
            Globals_Player.should_I_Move_Player_Down = true;
            Globals_Player.should_I_Move_Player_Up = false;

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            Globals_Player.should_I_Move_Player_Up = true;
            Globals_Player.should_I_Move_Player_Down = false;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}