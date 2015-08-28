using System.Collections.Generic;
using System.Security.Principal;
using Calculator.Lexer.Tokens;

namespace Calculator.Lexer
{
    /// <summary>
    /// The lexer will scan a statement and will return known tokens.
    /// </summary>
    public class TheLexer
    {
        /// <summary>
        /// Scans the statement and returns a list of tokens
        /// </summary>
        /// <param name="statement"></param>
        /// <returns></returns>
        public IEnumerable<AToken> GetTokens(string statement)
        {
            var tokens = statement.Split(' ');
            var factory = new TokenFactory();
            foreach (var token in tokens)
            {
                yield return factory.Interpret(token);
            }
        } 
    }
}
