



namespace HomeWork4
{
    public delegate void Messeger();
    class Programm
    {

        
        public static event Messeger Number;

        static void Main()
        {
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            Counter counter = new Counter();

            Messeger messeger = new Messeger(handler1.Message);
            messeger+=handler2.PrintMessage;
            
            Number = messeger;

            for (int i = 0; i < 101; i++)
            {
                if (counter.count == 42)
                {
                    Number();
                    counter.count += 1;
                }
                else
                    counter.count += 1;
                
            }
            Console.WriteLine("Счет до 100 закончен!");
            Console.ReadLine();
        }
    }
}