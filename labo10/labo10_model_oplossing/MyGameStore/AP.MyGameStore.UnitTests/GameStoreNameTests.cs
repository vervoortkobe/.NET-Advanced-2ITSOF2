using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Services;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Moq;

namespace AP.MyGameStore.UnitTests
{
    [TestClass]
    public class GameStoreNameTests
    {
        [TestMethod]
        public void AddStore_NameTooLong()
        {
            var storeName = "0123456789012345678901234567890123456789"; //40 chars long

            StoresService svc = new StoresService(null);

            var s = new Store() { Name = storeName };
            try
            {
                svc.Add(s);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.NameTooLong)
                    Assert.Fail();
            }
        }


        [TestMethod]
        public void UpdateStore_NameTooLong()
        {
            var OldStoreName = "Store 1";
            var newStoreName = "0123456789012345678901234567890123456789"; //40 chars long
            
            var storesRepoMock = new Mock<IStoresRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository)
                    .Returns(storesRepoMock.Object);
            storesRepoMock.Setup(srp => srp.GetById(It.IsAny<int>()))
                            .Returns(new Store() { Name = OldStoreName });

            StoresService svc = new StoresService(uowMock.Object);

            var s = new Store() { Name = newStoreName };
            try
            {
                svc.Update(s);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.NameTooLong)
                    Assert.Fail();  
            }
        }

        [TestMethod]
        public void CreateStore_NameAlreadyExists()
        {
            var storeName = "Store 1";
            var storesRepoMock = new Mock<IStoresRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository).Returns(storesRepoMock.Object);
            storesRepoMock.Setup(srp => srp.GetByName(storeName))          //setup the repo so that 
                          .Returns(new Store() { Name = storeName });      //it returns a store
            
            StoresService svc = new StoresService(uowMock.Object);

            var s = new Store() { Name = storeName };
            try
            {
                svc.Add(s);
                Assert.Fail();
            }
            catch(ValidationException ex)
            {

            }
        }

        [TestMethod]
        public void CreateStore_NameDoesNotExist()
        {
            var storeName = "Store 1";
            var storesRepoMock = new Mock<IStoresRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository).Returns(storesRepoMock.Object);
            storesRepoMock.Setup(srp => srp.GetByName(storeName))  //setup the repo
                          .Returns<Store>(null);                          //so that it returns null

            StoresService svc = new StoresService(uowMock.Object);

            var s = new Store() { Name = storeName };
            svc.Add(s);  //should not throw exception, otherwise test will fail
        }

        [TestMethod]
        public void UpdateStore_NameAlreadyExists()
        {
            var OldStoreName = "Store 1";
            var newStoreName = "Store 2";
            var storesRepoMock = new Mock<IStoresRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository).Returns(storesRepoMock.Object);
            storesRepoMock.Setup(srp => srp.GetById(It.IsAny<int>()))
                            .Returns(new Store() { Name = OldStoreName });
            storesRepoMock.Setup(srp => srp.GetByName(newStoreName))          //setup the repo so that 
                          .Returns(new Store() { Name = newStoreName });      //it returns a store

            StoresService svc = new StoresService(uowMock.Object);

            var s = new Store() { Name = newStoreName };
            try
            {
                svc.Update(s);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {

            }
        }

        [TestMethod]
        public void UpdateStore_NameDoesNotExist()
        {
            var OldStoreName = "Store 1";
            var newStoreName = "Store 2";
            var storesRepoMock = new Mock<IStoresRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.StoresRepository).Returns(storesRepoMock.Object);
            storesRepoMock.Setup(srp => srp.GetById(It.IsAny<int>()))
                            .Returns(new Store() { Name = OldStoreName });
            storesRepoMock.Setup(srp => srp.GetByName(newStoreName))          //setup the repo so that 
                          .Returns<Store>(null);      //it returns nothing

            StoresService svc = new StoresService(uowMock.Object);

            var s = new Store() { Name = newStoreName };
            svc.Update(s);  //Should not throw exception, otherwise test will fail.
        }
    }
}