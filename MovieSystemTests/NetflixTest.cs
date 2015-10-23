using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieSystemTests
{
    [TestClass]
    public class NetflixTest
    {
        [TestMethod]
        public void Test_That_Facade_Can_Be_Created()
        {
            MovieFacade facade = new MovieFacade();
            Assert.IsNotNull(facade);
        }

        [TestMethod]
        public void Test_That_Netflix_Can_Be_Played()
        {
            MovieFacade facade = new MovieFacade();
            facade.Play("Netflix");
            Assert.IsTrue(facade.HasBeenPlayed);
            //Assert.Fail();
        }
    }
}
