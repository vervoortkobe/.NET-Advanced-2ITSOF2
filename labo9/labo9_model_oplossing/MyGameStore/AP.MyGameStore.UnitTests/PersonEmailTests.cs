using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Services;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using Moq;

namespace AP.MyGameStore.UnitTests
{
    [TestClass]
    public class PersonEmailTests
    {
        [DataTestMethod]
        [DataRow("a@b")]
        [DataRow("ab.com")]
        [DataRow("abcde")]
        [DataRow("abc.ap.com")]
        [DataRow("abc@ap@com")]
        [DataRow("abc@ap@zzz.com")]
        public void AddPerson_EmailInvalid(string invalidEmail)
        {
            var p = new Person() { 
                Email = invalidEmail,
                //make sure the age meets the correct constraints 
                //because this is tested before email address
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1)};
            var svc = new PeopleService(null);
            try
            {
                svc.Add(p);
                Assert.Fail();
            }
            catch (ValidationException ex)
            {
                if (ex.ErrorCode != ValidationException.ValidationError.EmailAddressInvalid)
                    Assert.Fail();
            }
        }

        [DataTestMethod]
        [DataRow("a@b")]
        [DataRow("ab.com")]
        [DataRow("abcde")]
        [DataRow("abc.ap.com")]
        [DataRow("abc@ap@com")]
        [DataRow("abc@ap@zzz.com")]
        public void UpdatePerson_EmailInvalid(string invalidEmail)
        {
            var p = new Person()
            {
                Email = invalidEmail,
                //make sure the age meets the correct constraints 
                //because this is tested before email address
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1)
            };
            //prepare some mocks for test to succeed
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
                if (ex.ErrorCode != ValidationException.ValidationError.EmailAddressInvalid)
                    Assert.Fail();
            }
        }

        [DataTestMethod]
        [DataRow("a@b.com")]
        [DataRow("ab.ab@bb.com")]
        [DataRow("")]
        [DataRow(null)]
        public void AddPerson_EmailValid(string validEmail)
        {
            var p = new Person()
            {
                Email = validEmail,
                //make sure the age meets the correct constraints 
                //because this is tested before email address
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1)
            };

            var peopleRepoMock = new Mock<IPeopleRepository>();
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.SetupGet(m => m.PeopleRepository)
                    .Returns(peopleRepoMock.Object);

            var svc = new PeopleService(uowMock.Object);
            svc.Add(p);
        }

        [DataTestMethod]
        [DataRow("a@b.com")]
        [DataRow("ab.ab@bb.com")]
        [DataRow("")]
        [DataRow(null)]
        public void UpdatePerson_EmailValid(string validEmail)
        {
            var p = new Person()
            {
                Email = validEmail,
                //make sure the age meets the correct constraints 
                //because this is tested before email address
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1)
            };

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
