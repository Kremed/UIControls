
namespace UIControls;

public partial class GridLayout : ContentPage
{
    public GridLayout()
    {
        InitializeComponent();
    }

    private async void BtnButtonsPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ButtonsView());
    }

    private async void BtnEntryPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new EntryPage());
    }

    private async void BtnStackLayout_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new LayoutsPage());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new GridViewPage());
    }
}