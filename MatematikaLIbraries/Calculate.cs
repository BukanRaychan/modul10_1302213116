using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

namespace MatematikaLibraries
{
    public static class Calculate
    {
        public static int FPB(int input1, int input2)
        {
            int temp;
            while(input2 != 0)
            {
                temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }
        public static int KPK(int input1, int input2)
        {
            int max = Math.Max(input1, input2);
            int min = Math.Min(input1, input2);
            int result = max;

            while(result % min != 0) {
                result += max;
            }

            return result;
        }
        public static String Turunan(int[] persamaan)
        {
            String result = "";
            int first_num;
            for (int i = 0, pangkat = persamaan.Length - i - 1; i < persamaan.Length - 2; i++, pangkat--)
            {
                first_num = persamaan[i] * pangkat;
                result += (first_num == 1 ? null : (first_num).ToString(" + #; - #;0")) + "x" + (pangkat - 1 == 1 ? null : (pangkat - 1));
            }
            return (result[1].ToString() == "+" || result[1].ToString() == "-" ? result.Substring(3) : result) + persamaan[^2].ToString(" + #; - #;0");
        }

        public static String Integral(int[] persamaan)
        {
            String result = "";
            int first_num;
            for (int i = 0, pangkat = persamaan.Length - i - 1; i < persamaan.Length; i++, pangkat--)
            {
                first_num = persamaan[i] / (pangkat + 1);
                result += (first_num == 1 ? null : first_num.ToString(" + #; - #;0")) + "x" + (i == persamaan.Length - 1 ? null : (pangkat + 1));
            }
            return (result[1].ToString() == "+" || result[1].ToString() == "-" ? result.Substring(3) : result) + " + C";
        }
    }
}