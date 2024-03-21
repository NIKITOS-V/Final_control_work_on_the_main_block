# Описание проекта
Данная работа необходима для проверки моих знаний и навыков по итогу прохождения первого блока обучения 
на программе Разработчик. В данном репозитории представлены решение задачи на языках программирования С# и Python
(последний по собственному желанию), блок-схема решения задачи на C#, а также разбор решения, с которым вы можете 
ознакомиться ниже.

# Условия задачи

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

# Разбор решения

## static void Main()
Этот метод вызывается при запуске программы.

* С помощью вывода текста в консоль программа просит пользователя ввести любую строку.
```text
Console.Write("Введите строку: ");
```
* С консоли считываются полученные данные. Строка разбивается на подстроки, в качестве разделителя используется пробел.
Полученные подстроки записываются в массив из строк.
```text
string[]  UserArray  = Console.ReadLine().Split();
```

* Определяется минимальное допустимое количество символов в строке.
```text
int LenShortStrings = 3;
```

* Функция __*[PrintResult](#-static-void-printresultstring-arrayofshortstrings)*__ 
* в удобном формате выводит в консоль массив из строк, полученный из функции
__*[FindShortStrings](#static-string-findshortstringsstring-userarray-int-lenshortstrings)*__.
```text
PrintResult(FindShortStrings(UserArray, LenShortStrings));
```

## static string[] FindShortStrings(string[] UserArray, int LenShortStrings)

Данная функция из имеющегося массива строк __*[UserArray](#static-void-main)*__ формирует и возвращает 
новый массив из строк, длина которых меньше, либо равна установленному в переменной 
__*[LenShortStrings](#static-void-main)*__ количеству символов. В качестве аргументов принимает пользовательский массив 
__*[UserArray](#static-void-main)*__ и минимальное допустимое количество символов в строке из переменной 
__*[LenShortStrings](#static-void-main)*__.

* Определяются массив из строк, индекс первого элемента массива, переменная для временного хранения строки из
пользовательского массива __*[UserArray](#static-void-main)*__.
```text
string[] ArrayOfShortStrings = new string[0];
int INDEX = 0;
string word;
```
* С помощью цикла программа проходит по всем элементам массива __*[UserArray](#static-void-main)*__, проводит проверку:
 элементы, не являющиеся пустой строкой, с допустимым количеством символов записываются в массив
__*ArrayOfShortStrings*__.  
```text
for (int index = 0; index < UserArray.Length; index++){
    word = UserArray[index];
            
    if ((word.Length <= LenShortStrings) && (word != "")){
        Array.Resize(ref ArrayOfShortStrings, ArrayOfShortStrings.Length+1);
        ArrayOfShortStrings[INDEX] = word;
        INDEX += 1;
    }
}
```
## static void PrintResult(string[] ArrayOfShortStrings)
Блок не влияет на решение. Его задачей является вывод элементов из ранее сформированного массива 
__*[ArrayOfShortStrings](#static-string-findshortstringsstring-userarray-int-lenshortstrings)*__ в том же виде, что и
Python. В качестве аргумента принимает массив 
__*[ArrayOfShortStrings](#static-string-findshortstringsstring-userarray-int-lenshortstrings)*__.

