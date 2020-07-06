﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habr_Headline_Parser.Core
{
    class ParserWorker<T> where T: class
    {
         IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;

        #region properties

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        #endregion

        public ParserWorker (IParser<T> parser)
        {
            this.parser = parser;

        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;

        }

        public void Start()
        {

        }

        public void Abort()
        {

        }
    }
}
