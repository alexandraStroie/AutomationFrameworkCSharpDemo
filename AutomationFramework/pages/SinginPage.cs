using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.helpMethods;
using OpenQA.Selenium;

namespace AutomationFramework.pages
{
    class SinginPage
    {
        public IWebDriver Driver { get; private set; }
        public ElementMethods EMethods { get; private set; }
        public PageMethods PMethods { get; private set; }


        public SinginPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            EMethods = new ElementMethods(Driver);
            PMethods = new PageMethods(Driver);

        }

    }
}
