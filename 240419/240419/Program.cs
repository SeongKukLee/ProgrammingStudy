// 3. 배열 연습

using System.Text;
using System.Threading.Channels;

int number1;
int number2;
int number3;

int[] numbers = new int[3]; // 배열의 크기를 정의

// 배열의 초기화 1
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3; 

int[] numbers2 = { 4, 5, 6 };           // 배열의 초기화 2
int[] numbers3 = new int[3]{ 4, 5, 6 };    // 배열의 초기화 3

//배열의 길이
int length = numbers.Length;
Console.WriteLine("배열의 길이 : " + numbers.Length);


//numbers.Reverse(); // 배열을 역순으로 바꿈 1,2,3 -> 3,2,1



// 3x3 배열의 2차원 선언
int[,] coordinates = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
Console.WriteLine("1,0의 값 : " + coordinates[0,1]);
Console.WriteLine("2,1의 값 : " + coordinates[2,1]);
Console.WriteLine("배열의 값 : " + coordinates.Length);

// 실습 1. 가로 3칸, 세로 2칸의 책꽂이에 문자열형 책 이름을 넣는다.
// 2번째 줄의 3번째열의 책 이름을 출력한다.

string[,] bookShelf =
{
    { "책1", "책2" , "책3" },
    { "책4", "책5" , "책6" },

};
bookShelf[1, 2] = "책60";
Console.WriteLine("두번째줄, 세번째열의 책 이름: " +bookShelf[1, 2]);

// 실습 2. 두 개 의 숫자와 연산자를 입력을 받아 사칙연산 계산기 만들기
Console.WriteLine("첫번째 숫자를 입력하시오");
string strA = Console.ReadLine();
Console.WriteLine("연산자를 입력하시오");
string oper = Console.ReadLine();
Console.WriteLine("두번째 숫자를 입력하시오");
string strB = Console.ReadLine();

int numberA = int.Parse(strA); //문자열을 숫자로 변환
int numberB = int.Parse(strB);
float result = 0;

switch (oper) // switch =  기능을 여러가지로 나열
{
    case "+":
        result = numberA + numberB;
        break;
    case "-":
        result = numberA - numberB;
        break;
    case "*":
        result = numberA * numberB;
        break;
    case "/":
        result = numberA / (float)numberB; // 입력값이 int 정수형이어도 (float)이라는 형 변환을 통해 실수 출력
        break;
}

Console.WriteLine(strA);
Console.WriteLine(oper);
Console.WriteLine(strB);

Console.WriteLine("값 = " + result);

