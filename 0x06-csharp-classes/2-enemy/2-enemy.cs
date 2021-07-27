using System;

namespace Enemies
{
    /// <summary>
    /// Empty Zombie Class.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// public field health.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// <param name="value"> The value of health.</param>
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}
