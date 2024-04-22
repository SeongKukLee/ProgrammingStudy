// 6. if 제어문
/*
bool isActive = true;

if(isActive)
{
    Console.WriteLine("작동 중...");
}
else
{
    Console.WriteLine("정지 상태입니다.");
}

int number = 5;
if (number == 0 ) Console.WriteLine("");
else if (number != 0 ) Console.WriteLine("");
else if (number > 0 ) Console.WriteLine("");
else if (number < 0 ) Console.WriteLine("");
else if (number >= 0) Console.WriteLine("");
else if (number <= 0) Console.WriteLine("");

if (number == 0 && isActive == true)        Console.WriteLine("");
else if (number == 0 || isActive == false)  Console.WriteLine("");
else if (!isActive)                         Console.WriteLine("");

// 번호에 따른 시퀀스 작동
int status = 0;

switch(status)
{
    case 0:
        Console.WriteLine("0번 상태입니다.");
        break;
    case 1:
        Console.WriteLine("1번 상태입니다.");
        break;
    case 2:
        Console.WriteLine("2번 상태입니다.");
        break;
}
*/
// 실습3. PLC 5초 릴레이 신호등을 if문 또는 switch case 문으로 작성
// 조건 : status / 황색 0 적색 1 녹색 2
// M10, M11, M12 -> Console.Write("황색전구 on");
// Timer -> Console.Write("5초 Timer On")

for ( int status = 0; status < 3; status++)
{
    switch(status)
    {
        case 0:
            Console.WriteLine("황색 전구 on");
            break;
        case 1:
            Console.WriteLine("적색 전구 on");
            break;
        case 2:
            Console.WriteLine("녹색 전구 on");
            break;

    }
}