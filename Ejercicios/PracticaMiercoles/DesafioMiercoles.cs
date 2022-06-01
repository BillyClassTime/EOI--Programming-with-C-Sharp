/*
Dear Mr. Jones,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   ¤55,000,000.00      
Glorious Future     13.13 %   ¤63,000,000.00 */

string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine();
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}");


Console.WriteLine("Here's a quick comparison:\n");
//Magic Yield         12.75 %   ¤55,000,000.00      
//Glorious Future     13.13 %   ¤63,000,000.00 
//string comparisonMessage = string.Format("{0}{1:P2}{2:C}",currentProduct,currentReturn,currentProfit);

var comparisonMessage = currentProduct.PadRight(20) + string.Format("{0:P2}",currentReturn).PadRight(10) + string.Format("{0:C}",currentProfit).PadRight(20);
comparisonMessage += "\n"+newProduct.PadRight(20) + (string.Format("{0:P2}",newReturn)).PadRight(10) + (string.Format("{0:C}",newProfit)).PadRight(20);
// Your logic here

Console.WriteLine(comparisonMessage);