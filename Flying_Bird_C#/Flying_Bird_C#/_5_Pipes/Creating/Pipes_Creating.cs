﻿using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Flying_Bird_C_._5_Pipes.Creating
{
    internal class Pipes_Creating
    {
        #region Fields
        private string img_UP_Pipes_Path = "./Assets/Photos/pipe.png";
        private string img_Down_Pipes_Path = "./Assets/Photos/pipedown.png";
        #endregion
        //--------------------------------------------------------------------------------------------------------------------------
        public void handle_Creating_And_Adding_The_Pipes_To_GameArea()
        {
            create_List_Of_Pipes();
            add_The_Pipes_To_GameArea();
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void create_List_Of_Pipes()
        {
            //----
            BitmapImage bitmap_Up_Pipe_Imgae = get_Up_Image();
            //----
            BitmapImage bitmap_Down_Pipe_Imgae = get_Down_Image();
            //----
            for (int i = 0; i < Globals_Pipes.num_Of_Pipes; i++)
            {
                //----
                if (i % 2 == 0)
                {
                    //up pipe
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        Image i_Image = new Image()
                        {
                            Width = Globals_Pipes.width_Of_Pipe,
                            Height = Globals_Pipes.height_Of_Pipe
                        };
                        //----
                        i_Image.Source = bitmap_Up_Pipe_Imgae;
                        //----
                        Globals_Pipes.li_Of_Pipes.Add(i_Image);
                        //----
                    });
                    //----
                }
                //----
                else
                {
                    // down pipe
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        Image i_Image = new Image()
                        {
                            Width = Globals_Pipes.width_Of_Pipe,
                            Height = Globals_Pipes.height_Of_Pipe
                        };
                        //----
                        i_Image.Source = bitmap_Down_Pipe_Imgae;
                        //----
                        Globals_Pipes.li_Of_Pipes.Add(i_Image);
                        //----
                    });
                    //----
                  
                }
                //----
            }
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private void add_The_Pipes_To_GameArea()
        {
            //----
            for (int i = 0; i < Globals_Pipes.li_Of_Pipes.Count; i++)
            {
                //----
                if (i % 2 == 0)
                {
                    // up pipe
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        Globals.gameArea.Children.Add(Globals_Pipes.li_Of_Pipes[i]);
                        //----
                        Canvas.SetLeft(Globals_Pipes.li_Of_Pipes[i],
                            Globals_Pipes.starting_Left);
                        Canvas.SetTop(Globals_Pipes.li_Of_Pipes[i],
                            0);
                        //----
                    });
                    //----
                }
                //----
                else
                {
                    //down pipes
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        Globals.gameArea.Children.Add(Globals_Pipes.li_Of_Pipes[i]);
                        //----
                        Canvas.SetLeft(Globals_Pipes.li_Of_Pipes[i],
                            Globals_Pipes.starting_Left);
                        Canvas.SetTop(Globals_Pipes.li_Of_Pipes[i],
                            Globals.gameArea.Height - Globals_Pipes.height_Of_Pipe);
                        //----
                    });
                   //----
                }
                //----
                Globals_Pipes.starting_Left = Globals_Pipes.starting_Left + Globals_Pipes.width_Bet_Pipes;
                //----
            }
            //----
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private BitmapImage get_Up_Image()
        {
            BitmapImage bitmap_Up_Pipe_Imgae = new BitmapImage();
            bitmap_Up_Pipe_Imgae.BeginInit();
            bitmap_Up_Pipe_Imgae.UriSource = new Uri(img_UP_Pipes_Path, UriKind.Relative);
            bitmap_Up_Pipe_Imgae.EndInit();

            return bitmap_Up_Pipe_Imgae;
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private BitmapImage get_Down_Image()
        {
            BitmapImage bitmap_Down_Pipe_Imgae = new BitmapImage();
            bitmap_Down_Pipe_Imgae.BeginInit();
            bitmap_Down_Pipe_Imgae.UriSource = new Uri(img_Down_Pipes_Path, UriKind.Relative);
            bitmap_Down_Pipe_Imgae.EndInit();

            return bitmap_Down_Pipe_Imgae;
        }
    }
}
