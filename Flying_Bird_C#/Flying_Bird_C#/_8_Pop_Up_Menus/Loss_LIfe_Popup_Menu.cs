using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Windows;

namespace Flying_Bird_C_._8_Pop_Up_Menus
{
    internal class Loss_LIfe_Popup_Menu:Window
    {
        #region The Fields
        #endregion
        //--------------------------------------------------------------------------------------------------
        public Loss_LIfe_Popup_Menu()
        {
            //----
            Title = "Game Over";
            Width = 300;
            Height = 200;
            //----
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //----
            StackPanel mainPanel = new StackPanel
            {
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            //----
            TextBlock messageText = new TextBlock
            {
                Text = "YOU LOST ONE LIFE",
                FontSize = 16,
                FontWeight = FontWeights.Bold,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(10)
            };
            //----
            StackPanel buttonPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(10)
            };
            //----
            Button restartButton = CreateButton("Restart", RestartButton_Click);
            Button chooseLevelButton = CreateButton("Choose Another Level", ChooseLevelButton_Click);
            Button exitButton = CreateButton("Exit Game", ExitButton_Click);
            //----
            buttonPanel.Children.Add(restartButton);
            buttonPanel.Children.Add(chooseLevelButton);
            //----
            StackPanel bottomPanel = new StackPanel
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(10)
            };
            //----
            bottomPanel.Children.Add(exitButton);
            mainPanel.Children.Add(messageText);
            mainPanel.Children.Add(buttonPanel);
            mainPanel.Children.Add(bottomPanel);
            //----
            Content = mainPanel;
            //----
        }
        //-------------------------------------------------------------------------------------------------
        private Button CreateButton(string text, RoutedEventHandler clickHandler)
        {
            return new Button
            {
                Content = text,
                Margin = new Thickness(5),
                Padding = new Thickness(10),
                ClickMode = ClickMode.Release,
                /// bug #8 it give me 2 alarms pls check why and continue
          //     Click += clickHandler
            };
        }
        //--------------------------------------------------------------------------------------------------
        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Restart button pressed");
            Close();
        }
        //--------------------------------------------------------------------------------------------------
        private void ChooseLevelButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Choose Another Level button pressed");
            Close();
        }
        //--------------------------------------------------------------------------------------------------
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Exit Game button pressed");
            Application.Current.Shutdown();
        }
        //--------------------------------------------------------------------------------------------------

    }
}
