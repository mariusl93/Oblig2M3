using System;

namespace SimpleChess
{
    abstract class Piece //Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
    {
        public string Symbol { get; }

        protected Piece(string symbol) // A protected member is accessible within its class and by derived class instances.
        {
            Symbol = symbol;
        }

        public abstract bool Move(string fromPosition, string toPosition); //Abstract method: can only be used in an abstract class, and it does not have a body.
                                                                           //The body is provided by the derived class (inherited from).


    }
}





