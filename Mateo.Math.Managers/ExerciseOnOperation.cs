using System;
using System.Collections.Generic;
using System.Text;

namespace Mateo.Math.Managers
{
  public static class ExerciseOnOperation
  {    
    public static O GenerateFormulaForMandatoryOperand<O>(int mandatoryOperand, int limitMinOtherValue = 1, int limitMaxOtherValue = 101, bool? forceMandatoryPositionRight = null)
      where O : IBinaryOperation<int>, new()
    {
      var otherOperand = new System.Random().Next(limitMinOtherValue, limitMaxOtherValue);      
      var IsRightOperandMandatory = (forceMandatoryPositionRight.HasValue) ? (forceMandatoryPositionRight.Value) : new Random().Next(2) == 1;

      return (IsRightOperandMandatory)
        ? new O() { LeftOperand = new Operand<int>(otherOperand), RightOperand = new Operand<int>(mandatoryOperand) }
        : new O() { LeftOperand = new Operand<int>(mandatoryOperand), RightOperand = new Operand<int>(otherOperand) }; 
    }

    public static O GenerateFormula<O>(int limitMinOtherValue = 1, int limitMaxOtherValue = 101)
      where O : IBinaryOperation<int>, new()
    {
      var leftOperand = new System.Random().Next(limitMinOtherValue, limitMaxOtherValue);
      var rightOperand = new System.Random().Next(limitMinOtherValue, limitMaxOtherValue);

      return new O() { LeftOperand = new Operand<int>(leftOperand), RightOperand = new Operand<int>(rightOperand) };
    }
  }
}
