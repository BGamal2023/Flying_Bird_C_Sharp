using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Flying_Bird_C_._1_MainWindow_Handler
{
    internal class MainWindow_Handler
    {
        #region Fields
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------
        public void handle_The_MainWindow(Window mWindow)
        {
            //----
            adjust_Height_Width_And_Background_Of_The_MainWindow(mWindow);
            //----
            show_The_MainWindow_In_The_Middle_Of_Screen(mWindow);
            //----
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void adjust_Height_Width_And_Background_Of_The_MainWindow(Window mWindow)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                mWindow.Width = Globals.mWindow_W;
                mWindow.Height = Globals.mWindow_H;
            });
          
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void show_The_MainWindow_In_The_Middle_Of_Screen(Window mWindow)
        {
        
            Application.Current.Dispatcher.Invoke(() =>
            {
                mWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            });
        }
    }
}
