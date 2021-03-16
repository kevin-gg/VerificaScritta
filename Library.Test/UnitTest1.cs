using Microsoft.VisualStudio.TestTools.UnitTesting;
using Funzioni;
namespace Library.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnMese()
        {
            int n = 1;
            double risultato_aspettato = 115.99;
            double verifica = Gestione.TariffaPalestra(n);
            Assert.AreEqual(risultato_aspettato, verifica);
        }
        
        [TestMethod]
        public void TreMesi()
        {
            int n = 3;
            double risultato_aspettato = 99.99;
            double verifica = Gestione.TariffaPalestra(n);
            Assert.AreEqual(risultato_aspettato, verifica);
        }

        [TestMethod]
        public void DodiciMesi()
        {
            int n = 12;
            double risultato_aspettato = 79.99;
            double verifica = Gestione.TariffaPalestra(n);
            Assert.AreEqual(risultato_aspettato, verifica);
        }



    }
}
