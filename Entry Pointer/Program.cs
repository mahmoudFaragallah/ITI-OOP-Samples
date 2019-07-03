using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entry_Pointer
{
    class Employee
    {
        public string name;
        public string code;
    }
    unsafe class EntryPoint
    {
        public static void Main()
        {
            Employee e = new Employee();
            Console.SetCursorPosition(10, 10);
            Console.Write("Code:\t");
            e.code = GetStringFromUser(18, 10, 10, ConsoleColor.Red, ConsoleColor.White);
            Console.SetCursorPosition(30, 10);
            Console.Write("Name:\t");
            e.name = GetStringFromUser(38, 10, 15, ConsoleColor.Red, ConsoleColor.White);

            //Console.WriteLine(s);
            Console.ReadKey();
        }
        public static void PrintSpaces(int x, int y, int size, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.SetCursorPosition(x, y);

            // loop to set the space which will use in typing 
            for (int i = 0; i < size; i++)
            {
                Console.Write(" ");
            }
            Console.ResetColor();
        }
        public static string GetStringFromUser(int x, int y, int size, ConsoleColor backColor, ConsoleColor foreColor)
        {
            int cur = x;  // int to set the current pointion of curser 
            int end = x;  // int to set the end pointion of curser 

            //pointer to allocate space in memory to set vales from user 
            char* result = (char*)Marshal.AllocHGlobal((size + 1) * sizeof(char));
            char* pCur = result; // pointer to the current result 
            char* pEnd = result; // pointer to the end result 
            PrintSpaces(x, y, size, backColor);
            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;
            bool flag = true; // bool to control of the do while loop.

            do
            {
                Console.SetCursorPosition(cur, y);
                ConsoleKeyInfo cki = Console.ReadKey(true); // read input of the user 
                switch (cki.Key) //check every action of the user and set its condition
                {
                    case ConsoleKey.RightArrow:
                        if (cur < end) // to prevent curser get out of the scoop of the result pointer
                        {
                            cur++;
                            pCur++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (cur > x) // to prevent curser get out of the scoop of the result pointer
                        {
                            cur--;
                            pCur--;
                        }
                        break;
                    case ConsoleKey.Home:
                        cur = x;
                        pCur = result;
                        break;
                    case ConsoleKey.End:
                        cur = end;
                        pCur = pEnd;
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        *result = '\0'; // to clear the string of result pointer 
                        break;
                    case ConsoleKey.Enter:
                        flag = false;
                        *pEnd = '\0'; // to clear the string of result pointer 
                        break;
                    case ConsoleKey.Backspace:
                        break;
                    case ConsoleKey.Insert:
                        break;
                    case ConsoleKey.Delete:
                        break;
                    default:
                        // check if input of the user is letter , Digit or Spearator
                        if (char.IsLetterOrDigit(cki.KeyChar) || char.IsSeparator(cki.KeyChar))
                        {
                            if (cur < size + x) // prevent current curser to get out of the scoop of pointer
                            {
                                Console.Write(cki.KeyChar);
                                *pCur = cki.KeyChar;
                                if (cur == end)
                                {
                                    end++;
                                    pEnd++;
                                }
                                cur++;
                                pCur++;
                            }
                        }
                        break;
                }
            } while (flag);

            Console.ResetColor();
            string s = new string(result);
            return s;
        }
    }
}