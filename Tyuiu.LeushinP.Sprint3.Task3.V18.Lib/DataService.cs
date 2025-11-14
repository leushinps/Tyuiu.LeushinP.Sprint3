using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var sb = new StringBuilder(value.Length);
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                    sb.Append(item);
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}