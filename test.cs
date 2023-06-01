using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
public static void Main (string[] args) {
// Ввод массива строк с клавиатуры
Console.Write("Мы учим Git");
Console.Write("Мы учим GitHub");
Console.Write("Ошибочное сохранение");
Console.Write("Введите массив строк через запятую: ");
string[] input_array = Console.ReadLine().Split(',');

// Формирование выходного массива строк
List<string> output_array = new List<string>();
foreach (string str in input_array) {
if (str.Trim().Length <= 3) {
output_array.Add(str.Trim());
}
}

// Вывод результата
Console.WriteLine(string.Join(",", output_array.ToArray()));
}
}