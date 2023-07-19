using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLOGProgram
{
    internal class Addition
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void SumOfTwoNumbers(int firstnum, int secondnum)
        {
            int sum = 0;
            if (firstnum <= 0 || secondnum <= 0)
            {
                logger.Warn("Input should be greater than zero");
                logger.Error("Give proper +ve inputs");
            }
            else
            {
                sum = firstnum * secondnum;
                logger.Info("Succesfully added the numbers and sum is :{0}" + sum);
            }
        }
    }
}
