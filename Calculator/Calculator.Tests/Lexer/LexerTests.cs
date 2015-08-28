using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.Lexer;
using Calculator.Lexer.Tokens;

namespace Calculator.Tests.Lexer
{
    [TestFixture]
    class LexerTests
    {
        public void ValidExpressionContainsNoUnrecognizedTokens()
        {
            TheLexer lexer = new TheLexer();
            var tokens = lexer.GetTokens("3 + 5");

            Assert.AreEqual(0, tokens.Count(p => p.GetType() == typeof (UnrecognizedToken)));
        }

        public void UnrecognizedTokenDetected()
        {
            TheLexer lexer = new TheLexer();
            var tokens = lexer.GetTokens("3 xyz 5");

            Assert.AreEqual(1, tokens.Count(p => p.GetType() == typeof(UnrecognizedToken)));
        }
    }
}
