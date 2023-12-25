
using System.Text;

string? firstName = "Pablo";
string? folderName = "Data";
string? filePath = @$"C:\Temp\{folderName}\{firstName}";

Console.WriteLine(filePath);

StringBuilder stringBuilder = new StringBuilder();//faster

stringBuilder.Append("oh ");
stringBuilder.Append("no :c");

Console.WriteLine(stringBuilder);