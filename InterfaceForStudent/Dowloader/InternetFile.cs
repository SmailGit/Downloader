using System;
using System.Threading;

namespace EventAndDelegateHomeWork.InterfaceForStudent
{
    /// <summary>
    /// Должен содержать в поле: Название, размер файла
    /// </summary>
    public class InternetFile : IDowloader
    {
        public delegate void Message(int a, int buffer, int weight);
        public event Message MessageEvent;
        private int _buffer = 0;
        private int _weight = 500;
        private string _name = "'Amongus'";
        Random rand = new Random();

        public string Name { get => _name; set => _name = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public int Buffer { get => _buffer; set => _buffer = value; }

        public void Complete(int n)
        {
            if (n == Weight)
            {
                Console.WriteLine("-Загрузка файла завершена-");
            }
        }



        public void Error(int speed)
        {
            if (speed < 5)
            {
                Console.WriteLine("-Плохое интернет соединение-");
                speed = 0;
            }
        }
        public void Start()
        {
            Console.WriteLine("-Загрузка началась-");

            for ( int i = 0; Buffer < Weight; i++)
            {
                Thread.Sleep(1000);
                int a = rand.Next(100);
                Error(a);
                Buffer = Buffer + a;
                if ( Buffer > Weight)
                {
                    Buffer = Weight;
                }
                Complete(Buffer);
                MessageEvent.Invoke(a, Buffer, Weight);
            }

        }
    }
}
