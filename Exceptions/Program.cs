using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryCatch();

            //try
            //{
            //    Find();
            //}
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);
               
            //}

            HandleException(() =>
            {
                Find();
            });



            Console.ReadLine();

        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
          
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> {"hasan", "hüseyin", "sevim"};


            if (!students.Contains("hasan"))
            {
                throw new RecordNotFoundException("record not found");
            }
            else
            {
                Console.WriteLine("record found!");
            }


            Console.ReadLine();
        }

        private static void TryCatch()
        {
            try //hatalı olsa bile çalıştır
            {
                string[] students = new string[3] {"hasan", "hüseyin", "sevim"};
                students[3] = "ahmet";
            }

            catch (IndexOutOfRangeException exception) //hatanın türü özel olarak belirtildi
            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception) //diğer tüm hatalarda bu kodu çalıştır
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(exception.Message); //hata mesajını verir
            }


            /* students[3] = "ahmet"; */ //dizi elemanları 0 1 2 ile indexlenebilir, sınırı aşar
        }
    }
}
