<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceService
{
    class InsuranceService
    {
        static void Main(string[] args)
        {

         //   float premium = CalcPremium(1, "male");



           // Console.WriteLine("Costs of Premium:" + premium);

            Console.ReadKey();
        }

        public  float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                    premium = 5.0f;
                else
                    if (age >= 31)
                    premium = 3.50f;
                else
                    premium = 0.0f;
            }

            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                    premium = 6.0f;
                else
                    if (age >= 36)
                    premium = 5.0f;
                else
                    premium = 0.0f;
            }
            else
                premium = 0.0f;

            if (age >= 50)
                premium = premium * 0.5f;

            return premium;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceService
{
    class InsuranceService
    {
        static void Main(string[] args)
        {

         //   float premium = CalcPremium(1, "male");



           // Console.WriteLine("Costs of Premium:" + premium);

            Console.ReadKey();
        }

        public  float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                    premium = 5.0f;
                else
                    if (age >= 31)
                    premium = 3.50f;
                else
                    premium = 0.0f;
            }

            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                    premium = 6.0f;
                else
                    if (age >= 36)
                    premium = 5.0f;
                else
                    premium = 0.0f;
            }
            else
                premium = 0.0f;

            if (age >= 50)
                premium = premium * 0.5f;

            return premium;
        }
    }
}
>>>>>>> 984f4c9b9290616b6d6346ddd2f6c584ce60a113
