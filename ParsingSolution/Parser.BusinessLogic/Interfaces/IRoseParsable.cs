using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.BusinessLogic.Enums;

namespace Parser.BusinessLogic.Interfaces
{
    public interface IRoseParsable
    {
        ParsableEnum FileType { get; set; }
        string CardList { get; set; }
    }
}
