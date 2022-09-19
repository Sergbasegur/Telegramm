int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;

}

int[] array = {11,22,33,41,53,67,77,88,9};
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);

int[] array1 = {1,2,3,4,5,21, 16, 21,56}; 
int n = array1.Length;
int find = 21;
int index = 0;

while(index < n) {
    if(array1[index] == find){
        Console.WriteLine(index);
        break;
    }

    index ++;
}




