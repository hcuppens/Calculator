using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.Lexer;
using Calculator.Lexer.Tokens;

namespace Calculator.Tests.Lexer.Tokens
{
    [TestFixture]
    class TokenFactoryTests
    {
        public void MultiplicationIsRecognized()
        {
            TokenFactory factory = new TokenFactory();
            var token = factory.Interpret("*");
            Assert.AreEqual(token.GetType(), typeof (Multiplication));
        }

        public void DivisionIsRecognized()
        {
            TokenFactory factory = new TokenFactory();
            var token = factory.Interpret("/");
            Assert.AreEqual(token.GetType(), typeof(Multiplication));
        }

        ///
        /// More tests for all the tokens we can recognize.
    }
}
