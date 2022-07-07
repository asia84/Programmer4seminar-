//бинарный поиск числа от 1 до 100
Console.WriteLine("Загадай число от 1 до 100");
int n_first  = 0, n_last = 100, mid = 50;
while(n_first<=n_last)
{
    mid = (n_first + n_last)/2;
    Console.WriteLine("Число БОЛЬШЕ {0} ?", mid ); 
    string ?ans = Console.ReadLine();//ВВОД СТРОКИ В С#
    if(mid == n_first)
        break;
    if( ans == "да")
    {
        n_first = mid;
    }
    else
    {
        n_last = mid;

    }


}
Console.WriteLine(mid);