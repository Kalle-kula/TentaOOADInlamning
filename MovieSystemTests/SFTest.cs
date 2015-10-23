using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieSystemTests
{
    [TestClass]
    public class SFTest
    {
        [TestMethod]
        public void Test_That_Facade_Can_Be_Created()
        {
            MovieFacade facade = new MovieFacade();
            Assert.IsNotNull(facade);
        }

        [TestMethod]
        public void Test_That_SF_Can_Be_Played()
        {
            MovieFacade facade = new MovieFacade();
            facade.Play("SF", "hemma med vinden");
            Assert.IsTrue(facade.HasBeenPlayed);            
        }
    }
}
