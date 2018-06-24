using CharacterCreationTree;
using CharacterCreationTree.Utils;
using Harmony;
using nl.flukeyfiddler.bt.CharacterCreationTree.Utils;
using nl.flukeyfiddler.bt.Utils.Logger;
using System;
using System.IO;
using System.Reflection;

namespace nl.flukeyfiddler.bt.CharacterCreationTree
{
    public class CharacterCreationTree
    {
        public static Background background;

        public static void Init(string modDirectory, string settingsJSON)
        {
            var harmony = HarmonyInstance.Create("nl.flukeyfiddler.bt.CharacterCreationTree");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            Logger.SetLogFilePath(new LogFilePath(Path.Combine(modDirectory, "Log.txt")));
            Logger.GameStarted();

            try
            {
                background = JsonParser.GetBackgroundFromJSON(modDirectory);
            } catch (Exception) {
                background = new Background();
            }
        }
    }
}
