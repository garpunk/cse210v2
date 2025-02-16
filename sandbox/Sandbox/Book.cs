
using System.ComponentModel.Design;

public class Book
{
    private string _title;
    private string _author;
    private string _checkOutDate;


    public Book(string title, string author)
    {
        _title = title;

        _author = author;

        _checkOutDate = "";
    }

    public void checkOut() //set it internally and it doesn't really need to do anything
    {
       _checkOutDate = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public bool IsCheckedout()
    {
        bool isCheckedOut;

        if (_checkOutDate == "")
        {
            isCheckedOut = false;
        }
        else
        {
            isCheckedOut = true;
        }

        return isCheckedOut;

        //return _checkOutDate != ""; // this is a fancy way of doing this if else statement in one line
    }

    public void Display()
    {
        if (IsCheckedout())
        {
             Console.WriteLine($"{_title} byte {_author} checked out {_checkOutDate}");
        }
        else
        {
            Console.WriteLine($"{_title} by {_author}");
        }
    }


}
