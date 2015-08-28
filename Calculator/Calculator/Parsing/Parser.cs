using System.Collections.Generic;
using Calculator.Lexer.Tokens;

namespace Calculator.Parsing
{
    /// <summary>
    /// The parser will interpret a stream of tokens and will construct 
    /// a tree of expressions that will be evaluated in a certain order.
    /// </summary>
    public class Parser
    {
        private readonly OperationOrder _order;


        /// <summary>
        /// Constructs a new parser that takes a certain operation order into account
        /// </summary>
        /// <param name="order"></param>
        public Parser(OperationOrder order)
        {
            _order = order;
        }

        /// <summary>
        /// The parser will inspect the tokens and construct an expression tree that can
        /// be evaluated by walking it.
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public ExpressionTree Parse(IList<AToken> tokens)
        {
            OrderedExpressionTreeBuilder treeBuilder = new OrderedExpressionTreeBuilder();
            return treeBuilder.Build(tokens, _order);
        }

    }

}
