using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;

namespace BlossomSaves
{
    public static class Helper
    {
        public static readonly string SaveFileBaseName = "save_file_";
        public static readonly string AFileEnding = ".txt";
        public static readonly string BFileEnding = "_b.txt";
        public static readonly string CFileEnding = "_c.txt";

        private static readonly string _saveInfoFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "saveStateInfo.json");

        public static SaveState CreateSaveState(string categoryName, string saveStateName, int saveSlotNumber)
        {
            var origA = GetOriginalSavePath(saveSlotNumber,"A");
            var origB = GetOriginalSavePath(saveSlotNumber, "B");
            var origC = GetOriginalSavePath(saveSlotNumber, "C");

            return CreateSaveState(categoryName, saveStateName, origA, origB, origC);
        }

        public static SaveState CreateSaveState(string categoryName, string saveStateName, string origAFilePath, string origBFilePath, string origCFilePath)
        {
            var config = BlossomConfig.GetBlossomConfig();
            var shortenedCategory = new string(categoryName.Where(char.IsLetterOrDigit).ToArray());
            var shortenedState = new string(saveStateName.Where(char.IsLetterOrDigit).ToArray());
            var save = new SaveState()
            {
                SaveStateName = saveStateName,
                CategoryName = categoryName,
                FileAName = $@"{shortenedCategory}-{shortenedState}-A-{Guid.NewGuid()}.txt",
                FileBName = $@"{shortenedCategory}-{shortenedState}-B-{Guid.NewGuid()}.txt",
                FileCName = $@"{shortenedCategory}-{shortenedState}-C-{Guid.NewGuid()}.txt"
            };

            try
            {
                File.Copy(origAFilePath, GetFullManagedSavePath(save.FileAName));
                File.Copy(origBFilePath, GetFullManagedSavePath(save.FileBName));
                File.Copy(origCFilePath, GetFullManagedSavePath(save.FileCName));
            }
            catch (Exception)
            {

            }
            return save;
        }

        public static SaveState RenameSave(SaveState originalSave, string categoryName, string saveName)
        {
            var shortenedCategory = new string(categoryName.Where(char.IsLetterOrDigit).ToArray());
            var shortenedState = new string(saveName.Where(char.IsLetterOrDigit).ToArray());

            var movedSave = new SaveState()
            {
                SaveStateName = saveName,
                CategoryName = categoryName,
                FileAName = $@"{shortenedCategory}-{shortenedState}-A-{Guid.NewGuid()}.txt",
                FileBName = $@"{shortenedCategory}-{shortenedState}-B-{Guid.NewGuid()}.txt",
                FileCName = $@"{shortenedCategory}-{shortenedState}-C-{Guid.NewGuid()}.txt",
                PositionNumber = originalSave.PositionNumber
            };

            try
            {
                File.Move(GetFullManagedSavePath(originalSave.FileAName), GetFullManagedSavePath(movedSave.FileAName));
                File.Move(GetFullManagedSavePath(originalSave.FileBName), GetFullManagedSavePath(movedSave.FileBName));
                File.Move(GetFullManagedSavePath(originalSave.FileCName), GetFullManagedSavePath(movedSave.FileCName));
            }
            catch (Exception)
            {

            }

            return movedSave;
        }

        public static void DeleteSave(SaveState saveState)
        {
            var config = BlossomConfig.GetBlossomConfig();
            try
            {
                File.Delete(GetFullManagedSavePath(saveState.FileAName));
                File.Delete(GetFullManagedSavePath(saveState.FileBName));
                File.Delete(GetFullManagedSavePath(saveState.FileCName));
            }
            catch (Exception)
            {

            }
        }


        public static string GetOriginalSavePath(int saveSlotNumber, string fileLetter)
        {
            string ending;
            if (fileLetter.Equals("A", StringComparison.InvariantCultureIgnoreCase)) ending = AFileEnding;
            else if (fileLetter.Equals("B", StringComparison.InvariantCultureIgnoreCase)) ending = BFileEnding;
            else  ending = CFileEnding;

            var config = BlossomConfig.GetBlossomConfig();

            return Path.Combine(config.OriginalSaveDirectory, $"{SaveFileBaseName}{saveSlotNumber}{ending}");
        }

        public static string GetFullManagedSavePath(string managedSaveFileName)
        {
            var config = BlossomConfig.GetBlossomConfig();
            return Path.Combine(config.ManagedSaveDirectory, managedSaveFileName);
        }

        public static void WriteSaveInfo(BindingList<Category> cats)
        {
            var catsText = JsonConvert.SerializeObject(cats);
            try
            {
                File.WriteAllText(_saveInfoFile, catsText);
            }
            catch (Exception) { }
        }
    }
}
