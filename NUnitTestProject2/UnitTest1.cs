using NUnit.Framework;
using System;
using ŒŒ¿Ëƒ_À–10;

namespace NUnitTestProject2
{
    public class Tests
    {     
        [Test]
        public void TestRegister()
        {
            Observable obs = new Observable();
            CountObserver cobs = new CountObserver(obs);
            Assert.Throws<Exception>(() => obs.RegisterObserver(cobs));
        }
        [Test]
        public void TestRegisterNull()
        {
            Observable obs = new Observable();
            CountObserver cobs = null;
            Assert.Throws<ArgumentNullException>(() => obs.RegisterObserver(cobs));
        }
        [Test]
        public void TestRemoveNull()
        {
            Observable obs = new Observable();
            CountObserver cobs = null;
            Assert.Throws<ArgumentNullException>(() => obs.RemoveObserver(cobs));
        }
        [Test]
        public void TestChange()
        {
            Observable obs = new Observable();
            obs.Change();
            Assert.AreNotEqual(obs.GetState(), 0);
        }
        [Test]
        public void TestUpdate()
        {
            Observable obs = new Observable();
            CountObserver cobs = new CountObserver(obs);
            obs.NotifyObservers();
            Assert.AreEqual(1, cobs.Count);
        }
    }
}