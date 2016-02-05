using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.BusinessLogic.Internal.Interfaces
{
    interface ICard
    {
        int ID { get; }

        string Name { get; }
        string CardType { get; }
        string Description { get; }
        string Attribute { get; }
        string SubType { get; }
        
        ICollection<IFusable> FusableFrom { get; }
        ICollection<int> AugementableBy { get; }

        int DeckCost { get; }
        int? Attack { get; }
        int? Defense { get; }
    }
}
