using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.BusinessLogic.Interfaces;
using Parser.BusinessLogic.Enums;
using System.Text.RegularExpressions;


namespace Parser.BusinessLogic
{
    /// <summary>
    /// Parses a rose card document based upon it's formatting style.
    /// </summary>
    /// <seealso cref="Parser.BusinessLogic.Interfaces.IRoseParser" />
    public class RoseParser : IRoseParser
    {
        public string ConvertToJson(IRoseParsable content)
        {
            /* Convert card tables to JSON Objects from the following FAQs:
             *
             * Simple Card List:
             * http://www.gamefaqs.com/ps2/589455-yu-gi-oh-the-duelists-of-the-roses/faqs/42996
             *
             * Card List with Details:
             * http://www.gamefaqs.com/ps2/589455-yu-gi-oh-the-duelists-of-the-roses/faqs/22013
             *
             * Fusion Rule List:
             * http://www.gamefaqs.com/ps2/589455-yu-gi-oh-the-duelists-of-the-roses/faqs/22087
             */

            string returnValue = string.Empty;

            switch (content.FileType)
            {
                case ParsableEnum.Card:
                    //Dummy test data
                    returnValue = ParseCardsFromPath(content.FilePath).ToString();
                    break;
                case ParsableEnum.Detail:
                    //Dummy test data
                    returnValue = content.FileType.ToString();
                    break;
                case ParsableEnum.Fusion:
                    //Dummy test data
                    returnValue = content.FileType.ToString();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return returnValue;

            throw new NotImplementedException();
        }

        public string ConvertToJson(string filePath)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<string> ParseCardsFromPath(string filePath)
        {
            //As a single string because text lines are not trustable.
            string text = System.IO.File.ReadAllText(filePath);
            const string regexPattern = @"\s+[\w]+\s+";
            ICollection<string> output = new List<string>();

            foreach (Match m in Regex.Matches(text, regexPattern))
            {
                if (!m.Success) continue;

                var trimmed = Regex.Replace(m.Value, @"\s\s+", " ").Trim();
                output.Add(m.Value);
                Console.WriteLine("'{0}' found at index {1}.",
                                  trimmed, m.Index);
                //TODO: Parse the line for their individual components.
            }

            Console.WriteLine("'{0}' total cards parsed.", output.Count());

            return output;
        }
    }

    
}
