//------------------------Блок вспомогательных методов-------------------------------------------------------------------
// запрос данных у пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    int num = int.Parse(Console.ReadLine() ?? "");
    return num;
}
// вывод в консоль результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

//-----------------------------------------------------------------------------------------------------------------------
/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""


// рекурсивный метод 
string NumMN(int N, int M)
{
    if (N>=M) return M.ToString();
    return N + NumMN(N+1,M);
}

int N = ReadData("Введите число N:");
int M = ReadData("Введите число M:");

string res = (M<N)?(NumMN(M,N)):(NumMN(N,M));  

PrintData("Натуральные числа от N до M ", res.ToString());

-----------------------------------------------------------------
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30


int SumMN(int M, int N)
{
    if (M >= N) return N;
    return M + SumMN(M + 1, N);
}


int M = ReadData("Введите число M:");
int N = ReadData("Введите число N:");

int res = (M<N)?(SumMN(M,N)):(SumMN(N,M));  


PrintData("Cумму натуральных элементов от N до M ", res.ToString());

//------------------------------------------------------------------------------------------------------------------------
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.

M = 2, N = 3 -> A(M,N) = 29

*/

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}
int M = ReadData("Введите число M:");
int N = ReadData("Введите число N:");

int res = Akkerman(M,N);
PrintData("Cумму натуральных элементов от N до M ", res.ToString());
