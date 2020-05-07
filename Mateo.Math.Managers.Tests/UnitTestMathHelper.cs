using FsCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Mateo.Math.Managers.Tests
{
  [TestClass]
  public class UnitTestMathHelper
  {
    [TestMethod]
    public void TestIntToFrSimple()
    {
      int sept = 7;
      Assert.AreEqual("sept", MathHelper.IntToFr(sept), true);
      
      int douze = 12;
      Assert.AreEqual("douze", MathHelper.IntToFr(douze), true);
      
      int soixantedixhuit = 78;
      Assert.AreEqual("soixante-dix-huit", MathHelper.IntToFr(soixantedixhuit), true);

      int quatrevingts = 80;
      Assert.AreEqual("quatre-vingts", MathHelper.IntToFr(quatrevingts), true);

      int quatrevingtdixneuf = 99;
      Assert.AreEqual("quatre-vingt-dix-neuf", MathHelper.IntToFr(quatrevingtdixneuf), true);

      int troiscentquarantcinq = 345;
      Assert.AreEqual("trois cent quarante-cinq", MathHelper.IntToFr(troiscentquarantcinq), true);

    }
  }
}
