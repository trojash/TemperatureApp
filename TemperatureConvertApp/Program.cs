

Console.WriteLine("This is a convert temperature app\n");

Console.WriteLine("Enter a Fahrenheit temperature: ");
int fahrenheit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an Celsius temperature: ");
decimal celsius = Convert.ToDecimal(Console.ReadLine());

decimal convertToCelsius = (fahrenheit - 32m) * (5m/9m);
decimal convertTofahrenheit = (celsius * 9m / 5m) + 32;

Console.WriteLine($"The temperature in celsius is: {convertToCelsius} °C");
Console.WriteLine($"The temperature in fahrenheit is: {convertTofahrenheit} °F");

