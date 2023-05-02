#region StringBuilder
using CodeAcademy.Models;
CustomBuilder cb = new CustomBuilder();
Console.WriteLine("Lenght:" + cb.Length);
Console.WriteLine("Capacity:" + cb.Capacity);
cb.Append('a');
cb.Append('b');
cb.Append('c');
foreach (var item in cb.GetResult)
{
    Console.WriteLine(item);
}
cb.Replace('\0', 'k');
cb.Remove(2, 5);
Console.WriteLine(cb);
#endregion
