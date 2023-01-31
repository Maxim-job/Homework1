int max = int.MinValue; 
for (int i = 0; i < 3; i++) 
{
   int num = Convert.ToInt32(Console.ReadLine()); 
   if (num > max) 
      max = num; 
}
Console.WriteLine(max); 
Console.Read(); 