using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Bishop : Piece
    {
        public Bishop() : base ("LPR") //konstruktoren arver fra Piece klassen(base) sin konstruktor, protected Piece(string symbol) Symbol = symbol; Setter Symbol Stringen til "LPR"
        {
        }



        public override bool Move(string fromPosition, string toPosition) //we use the override keyword to override the base class method.
                                                                          //Fordi Move er abstract og abstract metoder må være i abstract class.
                                                                          //An override method provides a new implementation of the method inherited from a base class.
                                                                          //The method that is overridden by an override declaration is known as the overridden base method.
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }
}
