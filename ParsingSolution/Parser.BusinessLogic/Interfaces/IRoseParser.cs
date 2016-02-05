using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.BusinessLogic.Interfaces
{
    public interface IRoseParser
    {
        string ConvertToJson(string content);
        string ConvertToJson(IRoseParsable content);
    }
}
