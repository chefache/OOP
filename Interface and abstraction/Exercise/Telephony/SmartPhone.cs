using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class SmartPhone : ICallable, IBrowsable
    {
        private string phoneNumber;
        private string url;

        public SmartPhone(string phoneNumber, string url)
        {
            this.PhoneNumber = phoneNumber;
            this.Url = url;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                PhoneValidator(value);
                phoneNumber = value;
            }
        }
        public string Url
        {
            get => url;
            set
            {
                UrlValidator(value);
                url = value;
            }
        }

        public string Call()
        {
            return $"Calling...{PhoneNumber}";
        }

        public string Browse()
        {
            return $"browsing: {Url}";
        }

        public void PhoneValidator(string value)
        {
            if (Regex.IsMatch(value, ".*?[a-zA-Z].*?"))
            {
                throw new Exception("Invalid number!");
            }
        }

        public void UrlValidator(string value)
        {
            if (Regex.IsMatch(value, ".*?[0-9].*?"))
            {
                throw new Exception("Invalid URL!");
            }
        }
    }
}
