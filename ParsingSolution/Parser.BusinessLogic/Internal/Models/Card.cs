using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.BusinessLogic.Internal.Interfaces;

namespace Parser.BusinessLogic.Internal.Models
{
    class Card : ICard
    {
        public int? Attack { get; set; }


        public string Attribute
        { get; set; }

        public string CardType
        { get; set; }

        public int DeckCost
        { get; set; }

        public int? Defense
        { get; set; }

        public string Description
        { get; set; }

        public ICollection<IFusable> FusionMaterials
        { get; set; }

        public int? Level
        { get; set; }

        public ICollection<int> ModifiableByCardNumbers
        { get; set; }

        public string Name
        { get; set; }

        public int Number
        { get; set; }

        public HashSet<string> SubTypes
        { get; set; }
    }
}
