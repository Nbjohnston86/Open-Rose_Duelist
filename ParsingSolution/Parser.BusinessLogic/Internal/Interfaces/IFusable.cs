using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.BusinessLogic.Internal.Interfaces
{
    /// <summary>
    /// A pair of card numbers that represent a fusable pair of cards, 
    /// and whether or not it is a verified fusion.wh
    /// </summary>
    interface IFusable
    {
        /// <summary>
        /// Gets the first card number.
        /// </summary>
        /// <value>
        /// The first card number.
        /// </value>
        int FirstCardNumber { get; }
        /// <summary>
        /// Gets the second card number.
        /// </summary>
        /// <value>
        /// The second card number.
        /// </value>
        int SecondCardNumber { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is a verified fusion.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is a verified fusion; otherwise, <c>false</c>.
        /// </value>
        bool IsVerifiedFusion { get; }
    }
}
