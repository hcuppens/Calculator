using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Calculator.Lexer.Tokens;

namespace Calculator.Lexer
{
    /// <summary>
    /// Factory that can recognize a token in a calculator expression.
    /// </summary>
    public class TokenFactory
    {
        private readonly IList<AToken> _knownTokens;

        public TokenFactory()
        {
            _knownTokens = new List<AToken>();

            InitDefaultTokens();
        }

        /// <summary>
        /// Default set of tokens that we recognize
        /// </summary>
        private void InitDefaultTokens()
        {
            _knownTokens.Add(new Addition());
            _knownTokens.Add(new Multiplication());
            _knownTokens.Add(new Division());
            //.... more to support by default
            _knownTokens.Add(new Number());

        }

        /// <summary>
        /// Allows you to register a new token in the lexer.
        /// Thus being able to extend the calculator.
        /// </summary>
        /// <param name="recognizedToken"></param>
        public void RegisterToken(AToken recognizedToken)
        {
            _knownTokens.Add(recognizedToken);
        }

        public AToken Interpret(string token)
        {
            foreach (var tokenHandler in _knownTokens)
            {
                if (tokenHandler.Matches(token))
                    return tokenHandler.InstanceOf(token);
            }
            return new UnrecognizedToken();
        }
    }
}
