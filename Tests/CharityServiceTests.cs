using CharityApp.Data.UnitOfWork;
using CharityApp.Services;
using CharityApp.Testing.MockData;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace CharityApp.Testing
{
    public class CharityServiceTests
    {
        [Fact]
        public void Only_Max_Ten_Records_Are_Returned()
        {

            var mock = new Mock<IUnitOfWork>();
            var dbContextMock = new Mock<DbContext>();
            mock.Setup(db => db.OrganizationRepository).Returns(new OrganizationRepositoryMock(dbContextMock.Object));


            var sut = new CharityService(mock.Object);
            var result = sut.Search("Name"); // 14+ valid results.
            
            Assert.Equal(10, result.Count());
        }

        [Theory]
        [InlineData("NpoName SEARCHED ON")]
        [InlineData("Description SEARCHED ON")]
        [InlineData("THEME SEARCHED ON")]
        [InlineData("Objective SEARCHED ON")]
        public void Ensure_NpoName_Description_Theme_And_Objective_Is_Searched_On(string searchText)
        {
            var uowMock = new Mock<IUnitOfWork>();
            var dbContextMock = new Mock<DbContext>();
            uowMock.Setup(uow => uow.OrganizationRepository)
                .Returns(new OrganizationRepositoryMock(dbContextMock.Object));

            var sut = new CharityService(uowMock.Object);
            var result = sut.Search(searchText);

            Assert.Single(result);
        }

        [Theory]
        [InlineData("@!#$%^&)()")]
        [InlineData("♥■←↔o")]
        [InlineData(null)]
        [InlineData("null")]
        public void Ensure_Special_Characters_Requests_Are_Handled(string searchText)
        {
            var uowMock = new Mock<IUnitOfWork>();
            var dbContextMock = new Mock<DbContext>();
            uowMock.Setup(uow => uow.OrganizationRepository)
                .Returns(new OrganizationRepositoryMock(dbContextMock.Object));

            var sut = new CharityService(uowMock.Object);


            var exception = Record.Exception(() => sut.Search(searchText));

            Assert.Null(exception);

        }

        [Theory]
        [InlineData("food")]
        [InlineData("shoes")]
        [InlineData("inactive")]
        public void Ensure_Only_Orgs_Marked_Active_Are_Returned(string searchText)
        {
            var uowMock = new Mock<IUnitOfWork>();
            var dbContextMock = new Mock<DbContext>();
            uowMock.Setup(uow => uow.OrganizationRepository)
                .Returns(new OrganizationRepositoryMock(dbContextMock.Object));

            var sut = new CharityService(uowMock.Object);

            var results = sut.Search(searchText);

            foreach (var org in results)
            {
                Assert.True(org.Active);
            }

        }



    }
}