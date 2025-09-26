using System; 
using static System.Console;

/*
    using << 뒤에 따라오는 ~을 사용하겠다.
    System << 기본적으로 필요로하는 클래스를 담고 있는 네임스페이스
    ; << 문장의 끝을 알리는 기호
    메소드 << 일련의 기능을 수행하는 명령어
    CLR <<  C# 프로그램을 실행해주는 또 다른 프로그램
    전입점 << 프로그램이 시작되는 첫 번째 코드
 */

namespace _2025_09_26
{
    class MainApp
    {
        // 프로그램이 시작되는 곳
        static void Main(string[] args)
        { 
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);
        }
    }
}
