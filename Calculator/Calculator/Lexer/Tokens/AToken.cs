namespace Calculator.Lexer.Tokens
{
    public abstract class AToken
    {
        public abstract bool Matches(string token);
        public abstract AToken InstanceOf(string token);
    }
}
