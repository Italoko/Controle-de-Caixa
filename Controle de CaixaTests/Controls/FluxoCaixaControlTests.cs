using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Controle_de_Caixa.Controls.Tests
{
    [TestClass()]
    public class FluxoCaixaControlTests
    {
        public TestContext testContextInstance;
        public TestContext TestContextInstance
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataTestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential)]
   

        public void GravarTest()
        {
            FluxoCaixaControl FluxoCxControl = FluxoCaixaControl.getInstance();
            bool sucesso = false;
            string valor = Convert.ToInt32(TestContext.DataRow["Nota"]);



            char tipo = 'e';
            string motivo = "aa";
            
            (sucesso,_) = FluxoCxControl.Gravar(tipo,valor,motivo);
            Assert.IsTrue(sucesso);
        }
    }
}