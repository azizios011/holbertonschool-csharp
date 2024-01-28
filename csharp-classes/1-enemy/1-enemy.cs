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
        /// Initializes a new instance of the <see cerf="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            // Set the intial value of health to 0 in the constructor.
            health = 0;
        }
    }
}
