using System.ComponentModel;

namespace Enemies
{
    /// <summary>
    /// Represents an empty public class 'Zombie'.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Get or sets the health of the Zombie.
        /// </summary>
        public int health { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            // Set the intial value of health to 0 in the constructor.
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with the specified health value.
        /// </summary>
        /// <param name="value">The initial health value. Must be greater than or equal to 0.</param>
        /// <exception cref="ArgumentException">Thrown when the provided health value is less than 0</exception>
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
