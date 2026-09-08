

Console.WriteLine("This is a convert temperature app\n");
int fahrenheit = 94;
decimal celsius = 34;

decimal convertToCelsius = (fahrenheit - 32m) * (5m/9m);
decimal convertTofahrenheit = (celsius * 9m / 5m) + 32;

Console.WriteLine($"The temperature in celsius is: {convertToCelsius} °C");
Console.WriteLine($"The temperature in fahrenheit is: {convertTofahrenheit} °F");

