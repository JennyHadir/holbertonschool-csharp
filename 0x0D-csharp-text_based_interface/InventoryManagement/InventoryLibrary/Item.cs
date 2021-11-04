using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryLibrary
{
    /// <summary>
    /// 
    /// </summary>
    class Item : BaseClass
    {
        /// <summary>
        /// Required name property
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Optional description property
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Optional price property
        /// </summary>
        public float price { get; set; }
        /// <summary>
        /// Optional tags property
        /// </summary>
        public List<string> tags { get; set; }
        /// <summary>
        /// Item Constructor to assigne properties
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="tags"></param>
        public Item(string name = "Item_name", string description = "Item_description", float price = 0.0f, List<string> tags = null)
        {
            this.name = name;
            this.description = description;
            this.tags = tags;
            this.price = (float)Math.Round(price, 2);

        }
    }
}
