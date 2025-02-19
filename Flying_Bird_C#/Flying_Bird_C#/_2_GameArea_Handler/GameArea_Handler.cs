﻿using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static System.Formats.Asn1.AsnWriter;

using System.Xml.Linq;


namespace Flying_Bird_C_._2_GameArea_Handler
{
    internal class GameArea_Handler
    {
        #region Fields
        #endregion 
        //-------------------------------------------------------------------------------------------------------------------
        public void handle_The_GameArea(Window mWindow)
        {
            //----
            create_The_GameArea();
            //----
            add_The_GameArea_To_The_MainWindow(mWindow);
            //---
            add_Score_Label_On_The_GameArea();
            //----
            add_Score_Box_To_The_GameArea();
            //----
        }
        //------------------------------------------------------------------------------------------------------------------------\
        private void create_The_GameArea()
        {
            /// bug #0 ...i think this will cause issue

            Application.Current.Dispatcher.Invoke(() =>
            {
                Globals.gameArea = new Canvas();
                Globals.gameArea.Height = Globals.mWindow_H;
                Globals.gameArea.Width = Globals.mWindow_W;
                Globals.gameArea.Background = Brushes.Aqua;


            });

            
        }

        //------------------------------------------------------------------------------------------------------------------------\
        private void add_The_GameArea_To_The_MainWindow(Window mWindow )
        {
            mWindow.Dispatcher.Invoke(() =>
            {
                mWindow.Content = Globals.gameArea;

            });

        }
        //------------------------------------------------------------------------------------------------------------------------\
        private void add_Score_Label_On_The_GameArea( )
        {

            //----
            Application.Current.Dispatcher.Invoke((Delegate)(() =>
            {
                //----
                Label score_Lable = new Label
                {
                    Content = "Score :",
                    FontSize = 25,
                    Foreground = System.Windows.Media.Brushes.Black
                };
                //----
                Canvas.SetLeft(score_Lable, Globals.score_Lable_Left);
                Canvas.SetTop(score_Lable, Globals.score_Lable_Top);
                Canvas.SetZIndex(score_Lable,Globals.zIndex_Score_Lable);
                //----
                Globals.gameArea.Children.Add(score_Lable);
                //----
            }));
            //----

        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void add_Score_Box_To_The_GameArea( )
        {
            //----
            Application.Current.Dispatcher.Invoke(() =>
            {
                //----
                Globals.scoreTextBlock = new TextBlock
                {
                    FontSize = Globals.score_TextBlock_FontSize,
                    FontWeight = FontWeights.Bold,
                    Foreground = Brushes.Black,
                    Text = $"{Globals.Score}",
                    Margin = new Thickness(
                        Globals.score_TextBlock_Left,
                        Globals.score_TextBlock_Top,
                        0,
                        0)
                };
                //----
                Globals.gameArea.Children.Add(Globals.scoreTextBlock);
                Canvas.SetZIndex(Globals.scoreTextBlock,Globals.zIndex_Score_TextBlock);
                //----
            });
            //----
        }
       
        //--------------------------------------------------------------------------------------------------------------------------


    }
}
