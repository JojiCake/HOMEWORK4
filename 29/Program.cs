void fillArray(int[] collection)
{
int lenght = collection.Length;
int index = 0;
while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void printArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    
    while(position < count)
    {
    Console.WriteLine(col[position]);
    position++;
    }
}



int[] array = new int[10];



fillArray(array);
printArray(array);