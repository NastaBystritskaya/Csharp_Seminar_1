Console.WriteLine("Введите число №1: ");
String? input1 =System.Console.ReadLine();
int num1 = int.Parse(input1!);

Console.WriteLine("Введите число №2: ");
String? input2 =System.Console.ReadLine();
int num2 = int.Parse(input2!);

if(num1<num2) { 
System.Console.WriteLine($"{num2} больше {num1}");
} 
else  {
System.Console.WriteLine($"{num1} больше {num2}");
}