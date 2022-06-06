const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
string[] etiquetas = {"<div>","</div>","<span>","</span>"};
int startPosition, endPosition; // para establecer las donde comienza una y otra etiqueta
int longitudCadenaEntreEtiquetas;
// div
startPosition = input.IndexOf(etiquetas[0]);
startPosition += etiquetas[0].Length;        //startPosition += 5;
endPosition = input.IndexOf(etiquetas[1]);
longitudCadenaEntreEtiquetas = endPosition - startPosition;
output = input.Substring(startPosition,longitudCadenaEntreEtiquetas);
output = output.Replace("&trade","&reg");
output = $"Output:{output}";
// span
startPosition = input.IndexOf(etiquetas[2]);
startPosition += etiquetas[2].Length;        //startPosition += 5;
endPosition = input.IndexOf(etiquetas[3]);
longitudCadenaEntreEtiquetas = endPosition - startPosition;
quantity = input.Substring(startPosition,longitudCadenaEntreEtiquetas);
quantity = $"Quantity:{quantity}";

Console.WriteLine(quantity);
Console.WriteLine(output);   //Output: <h2>Widgets &reg;</h2><span>5000</span>