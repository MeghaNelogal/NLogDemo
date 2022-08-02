using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    public class Sum
    {
        NLog nLog = new NLog();

        public void DoSum(int a,int b)
        {
            if(a==0 || b==0)
            {
                nLog.LogErroring(" A and B value Are 0");
            }
            else
            {
                int c = a + b;
                nLog.LogDebugMode("The Program executing");
                nLog.LogInformation("The Values Added");
            }
        }
    }
}
