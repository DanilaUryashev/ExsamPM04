using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExsamPM04.MainWindow;
namespace UnitTest
{


[TestClass]

    public class Testing
    {
        
        [TestMethod]
        
        public void TestMetod1(bool result)
        {

            
            string lenghTest = "1234567";
            if (lenghTest.Length < 10)
            {
                result=false;
            }
            int ext= 10;
            

            
        }
        [TestMethod]
        public void TestMetod2()
        {

        }
        [TestMethod]
        public void TestMetod3()
        {

        }
        [TestMethod]
        public void TestMetod4()
        {

        }

    }
}
