using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;
using MyGameStore.Controllers;

namespace AP.MyGameStore.UnitTests
{
    [TestClass]
    public class PeopleControllerTests
    {
        [TestMethod]
        public void TestGetByIdSuccessful()
        {
            var id = 1;
            var psMock = new Mock<IPeopleService>();
            psMock.Setup(psm => psm.GetById(id)).Returns(new DAL.Model.Person() { Id = id });
            var pc = new PeopleController(psMock.Object);
            var result = pc.GetById(id);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            Assert.IsInstanceOfType(((OkObjectResult)result).Value, typeof(Person));
        }

        [TestMethod]
        public void TestGetByIdNotSuccessful()
        {
            var id = 1;
            var psMock = new Mock<IPeopleService>();
            psMock.Setup(psm => psm.GetById(id)).Returns<Person>(null);
            var pc = new PeopleController(psMock.Object);
            var result = pc.GetById(id);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void TestAddSuccessFul()
        {
            var psMock = new Mock<IPeopleService>();
            var pc = new PeopleController(psMock.Object);
            var result = pc.Add(new () { Id = 1});
            Assert.IsInstanceOfType(result, typeof(CreatedResult));
            Assert.IsInstanceOfType(((CreatedResult)result).Value, typeof(Person));
        }

        [TestMethod]
        public void TestAddNotSuccessFul()
        {
            var psMock = new Mock<IPeopleService>();
            psMock.Setup(psm => psm.Add(It.IsAny<Person>()))
                                 .Throws<RelationNotFoundException>();
            var pc = new PeopleController(psMock.Object);
            var result = pc.Add(new() { Id = 1 });
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
            Assert.IsInstanceOfType(((BadRequestObjectResult)result).Value, typeof(string));
        }

    }
}
