using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.BusinessLogic.Internal.Interfaces
{
    interface IFusable
    {
        int CardIdentityOne { get; }
        int CardIdentityTwo { get; }
        bool VerifiedFusion { get; }
    }
}
