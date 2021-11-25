using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        [DataSource("System.Data.OleDB",
                    @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Test1.xlsx; 
                      Extended Properties='Excel 12.0;HDR=yes';",
                    "Sheet1$",
                    DataAccessMethod.Sequential)]
        public void TestMethodGravar()
        {
            int a = TestContext.DataRow["a"];
        }
    }
}
