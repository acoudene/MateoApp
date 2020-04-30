using System;

namespace Mateo.Math.Managers
{
  public class Operand<T>
    where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
  {
    public T Value { get; set; }
    public override string ToString()
    {
      return Value.ToString();
    }
  }
}