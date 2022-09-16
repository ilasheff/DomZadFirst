// Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее
Console.Write("введите первое число: ");
int num1;
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2;
num2 = Convert.ToInt32(Console.ReadLine());

if (num1<num2)
{
    Console.WriteLine($"max =  {num2}" );
}
else
{
    Console.WriteLine($"max =  {num1}" );  
}
if (num1>num2)
{
    Console.WriteLine($"min =  {num2}" );
}
else
{
    Console.WriteLine($"min =  {num1}" );  
}

//задача решена