using CharityApp.Core;
using CharityApp.Data.Interfaces;
using CharityApp.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CharityApp.Core.Domain;

namespace CharityApp.Data.Repos
{
    public class CategoryRepository(DbContext db) : Repository<Category>(db), ICategoryRepository
    {
    }
}
