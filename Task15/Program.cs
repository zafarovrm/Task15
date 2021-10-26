using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public interface ISeries
    {
        void setStart(int x);//устанавливает начальное значение
        int GetNext();//возвращает следующее число ряда        
        void reset();//выполняет сброс к начальному значению
    }
    class ArithProgression : ISeries
    {
        int value = 0;
        int x = 0;
        int step = 2;
        public void setStart(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
        }
        public int GetNext()
        {
            int value = x + step;
            return value;
        }
        public void reset()
        {
            int startValue = value - step;
        }       
    }
    class GeomProgression : ISeries
    {
        int x = 0;
        int step = 2;
        public void setStart(int x)
        {            
            x = Convert.ToInt32(Console.ReadLine());
        }
        public int GetNext()
        {
            int value = x * step;
            return value;
        }
        public void reset()
        {
            int startValue = x/step;
        }               
    }
}