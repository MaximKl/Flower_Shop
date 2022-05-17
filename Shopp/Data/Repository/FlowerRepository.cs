using Microsoft.EntityFrameworkCore;
using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shopp.Data.Repository
{
    public class FlowerRepository : IAllFlowers
    {
        //змінна для роботи з класом налаштувань БД AppDBContext.cs
        private readonly AppDBContent appDBContent;
        public FlowerRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Flower> flowers => appDBContent.Flower.Include(c =>
       c.Category);
        public IEnumerable<Flower> getFavFlower => appDBContent.Flower.Where(p => p.isFavourite).Include(c => c.Category);

        public Flower getObjectFlow(int flowID) =>
       appDBContent.Flower.FirstOrDefault(p => p.id == flowID);
    }

}
