using System.Threading.Tasks;

namespace FilpickerBug;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}



    private async void CounterBtn_Clicked(object sender, EventArgs e)
    {
		var res = await FilePicker.PickMultipleAsync();
		myLabel.Text = $"{res.Count()} files selected.";
    }
}

