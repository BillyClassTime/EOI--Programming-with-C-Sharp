string value = "5";

int result = 2;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Since it is defined outside of the if statement, 
// it can be accessed later in your code.
if (result > 0) // Si no funciona el TryParse el parametro de salida (out) es 0
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");