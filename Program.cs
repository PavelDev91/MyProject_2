/*
 * Pavel Dev
 * GitHub: PavelDev91
 * E-mail: PavelDev1991@gmail.com
 */

using System;

using _MyFunc;
using _MyConsole;

namespace MyProject_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetWindowSize(98, 44);
            Console.SetBufferSize(98, 44);

            Console.SetWindowPosition(0, 0);

            Console.Title = "GitHub: PavelDev91";
            //-------------------------------------------------

            #region Задание 1 (Ctrl + Shift + /)

            /*            Console.WriteLine("Вывод нечетных чисел: (1 - 99)");

                        for (int i = 1; i < 100; i+= 2)
                        {
                            Console.WriteLine("Число: " + i.ToString());
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 2 (Ctrl + Shift + /)

            /*            for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i.ToString());
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 3 (Ctrl + Shift + /)

            /*            string value;

                        while (true)
                        {
                            Console.WriteLine("Введите любое (целое) число!");

                            value = Console.ReadLine();

                            if (MyFunc.String_IntOrNotInt(value) == true & MyFunc.StringToInt(value) > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода!");

                                Console.WriteLine("Нажми любую клавишу!");

                                Console.ReadKey(true);

                                Console.Clear();
                            }
                        }

                        int x = 0;

                        for (int i = 1; i <= MyFunc.StringToInt(value); i++)
                        {
                            x += i;
                        }

                        Console.WriteLine("Сумма всех чисел: (от 1 до " + MyFunc.StringToInt(value) + ") = " + x.ToString());*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 4 (Ctrl + Shift + /)

            /*            int x = 7;

                        while (x <= 98)
                        {
                            Console.WriteLine(x.ToString());

                            x += 7;
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание 5 (Ctrl + Shift + /)

            /*            int[] FirstArray = new int[5];
                        int[] SecondArray = new int[5];

                        Random RandomValue = new Random();

                        string FArray = "First Array:  |";
                        string SArray = "Second Array: |";

                        int Sum_FArray = 0;
                        int Sum_SArray = 0;

                        for (int i = 0; i < 5; i++)
                        {
                            FirstArray[i] = RandomValue.Next(0, 100);
                            SecondArray[i] = RandomValue.Next(0, 100);

                            FArray += FirstArray[i].ToString() + "|";
                            Sum_FArray += FirstArray[i];

                            SArray += SecondArray[i].ToString() + "|";
                            Sum_SArray += SecondArray[i];
                        }

                        Sum_FArray /= 5;
                        Sum_SArray /= 5;

                        Console.WriteLine(FArray);
                        Console.WriteLine(SArray);

                        Console.WriteLine("(First Array) Среднее арифметическое: " + Sum_FArray.ToString());
                        Console.WriteLine("(Second Array) Среднее арифметическое: " + Sum_SArray.ToString());

                        if (Sum_FArray > Sum_SArray)
                        {
                            Console.WriteLine("Среднее арифметическое больше: (First Array > Second Array)");
                        }
                        else
                        {
                            Console.WriteLine("Среднее арифметическое больше: (Second Array > First Array)");
                        }

                        if (Sum_FArray == Sum_SArray)
                        {
                            Console.WriteLine("Средние арифметические равны: (First Array = Second Array)");
                        }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------

            #region Задание * (Ctrl + Shift + /)
/*
            Console.CursorVisible = false;

            MyConsole WorkConsole = new MyConsole(0, 0, Console.BufferWidth, Console.BufferHeight);

            ConsoleKeyInfo PressKey;

            //-------------------------------------------------
            void Menu()
            {
                WorkConsole.Write(2, 0, new string('-', Console.BufferWidth - 4));
                WorkConsole.Write((Console.BufferWidth - (4 + "| Работа с 2х мерным массивом |".Length)) / 2,
                1, "| Работа с 2х мерным массивом |");
                WorkConsole.Write(2, 2, new string('-', Console.BufferWidth - 4));

                WorkConsole.Write(2, 3, "| Создать массив | Press Key: '" + ConsoleKey.C.ToString() + "'");
                WorkConsole.Write(2, 4, "| Выход          | Press Key: '" + ConsoleKey.Escape.ToString() + "'");
                WorkConsole.Write(2, 5, new string('-', Console.BufferWidth - 4));

                WorkConsole.Draw();
            }
            //-------------------------------------------------

            char MenuPos = 'M';

            //-------------------------------------------------
            int[,] WorkArray = null;

            int? XCount = 0;
            int? YCount = 0;
            //-------------------------------------------------

            Menu();

            while (true)
            {
                PressKey = Console.ReadKey(true);

                //---------------------------------------------
                if (MenuPos == 'M')
                {
                    WorkArray = null;
                    XCount = null;
                    YCount = null;

                    Menu();
                    //-----------------------------------------
                    if (PressKey.Key == ConsoleKey.C)
                    {
                        MenuPos = 'C';
                    }
                }
                //---------------------------------------------
                if (MenuPos == 'C')
                {
                    //-----------------------------------------
                    WorkConsole.Write(2, 6, "| Введите размер 2х мерного массива!");
                    WorkConsole.Write(2, 7, "| 1е измерение (X) [от 1 - до 9]");
                    WorkConsole.Write(2, 8, new string('-', Console.BufferWidth - 4));
                    //-----------------------------------------
                    string s = "| 1е измерение (X) [от 1 - до 9]";

                    while (true)
                    {
                        WorkConsole.ClearLine(7);
                        WorkConsole.Write(2, 7, s);

                        XCount = MyFunc.StringToInt(WorkConsole.WriteRead(35, 7, "0", 1, "1"));

                        if (XCount >= 1 && XCount <= 9)
                        {
                            break;
                        }
                        else
                        {
                            Console.CursorVisible = false;

                            WorkConsole.ClearLine(7);
                            WorkConsole.Write(2, 7, "| Ошибка ввода!");
                            WorkConsole.Draw();

                            Console.ReadKey(true);

                            continue;
                        }
                    }
                    //-----------------------------------------
                    s = "| 2е измерение (Y) [от 1 - до 9]";

                    while (true)
                    {
                        WorkConsole.ClearLine(7);
                        WorkConsole.Write(2, 7, s);

                        YCount = MyFunc.StringToInt(WorkConsole.WriteRead(35, 7, "0", 1, "1"));

                        if (YCount >= 1 && YCount <= 9)
                        {
                            break;
                        }
                        else
                        {
                            Console.CursorVisible = false;

                            WorkConsole.ClearLine(7);
                            WorkConsole.Write(2, 7, "| Ошибка ввода!");
                            WorkConsole.Draw();

                            Console.ReadKey(true);

                            continue;
                        }
                    }
                    //-----------------------------------------

                    WorkConsole.ClearLine(6);
                    WorkConsole.ClearLine(7);
                    WorkConsole.ClearLine(8);

                    WorkConsole.Draw();

                    WorkArray = new int[(int)XCount, (int)YCount];

                    MenuPos = 'E';
                }
                //---------------------------------------------
                if (MenuPos == 'E')
                {
                    //-----------------------------------------
                    WorkConsole.Write(2, 3, "| Удалить массив | Press Key: '" + ConsoleKey.D.ToString() + "'");
                    WorkConsole.Write(2, 4, "| Выход          | Press Key: '" + ConsoleKey.Escape.ToString() + "'");
                    //-----------------------------------------

                    WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), new string('-', Console.BufferWidth - 4));

                    WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "| Заполнить случайными числами | Press Key: '" +
                                                                           ConsoleKey.R.ToString() + "'");

                    WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "| Найти кол-во + чисел         | Press Key: '" +
                                                                           ConsoleKey.P.ToString() + "'");

                    WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "| Найти кол-во - чисел         | Press Key: '" +
                                                                           ConsoleKey.M.ToString() + "'");

                    WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "| Сортировка (Min => Max)      | Press Key: '" +
                                                                           ConsoleKey.F.ToString() + "'");

                    WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "| Сортировка (Max => Min)      | Press Key: '" +
                                                                           ConsoleKey.B.ToString() + "'");

                    WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "| Инверсия                     | Press Key: '" +
                                                                           ConsoleKey.I.ToString() + "'");

                    WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), new string('-', Console.BufferWidth - 4));

                    WorkConsole.Draw();
                    //-----------------------------------------
                    Random RValue = new Random();

                    int l;

                    int y_pos = (int)WorkConsole.GetLineCount();

                    string vres;

                    while (true)
                    {
                        l = 0;
                        for (int x = 0; x < XCount; x++)
                        {
                            for (int y = 0; y < YCount; y++)
                            {
                                if (WorkArray[x, y].ToString().Length > l)
                                {
                                    l = WorkArray[x, y].ToString().Length;
                                }
                            }
                        }

                        l++;

                        int x_pos = (WorkConsole.GetWidth() - ((int)XCount * l)) / 2;

                        WorkConsole.Write(x_pos + 1, y_pos, "X =>");
                        WorkConsole.Write(x_pos - 5, y_pos + (int)YCount + 1, "Y ^");

                        int z = 1;
                        WorkConsole.Write(x_pos, y_pos + 1, "|");
                        for (int x = 0; x < XCount; x++)
                        {
                            vres = new string(' ', l - (x.ToString().Length + 1));
                            WorkConsole.Write(x_pos + z, y_pos + 1, x.ToString() + vres + "|");
                            z += l;
                        }

                        for (int y = 0; y < YCount; y++)
                        {
                            WorkConsole.Write(x_pos - 2, y_pos + y + 2, "|" + y.ToString() + "|");
                        }

                        z = 1;
                        for (int x = 0; x < XCount; x++)
                        {
                            for (int y = 0; y < YCount; y++)
                            {
                                vres = new string(' ', l - (WorkArray[x, y].ToString().Length + 1));
                                WorkConsole.Write(x_pos + z, y_pos + 2 + y, WorkArray[x, y].ToString() + vres + "|");
                            }

                            z += l;
                        }

                        WorkConsole.Draw();

                        PressKey = Console.ReadKey(true);

                        //-------------------------------------
                        int[] buf;

                        if (PressKey.Key == ConsoleKey.F || PressKey.Key == ConsoleKey.B)
                        {
                            buf = new int[(int)XCount];

                            for (int y = 0; y < YCount; y++)
                            {
                                for (int x = 0; x < XCount; x++)
                                {
                                    buf[x] = WorkArray[x, y];
                                }

                                if (PressKey.Key == ConsoleKey.F)
                                {
                                    MyFunc.IntArray_Sort(ref buf);
                                }

                                if (PressKey.Key == ConsoleKey.B)
                                {
                                    MyFunc.IntArray_Sort(ref buf, true);
                                }

                                for (int x = 0; x < XCount; x++)
                                {
                                    WorkArray[x, y] = buf[x];
                                }
                            }

                            int? y1 = WorkConsole.GetLineCount();
                            for (int y = y_pos; y < (int)y1; y++)
                            {
                                WorkConsole.ClearLine(y);
                            }

                            continue;
                        }
                        //-----------------------------------------------------------------------------------------------------
                        int res;

                        res = 0;
                        if (PressKey.Key == ConsoleKey.P)
                        {
                            for (int y = 0; y < YCount; y++)
                            {
                                for (int x = 0; x < XCount; x++)
                                {
                                    if (WorkArray[x, y] >= 0)
                                    {
                                        res++;
                                    }
                                }
                            }

                            int p = (int)WorkConsole.GetLineCount();

                            WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "Найдено + чисел: " + res);
                            WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "Нажми любую клавишу!");

                            WorkConsole.Draw();

                            int c = (int)WorkConsole.GetLineCount();

                            Console.ReadKey(true);

                            for (int i = p; i < c; i++)
                            {
                                WorkConsole.ClearLine(i);
                            }

                            continue;
                        }
                        //-------------------------------------
                        res = 0;
                        if (PressKey.Key == ConsoleKey.M)
                        {
                            for (int y = 0; y < YCount; y++)
                            {
                                for (int x = 0; x < XCount; x++)
                                {
                                    if (WorkArray[x, y] < 0)
                                    {
                                        res++;
                                    }
                                }
                            }

                            int p = (int)WorkConsole.GetLineCount();

                            WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "Найдено - чисел: " + res);
                            WorkConsole.Write(2, (int)WorkConsole.GetLineCount(), "Нажми любую клавишу!");

                            WorkConsole.Draw();

                            int c = (int)WorkConsole.GetLineCount();

                            Console.ReadKey(true);

                            for (int i = p; i < c; i++)
                            {
                                WorkConsole.ClearLine(i);
                            }

                            continue;
                        }
                        //-----------------------------------------------------------------------------------------------------
                        if (PressKey.Key == ConsoleKey.R)
                        {
                            for (int x = 0; x < XCount; x++)
                            {
                                for (int y = 0; y < YCount; y++)
                                {
                                    WorkArray[x, y] = RValue.Next(-99, 100);
                                }
                            }

                            int? y1 = WorkConsole.GetLineCount();
                            for (int y = y_pos; y < (int)y1; y++)
                            {   
                                WorkConsole.ClearLine(y);
                            }

                            continue;
                        }
                        //-------------------------------------
                        if (PressKey.Key == ConsoleKey.I)
                        {
                            for (int x = 0; x < XCount; x++)
                            {
                                for (int y = 0; y < YCount; y++)
                                {
                                    WorkArray[x, y] = MyFunc.IntNot(WorkArray[x, y]);
                                }
                            }

                            int? y1 = WorkConsole.GetLineCount();
                            for (int y = y_pos; y < (int)y1; y++)
                            {
                                WorkConsole.ClearLine(y);
                            }

                            continue;
                        }
                        //-------------------------------------

                        if (PressKey.Key == ConsoleKey.D)
                        {
                            WorkConsole.Clear();

                            MenuPos = 'M';
                            Menu();

                            break;
                        }

                        if (PressKey.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                    }
                }
                //---------------------------------------------
                if (PressKey.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }*/

            #endregion

            //-----------------------------------------------------------------------------------------------------------------
        }
    }
}
