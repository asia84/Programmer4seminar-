Console.WriteLine("Введите число A, B:  ");//сообщение для пользователя, ввести числа

int product = 1;//произведение чисел = 1
int i = 1;
int number1 = Convert.ToInt32(Console.ReadLine());//преобразует первое число

int numder2 = Convert.ToInt32(Console.ReadLine());//преобразует второе число


while(i <= numder2)//пока счетчик<=второго числа
{
    product = number1 * product;//умножаем первое число 
    i++;//плюсуем счетчик
} 
Console.WriteLine($"Число А в степени В будет равно {product}");//выводим на экран ответ