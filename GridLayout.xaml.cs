
namespace UIControls;

public partial class GridLayout : ContentPage
{
    public GridLayout()
    {
        InitializeComponent();
    }

    private void BtnButtonsPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ButtonsView());
    }

    private void BtnEntryPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new EntryPage());
    }

    private void BtnStackLayout_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new LayoutsPage());
    }

    private void BtnGridView_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new GridViewPage());
    }

    private void BtnGoImages_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ImagesPage());
    }

    private void BtnPicerPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new PickerPage());
    }

    private void BtnCalculator_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new CalculatorPage());
    }
}