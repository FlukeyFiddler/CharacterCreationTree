using System.Collections.Generic;
using System.Text;

namespace CharacterCreationTree
{
    public class FlavourTexts
    {
        public FlavourText FlavourText1 { get; set; }
        public FlavourText FlavourText2 { get; set; }
        public FlavourText FlavourText3 { get; set; }

        public FlavourTexts()
        {
            FlavourText1 = new FlavourText();
            FlavourText2 = new FlavourText();
            FlavourText3 = new FlavourText();
        }
    }

    public class FlavourText
    {
        public string title { get; set; }
        public List<string> textLines { get; set; }
        public string text { get { return getText(); } }

        public FlavourText() {
            title = "Something went wrong, Check CharacterCreationTree Logs";
            textLines = new List<string>();
        }

        private string getText()
        {
            StringBuilder builder = new StringBuilder();

            foreach (string line in textLines)
            {
                builder.AppendLine(line);
            }

            return builder.ToString();
        }
    }

    public class Questions
    {
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }

        public Questions()
        {
            Question1 = "Something really went wrong";
            Question1 = "Something really went wrong, believe me";
            Question1 = "Thick-headed bugger ey?";
        }
    }

    public class Background
    {
        public FlavourTexts FlavourTexts { get; set; }
        public Questions Questions { get; set; }

        public Background()
        {
            FlavourTexts = new FlavourTexts();
        }
    }

}
