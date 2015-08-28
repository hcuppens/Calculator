using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.Lexer.Tokens;

namespace Calculator.Parsing
{
    /// <summary>
    /// Represents the order of the operations that needs to be parsed.
    /// 
    /// This should be extensible like the TokenFactory, to be able to insert new order for new supported
    /// operations / tokens.
    /// </summary>
    public class OperationOrder
    {
        public IList<AToken> GetOperationOrder()
        {
            var order = new List<AToken>();
            order.Add(new Multiplication());
            order.Add(new Division());
            order.Add(new Addition());
            //...add the rest of the tokens here
            return order;
        } 

    }
}
