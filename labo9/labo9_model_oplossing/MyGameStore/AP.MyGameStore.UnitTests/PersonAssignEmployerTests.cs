using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Services;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Moq;

namespace AP.MyGameStore.UnitTests
{
    [TestClass]
    public class PersonAssignEmployerTests
    {
        [TestMethod]
        public void AddPerson_AssignNonExistingEmployer()
        {
            var p = new Person()
            {
                //We need to assign a valid age, because this is checked first
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1),
                EmployerId = 1
            };

            var storeRepoMock = new Mock<IStoresRepository>();
            storeRepoMock.Setup(srm => srm.GetById(p.EmployerId.Value))
                        .Returns<Store>(null);
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository)
                    .Returns(storeRepoMock.Object);

            var svc = new PeopleService(uowMock.Object);
            try
            {
                svc.Add(p);
                Assert.Fail();
            }
            catch (RelationNotFoundException ex)
            {
                //The test has succeeded !
            }
        }

        [TestMethod]
        public void UpdatePerson_AssignNonExistingEmployer()
        {
            var p = new Person()
            {
                //We need to assign a valid age, because this is checked first
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1),
                EmployerId = 1
            };

            var peopleRepoMock = new Mock<IPeopleRepository>();
            //Setup the mock, so that the person exists ofcourse
            peopleRepoMock.Setup(prm => prm.GetById(p.Id))
                           .Returns(new Person() { Id = p.Id });
            var storeRepoMock = new Mock<IStoresRepository>();
            //Setup the mock so that the store does not exist.
            storeRepoMock.Setup(srm => srm.GetById(p.EmployerId.Value))
                        .Returns<Store>(null);
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository)
                    .Returns(storeRepoMock.Object);
            uowMock.SetupGet(m => m.PeopleRepository)
                    .Returns(peopleRepoMock.Object);

            var svc = new PeopleService(uowMock.Object);
            try
            {
                svc.Update(p);
                Assert.Fail();
            }
            catch (RelationNotFoundException ex)
            {
                //The test has succeeded !
            }
        }

        [TestMethod]
        public void AddPerson_AssignExistingEmployer()
        {
            var p = new Person()
            {
                //We need to assign a valid age, because this is checked first
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1),
                EmployerId = 1
            };

            var storeRepoMock = new Mock<IStoresRepository>();
            storeRepoMock.Setup(srm => srm.GetById(p.EmployerId.Value))
                        .Returns(new Store() { Id = p.EmployerId.Value });
            var peopleRepoMock = new Mock<IPeopleRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository)
                    .Returns(storeRepoMock.Object);
            uowMock.SetupGet(m => m.PeopleRepository)
                    .Returns(peopleRepoMock.Object);
            var svc = new PeopleService(uowMock.Object);
            svc.Add(p);
        }

        [TestMethod]
        public void UpdatePerson_AssignExistingEmployer()
        {
            var p = new Person()
            {
                //We need to assign a valid age, because this is checked first
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1),
                EmployerId = 1
            };

            var peopleRepoMock = new Mock<IPeopleRepository>();
            //Setup the mock, so that the person exists ofcourse
            peopleRepoMock.Setup(prm => prm.GetById(p.Id))
                           .Returns(new Person() { Id = p.Id });
            var storeRepoMock = new Mock<IStoresRepository>();
            //Setup the mock so that the store does not exist.
            storeRepoMock.Setup(srm => srm.GetById(p.EmployerId.Value))
                        .Returns(new Store() { Id = p.EmployerId.Value });
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository)
                    .Returns(storeRepoMock.Object);
            uowMock.SetupGet(m => m.PeopleRepository)
                    .Returns(peopleRepoMock.Object);

            var svc = new PeopleService(uowMock.Object);
            svc.Update(p);
        }
    }
}
