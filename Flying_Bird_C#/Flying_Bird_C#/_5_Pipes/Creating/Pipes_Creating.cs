using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace Flying_Bird_C_._5_Pipes.Creating
{
    internal class Pipes_Creating
    {
        #region Fields
      
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
                        BitmapImage bitmap_Up_Pipe_Imgae = get_The_Down_Image();
                       
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
                        BitmapImage bitmap_Down_Pipe_Imgae = get_The_UP_Image();
                        //----
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
                    // down pipe
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        if (Globals_Pipes.li_Of_Pipes[i].Parent is Panel parentPanel)
                        {
                            parentPanel.Children.Remove(Globals_Pipes.li_Of_Pipes[i]); // Remove it from the old parent
                        }
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
                    // down pipes
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        if (Globals_Pipes.li_Of_Pipes[i].Parent is Panel parentPanel)
                        {
                            parentPanel.Children.Remove(Globals_Pipes.li_Of_Pipes[i]); // Remove it from the old parent
                        }
                        //----
                        Globals.gameArea.Children.Add(Globals_Pipes.li_Of_Pipes[i]);
                        //----
                        Canvas.SetLeft(Globals_Pipes.li_Of_Pipes[i],
                            Globals_Pipes.starting_Left);
                    Canvas.SetTop(Globals_Pipes.li_Of_Pipes[i], Globals_Pipes.down_Pipes_Top
                          );
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
        private BitmapImage get_The_Down_Image()
        {
            string str_Image_Path = "pack://application:,,,/Assets/Photos/pipedown.png";

            BitmapImage bitmap_Up_Pipe_Imgae = new BitmapImage();
            bitmap_Up_Pipe_Imgae.BeginInit();
            bitmap_Up_Pipe_Imgae.UriSource = new Uri(str_Image_Path, UriKind.Absolute);
            bitmap_Up_Pipe_Imgae.EndInit();

            return bitmap_Up_Pipe_Imgae;
        }
        //--------------------------------------------------------------------------------------------------------------------------
        private BitmapImage get_The_UP_Image()
        {
            string str_Image_Path = "pack://application:,,,/Assets/Photos/pipe.png";
            BitmapImage bitmap_Down_Pipe_Imgae = new BitmapImage();
            bitmap_Down_Pipe_Imgae.BeginInit();
            bitmap_Down_Pipe_Imgae.UriSource = new Uri(str_Image_Path, UriKind.Absolute);
            bitmap_Down_Pipe_Imgae.EndInit();

            return bitmap_Down_Pipe_Imgae;
        }
    }
}
