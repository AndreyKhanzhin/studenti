using System.ComponentModel.DataAnnotations;

int[,] Marks = new int[25, 5];
double[] results;
Random rnd = new Random();
double k;

for (int i = 0; i < 25; i++){
    for (int j = 0; j < 5; j++){
        Marks[i, j] = rnd.Next(3, 6);
    }
}

results = new double[5];
for (int i = 0; i < 5; i++){
    k = 0;
    for (int j = 0; j < 25; j++){
        k += Marks[j, i];
    }
    results[i] = k / 25;
    Console.WriteLine($"Средний балл по предмету {i + 1} — {k / 25}.");
}
Console.WriteLine($"Максимальный балл: {Enumerable.Max(results)}, принадлежит предмету предмету/ам:");
for (int i = 0; i < results.Length; i++){
    if (results[i] == Enumerable.Max(results)){
        Console.WriteLine(i + 1);
    }
}
Console.WriteLine($"Минимальный балл: {Enumerable.Min(results)}, принадлежит предмету предмету/ам:");
for (int i = 0; i < results.Length; i++){
    if (results[i] == Enumerable.Min(results)){
        Console.WriteLine(i + 1);
    }
}

Console.WriteLine();

results = new double[25];
for (int i = 0; i < 25; i++){
    k = 0;
    for (int j = 0; j < 5; j++){
        k += Marks[i, j];
    }
    results[i] = k / 5;
    Console.WriteLine($"Средний балл студента {i + 1} — {k / 5}.");
}
Console.WriteLine($"Максимальный балл: {Enumerable.Max(results)} принадлежит студенту/ам: ");
for (int i = 0; i < results.Length; i++){
    if (results[i] == Enumerable.Max(results)){
        Console.WriteLine(i + 1);
    }
}
Console.WriteLine($"Минимальный балл: {Enumerable.Min(results)}, принадлежит предмету предмету/ам:");
for (int i = 0; i < results.Length; i++){
    if (results[i] == Enumerable.Min(results)){
        Console.WriteLine(i + 1);
    }
}

Console.WriteLine();

