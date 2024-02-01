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
        private int health { get; set; }

        /// <summary>
        /// Private field string 'name' and have a default value of (No name);
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Public property 'Name' that retrieve a name using 'get' method and seting a name using 'set' method.
        /// </summary>
        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

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

        /// <summary>
        /// Public method 'GetHealth' that returns the value of health of the Zombie object.
        /// </summary>
        public int GetHealth()
        {
            int result = health;
            return result;
        }
    }
}
