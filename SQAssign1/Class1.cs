using fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAssign1
{
    public class Class1Test : ColumnFixture
    {
        /*  Fitnesse code:  
         
!define COMMAND_PATTERN {%m -r fitnesse.fitserver.FitServer,dotnet2\fit.dll %p}
!define TEST_RUNNER {dotnet2\Runner.exe}
# this is the path to the fixture code
!path C:\Users\harlu\Documents\Visual Studio 2017\Projects\SQAssign1\SQAssign1\bin\Debug\SQAssign1.dll

!| SQAssign1.Class1Test |
| age | gen | premium? |
| 15 | female | 0.0 |
| 25 | female | 5.0 |
| 40 | female | 2.5 |
| 60 | female | 0.375 |
| 17 | female | 0 |
| 18 | female | 5 |
| 19 | female | 5 |
| 30 | female | 5 |
| 31 | female | 2.5 |
| 32 | female | 2.5 |
| 49 | female | 2.5 |
| 50 | female | 0.375 |
| 51 | female | 0.375 |
| -1 | female | 0 |
| 105 | female | 0.375 |
| abc | female | error |
|   | female | error |
| 15 | male | 0.0 |
| 30 | male | 6.0 |
| 40 | male | 5.0 |
| 60 | male | 0.75 |
| 17 | male | 0 |
| 18 | male | 6 |
| 19 | male | 6 |
| 35 | male | 6 |
| 36 | male | 5 |
| 37 | male | 5 |
| 49 | male | 5 |
| 50 | male | 0.75 |
| 51 | male | 0.75 |
| -1 | male | 0 |
| 105 | male | 0.75 |
| abc | male | error |
|   | male | error |
| 18 | other | 0 |

        */

        public int age;
        public string gen;

        public Class1 c1 = new Class1();

        public float premium()
        {
            c1.setProperties(age, gen);
            return c1.CalcPremium();
        }
    }

    public class Class1
    {
        public int age; 
        public string gender;

        public void setProperties(int a, string g)
        {
            age = a;
            gender = g;
        }
        
        public float CalcPremium()
        {
            float premium;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                    premium = (float)5.0;
                else if (age >= 31)
                    premium = (float)2.50;
                else
                    premium = (float)0.0;
            }
            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                    premium = (float)6.0;
                else if (age >= 36)
                    premium = (float)5.0;
                else
                    premium = (float)0.0;
            }
            else
                premium = (float)0.0;

            if (age >= 50)
                premium = premium * (float)0.15;

            return premium;
        }
    }
}