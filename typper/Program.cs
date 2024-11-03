namespace typper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // calling the method to type the wanted string
            TextTyper("salam baby");

            Console.WriteLine();

            // calling the method for using the arrays without listing 
            char[] example1 = { 'a', 'b', 'c', 'd' };
            TextTyper (example1);

            // calling the method for using the arrays without listing 
            char[] example2 = { 'e', 'f', 'g', 'h' };
            TextTyper (example2,true);

            Console.ReadKey();
        }

        // making a function that put delays as we need 
        static void delay(int DelayTime)
        {
            // the value is counting by miliseconds
            Thread.Sleep(DelayTime);
        }
        
        // the typertext function for strings
        static void TextTyper(string text)
        {
                foreach (char c in text)
                {
                    Console.Write(c);
                    delay(40);
                }
        }

        // the typertext function for arrys
        static void TextTyper(char[] array,bool listing=false)
        {
            foreach(char c in array)
            {
                if (listing)
                    Console.WriteLine();
                Console.Write(c);
                delay(40);
            }
        }


    }
}
