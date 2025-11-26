using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
        {
            public string ReplaceNumOnChar(string value, char item)
            {
                var res = new StringBuilder();

                foreach (char replaceChr in value)
                {
                    if (char.IsDigit(replaceChr))
                    {
                        res.Append(item);
                    }
                    else
                    {
                        res.Append(replaceChr);
                    }
                }
                return res.ToString();
            }
        }
    }