using Microsoft.VisualStudio.TestTools.UnitTesting;
using gursimran_FireGame_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gursimran_FireGame_Project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 instance = new Form1();
            instance.playSound();
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void trigTest() {
            Form1 instance = new Form1();
            instance.trigger();
            Assert.IsTrue(true);
        }
    }
}