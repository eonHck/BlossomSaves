using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BlossomSaves
{
    [Serializable]
    public class Category
    {
        [JsonProperty("cn")]
        public string CategoryName { get; set; }

        [JsonProperty("s")]
        public List<SaveState> SaveStates;

        [JsonProperty("pn")]
        public int PositionNumber;

        public Category Clone()
        {
            var cat = new Category();
            cat.CategoryName = CategoryName;
            cat.SaveStates = new List<SaveState>();
            foreach (var save in SaveStates)
            {
                cat.SaveStates.Add(save.Clone());
            }
            cat.PositionNumber = PositionNumber;
            return cat;
        }
    }
}
