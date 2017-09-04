using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int numb1,int numb2)
        {
            int result = checked(numb1 + numb2);
            return result;
        }

        public int Mul(int numb1, int numb2)
        {
            int result = checked(numb1 *numb2);
            return result;
        }

        public int Div(int numb1, int numb2)
        {
            int result = numb1 / numb2;
            return result;
        }

        public int DivByZero(int numb1, int numb2)
        {
            try
            {
                int result = numb1 / numb2;
                return result;
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public int Sub(int numb1, int numb2)
        {
            int result = numb1 - numb2;
            return result;
        }

        public int Exp1(int numb1, int numb2)
        {
            int result = numb1;
            for (int i = 1; i < numb2; ++i)
                result = checked(Mul(result, numb1));
            return result;
        }

        public int Exp2(int numb1, int numb2)
        {
            if (numb2 == 0)
                return 1;
            int result = numb1;
            for (int i = 1; i < numb2; ++i)
                result = Mul(result, numb1);
            return result;
        }

        public int Exp3(int numb1, int numb2)
        {
            if (numb2 == 0)
                return 1;
            if (numb1 == 0)
                throw new ArgumentException("Invalid argument passed to the function.");
            int result = numb1;
            for (int i = 1; i < numb2; ++i)
                result = Mul(result, numb1);
            return result;
        }
    }
}
