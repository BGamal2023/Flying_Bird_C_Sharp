using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Flying_Bird_C_._5_Pipes.Moving
{
    internal class Pipes_Moving_Handler
    {
        #region Fields
        #endregion
        //---------------------------------------------------------------------------------------------------------------------------------------
        public void move_The_Pipes()
        {
            Thread moving_Pipes_Thread = new Thread(() =>
            {

                Application.Current.Dispatcher.Invoke(() =>
                {
                    //----
                    for(int i=0;i<Globals_Pipes.li_Of_Pipes.Count;i++)
                    {

                        Image i_Pipe= Globals_Pipes.li_Of_Pipes[i];

                        Globals.gameArea.Children.Remove(i_Pipe);

                        double left = Canvas.GetLeft(i_Pipe);

                        if(left<0)
                        {
                            Image last_Pipe = Globals_Pipes.li_Of_Pipes.Last();

                            double left_Of_Last_Pipe= Canvas.GetLeft(last_Pipe);
                            left = left_Of_Last_Pipe + Globals_Pipes.width_Of_Pipe + Globals_Pipes.width_Bet_Pipes;
                        }


                        Globals.gameArea.Children.Add(i_Pipe);

                        Canvas.SetLeft(i_Pipe, left-Globals_Pipes.pipes_Moving_Step);


                    }
                    //----
                });

            });
            moving_Pipes_Thread.Start();
            Globals_Pipes.moving_Pipes_Thread=moving_Pipes_Thread;
        }
    }
}
