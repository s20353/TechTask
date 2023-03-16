class Program
{
    static void Main(string[] args)
    {
        //Inputting coordinates
        Console.WriteLine("Enter coordinates of the desired 3 points (x,y) below.");
        Console.Write("Point 1: ");
        string[] p1 = Console.ReadLine().Split(',');
        double x1 = Convert.ToDouble(p1[0]);
        double y1 = Convert.ToDouble(p1[1]);

        Console.Write("Point 2: ");
        string[] p2 = Console.ReadLine().Split(',');
        double x2 = Convert.ToDouble(p2[0]);
        double y2 = Convert.ToDouble(p2[1]);

        Console.Write("Point 3: ");
        string[] p3 = Console.ReadLine().Split(',');
        double x3 = Convert.ToDouble(p3[0]);
        double y3 = Convert.ToDouble(p3[1]);

        //Calulating length of sides
        double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

        //Checking for properties
        string equi = (side1==side2 && side1==side3) ? "The triangle is equlateral." : "The triangle is NOT equlateral.";
        string iso = (side1 == side2 || side2 == side3 || side1 == side3) ? "The triangle is isosceles." : "The triangle is NOT isosceles.";
        string right = (
            Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
            Math.Pow(side1, 2) + Math.Pow(side3, 2) == Math.Pow(side2, 2) ||
            Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2)) ? "The triangle is right." : "The triangle is NOT right.";

        //Calculating perimeter
        double perimeter = side1 + side2 + side3;

        //Checking even numbers from 0 to perimeter's value
        List<int> even = new List<int>();
        for (int i=0; i < perimeter; i+=2)
        {
            even.Add(i);
        }

        //Output
        Console.WriteLine($"Length of side 1: {side1:F3}");
        Console.WriteLine($"Length of side 2: {side2:F3}");
        Console.WriteLine($"Length of side 3: {side3:F3}");

        Console.WriteLine(equi);
        Console.WriteLine(iso);
        Console.WriteLine(right);

        Console.WriteLine($"The perimeter of the triangle is equal to: {perimeter:F3}");

        Console.WriteLine("Even numbers from 0 to the value of the triangle's perimeter: ");
        Console.WriteLine(string.Join(", ", even));

        Console.ReadLine();
    }
}