namespace Triangle.Compiler.SyntacticAnalyzer
{
    /// <summary>
    /// A token in the source language
    /// </summary>
    public class Token
    {
        /// <summary>
        /// The kind of a source token
        /// </summary>
        public TokenKind Kind { get; }

        /// <summary>
        /// The spelling of a source token.
        /// </summary>
        public string Spelling { get; }

        /// <summary>
        /// Creates a token in the source language
        /// </summary>
        /// <param name="kind">The type of the token</param>
        /// <param name="spelling">The spelling of the token</param>
        public Token(TokenKind kind, string spelling)
        {
            Spelling = spelling;
            Kind = kind;
        }

        /// <inheritDoc />
        public override string ToString()
        {
            return string.Format($"Kind={Kind}, spelling=\"{Spelling}\"");
        }
    }
}