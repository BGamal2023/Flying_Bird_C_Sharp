using Flying_Bird_C_.__Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flying_Bird_C_._7_Score
{
    internal class Score_Handler
    {
        #region The Fields
        #endregion
        /// bug #7 ...change the position of invoking the increasing score from pipe moving handler class to on run method
        //---------------------------------------------------------------------------------------------------------------------------
        public static void IncreaseScore()
        {

            
            //----
            Globals.Score++;
            //----
            Globals.scoreTextBlock.Text = $"{Globals.Score}";
            //----
        }
    }
}
