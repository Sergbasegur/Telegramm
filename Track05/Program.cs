void FillArray(int[] collection) {
    int lendth = collection.Length;
    int index = 0;

    while(index < lendth) {
        collection[index] = new Random().Next(1, 10);
        index++;
    }   
}
void PrintArray(int[] col) {
    int count = col.Length;
    int position = 0;
    while(position < count) {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array2 = new int[10];

FillArray(array2);
PrintArray(array2);






