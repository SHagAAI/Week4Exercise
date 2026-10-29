using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularQueue
{
    public class CircularQWeek4
    {
        private int _head;
        private int _tail;
        public int Capacity = 3;

        private int _counter;
        private int[] _buffer;

        public bool overwriteEnable = false;

        private const double LOWER_THRESHOLD = 0.66;

        public CircularQWeek4()
        {
            _tail = -1;
            _head = 0;
            _buffer = new int[Capacity];
            overwriteEnable = false;
        }


        public void Log(int number)
        {
           
            if (_counter == Capacity)
            {
                if (overwriteEnable)
                {


                    // Ganti dengan mengisi oldest data
                    _buffer[_head] = number;
                    Console.WriteLine($"Overwritten oldest with [{number}]");

                    // geser
                    _head = (_head + 1) % Capacity;

                    // tail geser ke yang baru
                    _tail = (_tail + 1) % Capacity;


                    // Console.WriteLine("Buffer Full");
                    return;
                }

                Console.WriteLine("Number rejected, Buffer full");
                return;
            }

            // add to array
            _counter++;
            _tail = (_tail + 1) % Capacity;
            // Console.WriteLine($"TAIL is {_tail}");
            _buffer[_tail] = number;

            // Console.WriteLine($"Tail : {_tail}");
            Console.WriteLine($"Logged [{number}]");

            if (_counter == Capacity)
            {
                Console.WriteLine("Critical: Buffer Full");
                return;
            }

            if (_counter >= Capacity * LOWER_THRESHOLD)
            {
                Console.WriteLine("Buffer at 66%");
            }
            //  Console.WriteLine("===========");
        }

        public void Read()
        {

            if (_counter == 0)
            {
                Console.WriteLine("EMPTY");
                return;
            }
            int headVal = _buffer[_head];
            Console.WriteLine($"Read [{headVal}]");
            _buffer[_head] = 0;
            _counter--;

            _head = (_head + 1) % Capacity;
            // Console.WriteLine($"Head : {_head}");
            // Console.WriteLine("===========");
        }

        public void SetCapacity(int n)
        {
            Capacity = n;
            _buffer = new int[Capacity];
        }

        public void SetOverwritePolicy(bool isOverwriteEnabled)
        {
            overwriteEnable = isOverwriteEnabled;
        }
    }
}
