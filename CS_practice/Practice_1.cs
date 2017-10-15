using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_practice
{
    class Practice_1
    {
        static void Main(string[] args)
        {
            // GetAndSet
            GetAndSet obj = new GetAndSet();
            Console.WriteLine("----GetAndSet----");
            obj.number1 = Convert.ToInt32(Console.ReadLine());
            obj.number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(obj.number3);
            Console.WriteLine();

            // Constructors
            Console.WriteLine("----Constructors----");
            GetAndSet obj2 = new GetAndSet(180, 180);
            Console.WriteLine(obj2.number3);
            Console.ReadLine();

        }

        class GetAndSet                 //Learning Getters & Setters , Constructors
        {

            public GetAndSet(){}
            public GetAndSet(int num1, int num2) {
                _number1 = num1;
                _number2 = num2;
            }

            int _number1 = 0, _number2 = 0, _number3 = 0;
            public int number1
            {
                get
                {
                    return _number1;
                }
                set
                {
                    _number1 = value;
                }
            }

            public int number2
            {
                get
                {
                    return _number2;
                }
                set
                {
                    _number2 = value;
                }
            }

            public int number3
            {
                get
                {
                    return _number1 + _number2;
                }
            }
        }

    }
}
