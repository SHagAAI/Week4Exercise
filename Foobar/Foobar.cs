using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foobar
{

    struct DivisorPattern
    {
        public int divisorNumber { get; set; }
        public string output { get; set; }

    }
    public class Fooba
    {
        List<DivisorPattern> rules = new();
        string foobarjazz = string.Empty;

        public void AddRule(int divisor, string outputString)
        {
            rules.Add(new DivisorPattern { divisorNumber = divisor, output = outputString });
        }

        public void Evaluate(int evaluateThisNumber)
        {
            foreach (var rule in rules)
            {
                if (evaluateThisNumber % rule.divisorNumber == 0)
                {
                    foobarjazz += rule.output;
                }
            }

            Console.WriteLine(foobarjazz);
            foobarjazz = string.Empty;
        }

        public string EvaluateNoPrint(int evaluateThisNumber)
        {
            foreach (var rule in rules)
            {
                if (evaluateThisNumber % rule.divisorNumber == 0)
                {
                    return rule.output;
                } 
                return evaluateThisNumber.ToString();
               
            }

           return "";
          
        }

        public void GenerateSequence(int start, int end)
        {

            
            while (start <= end)
            {
                foobarjazz = foobarjazz + EvaluateNoPrint(start) + ", ";
                start += 1;
            }

            Console.WriteLine(foobarjazz);
            foobarjazz = string.Empty;
        }
    }
}