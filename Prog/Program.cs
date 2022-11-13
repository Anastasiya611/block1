Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
string[] newarray = new string[n];

for (int i= 0; i < n; i++)
{
    Console.Write("Введите значение: ");
    array [i] = Console.ReadLine();
    if (array[i].Length<4)
    {
        newarray[i]=array[i]; 
    }
}
for (int i= 0; i < n; i++)
{
    if (newarray[i] != null)
    { 
        Console.WriteLine("[" + string.Join(", ", newarray[i]) + "]");
    }
}