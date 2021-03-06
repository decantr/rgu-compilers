using Triangle.Compiler.SyntaxTrees.Commands;

namespace Triangle.Compiler.SyntaxTrees.Visitors
{
    public interface ICommandVisitor<TArg, TResult>
    {
        TResult VisitAssignCommand(AssignCommand ast, TArg arg);

        TResult VisitCallCommand(CallCommand ast, TArg arg);

        TResult VisitSkipCommand(SkipCommand ast, TArg arg);

        TResult VisitIfCommand(IfCommand ast, TArg arg);

        TResult VisitLetCommand(LetCommand ast, TArg arg);

        TResult VisitSequentialCommand(SequentialCommand ast, TArg arg);

        TResult VisitWhileCommand(WhileCommand ast, TArg arg);
    }
}