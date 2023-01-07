using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChangeBaseDefinition;
using System;

namespace UnitTestSample
{
    [TestClass]
    public class ChangeBaseTest
    {
        private readonly ChangeBaseNumber _changeBase;
        public ChangeBaseTest()
        {
            _changeBase = new ChangeBaseNumber();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChangeBase_IsBaseNotValid_returnException()
        {
            var result = _changeBase.ChangedBase(256, 17);            
        }
        [TestMethod]
        [DataRow(256,16,"")]
        [DataRow(287, 4, "")]
        [DataRow(123, 2, "")]
        public void ChangeBase_IsBaseValid_returnNumberInNewBase(int Number, int Base, string SpectedValue)
        {
            var result=  _changeBase.ChangedBase(Number, Base);
            Assert.AreNotEqual(SpectedValue, result);
        }

    }
}
