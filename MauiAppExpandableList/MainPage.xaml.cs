namespace MauiAppExpandableList;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();

		var filtredFilds = new Dictionary<string, string[]>() ;
		filtredFilds.Add("test", new string[] { "123", "321", "123", "321" });
		filtredFilds.Add("test2", new string[] { "123", "321", "123", "321" });
		filtredFilds.Add("test3", new string[] { "123", "321", "123", "321" });
       
        ExpandableList1.FiltredFilds = filtredFilds.FirstOrDefault();
        //ExpandableList2.FiltredFilds = filtredFilds;
        //ExpandableList3.FiltredFilds = filtredFilds;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
	
	}
}

