// 10. 클래스



using System.Reflection.Metadata.Ecma335;

public class MainClass
{
    // Persdon Class Template
    public class Person
    {
        // 필드 or 멤버 변수 or global variable
        public string name;
        public int age;
        public int id;

        //생성자 Constructor : 인스턴싱 시 필드 초기화 or 메서드 실행
        public Person(string _name, int _age, int _id)
        {
            name = _name;
            age = _age;
            id = _id;

            Introduce();
        }

        public Person()
        {
            Introduce();
        }

        // 함수 x -> 메서드 o
        public void Introduce()
        {
            // 지역변수, local variable
            //int number = 10;
            //number = 20;
            //this.name = "이재형"; // 전역변수 name 사용
            Console.WriteLine("저는 " + this.name + "입니다.");

            //string name = "이성국";
            //Console.WriteLine(name);
        }
        public void Move()
        {

        }


    }

    public static void Main()
    {
        Person person1 = new Person(); // Instancing, 인스턴스화, 객체화, 메모리 할당
        // person1.name = "이성국"; // 변수의 초기화, Variable Initialization
        // person1.Introduce();

        // 실습 5. 클래스 생성자를 사용하여 5명의 사람 클래스 인스턴싱
        Person person2 = new Person("이생국", 30, 1);
        Person person3 = new Person("이셩국", 40, 2);
        Person person4 = new Person("이쉥국", 50, 3);
        Person person5 = new Person("히성국", 20, 4);
        Person person6 = new Person("위성국", 10, 5);

        List<string> bookList = new List<string>();
        List<Person> personList = new List<Person>();
        // 실습 7. 아래의 내용으로 도서 클래스 만들고, 라이브러리 (Dictionary)에 도서 3권 저장
        // 도서명, 저자, 출판사, 일련번호, 출판일, 도서관에서의 위치, 도서 대여여부 ...

        Book book1 = new Book("다이슨 자서전", "0,1");
        Book book2 = new Book("퓨쳐셀프", "0,2");
        List<Book> books = new List<Book>();
        books.Add(book1);
        books.Add(book2);


        bool isExist = books.Contains(new Book("다이슨 자서전", ""));
        if (isExist)
        {
            Console.WriteLine("존재합니다");
        }
        Book bookFound = books.Find(x => x.name.Contains("퓨쳐셀프"));
        Console.WriteLine(bookFound.location);

        // 실습8. 도서관에 책 등록 시스템 구성
        List<Book> books2 = new List<Book>();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("책 등록하겠습니다");
            int statusNumber = 7;
            Book book = new Book();

            for (int status = 0; status < statusNumber; status++)
            {
                string input = "";

                switch (status)
                {
                    case 0:
                        Console.WriteLine("책 이름을 입력해주세요");
                        input = Console.ReadLine();
                        book.name = input;
                        break;
                    case 1:
                        Console.WriteLine("작가를 입력해주세요");
                        input = Console.ReadLine();
                        book.author = input;
                        break;
                    case 2:
                        Console.WriteLine("출판사를 입력해주세요");
                        input = Console.ReadLine();
                        book.company = input;
                        break;
                    case 3:
                        Console.WriteLine("일련번호를 입력해주세요");
                        input = Console.ReadLine();
                        book.serialNumber = int.Parse(input);
                        break;
                    case 4:
                        Console.WriteLine("출판일을 입력해주세요");
                        input = Console.ReadLine();
                        book.publicationDate = DateTime.Now;
                        break;
                    case 5:
                        Console.WriteLine("책의 위치를 입력해주세요");
                        input = Console.ReadLine();
                        book.location = input;
                        break;
                    case 6:
                        Console.WriteLine("대여 상태를 입력해주세요");
                        input = Console.ReadLine();
                        bool isCheckedOut = book.isCheckedOut;
                        break;
                    case 10:
                        isRunning = false;
                        break;
                }
            }
            book.ShowInformation();
            book.ShowInformation(1, DateTime.Now);
            string retuenValue = book.ShowInformation(4);
            Console.WriteLine(retuenValue);


            Console.WriteLine($"{book.name}, {book.author}, {book.company}, {book.publicationDate},{book.location},{book.isCheckedOut}");
            books2.Add(book);
            Console.WriteLine("책 등록이 완료되었습니다.");
        }
        // 도서의 이름을 입력하세요
        // 삼국지
        // 도서의 위치를 입력하세요
        // 1, 5
        // 1번 눌러서 도서 검색 (도서 이름 또는 위치 검색)
        // 도서의 정보를 출력 (삼국지, 1,5)

    }
    public class Book
    {
        public string name;
        public string author;
        public string company;
        public int serialNumber;
        public DateTime publicationDate;
        public string location;
        public bool isCheckedOut;

        public Book(string name, string location)
        {
            this.name = name;
            this.location = location;

        }
        public Book()
        {

        }

        public void ShowInformation()
        {
            Console.WriteLine($"{this.name}, {this.author}");
        }

        public void ShowInformation(int name, DateTime dateTime)
        {
            Console.WriteLine("리턴타입 없음");
        }

        public string ShowInformation(int name)
        {
            string result = "리턴타입 있음";

            return result;
        }
    }

}