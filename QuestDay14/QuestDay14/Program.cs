using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestDay14
{
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
    }

   
    public abstract class BaseCalculator : ICalculator
    {
        
        public abstract double Multiply(double a, double b);


        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;


        public virtual double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            return a / b;
        }
    }

    
    public class AdvancedCalculator : BaseCalculator
    {
       
        public override double Multiply(double a, double b)
        {
            return a * b;
        }

       
        public override double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Custom handling: Division by zero is not allowed!");
                return double.NaN; 
            }
            return base.Divide(a, b); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AdvancedCalculator calculator = new AdvancedCalculator();

            Console.WriteLine("Addition: " + calculator.Add(10, 5));
            Console.WriteLine("Subtraction: " + calculator.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + calculator.Multiply(10, 5));
            Console.WriteLine("Division: " + calculator.Divide(10, 0));
        }
    }
}
