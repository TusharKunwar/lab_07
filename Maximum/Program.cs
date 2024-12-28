int[] RollNos = new int[] {20, 30, 10, 5, 8, 50, 100, 40, 45};

int max = (from rollno in RollNos select rollno).Max();

Console.WriteLine("Maximum number is "+max);