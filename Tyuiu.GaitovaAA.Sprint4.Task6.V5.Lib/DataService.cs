using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GaitovaAA.Sprint4.Task6.V5.Lib
{
    public class DataService : ISprint4Task6V5
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length == 5);
            return mas.Length;
        }
    }
}
