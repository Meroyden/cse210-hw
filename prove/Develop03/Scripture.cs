public class Scripture{


    private string fullScripture="And all these things, of which I have spoken, were done as my father dwelt in a tent, in the valley of Lemuel. ";
    Word w=new();
    
    public Scripture(){}

    public string getScripture(){
        return fullScripture;
    }
    public void splitScripture(){
        string[] scriptureArray=fullScripture.Split(" ");
        foreach(string wordstuff in scriptureArray){
           w.FillThing(wordstuff);
        }
    }

}