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
        public  Die()
       {
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
            Random rand = new Random();
            int result = rand.Next(1, 7);
            this.Value = (byte)result;
        }
    }
}
