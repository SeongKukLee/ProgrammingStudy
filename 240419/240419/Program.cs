// 5. 컬렉션 연습 2
/*
Stack<int> numbers = new Stack<int>();
numbers.Push(10); // 값을 쌓아 올린다.
numbers.Push(100); 
numbers.Push(1000);


foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------");

int value = numbers.Pop(); // 쌓아 올린 값을 순서대로 꺼낸다
Console.WriteLine(value);

value = numbers.Pop();  // 쌓아올린 값을 순서대로 꺼낸다
Console.WriteLine(value);

value = numbers.Pop();  // 쌓아올린 값을 순서대로 꺼낸다
Console.WriteLine(value);
*/

// 실습 1 . 작업 (파워포인트)을 되돌리기 상태로 만들어주는 예제
// 특정 횟수만큼 파워포인트 각 작업 반복해서 넣고
// (넣는 과정이 끝나면) 1번 입력(되돌리기 버튼)을 누를 경우
// 되돌리기 작업과 현재 진행된 작업의 이름을 Stack에 쌓인 순서대로 출력


/*Stack<string> jobs = new Stack<string>();
Console.WriteLine("<Jobs List>");
jobs.Push("1. 삽입 메뉴 클릭");
jobs.Push("2. 표 아이콘 클릭");
jobs.Push("3. 표 크기 설정 및 표 생성");
jobs.Push("4. 0,0에 안녕하세요 입력");
jobs.Push("5. 0,1에 반갑습니다 입력");
jobs.Push("6. 저는 이성국 입니다. 입력");

foreach(string job in jobs)
{
    Console.WriteLine(job);
}
for (int i = 0; i <= jobs.Count; i++)
{

    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("명령을 입력해주세요. 되돌리기(1)을 입력해 주세요");
    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("아래 명령을 되돌렸습니다.");
        Console.WriteLine(jobs.Peek());

        jobs.Pop();
        Console.WriteLine("<Jobs List>");
        foreach (string job in jobs)
        {
            Console.WriteLine(job);
        }
    }
}





Queue<string> waitingPeople = new Queue<string>();
waitingPeople.Enqueue("이성국");
waitingPeople.Enqueue("이성국1");
waitingPeople.Enqueue("이성국2");

foreach(string people in waitingPeople)
{
Console.WriteLine(people);
}

string name = waitingPeople.Dequeue();
Console.WriteLine(name);

name = waitingPeople.Dequeue();
Console.WriteLine(name);

name = waitingPeople.Dequeue();
Console.WriteLine(name);
*/

//Queue 연습

/*
 실습2- Queue
도서관 대출자 대기열
1. 대출자 대기열에 맞춰 대출자의 이름과 도서의 이름을 대기열(Queue)에 등록
2. 도서관 직원이 대기열에 맞춰 대출목록에 업데이트

입출력예시
"대출자 이름을 입력하라"
이성국
"도서 권수를 입력하라"
2
"대출을 위한 도서 목록을 입력하라"
이재형
"대출을 위한 도서 목록을 입력하라"
이재형2

Queue에 들어갈 내용 -> 이름 : 이성국 \n 도서1. 이재형 \n 도서2. 이재형2

"도서가 등록 되었습니다."
이름 : 이성국
도서1. 이재형
도서2. 이재형2
*/

Queue<string> libraryQueue = new Queue<string>();
string totalInfo = "";

Console.WriteLine("대출자 이름을 입력하시오");
string name = Console.ReadLine();

Console.WriteLine("도서 권 수 를 입력하시오");
string bookNumber = Console.ReadLine();
int count = int.Parse(bookNumber); // 숫자로 만듦

totalInfo = name + "\n" + count + "\n";

for(int i = 0; i < count; i++)
{
    Console.WriteLine("대출을 위한 도서 목록을 입력하시오");
    string bookName = Console.ReadLine();
    totalInfo += bookName + "\n";
}

Console.WriteLine("입력된 내용은 아래와 같습니다.");
Console.WriteLine(totalInfo);
libraryQueue.Enqueue(totalInfo); // 1번 작동하는