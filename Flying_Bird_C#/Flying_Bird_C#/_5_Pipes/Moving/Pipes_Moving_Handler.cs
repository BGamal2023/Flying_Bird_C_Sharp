using Flying_Bird_C_.__Globals;
using Flying_Bird_C_._7_Score;
using Flying_Bird_C_._A_10_General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Flying_Bird_C_._5_Pipes.Moving
{
    internal class Pipes_Moving_Handler
    {
        #region Fields
        private int count = 0;
        #endregion
        //--------------------------------------------------------------------------------------------------------------------------------------
        public void handl_The_Moving_Of_The_Pipes()
        {
           // move_The_Pipes_V1();
            move_The_Pipes_V2();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void move_The_Pipes_V1()
        {


            


            //----
            foreach (var i_Pipe in Globals_Pipes.li_Of_Pipes.ToList())
            {

                Thread thread = new Thread(() =>
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        Globals.gameArea.Children.Remove(i_Pipe);

                        double left = Canvas.GetLeft(i_Pipe);
                        if (left < -Globals_Pipes.width_Of_Pipe)
                        {
                            Image last_Pipe = Globals_Pipes.li_Of_Pipes.Last();
                            double left_Of_Last_Pipe = Canvas.GetLeft(last_Pipe);
                            left = left_Of_Last_Pipe + Globals_Pipes.width_Bet_Pipes;

                            Globals_Pipes.li_Of_Pipes.Remove(i_Pipe);
                            Globals_Pipes.li_Of_Pipes.Add(i_Pipe);
                        }

                        Globals.gameArea.Children.Add(i_Pipe);
                        Canvas.SetLeft(i_Pipe, left - Globals_Pipes.pipes_Moving_Step);
                    });
                });

                thread.Start();

                if (count == 0)
                {
                    Globals_Pipes.moving_Pipes_Thread_1 = thread;
                }
                else if (count == 1)
                {
                    Globals_Pipes.moving_Pipes_Thread_2 = thread;
                }
                else if (count == 2)
                {
                    Globals_Pipes.moving_Pipes_Thread_3 = thread;
                }
                else if (count == 3)
                {
                    Globals_Pipes.moving_Pipes_Thread_4 = thread;
                }
                else
                {

                }

                count++;
                if (count > 3)
                {
                    count = 0;
                }
            }
            //----




        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private void move_The_Pipes_V2()
        {
            //----
            Thread thread = new Thread(() =>
            {
                //----
                foreach (var i_Pipe in Globals_Pipes.li_Of_Pipes.ToList())
                {
                    //----
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //----
                        Globals.gameArea.Children.Remove(i_Pipe);
                        //----
                        double left = Canvas.GetLeft(i_Pipe);
                        //----
                        if (left < -Globals_Pipes.width_Of_Pipe)
                        {
                            //--
                            Image last_Pipe = Globals_Pipes.li_Of_Pipes.Last();
                            //--
                            double left_Of_Last_Pipe = Canvas.GetLeft(last_Pipe);
                            //--
                            left = left_Of_Last_Pipe + Globals_Pipes.width_Bet_Pipes;
                            //--
                            Globals_Pipes.li_Of_Pipes.Remove(i_Pipe);
                            Globals_Pipes.li_Of_Pipes.Add(i_Pipe);
                            //--
                            Score_Handler.IncreaseScore();
                            //--
                        }
                        //----
                        Globals.gameArea.Children.Add(i_Pipe);
                        Canvas.SetLeft(i_Pipe, left - Globals_Pipes.pipes_Moving_Step);
                        //----
                    });
                    //----
                }
                //----
            });
            //----
            thread.Start();
            //----
        }
        //---------------------------------------------------------------------------------------------------------------------------------------

    }
}
