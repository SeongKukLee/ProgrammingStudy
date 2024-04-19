// 24.04.19 공부내용
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); // 한줄 주석 : Ctrl + K + C 
Console.WriteLine("Hello, World!"); // 한줄 주석 해제 : Ctrl + K + U
Console.WriteLine("Hello, World!"); // 영역 주석 : Ctrl + Shift + / /**/


int countNumber = 0; // camelCase (네이밍규칙)
int a = 10; // 나쁜 예시 주석을 최대한 안달아줘야 좋은 변수선언임
int totalNumber = 10;
bool isActive = true;

// 함수 이름은 동사
// 함수와 메서드의 차이
// 함수(function) : 클래스 외에서 사용 시
// 메서드(method) : 클래스 내부에서 사용 시
void Move()
{

}

void Rotate()
{

}
void LoopSystem() // PascalCase (네이밍규칙)
{
    for (int i = 0; i < a; i++)
    {
        countNumber++;
    }

    for (int i = 0;i < totalNumber; i++)
    {
        countNumber++;
    }
}

if (countNumber == 0)
{

    countNumber = 1;

    LoopSystem();
    
}

