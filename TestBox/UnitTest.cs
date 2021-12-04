using FluxoCaixaApplication.Controls;
using FluxoCaixaApplication.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBox
{
    [TestClass]
    public class UnitTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void GravarTestMethod()
        {
            FluxoCaixaControl FluxoCxControl = FluxoCaixaControl.getInstance();

            Caixa caixa = new Caixa()
            {
                SaldoInicial = Convert.ToDecimal(TestContext.DataRow[0]),
                SaldoFinal = Convert.ToDecimal(TestContext.DataRow[1]),
                Status = Convert.ToBoolean(TestContext.DataRow[2])
            };

            char tipo = Convert.ToChar(TestContext.DataRow[3]);
            decimal valor = Convert.ToDecimal(TestContext.DataRow[4]);
            string motivo = TestContext.DataRow[5].ToString();

            bool sucess = false;
            string msg = "";
            (sucess,msg) = FluxoCxControl.Gravar(caixa, tipo, valor, motivo);

            Assert.IsTrue(sucess == Convert.ToBoolean(TestContext.DataRow[6].ToString()));
        }
    }
}
