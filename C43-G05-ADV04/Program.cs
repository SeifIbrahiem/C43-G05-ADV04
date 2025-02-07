using C43_G05_ADV04.Fifa;

namespace C43_G05_ADV04
{
    internal class Program
    {
        static void Main()
        { 
            Ball ball = new Ball() {Id = 1};
            Console.WriteLine(ball);
            ball.Location = new Location() { X = 0, Y = 0 , Z=0 };
            Console.WriteLine(ball);
        }
    }
}
