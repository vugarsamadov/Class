
using October31.Extensions;

var s = "Bu bir custom contains methodudur";

Console.WriteLine(s.CustomContains("bb"));
Console.WriteLine(s.CustomContains("bu"));
Console.WriteLine(s.CustomContains("tains"));
Console.WriteLine(s.CustomContains("co"));
Console.WriteLine(s.CustomContains("ns Methodudur"));
Console.WriteLine(s);