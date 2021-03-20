using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiburadaApp.Base
{
    public class PageFactory
    {

        private static Lazy<PageFactory> _instance = new Lazy<PageFactory>(() => new PageFactory());

        public static PageFactory Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private PageFactory() { }


        public BasePage CurrentPage { get; set; }
    }
}
