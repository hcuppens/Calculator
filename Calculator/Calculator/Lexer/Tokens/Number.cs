using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Lexer.Tokens
{
    class Number: AToken
    {
        private int _val;

        public Number()
        {
            
        }

        public Number(int nr)
        {
            this._val = nr;
        }

        public int Value { get { return _val; } }

        public override bool Matches(string token)
        {
            int nr = 0;
            return Int32.TryParse(token, out nr);
        }

        public override AToken InstanceOf(string token)
        {
            int nr = 0;
            Int32.TryParse(token, out nr);
            return new Number(nr);
        }
    }
}
