using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.Lexer.Tokens;

namespace Calculator.Parsing
{
    /// <summary>
    /// Builds an expression tree taking into account the
    /// order of the operations.
    /// </summary>
    public class OrderedExpressionTreeBuilder
    {
        /// <summary>
        /// Build the expression tree that can be walked in the correct order
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public ExpressionTree Build(IList<AToken> tokens, OperationOrder order)
        {
            var tree = new ExpressionTree();
            var tokensOrderedByImportance = order.GetOperationOrder();

            //Do magic here if I had more time

            return tree;
        }
    }
}
