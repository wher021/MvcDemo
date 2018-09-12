using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathServiceClient" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MathServiceClient.svc or MathServiceClient.svc.cs at the Solution Explorer and start debugging.
    public class MathServiceClient : IMathService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
