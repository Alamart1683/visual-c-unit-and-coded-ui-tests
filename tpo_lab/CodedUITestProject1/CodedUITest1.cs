using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


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
        public void CodedUITestMethodStarValue2()
        {
            this.UIMap.OpenApplication();
            this.UIMap.input_s();
            this.UIMap.input_t();
            this.UIMap.ChooseSharp();
            this.UIMap.Compute();
            this.UIMap.AssertMethod1();
            this.UIMap.CloseApp();
        }

        [TestMethod]
        public void CodedUITestMethodAmpersantValue2()
        {
            this.UIMap.OpenApplication();
            this.UIMap.input_s();
            this.UIMap.input_t();
            this.UIMap.ChooseAmpersant();
            this.UIMap.Compute();
            this.UIMap.AssertMethod1();
            this.UIMap.CloseApp();  
        }

        [TestMethod]
        public void CodedUITestMethodError()
        {
            this.UIMap.OpenApplication();
            this.UIMap.input_s2();
            this.UIMap.input_t2();
            this.UIMap.ChooseSharp();
            this.UIMap.Compute();
            this.UIMap.AssertMethod2();
            this.UIMap.PressOk();
            this.UIMap.CloseApp();
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
