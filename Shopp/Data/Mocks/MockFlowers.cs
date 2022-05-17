using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopp.Data.Mocks
{
    public class MockFlowers : IAllFlowers
    {
        private readonly IFlowerCategory _categoryFlowers = new MockCategory();

        public IEnumerable<Flower> flowers
        {
            get
            {
                return new List<Flower> {
                                         new Flower {
                                         name = "Кактус",
                                         shortDesc = "Трошки колиться",
                                         longDesc=" Гарна прикраса для вашої кухні ",
                                         img="/img/kaktys.jpg",
                                         price=400,
                                         isFavourite=true,
                                         available=true,
                                         Category = _categoryFlowers.AllCategories.First()
                                         },
                                         new Flower {
                                         name = "Роза",
                                         shortDesc = "Червона",
                                         longDesc = "Чим більше роз у букеті, тим краще!",
                                         img = "/img/rose.jpg",
                                         price = 100,
                                        isFavourite = false,
                                        available = true,
                                        Category = _categoryFlowers.AllCategories.Last()
                                         }
                                         };
            }
        }
        public IEnumerable<Flower> getFavFlower { get; set; }
        public Flower getObjectFlow(int carId)
        {
            throw new NotImplementedException();
        }

    }
}
