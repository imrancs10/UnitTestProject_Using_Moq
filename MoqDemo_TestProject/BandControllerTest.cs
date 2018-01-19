using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentAssertions;
using MoqDemo_POC;
using System.Collections.Generic;

namespace MoqDemo_TestProject
{
    [TestClass]
    public class BandControllerTest
    {
        [TestMethod]
        public void MethodToTest()
        {
            var bandList = new List<Band>();
            bandList.Add(new Band()
            {
                Name = "Band New 2",
                Origin = "India",
                Genre = "Alternative",
                BestSong = "May I know"
            });
            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetBands()).Returns(bandList);
            var bandController = new BandController(mockRepository.Object);
            bandController.MethodToTest();
            bandController.Should().NotBeNull();
        }
    }
}
