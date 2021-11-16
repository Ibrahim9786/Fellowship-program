using System;
using System.Collections.Generic;
using System.Text;

namespace NlogApplication
{
    class Addition
    {
        static Nlog nlog = new Nlog();

        public static int Add(int firstNum, int secondNum)
        {
            int sum = 0;
            try
            {

                if (firstNum == 0 || secondNum == 0)
                {
                    nlog.LogDebug("debug successfully");
                    nlog.LogError("first Number and Second Number is zero");
                    nlog.LogInfo("Add method");
                    return 0;
                }
                sum = firstNum + secondNum;
                nlog.LogInfo("Addition method executed");
                nlog.LogDebug("Debug Successfully");
                nlog.LogWarn("First Number and Second number is not zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sum;
        }
    }
}
