void FIllArray(string [] array, string[] array22)
{    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3 )
        {
          array22[count] = array[i];
          count++; 
        }
    }
}

void PrintArray(string []array)
{
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine();
}


string [] array10 = new string [7] {"#42", "gfdgs", "#$%@", "76", "the", "1", "FG"} ;
string [] array22 = new string[array10.Length];
FIllArray(array10,array22);
PrintArray(array22);