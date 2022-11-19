// Задача 8
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int EvenNumber = 2;

if (N > 1) {
    while (EvenNumber <= N) {
        Console.Write(EvenNumber + " ");
        EvenNumber += 2;
    }
    Console.WriteLine();
    /* Alternative
    for (int i=2; i <= N; i++) {
        Console.Write(i % 2 == 0 ? i : " ");
    }
    */
}