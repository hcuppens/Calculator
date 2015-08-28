using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Lexer.Tokens
{
    public class Multiplication: AToken
    {
        public override bool Matches(string token)
        {
            return token.Equals("*");
        }

        public override AToken InstanceOf(string token)
        {
            return new Multiplication();
        }
    }
}
