using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceroller
{
    /// <summary>
    /// Represents a standard individual 
    /// 6-sided die
    /// </summary>
    class Die
    {
        private static Random rand;

        /// <summary>
        /// Creates the Die with an initial
        /// random value 1-6
        /// </summary>

        public  Die()
       {
            rand = new Random();
            Roll();
        }
        /// <summary>
        /// Get/Set the face value of the die
        /// </summary>

        public byte Value { get; set; }

        ///<summary>
        /// Rolls the dice,
        /// and sets the value of the die
        /// </summary>
        
        public void Roll()
        {
            int result = rand.Next(1, 7);
            Value = (byte)result;
        }
    }
}
