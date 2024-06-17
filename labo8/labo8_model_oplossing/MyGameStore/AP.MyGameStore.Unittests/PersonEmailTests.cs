using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Services;
using AP.MyGameStore.DAL.Interfaces;
using AP.MyGameStore.DAL.Model;
using AP.MyGameStore.DAL.UOW;
using Moq;

namespace AP.MyGameStore.Unittests
{
    [TestClass]
    public class PersonEmailTests
    {
        [DataTestMethod]
        [DataRow("aaaaaa")]
        [DataRow("aaaaaa.com")]
        [DataRow("aaaaaa@apbe")]
        [DataRow("marien@ap.be")]
        public void AddPerson_EmailInvalid(string email)
        {
            var p = new Person()
            {
                Email = email,
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1)
            };
            var svc = new PeopleService(null);

            try
            {
                var newPerson = svc.Add(p);
                //Test NOT successful!
                Assert.Fail();
            } catch(ValidationException e)
            {
                //Test successful!
                if (e.Code != ValidationException.ErrorCode.EmailInvalid) Assert.Fail();
            }
        }

        [DataTestMethod]
        [DataRow("aa@bb.com")]
        [DataRow("marien@ap.be")]
        [DataRow("sven.marien@apbe")]
        public void AddPerson_EmailValid(string email)
        {
            var p = new Person()
            {
                Email = email,
                BirthDate = new DateTime(DateTime.Now.Year - 20, 1, 1)
            };
            var PeopleRepoMock = new Mock<IPeopleRepository>();
            var uowMock = new Mock<UnitOfWork>();
            uowMock.SetupGet(m => m.PeopleRepository).Returns(PeopleRepoMock.Object);
            var svc = new PeopleService(uowMock.Object);

            var newPerson = svc.Add(p);
            //Test successful!
        }
    }
}
