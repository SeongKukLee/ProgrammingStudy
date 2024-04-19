// 4. 컬렉션 연습

// 배열 : 고정형

string[] names = { "이재형", "이죄형", "이제형" };

// 리스트 : 가변형
List<string> names2 = new List<string>()
{
    "이재형",
    "이재형2",
    "이재형3"
};

Console.WriteLine(names[0]);
Console.WriteLine(names2[0]);
names2.Add("이재힝"); // List는 인덱스 추가가 가능함
Console.WriteLine(names2[3]);

// 배열의 반복
for(int i=0; i<names.Length; i++)
{
    Console.WriteLine(names[i]);
}

// 리스트의 반복
for (int i=0; i<names.Length; i++)
{
    Console.WriteLine(names2[i]);
}

// 리스트에서 이름찾기
int index = names2.BinarySearch("이재형");
Console.WriteLine("이재형은" + index + "번째에 있다.");

// 존재 여부 확인
bool isExist = names2.Contains("이재형");
if (isExist)
{
    Console.WriteLine("존재합니다.");
}

// 리스트를 정렬
names2.Sort();
for(int i =0; i < names2.Count; i++)
{
    Console.WriteLine(names2[i]);
}


// 딕셔너리: "example"(key), 5번째(value)
Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.Add("book", 0);
dictionary.Add("computer", 1);
dictionary.Add("mouse", 2);

index = dictionary["mouse"];
Console.WriteLine("mouse 는 " + index + "번째에 있습니다");
bool isContaing = dictionary.ContainsKey("book");
if(isContaing)
    Console.WriteLine("book이 존재합니다"); // if 한줄이면 {} 안써도됌

// 실습 2
// 도서관에 가로 4칸, 세로 3층의 책꽂이가 있습니다.
// (미리 책을 꽂아놓은 상태)
// 1. 각 책꽂이에 책을 추가하고
// 2. 특정 책의 이름을 입력받아 책의 위치를 출력하는 책꽂이 시스템을 만드세요.

// 예시
// 책의 이름을 입력하시오
// __
// 책의 위치는 (3,2)입니다.


/*
string[,] bookShelf =
{
    {"김씨", "이씨", "박씨", "정씨" },
    {"장씨", "민씨", "홍씨", "주씨" },
    {"황씨", "강씨", "소씨", "공씨" }
};
*/



Dictionary<string,string> lib = new Dictionary<string, string>();
lib.Add("김씨", "0,0");
lib.Add("이씨", "0,1");
lib.Add("박씨", "0,2");
lib.Add("정씨", "0,3");
lib.Add("장씨", "1,0");
lib.Add("민씨", "1,1");
lib.Add("홍씨", "1,2");
lib.Add("주씨", "1,3");
lib.Add("황씨", "2,0");
lib.Add("강씨", "2,1");
lib.Add("소씨", "2,2");
lib.Add("공씨", "2,3");


Console.WriteLine("책 이름을 입력하세요");
string bookname = Console.ReadLine();
string location = lib[bookname];
Console.WriteLine("책의 위치는 : " + location + "입니다.");



