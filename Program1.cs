// Можно сделать вот так. Буквально в несколько строчек


string[] strings= {"hello", "888", "world", "string","two", "2", "on", "5", "off"}; 
Console.Write($"[{String.Join(", ", strings)}]");
Console.WriteLine();

string[] result = strings.Where(x=>x.Length<=3).ToArray();

Console.Write($"[{String.Join(", ", result)}]");
