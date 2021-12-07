
using AutomationFramework.helpMethods;
using OpenQA.Selenium;

namespace AutomationFramework.pages
{
    public class RegisterPage
    {
        public IWebDriver Driver { get; private set; }
        public ElementMethods EMethods { get; private set; }
        public PageMethods PMethods { get; private set; }
        public RegisterPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            EMethods = new ElementMethods(Driver);
            PMethods = new PageMethods(Driver);
        }


        private By FirstNameElement => By.CssSelector("input[placeholder='First Name']");
        private By LastNameElement => By.CssSelector("input[placeholder='Last Name']");
        private By SkillsDropdownElement => By.Id("Skills");
        private By YearDropdownElement => By.Id("yearbox");
        private By SubmitElement => By.Id("submitbtn");
        private By LanguageElement => By.Id("msdd");
        private By LanguagesValues => By.CssSelector(".ui-autocomplete.ui-front>li>a");
        private By SelectedElementLanguage => By.CssSelector("#msdd>div");
        private By SelectCountryElement => By.CssSelector(".select2-selection--single");
        private By SwitchToHeaderElement => By.XPath("//a[contains(text(),'SwitchTo')]");
        private By AlertsHeaderElement => By.XPath("//a[contains(text(),'Alerts')]");
        private By WindowHeaderElement => By.XPath("//a[contains(text(),'Windows')]");
        private By FramesHeaderElement => By.XPath("//a[contains(text(),'Frames')]");
        private By InputCountryElement => By.CssSelector(".select2-search__field");
        private By AddressElement => By.CssSelector("textarea.form-control");
        private By EmailElement => By.CssSelector("input[type='email']");
        private By PhoneElement => By.CssSelector("input[type='tel']");
        private By GenderElementFemale => By.CssSelector("input[value='FeMale']");
        private By HobbyElement => By.Id("checkbox2");
        private By DayDropdownElement => By.Id("daybox");
        private By FirstPasswordElement => By.Id("firstpassword");
        private By SecondPasswordElement => By.Id("secondpassword");
        private By SubmitBtnElement => By.Id("submitbtn");

       


        public RegisterPage FillFirstName(string firstName)
        {
            EMethods.FillElement(FirstNameElement, firstName);
            return this;
        }

        public RegisterPage FillLastName(string lastName)
        {
            EMethods.FillElement(LastNameElement, lastName);
            return this;
        }


        public RegisterPage FillAddress(string address)
        {
            EMethods.FillElement(AddressElement, address);
            return this;
        }


        public RegisterPage FillEmail(string email)
        {
            EMethods.FillElement(EmailElement, email);
            return this;
        }


        public RegisterPage FillPhone(string phone)
        {
            EMethods.FillElement(PhoneElement, phone);
            return this;
        }


        public RegisterPage SelectSkills(string skill)
        {
            EMethods.selectElementByValue(SkillsDropdownElement, skill);
            return this;
        }


        public RegisterPage SelectYear(string year)
        {
            EMethods.selectElementByValue(YearDropdownElement, year);
            return this;
        }


        public RegisterPage SelectDay(string day)
        {
            EMethods.selectElementByValue(DayDropdownElement, day);
            return this;
        }


        public RegisterPage HooverSubmit()
        {
            EMethods.HooverElement(SubmitElement);
            return this;
        }


        public RegisterPage SelectLanguage(string lang)
        {
            EMethods.ClickElement(LanguageElement);
            foreach (var element in Driver.FindElements(LanguagesValues))
            {
                if (element.Text.Equals(lang))
                {
                    element.Click();
                    break;
                }
            }

            EMethods.validateText(SelectedElementLanguage, lang);
            return this;
        }


        public RegisterPage ClickFirstName()
        {
            EMethods.ClickElement(FirstNameElement);
            return this;
        }


        public AlertPage NavigateToAlertPage()
        {
            EMethods.HooverElement(SwitchToHeaderElement);
            EMethods.ClickElement(AlertsHeaderElement);
            PMethods.NavigateToURL("http://demo.automationtesting.in/Alerts.html");
            return new AlertPage(Driver);
        }

        public WindowsPage NavigateToWindowPage()
        {
            EMethods.HooverElement(SwitchToHeaderElement);
            EMethods.ClickElement(WindowHeaderElement);
            PMethods.NavigateToURL("http://demo.automationtesting.in/Windows.html");
            return new WindowsPage(Driver);
        }

        public FramePage NavigateToFramePage()
        {
            EMethods.HooverElement(SwitchToHeaderElement);
            EMethods.ClickElement(FramesHeaderElement);
            PMethods.NavigateToURL("http://demo.automationtesting.in/Frames.html");
            return new FramePage(Driver);
        }

        public RegisterPage ClickCountry()
        {
            EMethods.ClickElement(SelectCountryElement);
            return this;
        }


        public RegisterPage FillCountryNameAndSubmit(string Country)
        {
            EMethods.FillElement(InputCountryElement, Country);
            EMethods.FillElement(InputCountryElement, Keys.Enter);
            return this;
        }



        public RegisterPage ClickGenderElementFemale()
        {
            EMethods.ClickElement(GenderElementFemale);
            return this;
        }


        public RegisterPage ClickHobbyElement()
        {
            EMethods.ClickElement(HobbyElement);
            return this;
        }


        public RegisterPage FillFirstPassword(string firstPassword)
        {
            EMethods.FillElement(FirstPasswordElement,firstPassword);
            return this;
        }


        public RegisterPage FillConfirmationPassword(string secondPassword)
        {
            EMethods.FillElement(SecondPasswordElement, secondPassword);
            return this;
        }

        public RegisterPage ClickOnSubmitButton()
        {
            EMethods.ScrollElement(SubmitBtnElement);

            EMethods.ClickElement(SubmitBtnElement);
            return this;
        }
    }
}
