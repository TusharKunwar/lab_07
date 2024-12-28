List<string> students = new List<string>();
students.Add("sunil shrestha");
students.Add("surya prajapati");
students.Add("sajan shrestha");
students.Add("Yumesh Ban");
students.Add("subarna limbu");
students.Add("santosh shrestha");

List<string> shresthas  = students.Where(students => students.Contains("shrestha")).ToList();

Console.WriteLine("students with shrestha surname are:");

foreach(var item in shresthas)
{
    Console.WriteLine(item);
}