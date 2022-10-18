namespace MauiAppExpandableList;

public class Datas
{

    Dictionary<string, List<string>> dc { get; set; } = new Dictionary<string, List<string>>();

    Datas()
    {
        dc.Add("111111", new List<string>() { "aaaaa","bbbbbb"});
        dc.Add("222222", new List<string>() { "aaaaa","bbbbbb"});
    }
    
   
}
