using System.Text;

// Task 1
String source1 = "aabdbfbdbadfa";
String letter = "a";

int count = 0;
for (int i = source1.IndexOf(letter, 0); i < source1.Length; i = source1.IndexOf(letter, i + 1))
{
    if (i == -1) break;
    count++;
}
Console.WriteLine("1. " + count + "\n");

// Task 2
String source2 = "a * APBA", seq2 = " * ";
StringBuilder res2 = new StringBuilder();
foreach (var let in source2)
{
    if (let == ' ') continue;
    res2.Append(seq2).Append(let);
}
Console.WriteLine("2. " + res2.ToString().Trim() + "\n");

// Task 3
String source3 = "Тут знаходиться рядок у якому слова що почип нунан";
StringBuilder res3 = new StringBuilder();
foreach (String word in source3.Split(" "))
{
    String let1 = word.Substring(0, 1).ToLower();
    String let2 = word.Substring(word.Length - 1, 1).ToLower();
    if (let1.Equals(let2))
    {
        res3.Append(word).Append(" ");
    }
}
Console.WriteLine("3. " + res3 + "\n");

// Task 4
String source4 = "Тут знаходиться рядок у якому слова що почип нунан";
StringBuilder res4First = new StringBuilder(), res4Second = new StringBuilder();
int j = 0;
foreach (var word in source4.Split(" "))
{
    j++;
    if ((j & 1) == 1)
    {
        res4First.Append(word).Append(" ");
    }
    else
    {
        res4Second.Append(word).Append(" ");
    }
}
Console.WriteLine("4.\n" + res4First + "\n" + res4Second + "\n");
