// 7. 시간 지연 함수

using System.Runtime.InteropServices;

Console.WriteLine("시작");

Thread.Sleep(3000);

Console.WriteLine("종료");

// 실습
// 도서관리 시스템
// 기능 1. 도서등록 -> "퓨처셀프" "3,1" 입력-> Dictionary<string,string> library에 저장
// 기능 2. 도서검색 -> "퓨처셀프" 검색 -> 위치(3,1) 출력 -> library 사용 검색
// 기능 3. 회원등록 -> "회원명", "(임의)회원번호" -> Dictionary<string,string> members에 저장
// 기능 4. 예약대출
// 도서검색(빌려간 책(임의로 List에 정의)일 경우, "이름", "책 이름" Queue에 저장)->Queue<string> watings

// 입출력 예시
// 번호를 선택해 주세요(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)
// 0
// 도서명을 입력해주세요
// 퓨처셀프
// 도서 위치를 입력해주세요
// 3,1
// 등록이 완료되었습니다. 퓨처셀프(3,1)
// 번호를 선택해주세요(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)
// 1
// 도서 명 또는 도서 번호를 입력해주세요
// 퓨처셀프
// 퓨처셀프는 3,1에 있습니다.
// 번호를 선택해주세요(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)
// 3
// 회원 등록 페이지입니다. 회원 이름을 입력하세요
// 이성국
// 비밀번호를 입력하세요
// 1234
// 회원 등록이 완료되었습니다.
// 번호를 선택해주세요( 0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)

/*
while (true)
{


    Dictionary<string, string> lib = new Dictionary<string, string>();

    // 기능1
    Console.WriteLine("번호를 선택 해 주세요(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)");
    string status = Console.ReadLine();
    int inputNum = int.Parse(input);


    switch (status)
    {
        case "0":
            RegisterBook();
            break;

    }
}
*/
Dictionary<string, string> bookList = new Dictionary<string, string>();
Dictionary<string, string> memberList = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("번호를 선택해 주세요.(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)");
    string status = Console.ReadLine();
    switch(status)
    { 
        
        case "0":
        RegisterBook();
        break;
        case "1":
        SearchBook();
        break;
        case "2":
        RegisterMember();
        break;
        case "3":
        MakeReservation();
        break;
        default:
        Console.WriteLine("잘못 입력하였습니다. 다시 입력해 주세요.");
        break;
    }
}

// 기능 4. 예약대출
// 도서검색(빌려간 책(임의로 List에 정의)일 경우, "이름", "책 이름" Queue에 저장)->Queue<string> watings

void MakeReservation()
{
    Console.WriteLine("예약 대출하실 회원 명과 도서 명을 입력하세요");
    string memberName = Console.ReadLine();
    string bookName = Console.ReadLine();
    

    bool isRight = memberList.ContainsKey(memberName);
    if(isRight)
    {
        Console.WriteLine(memberName + "님" + bookName + " 예약되었습니다.");
    }
    else
    {
        Console.WriteLine("회원이 아닙니다");
    }

}

//기능 3. 회원등록 -> "회원명", "(임의)회원번호" -> Dictionary<string,string> members에 저장
void RegisterMember()
{
    Console.WriteLine(" 회원등록 페이지 입니다. 이름를 입력하세요");
    string memberName = Console.ReadLine();

    Console.WriteLine("비밀번호를 입력하세요.");
    string password = Console.ReadLine();

    memberList.Add(memberName, password);

    bool isRegister = memberList.ContainsKey(memberName);
    if (isRegister)
    {
        Console.WriteLine("회원등록이 완료되었습니다."+ "\n");
        Console.WriteLine("이름 :"+ memberName +",비밀번호 : "+ password);
    }

}

//기능 2. 도서검색 -> "퓨처셀프" 검색 -> 위치(3,1) 출력 -> library 사용 검색
void SearchBook()
{
    Console.WriteLine(" 도서 명 또는 도서 번호를 입력하세요");
    string bookName = Console.ReadLine();
    string bookLocation = bookList[bookName];
    Console.WriteLine("책의 위치는 :" + bookLocation + " 입니다.");
}


// 기능 1. 도서등록 -> "퓨처셀프" "3,1" 입력-> Dictionary<string,string> library에 저장
void RegisterBook()
{
    Console.WriteLine(" 등록하고자 하는 도서명을 입력해 주세요");
    string bookName = Console.ReadLine();

    Console.WriteLine("도서 위치를 입력해 주세요.");
    string bookLocation = Console.ReadLine();

    bookList.Add(bookName, bookLocation);

    bool isRegister = bookList.ContainsKey(bookName);
    if (isRegister)
    {
        Console.WriteLine("등록이 완료되었습니다." + bookName + " " + "(" + bookLocation + ")");
    }

}

