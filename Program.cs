const string inputString = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// Your work here

const string quantityIndexBeginTag = "<span>";
const string quantityIndexEndTag = "</span>";
int quantityIndexBegin = inputString.IndexOf(quantityIndexBeginTag);
int quantityIndexEnd = inputString.IndexOf(quantityIndexEndTag);
int quantityIndexBeginLength = quantityIndexBeginTag.Length;
quantityIndexBegin += quantityIndexBeginLength;
int quantityIndexLength = quantityIndexEnd - quantityIndexBegin;
string quantity = inputString.Substring(quantityIndexBegin, quantityIndexLength);

//

string output = inputString;
output = output.Replace("<div>", "");
output = output.Replace("</div>", "");
output = output.Replace("&trade", "&req");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine(output);