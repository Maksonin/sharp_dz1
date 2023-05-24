void Task2() {
    // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Console.Write("Введите первое число: ");
    int first_num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int second_num = Convert.ToInt32(Console.ReadLine());
    if (first_num > second_num) Console.WriteLine("Первое число больше второго");
    else if (first_num == second_num) Console.WriteLine("Первое число равно второму");
    else if (first_num < second_num) Console.WriteLine("Первое число меньше второго");
}

void Task4() {
    // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.Write("Введите первое число: ");
    int first_num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int second_num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int third_num = Convert.ToInt32(Console.ReadLine());
    int max_num;
    if (first_num > second_num) max_num = first_num;
    else max_num = second_num;
    if (third_num > max_num) max_num = third_num;
    Console.WriteLine($"Максимальное число - {max_num}");
}

void Task6() {
    // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 != 0) Console.WriteLine("Число нечетное");
    else Console.WriteLine("Число четное");
}

void Task8() {
    // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    while(num != count) {
        if(count % 2 == 0) Console.WriteLine(count);
        if(num > 0) count++;
        if(num < 0) count--;
    }
    if(num % 2 == 0) Console.WriteLine(num);
}

Task2();
Task4();
Task6();
Task8();