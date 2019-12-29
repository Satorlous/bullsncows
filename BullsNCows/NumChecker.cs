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
        /// <param name="NumberSave">Загаданное число</param>
        /// <param name="Number">Введенное число</param>
        /// <returns></returns>
        public static Dictionary<string,int[]> CheckNumber(int[] NumberSave, int[] Number)
        {
            int[] Bulls = new int[NumberSave.Length];
            int[] Cows = new int[NumberSave.Length];
            for (int i =0; i < NumberSave.Length;i++)
            {
                for(int j = 0; j < NumberSave.Length;j++)
                {
                    if(Number[j] == NumberSave[i])
                    {
                        if (i == j)
                        {
                            Bulls[i] = 1;
                        }
                        else
                        {
                            Cows[i] = 1;
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
