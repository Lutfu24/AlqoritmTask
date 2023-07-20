//Task 3

//Console.WriteLine("eded daxil edin");
//int num = int.Parse(Console.ReadLine());

//Console.WriteLine("eded daxil edin");
//int num1 = int.Parse(Console.ReadLine());

//int result = num1 - num;
//int total = 0;
//if (result>=0)
//{
//	for (int i = num; i <= num1; i++)
//	{
//		total += i;
//	}
//}
//else
//{
//    for (int i = num1; i <= num; i++)
//    {
//        total += i;
//    }
//}

//Console.WriteLine(total);

//Task 4

//Console.WriteLine("eded daxil edin");
//double num = double.Parse(Console.ReadLine());

//Console.WriteLine("eded daxil edin");
//double num1 = double.Parse(Console.ReadLine());

//double result = Math.Pow(num, num1);

//Console.WriteLine(result);

//Task 5

//Console.WriteLine("eded daxil edin");
//int num1 = int.Parse(Console.ReadLine());
//int count = 0;

//while (num1 != 0)
//{
//    num1 /= 10;
//    count++;
//}
//Console.WriteLine($"{count} mertebeli ededdir");

//Task 6

//string[] myArr = { "adsds", "bs", "ddc", "ddasdss", "dasdsaw" };

//foreach (string item in myArr)
//{
//	if (item.Length > 4)
//	{
//		Console.WriteLine(item);
//	}
//}

Console.WriteLine("eded daxil edin");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("eded daxil edin");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("say daxil edin");
int count = int.Parse(Console.ReadLine());

int total1 = num;

for (int i = 0; i < count; i++)
{
    total1 += num1;
    num1 = total1;
    Console.WriteLine(total1);
}