int[] Rollnos = new int[] {20, 30, 10, 5, 8, 50, 100, 40, 45};

List<int> Rollno = Rollnos.Where(Rollno => Rollno> 10).ToList();

Console.WriteLine("Students having rollno greater than 10 are:");

foreach (int rollno in Rollno)
{
    Console.WriteLine(rollno);
}