using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator(2,3);
            //Console.WriteLine(calculator.Add(3, 4));
            //Console.WriteLine(calculator.Add2());            //constructordan gelen değerler ile çalıştı
            var type = typeof(Calculator);

            //var calculator = Activator.CreateInstance(type);
            //Calculator calculator = (Calculator)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(calculator.Add(3,5));
            //Console.WriteLine(calculator.Add2());

            var calculator = Activator.CreateInstance(type, 6, 7);
            MethodInfo MethodInfo = calculator.GetType().GetMethod("Add2");

            //Console.WriteLine(MethodInfo.Invoke(calculator,null));
            Console.WriteLine("------------");
            var methods = type.GetMethods();
            foreach (var info in methods)
            {
                Console.WriteLine("metod adı: " + info.Name);

                foreach (var item in info.GetParameters())
                {

                    Console.WriteLine("parametre:" + item.Name);

                }

                foreach (var attribute in  info.GetCustomAttributes())
                {
                    Console.WriteLine("attribute:"+attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class Calculator
    {
        private int _sayi1;
        private int _sayi2;

        public Calculator(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Add2()
        {

            return _sayi1 + _sayi2;
        }
        public int Sub2()
        {

            return _sayi1 - _sayi2;
        }
        public int Add(int sayi1, int sayi2)
        {

            return sayi1 + sayi2;
        }
        public int Sub(int sayi1, int sayi2)
        {

            return sayi1 - sayi2;
        }

        [MethodName("Bölme")]
        public int Mul(int sayi1, int sayi2)
        {

            return sayi1 * sayi2;
        }
        public int Div(int sayi1, int sayi2)
        {

            return sayi1 / sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }


}
