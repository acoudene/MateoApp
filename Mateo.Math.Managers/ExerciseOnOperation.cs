using System;
using System.Collections.Generic;
using System.Text;

namespace Mateo.Math.Managers
{
  public static class ExerciseOnOperation
  {    
    public static O GenerateFormulaForMandatoryOperand<O>(int mandatoryOperand, int limitOtherValue = 101, bool? ForceMandatoryPositionLeft = null)
      where O : IBinaryOperation<int>, new()
    {
      var otherOperand = new System.Random().Next(0, limitOtherValue);      
      var IsLeftOperandMandatory = (ForceMandatoryPositionLeft.HasValue) ? (ForceMandatoryPositionLeft.Value) : new Random().Next(2) == 1;     

      return (IsLeftOperandMandatory)
        ? new O() { LeftOperand = new Operand<int>(mandatoryOperand), RightOperand = new Operand<int>(otherOperand) } 
        : new O() { LeftOperand = new Operand<int>(otherOperand), RightOperand = new Operand<int>(mandatoryOperand) };
    }

    public static O GenerateFormula<O>(int limitOperandValue = 101)
      where O : IBinaryOperation<int>, new()
    {
      var leftOperand = new System.Random().Next(0, limitOperandValue);
      var rightOperand = new System.Random().Next(0, limitOperandValue);

      return new O() { LeftOperand = new Operand<int>(leftOperand), RightOperand = new Operand<int>(rightOperand) };
    }
  }
}
