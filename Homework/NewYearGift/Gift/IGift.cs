using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift
{
    public interface IGift
    {
        IEnumerable<Sweet> Items { get; }
        IEnumerable<Sweet> FindCandyBySugar(int _min, int _max);
        void Add(Sweet _sweets);
        int GiftWeight();
        void SortByWeight();
        void GiftPrint();
    }
}
