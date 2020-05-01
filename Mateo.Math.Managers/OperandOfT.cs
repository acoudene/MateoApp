using System;

namespace Mateo.Math.Managers
{
  public class Operand<T>
    where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
  {
    public Operand(T value)
    {
      Value = value;
    }
    public T Value { get; private set; }
    public override string ToString()
    {
      return Value.ToString();
    }
  }
}