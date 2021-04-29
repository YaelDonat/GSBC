using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSB;

namespace TestUnitaireGSB
{
    [TestClass]
    public class UnitTestGetDateDuJour
    {

        GestionDate x = new GestionDate();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("202103", x.getDateDuJour(), "echec erreur");
        }

    }

    [TestClass]
    public class UnitTestGetJour
    {
        GestionDate y = new GestionDate();
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("23", y.getJour(), "echec erreur");
        }

    }

    [TestClass]
    public class UnitTestGetDateMoisPrecedent
    {
        GestionDate z = new GestionDate();
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("202102", z.getDateMoisPrecedent(), "echec erreur");
        }

    }


    [TestClass]
    public class UnitTestGetDateDuJourAvecErreur
    {

        GestionDate a = new GestionDate();

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("202104", a.getDateDuJour(), "echec erreur");
        }

    }

    [TestClass]
    public class UnitTestGetJourAvecErreur
    {
        GestionDate b = new GestionDate();
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("22", b.getJour(), "echec erreur");
        }

    }

    [TestClass]
    public class UnitTestGetDateMoisPrecedentAvecErreur
    {
        GestionDate c = new GestionDate();
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("202101", c.getDateMoisPrecedent(), "echec erreur");
        }

    }


}
