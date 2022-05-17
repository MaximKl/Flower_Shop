using Microsoft.EntityFrameworkCore;
using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using System.Collections.Generic;
using System.Linq;
namespace Shopp.Data.Repository
{
    public class CategoryRepository : IFlowerCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;


    }
}
