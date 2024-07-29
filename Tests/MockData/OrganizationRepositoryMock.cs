using System.Linq.Expressions;
using CharityApp.Core;
using CharityApp.Data.Interfaces;
using CharityApp.Data.Repos;
using Microsoft.EntityFrameworkCore;

namespace CharityApp.Testing.MockData;


public class OrganizationRepositoryMock(DbContext dbContext) : Repository<Organization>(dbContext)
{
    List<Organization> allOrgs =
    [
        new Organization {NpoName = "Food for you", Objective = "feeding lots", Theme = "Material assistance ", Active = true, Description = ""},
        new Organization {NpoName = "Food for animal", Objective = "feeding people", Theme = "Animal welfare", Active = true, Description = ""},
        new Organization {NpoName = "Old shoes (not active)", Objective = "giving shoes", Theme = "Material assistance ", Active = false, Description = ""},
        new Organization {NpoName = "Food for animals", Objective = "feeding people", Theme = "Animal welfare", Active = false, Description = ""},
        new Organization {NpoName = "Mock Npo Name 1", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 2", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 3", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 4", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 5", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 6", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 7", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 8", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 9", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 10", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 11", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 12", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 13", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Mock Npo Name 14", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "Real Org", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "NpoName SEARCHED ON", Objective = "", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "", Objective = "", Theme = "", Active = true, Description = "Description SEARCHED ON"},
        new Organization {NpoName = "", Objective = "", Theme = "THEME SEARCHED ON", Active = true, Description = ""},
        new Organization {NpoName = "", Objective = "Objective SEARCHED ON", Theme = "", Active = true, Description = ""},
        new Organization {NpoName = "2nd inactive org", Objective = "", Theme = "", Active = false, Description = ""},
    ];


    public override IEnumerable<Organization> GetAll()
    {
        return allOrgs;
    }

    public override IEnumerable<Organization> Find(Expression<Func<Organization, bool>> predicate)
    {

        return allOrgs.FindAll(predicate.Compile().Invoke);
    }

}