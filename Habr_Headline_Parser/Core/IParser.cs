﻿using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habr_Headline_Parser.Core
{
    interface IParser<T> where T :class
    {
        T Parse(IHtmlDocument document);
    }
}
