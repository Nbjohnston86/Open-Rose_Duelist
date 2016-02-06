using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.BusinessLogic.Enums;

namespace Parser.BusinessLogic.Interfaces
{
    /// <summary>
    /// Contains the full content of the file type attached to it.
    /// </summary>
    public interface IRoseParsable
    {
        ParsableEnum FileType { get; set; }
        string FilePath { get; set; }
    }
}
