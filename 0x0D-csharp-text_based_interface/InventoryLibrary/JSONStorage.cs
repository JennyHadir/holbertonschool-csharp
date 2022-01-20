using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    class JSONStorage
    {
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, dynamic> objects = new Dictionary<string, dynamic>();

        /// <summary>
        /// All mthods to return a dictionary
        /// </summary>
        /// <returns>Objects Dictionary</returns>
        public Dictionary<string, dynamic> All()
        {
           return objects;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void New(BaseClass obj)
        {
            if (obj == null)
                return;
            objects.Add(obj.GetType().Name + "." + obj.id, obj);
        }

        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(objects);
            File.WriteAllText("storage/inventory_manager.json", jsonString);
        }

        public void Load()
        {
            Dictionary<string, dynamic> JsonLoader = new Dictionary<string, dynamic>();
            if (Directory.Exists("storage") && File.Exists("storage/inventory_manager.json"))
            {
                JsonLoader = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(File.ReadAllText("storage/inventory_manager.json"));
                this.objects = JsonLoader;
            }
        }

    }
}
