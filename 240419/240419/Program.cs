// 8. 열거형


public enum Option
{
    RegisterBook=5,
    SearchBook,
    RegisterMember,
    SearchMember,
    MakeReservation
}

public class Student
{
    public static void Main()
    {
        Option op = Option.RegisterBook;

        switch (op)
        {
            case Option.RegisterBook:
                break; 
            case Option.SearchBook:
                break;
            case Option.RegisterMember:
                break;
            case Option.SearchMember:
                break;

        }
        if (op == Option.RegisterBook)
        {

        }

        

    }
}    


    
    
        
