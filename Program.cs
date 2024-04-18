internal class Program
{
    private static void Main(string[] args)
    {
            Shape shape = new Shape();
            Console.WriteLine(shape);
            shape = new Shape("blue", false);
            Console.WriteLine(shape);

            // Circle
            Console.WriteLine("Circle ##############");
            Circle circle = new Circle();

            Console.WriteLine(circle);

            circle = new Circle(12);

            Console.WriteLine(circle);

            circle = new Circle(1.46, "Yellow", true);

            Console.WriteLine(circle);

            // Rectangle 
            Console.WriteLine("Rectangle #################");
        Rectangle rectangle = new Rectangle();

        Console.WriteLine(rectangle);

        rectangle = new Rectangle(3, 4);

        Console.WriteLine(rectangle);

        rectangle = new Rectangle(12, 16, "White", true);

        Console.WriteLine(rectangle);

        // Square 
                Console.WriteLine("Square ###############");
                Square square = new Square();

                Console.WriteLine(square);

                square = new Square(3.7);

                Console.WriteLine(square);

                square = new Square(10, "Violet", true);

                Console.WriteLine(square);
    }
}