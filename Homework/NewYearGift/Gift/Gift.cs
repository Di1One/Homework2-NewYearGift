using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NewYearGift
{
    public class Gift : IGift
    {
        private readonly ICollection<Sweet> items;
        public Gift()
        {
            items = new List<Sweet>();
        }
        public void Add(Sweet _sweets)
        {
            items.Add(_sweets);
        }
        public int GiftWeight()
        {
            return items.Sum(x => x.Weight);
        }
        public IEnumerable<Sweet> FindCandyBySugar(int _min, int _max)
        {
            return items.Where(x => (x.Sugar >= _min) && (x.Sugar <= _max)).ToList();
        }
        public IEnumerable<Sweet> Items
        {
            get
            {
                return items;
            }
        }
        public void SortByWeight()
        {
            var temp = items.OrderBy(x => x.Weight).ToList();

            items.Clear();

            foreach (var item in temp)
            {
                items.Add(item);
            }
        }
        public void GiftPrint()
        {
            Console.WriteLine("Gift content:");
            foreach (var item in items)
            {
                Console.WriteLine($"Sweet name: {item.Name},\n Manufacturer country: {item.Manufacturer}," +
                    $"\n Sugar: {item.Sugar}g,\n Weight: {item.Weight}g\n\n");
            }
        }
    }
}
