using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GaitovaAA.Sprint4.Task2.V3.Lib
{
    public class DataService : ISprint4Task2V3
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
