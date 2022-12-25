string[] array1 = new string[4] { "hello", "2", "world", ":)" };
string[] array2 = new string[array1.Length];
int number = 0;


for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[number] = array1[i];
        number++;
    }
}

for (int i = 0; i < array2.Length; i++)
{
    Console.Write($"{array2[i]} ");
}


