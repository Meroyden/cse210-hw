using System.Dynamic;

public class Reference{
    private string _book="1 Nephi";
    private int _chapter=10;
    private int _verse=16;
    private int _endVerse=16;
    private string _fullReference;



    public Reference(){}
    public Reference(string book, int chapter, int verse)
    {

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        
    }

    public string GetDisplayText()
    {
            if(_verse==_endVerse){

        _fullReference=$"{_book} {_chapter}:{_verse}";
        return _fullReference;

    }
    else{
   
        _fullReference=$"{_book} {_chapter}:{_verse}-{_endVerse}";
        return _fullReference;
    }
    }

}