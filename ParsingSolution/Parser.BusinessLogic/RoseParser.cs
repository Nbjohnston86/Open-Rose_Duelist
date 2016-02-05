using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.BusinessLogic.Interfaces;

namespace Parser.BusinessLogic
{
    public class RoseParser : IRoseParser
    {
        public string ConvertToJson(IRoseParsable content)
        {
            throw new NotImplementedException();
        }

        public string ConvertToJson(string content)
        {
            throw new NotImplementedException();
        }
    }
}
