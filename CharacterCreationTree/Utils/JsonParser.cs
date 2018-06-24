using Newtonsoft.Json;
using nl.flukeyfiddler.bt.CharacterCreationTree.Utils;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace CharacterCreationTree.Utils
{
    class JsonParser
    {

        public static Background GetBackgroundFromJSON(string modDirPath)
        {
            //string backgroundsPath = Path.Combine(modDirPath, "backgrounds");

            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(modDirPath, "base_texts.json")))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<Background>(json);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                throw new FailedToParseBackgroundException(ex);
            }
        }
    }

    [Serializable]
    internal class FailedToParseBackgroundException : Exception
    {
        private Exception ex;

        public FailedToParseBackgroundException()
        {
        }

        public FailedToParseBackgroundException(Exception ex)
        {
            this.ex = ex;
        }

        public FailedToParseBackgroundException(string message) : base(message)
        {
        }

        public FailedToParseBackgroundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FailedToParseBackgroundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
