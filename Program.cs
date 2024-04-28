string[] array =
{
    "a",    
    "bb",
    "ccc",
    "dddd",
    "eeeee",
    "z",
    "ttt",
    "88",
    "7"
};

Console.Write($"[{String.Join(", ", array)}]"); 
Console.WriteLine();

var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}

Console.Write($"[{String.Join(",", result)}]");

