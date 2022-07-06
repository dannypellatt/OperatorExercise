using OperatorExercise;

// Exercise 1 - Create a simple program showcasing
// arithmetic operators

int a = 17;
int b = 4;

int addResult = a + b;
int subtractResult = a - b;
int multResult = a * b;
int divResult = a / b;
int quotient = a % b;


Console.WriteLine($"If you add a & b, you get: {addResult}\n" +
    $"If you subtracts b from a, you get: {subtractResult}\n" +
    $"If you multiply a and b, the answer is: {multResult}\n" +
    $"If you divide a by b, the result is: {divResult}\n" +
    $"Finally, the quotient of a and b is: {quotient}");


// Exercise 2 - Create a method that will calculate the area of a circle
// based on it's radius



Console.WriteLine("type in radius");
double r = double.Parse(Console.ReadLine());

Console.WriteLine($"The area of a circle with radius of {r}" +
    $" is {Methods.AreaOfCircle(r)}.");


