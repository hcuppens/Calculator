using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.Parsing;

namespace Calculator
{
    /// <summary>
    /// Represents a line in the calculator.
    /// </summary>
    public class Expression
    {
        private readonly string _expression;

        /// <summary>
        /// Constructs a new expression
        /// </summary>
        /// <param name="expression"></param>
        public Expression(string expression)
        {
            _expression = expression;
        }

        /// <summary>
        /// Evaluates the expression
        /// </summary>
        public decimal Evaluate()
        {
            Lexer.TheLexer lexer = new Lexer.TheLexer();
            var tokens = lexer.GetTokens(_expression).ToList();
            Parser parser = new Parser(new OperationOrder());
            ExpressionTree expressionTree = parser.Parse(tokens);
            return expressionTree.Walk();
        }
    }
}
