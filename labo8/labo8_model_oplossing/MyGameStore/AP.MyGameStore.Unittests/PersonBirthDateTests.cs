using AP.MyGameStore.BLL.Exceptions;
using AP.MyGameStore.BLL.Services;
using AP.MyGameStore.DAL.Model;

namespace AP.MyGameStore.Unittests
{
    [TestClass]
    public class PersonBirthDateTests
    {
        [TestMethod]
        public void AddPerson_MaximumAgeReached()
        {
            var p = new Person()
            {
                BirthDate = new DateTime(DateTime.Now.Year - 100, 1, 1)
            };
            var svc = new PeopleService(null);

            try
            {
                svc.Add(p);
                //Test NOT successful!
                Assert.Fail();
            }
            catch(ValidationException e)
            {
                //Test successful!
                if (e.Code != ValidationException.ErrorCode.AgeGreaterThan67) Assert.Fail();
            }
        }

        [TestMethod]
        public void AddPerson_MaximumAgeNotReached()
        {
            var p = new Person()
            {
                BirthDate = new DateTime(DateTime.Now.Year, 1, 1)
            };
            var svc = new PeopleService(null);

            try
            {
                svc.Add(p);
                //Test NOT successful!
                Assert.Fail();
            }
            catch (ValidationException e)
            {
                //Test successful!
                if (e.Code != ValidationException.ErrorCode.AgeSmallerThan16) Assert.Fail();
            }
        }
    }
}
