using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    class User : BaseClass
    {
        /// <summary>
        /// Required name property
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// User Constructor to make name property required
        /// </summary>
        /// <param name="name"></param>
        public User(string name = "User_name")
        {
            this.name = name;
        }

    }
}
