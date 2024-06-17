using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Services;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Moq;

namespace AP.MyGameStore.UnitTests
{
    [TestClass]
    public class PersonBirthDateTests
    {
        [TestMethod]
        public void AddPerson_MaximumAgeReached()
        {
            var p = new Person() { BirthDate = new DateTime(DateTime.Now.Year - 68, 1, 1) };
            var svc = new PeopleService(null);
            try
            {
                svc.Add(p);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.AgeGreaterThan67)
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void AddPerson_MinimumAgeNotReached()
        {
            var p = new Person() { BirthDate = new DateTime(DateTime.Now.Year - 15, 1, 1) };
            var svc = new PeopleService(null);
            try
            {
                svc.Add(p);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.AgeSmallerThan16)
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void AddPerson_ValidAge()
        {
            var p = new Person() { BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1) };
            var peopleRepoMock = new Mock<IPeopleRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.PeopleRepository)
                    .Returns(peopleRepoMock.Object);

            var svc = new PeopleService(uowMock.Object);
            svc.Add(p);
        }


        [TestMethod]
        public void UpdatePerson_MaximumAgeReached()
        {
            var p = new Person() { BirthDate = new DateTime(DateTime.Now.Year - 68, 1, 1) };
            var peopleRepoMock = new Mock<IPeopleRepository>();
            peopleRepoMock.Setup(prm => prm.GetById(It.IsAny<int>())).Returns(new Person());

            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.PeopleRepository)
                    .Returns(peopleRepoMock.Object);

            var svc = new PeopleService(uowMock.Object);
            try
            {
                svc.Update(p);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.AgeGreaterThan67)
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void UpdatePerson_MinimumAgeNotReached()
        {
            var p = new Person() { BirthDate = new DateTime(DateTime.Now.Year - 15, 1, 1) };
            var peopleRepoMock = new Mock<IPeopleRepository>();
            peopleRepoMock.Setup(prm => prm.GetById(It.IsAny<int>())).Returns(new Person());

            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.PeopleRepository)
                    .Returns(peopleRepoMock.Object);

            var svc = new PeopleService(uowMock.Object); 
            try
            {
                svc.Update(p);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.AgeSmallerThan16)
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void UpdatePerson_ValidAge()
        {
            var p = new Person() { BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1) };
            var peopleRepoMock = new Mock<IPeopleRepository>();
            peopleRepoMock.Setup(prm => prm.GetById(It.IsAny<int>())).Returns(new Person());

            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.PeopleRepository)
                    .Returns(peopleRepoMock.Object);

            var svc = new PeopleService(uowMock.Object);
            svc.Update(p);
        }

    }
}
