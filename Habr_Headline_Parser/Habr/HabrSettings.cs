using Habr_Headline_Parser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habr_Headline_Parser.Habr
{
    class HabrSettings : IParserSettings
    {
        string BaseURL { get; set; } = "https://habr.com/ru/all";
        string Prefix { get; set; } = "page{CurrentId}";
        int StartPoint { get; set; }
        int EndPoint { get; set; }
    }
}
