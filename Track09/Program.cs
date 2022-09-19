Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i <= N; i++){
    if(i % 2 == 0){
        Console.WriteLine("Это целые числа :" + "{0}", i);
    }
}

