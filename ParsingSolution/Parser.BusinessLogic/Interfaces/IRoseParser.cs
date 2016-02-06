using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.BusinessLogic.Interfaces
{
    /// <summary>
    /// Interface to receive the RoseParsable class abstractly.
    /// It's an abstraction for educational/informative/experimentation purposes.
    /// I may later make RoseParser a non-public class, 
    /// and create a class that returns this abstract version of RoseParser.
    /// </summary>
    public interface IRoseParser
    {
        string ConvertToJson(string filePath);
        string ConvertToJson(IRoseParsable content);
    }
}
