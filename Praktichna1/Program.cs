using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Задача номер 1");
Console.Write("Введіть логін: ");
string login = Console.ReadLine();

if (IsValidLogin(login))
{
    Console.WriteLine("Логін коректний.");
}
else
{
    Console.WriteLine("Логін некоректний.");
}
static bool IsValidLogin(string login)
{
    // Визначаємо регулярний вираз для перевірки логіна
    string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";

    // Перевіряємо логін за допомогою регулярного виразу
    return Regex.IsMatch(login, pattern);
}
Console.WriteLine("Задача номер 2");
string inputText = "Це текст з деякими визначеними словами, такими як Кіт, коТИк, к1Шка.";
string filteredText = FilterWords(inputText);

Console.WriteLine("Оригінальний текст: ");
Console.WriteLine(inputText);

Console.WriteLine("\nТекст після фільтрації: ");
Console.WriteLine(filteredText);
static string FilterWords(string input)
{
    // Список визначених слів, які ми хочемо фільтрувати
    string[] definedWords = { "кіт", "котик", "кішка" };

    // Регулярний вираз для знаходження всіх форм визначених слів
    string pattern = string.Join("|", definedWords.Select(word => $@"\b{word}\w*"));

    // Замінюємо відповідні слова на новий текст (наприклад, "кіт" на "***")
    string filteredText = Regex.Replace(input, pattern, "***", RegexOptions.IgnoreCase);

    return filteredText;
}

