/*
 * Pavel Dev
 * GitHub: PavelDev91
 * E-mail: PavelDev1991@gmail.com
 */

using System;
using System.Globalization;

namespace _MyConsole
{
    class MyConsole
    {
        //-----------------------------------------------------
        private struct _MyConsole_Position
        {
            public int L;
            public int T;

            public int Width;
            public int Height;
        }
        //-----------------------------------------------------
        private _MyConsole_Position MyConsole_Position;

        private char?[,] WorkArray;
        private char?[,] BufferArray;
        //-----------------------------------------------------
        public MyConsole(int L, int T, int Width, int Height)
        {
            MyConsole_Position = new _MyConsole_Position();

            MyConsole_Position.L = L;
            MyConsole_Position.T = T;

            MyConsole_Position.Width = Width;
            MyConsole_Position.Height = Height;

            WorkArray = new char?[Width, Height];
            BufferArray = new char?[Width, Height];

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    WorkArray[x, y] = null;
                    BufferArray[x, y] = null;
                }
            }
        }
        //-----------------------------------------------------
        public void Draw()
        {
            for (int x = 0; x < MyConsole_Position.Width; x++)
            {
                for (int y = 0; y < MyConsole_Position.Height; y++)
                {
                    if (WorkArray[x, y] == null)
                    {
                        continue;
                    }

                    if (BufferArray[x, y] == WorkArray[x, y])
                    {
                        continue;
                    }

                    BufferArray[x, y] = WorkArray[x, y];

                    Console.SetCursorPosition(MyConsole_Position.L + x, MyConsole_Position.T + y);

                    Console.Write(WorkArray[x, y]);
                }
            }
        }
        //-----------------------------------------------------
        public void Write(int L, int T, string Value)
        {
            for (int i = 0; i < Value.Length; i++)
            {
                if (L + i > MyConsole_Position.Width - 1 | T > MyConsole_Position.Height - 1)
                {
                    break;
                }

                WorkArray[L + i, T] = Value[i];
            }
        }
        //-----------------------------------------------------
        public string WriteRead(int L, int T, string Mask, int MaxLength, string DefaultValue = "")
        {
            string res = DefaultValue;

            ConsoleKeyInfo PressKey;

            Console.CursorVisible = false;

            while (true)
            {
                //---------------------------------------------
                Console.CursorVisible = false;

                Write(L, T, res);

                Draw();

                Console.SetCursorPosition(MyConsole_Position.L + L + res.Length, MyConsole_Position.T + T);

                Console.CursorVisible = true;
                //---------------------------------------------

                PressKey = Console.ReadKey(true);

                for (int i = 0; i < Mask.Length; i++)
                {
                    if (res.Length == MaxLength)
                    {
                        break;
                    }

                    if (CharUnicodeInfo.GetUnicodeCategory(PressKey.KeyChar) == CharUnicodeInfo.GetUnicodeCategory(Mask[i]))
                    {
                        res += PressKey.KeyChar;

                        break;
                    }
                }

                if (PressKey.Key == ConsoleKey.Backspace)
                {
                    if (res.Length > 0)
                    {
                        Write(L + res.Length - 1, T, " ");

                        res = res.Substring(0, res.Length - 1);
                    }
                }

                if (PressKey.Key == ConsoleKey.Enter)
                {
                    break;
                }

                if (PressKey.Key == ConsoleKey.Escape)
                {
                    res = "";

                    break;
                }
            }

            Draw();

            Console.CursorVisible = false;

            return res;
        }
        //-----------------------------------------------------
        public int GetWidth()
        {
            return MyConsole_Position.Width;
        }
        //-----------------------------------------------------
        public int GetHeight()
        {
            return MyConsole_Position.Height;
        }
        //-----------------------------------------------------
        public int? GetLineCount()
        {
            int? res = null;

            for (int y = 0; y < MyConsole_Position.Height; y++)
            {
                res = null;

                for (int x = 0; x < MyConsole_Position.Width; x++)
                {
                    if (WorkArray[x, y] != null)
                    {
                        res = -1;

                        break;
                    }
                }

                if (res == null)
                {
                    return y;
                }
            }

            return res;
        }
        //-----------------------------------------------------
        public void ClearLine(int LineIndex)
        {
            for (int x = 0; x < MyConsole_Position.Width; x++)
            {
                WorkArray[x, LineIndex] = null;
                BufferArray[x, LineIndex] = null;

                Console.SetCursorPosition(MyConsole_Position.L + x, MyConsole_Position.T + LineIndex);
                Console.Write(' ');
            }
        }
        //-----------------------------------------------------
        public void Clear()
        {
            for (int x = 0; x < MyConsole_Position.Width; x++)
            {
                for (int y = 0; y < MyConsole_Position.Height; y++)
                {
                    WorkArray[x, y] = null;
                    BufferArray[x, y] = null;

                    Console.SetCursorPosition(MyConsole_Position.L + x, MyConsole_Position.T + y);
                    Console.Write(' ');
                }
            }
        }
        //-----------------------------------------------------
    }
}
