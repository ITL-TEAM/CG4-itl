﻿namespace CG4.Impl.Dapper.Poco.Expressions
{
    public class ExprBoolEqPredicate : ExprBinary
    {
        public override void Accept(IExprVisitor visitor) => visitor.VisitEqPredicate(this);
    }
}
