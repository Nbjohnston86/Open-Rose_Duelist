using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.BusinessLogic.Internal.Interfaces
{
    /// <summary>
    /// The interface to user when parsing into a JSON object. Generalized as much as possible, 
    /// the point isn't to make a usable class, but a readable/parsable class. Anyone should be
    /// able to design their own classes for these based upon this format.
    /// </summary>
    interface ICard
    {
        /// <summary>
        /// Gets the unique identifiable number of the card.
        /// </summary>
        /// <value>
        /// The unique identifiable number of the card.
        /// </value>
        int Number { get; }

        /// <summary>
        /// Gets the name of the card.
        /// </summary>
        /// <value>
        /// The name of the card.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets the main type of the card [E.g. Monster/Spell/Trap].
        /// </summary>
        /// <value>
        /// The main type of the card.
        /// </value>
        string CardType { get; }

        /// <summary>
        /// Gets the description/written effect of the card.
        /// </summary>
        /// <value>
        /// The description/written effect of the card.
        /// </value>
        string Description { get; }

        /// <summary>
        /// Gets the attribute of the card.
        /// </summary>
        /// <value>
        /// The attribute of the card.
        /// </value>
        string Attribute { get; }

        /// <summary>
        /// Gets the sub types of the card. [E.g. Effect/Equip/Ritual/Warrior/Continuous/etc.]
        /// </summary>
        /// <value>
        /// The sub types of the card.
        /// </value>
        HashSet<string> SubTypes { get; }

        /// <summary>
        /// Gets the fusion materials.
        /// </summary>
        /// <value>
        /// The fusion materials.
        /// </value>
        ICollection<IFusable> FusionMaterials { get; }

        /// <summary>
        /// Gets the numbers of the cards that can directly modify this card.
        /// </summary>
        /// <value>
        /// The numbers of the cards that can directly modify this card.
        /// </value>
        ICollection<int> ModifiableByCardNumbers { get; }

        /// <summary>
        /// Gets the deck cost.
        /// </summary>
        /// <value>
        /// The deck cost.
        /// </value>
        int DeckCost { get; }
        /// <summary>
        /// Gets the attack.
        /// </summary>
        /// <value>
        /// The attack.
        /// </value>
        int? Attack { get; }
        /// <summary>
        /// Gets the defense.
        /// </summary>
        /// <value>
        /// The defense.
        /// </value>
        int? Defense { get; }
        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        int? Level { get; }
    }
}
