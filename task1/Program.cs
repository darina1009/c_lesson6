int GenLenght(string input){
    Console.WriteLine("Введите длину");
     int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}

int[] GetArray(int lenght){
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GenLenght($"Введите {i + 1}-й элемент");
        
    }
    return array;
}

int Count(int[] array){
    int count = 0;
    foreach (int num in array)
    {
        if(num > 0){
            count++;
        }
    }
    return count;
}

int lenght = GenLenght("Введите количество элементов");
int [] array = GetArray (lenght);
string arr = String.Join(", ", array);
Console.WriteLine(arr);
int count = Count(array);
Console.WriteLine(count);