using FsCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Mateo.Math.Managers.Tests
{
  [TestClass]
  public class UnitTestOperation
  {   
    public void TestMethodExerciseFor<O>(int mandatoryValue, int nbTests = 100) 
      where O : IBinaryOperation<int>, new()
    {      
      for (int i = 0; i < nbTests; i++)
      {
        var formula = ExerciseOnOperation.GenerateFormulaForMandatoryOperand<O>(mandatoryValue);        
        Console.WriteLine($"Formula (mandatory operand={mandatoryValue}): {formula.LeftOperand} {formula.OperatorSymbol} {formula.RightOperand}");
        Console.WriteLine($"Result={formula.DoOperation()}");
      }
    }

    [TestMethod]
    public void TestMethodAddExerciseFor()
    {
      var iterations = Gen.Sample(0, 1000, Gen.Choose(0, 10));
      foreach (var iteration in iterations)
      {
        Console.WriteLine($"Test exercise for {iteration}: ");
        TestMethodExerciseFor<AddOperation<int>> (iteration);
      }
    }

    [TestMethod]
    public void TestMethodSubExerciseFor()
    {
      var iterations = Gen.Sample(0, 1000, Gen.Choose(0, 10));
      foreach (var iteration in iterations)
      {
        Console.WriteLine($"Test exercise for {iteration}: ");
        TestMethodExerciseFor<SubOperation<int>>(iteration);
      }
    }

    [TestMethod]
    public void TestFormulaAdd()
    {
      Prop.ForAll<int, int>((a, b) => (new AddOperation<int>(new Operand<int>(a), new Operand<int>(b))).DoOperation().Equals(a + b))
        .QuickCheckThrowOnFailure();
    }

    [TestMethod]
    public void TestFormulaSub()
    {
      var configuration = Configuration.QuickThrowOnFailure;
      configuration.MaxNbOfTest = 1000;
      configuration.QuietOnSuccess = false;

      Prop.ForAll<int, int>((a, b) => (new SubOperation<int>(new Operand<int>(a), new Operand<int>(b))).DoOperation().Equals(a - b))                
        .Check(configuration);
    }
  }
}
