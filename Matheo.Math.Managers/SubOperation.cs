using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Mateo.Math.Managers
{
  public class SubOperation<T> : BinaryOperationBase<T>
    where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
  {
    public override string OperatorSymbol => "-";
    public override Func<Operand<T>, Operand<T>, T> Operation => (l, t) => (dynamic)l.Value - (dynamic)t.Value;

    public SubOperation()
    {

    }

    public SubOperation(Operand<T> leftOperand, Operand<T> rightOperand)
      : base(leftOperand, rightOperand)
    {
    }
  }
}
