using Newtonsoft.Json;
using System;

namespace BlossomSaves
{
    [Serializable]
    public class SaveState
    {
        [JsonProperty("sn")]
        public string SaveStateName { get; set; }

        [JsonProperty("cn")]
        public string CategoryName;

        [JsonProperty("a")]
        public string FileAName;

        [JsonProperty("b")]
        public string FileBName;

        [JsonProperty("c")]
        public string FileCName;

        [JsonProperty("pn")]
        public int PositionNumber;

        [JsonIgnore]
        public string CatAndSaveNames { get { return $"{CategoryName} - {SaveStateName}"; } }

        public SaveState Clone()
        {
            var save = new SaveState();
            save.SaveStateName = SaveStateName;
            save.CategoryName = CategoryName;
            save.FileAName = FileAName;
            save.FileBName = FileBName;
            save.FileCName = FileCName;
            save.PositionNumber = PositionNumber;
            return save;
        }
    }
}
