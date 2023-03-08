int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
// mew Randow().Next(min,max)
// даст случайное целое число от min до max-1 
// [min,max-1] или [min,max)

// int numberA = 31;
// int numberB = 2;
// int result = numberA + numberB;
// Console.WriteLine(result);