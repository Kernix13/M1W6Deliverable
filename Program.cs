// See https://aka.ms/new-console-template for more information

/*  Collection expression:
    double[] conversions = [0.3048, 3.28084]; 
*/

double[] conversions = new double[] { 0.3048, 3.28084 };

/* 1. Get type of conversion from user */
string type;

do
{
    Console.WriteLine("Enter '1' to convert feet to meters, or '2' to convert meters to feet");
    type = Console.ReadLine();
} while (type != "1" && type != "2");

string userType = type == "1" ? "feet" : "meters";

/* 2. Get value to convert from user */
double value;
bool isValid;

do
{
    Console.WriteLine($"Enter the number of {userType} you want to convert: ");
    isValid = double.TryParse(Console.ReadLine(), out value);

    if (!isValid)
    {
        Console.WriteLine("Invalid number entered. Please try again:");
    }

} while (!isValid);

Console.WriteLine($"{value} {userType} = {convertDistance(value)}");

/* 3. Based on type of conversion, return converted value */
double convertDistance(double value)
{
    return type == "1" ? value * conversions[0] : value * conversions[1];
}
