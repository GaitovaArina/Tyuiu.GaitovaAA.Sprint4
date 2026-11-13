using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GaitovaAA.Sprint4.Task1.V8.Lib
{
    public class DataService : ISprint4Task1V8
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
