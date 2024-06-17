using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Services;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Moq;

namespace AP.MyGameStore.UnitTests
{
    [TestClass]
    public class GameStoreDeleteTests
    {
        [TestMethod]
        public void DeleteStoreNoEmployeesPresent()
        {
            int storeId = 123;
            var storesRepoMock = new Mock<IStoresRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository)
                    .Returns(storesRepoMock.Object);
            storesRepoMock.Setup(srp => srp.GetById(storeId))
                            .Returns(new Store() );
            storesRepoMock.Setup(srp => srp.GetEmployees(storeId))
                            .Returns(new Person[0]);

            StoresService svc = new StoresService(uowMock.Object);

            var s = new Store() { Id = 1};
            svc.Delete(storeId);
        }

        [TestMethod]
        public void DeleteStoreOneEmployeePresent()
        {
            int storeId = 123;
            var storesRepoMock = new Mock<IStoresRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository)
                    .Returns(storesRepoMock.Object);
            storesRepoMock.Setup(srp => srp.GetById(storeId))
                            .Returns(new Store());
            storesRepoMock.Setup(srp => srp.GetEmployees(storeId))
                            .Returns(new Person[1]);

            StoresService svc = new StoresService(uowMock.Object);

            var s = new Store() { Id = 1 };
            try
            {
                svc.Delete(storeId);
                Assert.Fail();
            }
            catch(ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.EmployeesInStore)
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void DeleteStoreMoreEmployeesPresent()
        {
            int storeId = 123;
            var storesRepoMock = new Mock<IStoresRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository)
                    .Returns(storesRepoMock.Object);
            storesRepoMock.Setup(srp => srp.GetById(storeId))
                            .Returns(new Store());
            storesRepoMock.Setup(srp => srp.GetEmployees(storeId))
                            .Returns(new Person[5]);

            StoresService svc = new StoresService(uowMock.Object);

            var s = new Store() { Id = 1 };
            try
            {
                svc.Delete(storeId);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.EmployeesInStore)
                    Assert.Fail();
            }
        }


    }
}