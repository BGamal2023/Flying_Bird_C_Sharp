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
        private Game_Controller obj_Game_Controller=new Game_Controller();
        #endregion
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
            public MainWindow()
        {
            InitializeComponent();
            obj_Game_Controller.start_The_Game(this);
        }
    }
}