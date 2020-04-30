using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Mateo.Math.Managers
{
  public abstract class BinaryOperationBase<T> : IBinaryOperation<T> 
    where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable    
  {
    public abstract string OperatorSymbol { get; }
    public virtual Operand<T> LeftOperand { get; set; }
    public virtual Operand<T> RightOperand { get; set; }
    public abstract Func<Operand<T>, Operand<T>, T> Operation { get; }

    public BinaryOperationBase()
    {
    }

    public BinaryOperationBase(Operand<T> leftOperand, Operand<T> rightOperand)
    {
      LeftOperand = leftOperand;
      RightOperand = rightOperand;
    }

    public T DoOperation()
    {
      return Operation(LeftOperand, RightOperand);
    }
  }
}
