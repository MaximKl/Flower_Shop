using Shopp.Data.Models;
using System.Collections.Generic;

namespace Shopp.Data.Interfaces
{
    public interface IFlowerCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
