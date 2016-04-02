using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBCoinToss
{
    class Coin
    {
        //class field for side-up
        private string sideUp;

        //random object
        Random rand = new Random();

        //create coin constructor 
        public Coin()
        {
            //set default side-up
            sideUp = "Heads";
        }

        /// <summary>
        /// toss method to get side-up
        /// </summary>
        /// <returns></returns>
        public string Toss()
        {
            //statement to determine heads or tails
            if (rand.Next(2) == 0)
            {
                //set side-up to heads
                sideUp = "heads";
            }
            else
            {
                //set side-up to tails
                sideUp = "tails";
            }
            //return value
            return sideUp;
        }

        /// <summary>
        /// get side up method gets and returns the side-up value
        /// </summary>
        /// <returns></returns>
        public string GetSideUp()
        {
            //return side-up value
            return sideUp;
        }
    }
}
