using System;

namespace Mateo.Math.Managers
{
  public interface IBinaryOperation<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
  {
    string OperatorSymbol { get; }
    Operand<T> LeftOperand { get; set; }
    Operand<T> RightOperand { get; set; }
    Func<Operand<T>, Operand<T>, T> Operation { get; }
    T DoOperation();
  }
}