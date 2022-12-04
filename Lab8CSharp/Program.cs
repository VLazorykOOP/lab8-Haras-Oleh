using System.Text.RegularExpressions;
Console.WriteLine("Лабораторна робота №8 ");

//*АРХІВ З УСІЄЇ РОБОТОЮ ПРИКРІПЛЕНИЙ В МУДЛІ ТА РОБОТА Є НАЯВНОЮ НА ГІТХАБ КЛАСРУМІ
Pochatok:
var vubir = 0;
do
{
Console.WriteLine("Оберiть,будь ласка,яке завдання даної лабораторної роботи,Ви бажаєте перевiрити?(цифрою вiд одного до п'яти): ");
vubir = int.Parse(Console.ReadLine());
} 
while (vubir > 5 || vubir < 1);

switch (vubir)
{
case 1:
{
static void zminuvach_riadkiv(string novuj_tekst, string nazva_fajlu, int riadok_do_redaguvannia)
{
string[] arrLine = File.ReadAllLines(nazva_fajlu);
arrLine[riadok_do_redaguvannia - 1] = novuj_tekst;
File.WriteAllLines(nazva_fajlu, arrLine);
}

string text = File.ReadAllText(@"C:\users\freed\source\repos\VLazorykOOP\lab8-Haras-Oleh\Lab8CSharp\file1.txt");
Regex regex = new Regex(@"[a-fA-F0-9]{2}\.[a-fA-F0-9]{2}\.[a-fA-F0-9]{2}\.[a-fA-F0-9]{2}");
MatchCollection matches = regex.Matches(text);
if (matches.Count > 0)
{
Console.WriteLine("\Кiлькiсть спiвпадiнь:" + matches.Count+"\n");
                
string output = @"C:\users\freed\source\repos\VLazorykOOP\lab8-Haras-Oleh\Lab8CSharp\rezultat1.txt";
if (File.Exists(output))
{
File.Delete(output);
}
using (streamWriter sw = File.CreateText(output))
{
foreach (Match match in matches)
{
Console.WriteLine(match.Value);
sw.WriteLine(match.Tostring());
}
}
}
else
{
Console.WriteLine("Тут немає спiвпадiнь =(");
}
}
break;

//завдання №2
    case 2:
{
string riadok = File.ReadAllText(@"C:\users\freed\source\repos\VLazorykOOP\lab8-Haras-Oleh\Lab8CSharp\file2.txt");
riadok = Regex.Replace(riadok, @"\b\w\b\W*", "", RegexOptions.IgnoreCase);
riadok = Regex.Replace(riadok, @"\ba.*?\b", "", RegexOptions.IgnoreCase);
riadok = Regex.Replace(riadok, @"\bb.*?\b", "", RegexOptions.IgnoreCase);
riadok = Regex.Replace(riadok, @"\bc.*?\b", "", RegexOptions.IgnoreCase);
riadok = Regex.Replace(riadok, @"\bd.*?\b", "", RegexOptions.IgnoreCase);
riadok = Regex.Replace(riadok, @"\be.*?\b", "", RegexOptions.IgnoreCase);
Console.WriteLine(riadok);

string output = @"C:\users\freed\source\repos\VLazorykOOP\lab8-Haras-Oleh\Lab8CSharp\rezultat2.txt";
if (File.Exists(output))
{
File.Delete(output);
}
using (streamWriter sw = File.CreateText(output))
{
sw.WriteLine(riadok);
}
}
break;

//завдання №3
case 3:
{
string riadok = File.ReadAllText(@"C:\users\freed\source\repos\VLazorykOOP\lab8-Haras-Oleh\Lab8CSharp\file3.txt");
char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
string[] slova = riadok.Split(delimiterChars);

            
string output = @"C:\users\freed\source\repos\VLazorykOOP\lab8-Haras-Oleh\Lab8CSharp\rezultat3.txt";
if (File.Exists(output))
{
File.Delete(output);
}
using (streamWriter sw = File.CreateText(output))
{
                
foreach (var slovo in slova)
{
var pomilka = 0;
for (int i = 0, j = slovo.Length-1; i < j; i++, j--)
{
if (slovo[i] != slovo[j])
{
pomilka++;
}
}
if (pomilka == 0 && slovo.Length > 1)
{
sw.WriteLine(slovo.Tostring());
}
}
}
}
break;

//завдання №4
case 4:
{
string input = @"C:\users\freed\source\repos\VLazorykOOP\lab8-Haras-Oleh\Lab8CSharp\file4.txt";
if (File.Exists(input))
{
File.Delete(input);
}
using (streamWriter sw = File.CreateText(input))
{
Console.WriteLine("Введiть параметр N: ");
uint number = uint.Parse(Console.ReadLine());
ulong[] phibonazi = new ulong[number];
for(int i = 0; i < phibonazi.Length; i++)
{   
if(i == 0)
{
phibonazi[i] = 0;
} else if (i == 1)
{
phibonazi[i] = 1;
} else if(i != 0 && i != 1)
{
phibonazi[i] = phibonazi[i - 1] + phibonazi[i - 2];
}
sw.WriteLine(phibonazi[i]);
if((i % 3 != 0) || (i == 0))
{
Console.WriteLine($"{i}. {phibonazi[i]}");
}
}
}
}
break;

//завдання 5
case 5:
{
if (Directory.Exists(@"D:\Temp\All"))
{
Directory.Delete(@"D:\Temp\All", true);
}

string durektoria = @"D:\Temp\Haras_Oleh1";
if (!Directory.Exists(durektoria))
{
Directory.CreateDirectory(durektoria);
} else if(Directory.Exists(durektoria))
{
Directory.Delete(durektoria,true);
Directory.CreateDirectory(durektoria);
}

string durektoria2 = @"D:\Temp\Haras_Oleh2";
if (!Directory.Exists(durektoria2))
{
Directory.CreateDirectory(durektoria2);
}
else if (Directory.Exists(durektoria2))
{
Directory.Delete(durektoria2,true);
Directory.CreateDirectory(durektoria2);
}

string t1 = @"D:\Temp\Haras_Oleh1\t1.txt";
if (File.Exists(t1))
{
File.Delete(t1);
}
using (streamWriter sw = File.CreateText(t1))
{
sw.WriteLine("Haras Oleh Vladovich, 2003 roku narodzhennia, misze prozhuvannia Boianchuk");
}

string t2 = @"D:\Temp\Haras_Oleh1\t2.txt";
if (File.Exists(t2))
{
File.Delete(t2);
}
using (streamWriter sw = File.CreateText(t2))
{
sw.WriteLine("Zal Vitalij Bogdanovich, 1990 roku narodzhennia, misze prozhuvannia Vinnuzia");
}


string t1riadok = File.ReadAllText(@"D:\Temp\Haras_Oleh1\t1.txt");
string t2riadok = File.ReadAllText(@"D:\Temp\Haras_Oleh1\t2.txt");


string t3 = @"D:\Temp\Haras_Oleh2\t3.txt";
if (File.Exists(t3))
{
File.Delete(t3);
}
using (streamWriter sw = File.CreateText(t3))
{
sw.WriteLine(t1riadok);
sw.WriteLine(t2riadok);
}

string t3riadok = File.ReadAllText(@"D:\Temp\Haras_Oleh2\t3.txt");

string[] infodir = Directory.GetFiles(dir);
for (int i = 0; i < infodir.Length; i++)
{
Console.WriteLine(infodir[i]);
Console.WriteLine(File.ReadAllText(infodir[i]));
}
string[] infodir2 = Directory.GetFiles(dir2);
for (int i = 0; i < infodir2.Length; i++)
{
Console.WriteLine(infodir2[i]);
Console.WriteLine(File.ReadAllText(infodir2[i]));
}

string t1copy = @"D:\Temp\Haras_Oleh2\t1.txt";
File.Copy(t1, t1copy, true);
string t2copy = @"D:\Temp\Haras_Oleh2\t2.txt";
File.Move(t2, t2copy, true);

string dir2rename = @"D:\Temp\All";
Directory.Move(dir2, dir2rename);
Directory.Delete(dir, true);

string[] info = Directory.GetFiles(dir2rename);
for(int i = 0; i < info.Length; i++)
{
Console.WriteLine(info[i]);
Console.WriteLine(File.ReadAllText(info[i]));
}
            
}
break;

default: Console.WriteLine("Щось пiшло не так!");
break;
}

Console.WriteLine("\nВведiть,будь ласка, число '0' для перевiрки iншого завдання, або ж будь-яку iншу цифру для закiнчення роботи програми: ");
var end = int.Parse(Console.ReadLine());
if (end == 0)
{
goto Pochatok;
}
else
{
return 0;
}
