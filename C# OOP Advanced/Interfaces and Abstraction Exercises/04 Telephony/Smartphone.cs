using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IBrowser, ICallable
    {
        private IList<string> numbers;
        private IList<string> urls;

        public Smartphone()
        {
            this.numbers = new List<string>();
            this.urls = new List<string>();
        }

        public void MakeCall(IList<string> numbersParam)
        {
            foreach (var number in numbersParam)
            {
                if (number.Any(d => Char.IsLetter(d)))
                {
                    numbers.Add("Invalid number!");
                }
                else
                {
                    numbers.Add($"Calling... {number}");
                }
            }
        }

        public void Browse(IList<string> urlsParam)
        {
            foreach (var url in urlsParam)
            {
                if (url.Any(p => Char.IsDigit(p)))
                {
                    urls.Add("Invalid URL!");
                }
                else
                {
                    urls.Add($"Browsing: {url}!");
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Join(Environment.NewLine, this.numbers));
            sb.Append(string.Join(Environment.NewLine, this.urls));
            return sb.ToString();
        }
    }
}