using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Lexer.Tokens
{
    public class UnrecognizedToken:AToken
    {
        public override bool Matches(string token)
        {
            return false;
        }

        public override AToken InstanceOf(string token)
        {
            return new UnrecognizedToken();
        }
    }
}
