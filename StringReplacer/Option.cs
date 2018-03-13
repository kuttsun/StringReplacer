using System;
using System.Collections.Generic;
using System.Text;

namespace StringReplacer
{
    public class Option
    {
        public string Directory { get; set; }
        public List<Str> Str { get; set; }
    }

    public class Str
    {
        public string Before { get; set; }
        public string After { get; set; }
    }
}
