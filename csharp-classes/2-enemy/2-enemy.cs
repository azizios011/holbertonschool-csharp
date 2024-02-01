using System;
using System.ComponentModel;

namespace Enemies
{
    /// <summary>
    /// Represents an empty public class 'Zombie'.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Gets or sets the health of the Zombie.
        /// </summary>
        public int health { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            // Set the initial value of health to 0 in the constructor.
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with the specified health value.
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            // Set the health value in the constructor.
            health = value;
        }
    }
}
