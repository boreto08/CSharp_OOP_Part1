namespace ENCAPSULATION
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var lenght = double.Parse(Console.ReadLine());
            var widht = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Box box = new Box(lenght, widht, height);

            Console.WriteLine(box.ToString());
        }
    }
}
