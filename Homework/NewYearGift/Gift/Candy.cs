using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift
{
    public enum TypeOfCandy { ChocalateCandy, Lollipop };
    public class Candy : Sweet
    {
        public TypeOfCandy Type;
        public Candy(string _name, string _manufact, int _sugar, int _weight, TypeOfCandy _type)
        : base(_name, _manufact, _sugar, _weight)
        {
            Type = _type;
        }
    }
}
