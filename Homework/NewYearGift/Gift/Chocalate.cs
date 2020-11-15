using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearGift
{
    public enum ColorOfChocalate { BlackChocolate, WhiteChocolate };
    public class Chocalate : Sweet
    {
        public ColorOfChocalate Color;
        public Chocalate(string _name, string _manufact, int _sugar, int _weight, ColorOfChocalate _color)
        : base(_name, _manufact, _sugar, _weight)
        {
            Color = _color;
        }
    }
}
