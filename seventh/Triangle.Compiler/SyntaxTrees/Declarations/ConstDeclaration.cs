using Triangle.Compiler.SyntaxTrees.Expressions;
using Triangle.Compiler.SyntaxTrees.Terminals;
using Triangle.Compiler.SyntaxTrees.Types;


namespace Triangle.Compiler.SyntaxTrees.Declarations
{
    public class ConstDeclaration : Declaration
    {
        public ConstDeclaration(Identifier identifier, Expression expression, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Identifier = identifier;
            Expression = expression;
        }

        public ConstDeclaration(Identifier identifier, Expression expression)
            : this(identifier, expression, SourcePosition.Empty)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }

        public Identifier Identifier { get; }

        public Expression Expression { get; }

        public TypeDenoter Type { get { return Expression.Type; } }

    }
}