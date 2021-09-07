using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CodedUITestProject1
{
    /// <summary>
    /// Сводное описание для CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void compressStringWithChainsOnly()
        {
            this.UIMap.StartApplication();
            this.UIMap.Input_dddddbbbcccaa();
            this.UIMap.CompressText();
            this.UIMap.FirstAssertMethod();
            this.UIMap.StopApplication();
        }

        [TestMethod]
        public void compressStringWithChains()
        {
            this.UIMap.StartApplication();
            this.UIMap.Input_222222Dsss234bbaact();
            this.UIMap.CompressText();
            this.UIMap.SecondAssertMethod();
            this.UIMap.StopApplication();
        }

        [TestMethod]
        public void compressStringWithOneChainInEndOfString()
        {
            this.UIMap.StartApplication();
            this.UIMap.Input_1234567890000000000();
            this.UIMap.CompressText();
            this.UIMap.ThirdAssertMethod();
            this.UIMap.StopApplication();
        }

        [TestMethod]
        public void compressStringWithOneChainInBeginOfString()
        {
            this.UIMap.StartApplication();
            this.UIMap.Insert_aaaaaaaaaaaaaaaaaBCD();
            this.UIMap.CompressText();
            this.UIMap.FourthAssertMethod();
            this.UIMap.StopApplication();
        }

        [TestMethod]
        public void compressStringWithoutAnyChains()
        {
            this.UIMap.StartApplication();
            this.UIMap.Insert_advcsdc245();
            this.UIMap.CompressText();
            this.UIMap.CloseDialog();
            this.UIMap.FifthAssertMethod();
            this.UIMap.StopApplication();
        }

        #region Дополнительные атрибуты тестирования

        // При написании тестов можно использовать следующие дополнительные атрибуты:

        ////TestInitialize используется для выполнения кода перед запуском каждого теста 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Чтобы создать код для этого теста, выберите в контекстном меню команду "Формирование кода для кодированного теста пользовательского интерфейса", а затем выберите один из пунктов меню.
        //}

        ////TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Чтобы создать код для этого теста, выберите в контекстном меню команду "Формирование кода для кодированного теста пользовательского интерфейса", а затем выберите один из пунктов меню.
        //}

        #endregion

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
