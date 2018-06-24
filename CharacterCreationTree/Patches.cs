using BattleTech.UI;
using CharacterCreationTree;
using Harmony;
using nl.flukeyfiddler.bt.CharacterCreationTree.Utils;

namespace nl.flukeyfiddler.bt.CharacterCreationTree
{
    [HarmonyPatch(typeof(SGCharacterCreationBackgroundSelection), "ShowQuestion")]
    public class SGCharacterCreationBackgroundSelection_ShowQuestion_Patch
    {
        private static void Prefix(SGCharacterCreationBackgroundSelection __instance, int idx, int ___questionIdx)
        {
            SGCharacterCreationBackgroundSelection.BackgroundQuestion backgroundQuestion = __instance.questions[___questionIdx];

            FlavourTexts flavourTexts = CharacterCreationTree.background.FlavourTexts;
            Questions questions = CharacterCreationTree.background.Questions;

            switch (idx)
            {
                case 0: // Flavourtext 1
                    backgroundQuestion.premise = flavourTexts.FlavourText1.title;
                    backgroundQuestion.description = flavourTexts.FlavourText1.text;
                    break;
                case 1: // Question 1
                    backgroundQuestion.premise = questions.Question1;
                    break;
                case 2: // Flavourtext 2
                    backgroundQuestion.premise = flavourTexts.FlavourText2.title;
                    backgroundQuestion.description = flavourTexts.FlavourText2.text;
                    break;
                case 3: // Question 2
                    backgroundQuestion.premise = questions.Question2;
                    break;
                case 4: // Question 3
                    backgroundQuestion.premise = questions.Question3;
                    break;
                case 5: // Flavourtext 3
                    backgroundQuestion.premise = flavourTexts.FlavourText3.title;
                    backgroundQuestion.description = flavourTexts.FlavourText3.text;
                    break;
            }
        }
    }
}
