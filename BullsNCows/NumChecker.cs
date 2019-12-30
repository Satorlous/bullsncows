using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsNCows
{
    class NumChecker
    {
        /// <summary>
        /// Проверка загаданного числа и введенного
        /// </summary>
        /// <param name="Answer">Загаданное число</param>
        /// <param name="Number">Введенное число</param>
        /// <returns></returns>
        public static Dictionary<string,int[]> CheckNumber(int[] Answer, int[] Number)
        {
            int[] Bulls = new int[Answer.Length];
            int[] Cows = new int[Answer.Length];
            for (int i =0; i < Answer.Length;i++)
            {
                for(int j = 0; j < Number.Length;j++)
                {
                    if(Number[j] == Answer[i])
                    {
                        if (i == j)
                        {
                            Bulls[j] = 1;
                        }
                        else
                        {
                            Cows[j] = 1;
                        }
                    }
                }
            }
            Dictionary<string, int[]> answer = new Dictionary<string, int[]>();
            answer.Add("Bulls", Bulls);
            answer.Add("Cows", Cows);
            return answer;
        }
    }
}
