using Shopp.Data.Models;
using System.Collections.Generic;

namespace Shopp.Data.Interfaces
{
    public interface IAllFlowers
    {
        //функція повертає всі товари
        IEnumerable<Flower> flowers { get; }
        //функція повертає всі товари у яких isFavorite = true
        IEnumerable<Flower> getFavFlower { get; }
        //повертає товар за його id
        Flower getObjectFlow(int flowID);


    }
}
