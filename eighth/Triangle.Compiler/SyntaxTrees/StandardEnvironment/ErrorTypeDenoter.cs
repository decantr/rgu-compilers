using Triangle.Compiler.SyntaxTrees.Visitors;

namespace Triangle.Compiler.SyntaxTrees.Types
{
    public class ErrorTypeDenoter : TypeDenoter
    {
        public ErrorTypeDenoter() : base(SourcePosition.Empty) { }

        public override TResult Visit<TArg, TResult>(ITypeDenoterVisitor<TArg, TResult> visitor, TArg arg)
        {
            return visitor.VisitErrorTypeDenoter(this, arg);
        }
    }
}