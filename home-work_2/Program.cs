using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            string input_data = Console.ReadLine();
            bool result = ulong.TryParse(input_data, out var number);
            if (result == true)
            {
                if (number <= byte.MaxValue)
                    Console.WriteLine("введеное число без потерь точности приводится к типу - byte");
                else
                    if (number <= ushort.MaxValue)
                    Console.WriteLine("введеное число без потерь точности приводится к типу - ushort");
                else
                  if (number <= uint.MaxValue)
                    Console.WriteLine("введеное число без потерь точности приводится к типу - uint");
                else
                    Console.WriteLine("введеное число без потерь точности приводится к типу - ulong");
            }

            else
            {
                bool result2 = long.TryParse(input_data, out var number2);
                if (result2 == true)
                {
                    if (number2 >= sbyte.MinValue)
                        Console.WriteLine("введеное число без потерь точности приводится к типу - sbyte");
                    else
                        if (number2 >= short.MinValue)
                        Console.WriteLine("введеное число без потерь точности приводится к типу - short");
                    else
                      if (number2 >= int.MinValue)
                        Console.WriteLine("введеное число без потерь точности приводится к типу - int");
                    else
                        Console.WriteLine("введеное число без потерь точности приводится к типу - long");
                }
                else
                {
                 bool result3 = double.TryParse(input_data, out var number3);
                 if (result3 == true)
                    {
                        if (number3 >= float.MinValue && number3 <= float.MaxValue)
                            Console.WriteLine("введеное число без потерь точности приводится к типу - float");
                      
                        else
                            Console.WriteLine("введеное число без потерь точности приводится к типу - double");
                    }
                 else
                       Console.WriteLine("Преобразование невозможно - введен текст");
                }

            }
              

        }
    }
}
