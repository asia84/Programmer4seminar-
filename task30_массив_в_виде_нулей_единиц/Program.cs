/*Напишите программу, которая будет выводить массив из 8 элементов, заполненный нулями и единицами в случайном 
[1, 0, 1, 1, 0, 0, 0, 1]*/

int[]array = new int[8];//задаем массив. количество элементов. Далее создаем 2 процедуры. процедура всегда void, функция всегда тем типом данных, который будет возвращен 
void NewArray(int[] collection)// эта процедура определяет коллекцию и
{
    int length = collection.Length;//находит ее длину. Можно сразу записать сюда равно 8
    int index = 0;// начинаем с нуля
    while(index < length)//пока индекс меньше длины
    {
        collection[index] = new Random().Next(0, 2);//присваиваем индексу рандомное число от 0 до 1
        index++;//плюсуем индес+1

    }
}
void PrintArray(int[] col)//вторая процедура выводит результат
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
NewArray(array);
PrintArray(array);