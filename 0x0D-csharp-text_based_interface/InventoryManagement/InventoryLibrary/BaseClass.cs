using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    class BaseClass
    {
        /// <summary>
        /// Id property
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// date of creation property
        /// </summary>
        public DateTime date_created { get; set; }
        /// <summary>
        /// date of update property
        /// </summary>
        public DateTime date_updated{ get; set; }
    }
}
