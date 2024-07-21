using CharityApp.Data.UnitOfWork;
using Moq;

namespace Testing
{
    public class CharityServiceTests
    {
        // Search tests
        /*
         *  SUT=CharityService
         *  (not including controller r&r network and indicating how results form. status codes. potential errors. etc etc. maybe revisit after spending some time on front end.)
         *
         * Arrange. Setup DB to look how I want. (mock/stub)
         * Act: (go for search)
         * Assert:
         *  correct number of records in result.
         *      1. just find the x number of expected records.
         *      2. ensure npo name, description, theme and obj was searched on,
         *      3. top 10 (x) records is returned always only*. *for now
         *
         */

        public CharityServiceTests()
        {
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(db => db.OrganizationRepository).Returns(It.)


                
        }

        [Fact]
        public void Test1()
        {

        }
    }
}