// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();

int[] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

for (int i = 1; i <= (array.Length + 1) / 2; i++)
{
    Console.Write(array[i - 1] * (array[array.Length - i]) + "\t");
}