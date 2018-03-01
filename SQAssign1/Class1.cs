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
        public int age;
        public string gen;

        public Class1 c1 = new Class1();

        public float Check()
        {
            return c1.CalcPremium(age, gen);
        }
    }

    public class Class1
    {

        public float CalcPremium(int age, string gender)
        {
            float premium = 0;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                    premium = (float)5.0;
                else
                {
                    if (age >= 31)
                        premium = (float)2.50;
                    else
                        premium = (float)0.0;
                }
            }
            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                    premium = (float)6.0;
                else
                {
                    if (age >= 36)
                        premium = (float)5.0;
                    else
                        premium = (float)0.0;
                }
            }
            else
                premium = (float)0.0;

            //if (gender == "female")
            //{
            //    if ((age >= 18) && (age <= 30))
            //        premium = (float)5.0;
            //    else if (age >= 31)
            //        premium = (float)2.50;
            //    else
            //        premium = (float)0.0;
            //}
            //else if (gender == "male")
            //{
            //    if ((age >= 18) && (age <= 35))
            //        premium = (float)6.0;
            //    else if (age >= 36)
            //        premium = (float)5.0;
            //    else
            //        premium = (float)0.0;
            //}
            //else
            //    premium = (float)0.0;

            if (age >= 50)
                premium = premium * (float)0.15;

            return premium;
        }
    }
}