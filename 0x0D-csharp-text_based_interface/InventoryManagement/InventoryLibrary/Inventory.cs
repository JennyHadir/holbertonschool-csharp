using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    class Inventory : BaseClass
    {
        /// <summary>
        /// Required user id property
        /// </summary>
        public string user_id { get; set; }

        /// <summary>
        /// Required item id property
        /// </summary>
        public string item_id { get; set; }

        /// <summary>
        /// Required quantity property
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// Inventory Constructor to assign properity
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="item_id"></param>
        /// <param name="quantity"></param>
        public Inventory(string user_id = "User_id", string item_id = "Item_id", int quantity = 1)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            if (quantity < 0)
                quantity = 1;
        }
    }
}
