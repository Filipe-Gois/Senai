// array

// string[] a = new string[3];
// a[0] = "Filipe";
// a[1] = "Daniel";
// a[2] = "Góis";

// // coloca em ordem alfabética
// Array.Sort(a);

// foreach (var item in a)
// {   
//     Console.WriteLine(item);
// }

List<string> b = new List<string>();

b.Add("Eu");
b.Add("Góis");
b.Add("Rose");



foreach (var item in b)
{
    Console.WriteLine($"{item}");

}

// if (b.Exists(x => x== "Eu")) ou
if (b.Contains("Eu"))
{
    Console.WriteLine($"Encontrei.");

}

else
{
    Console.WriteLine($"N achei");
    
}