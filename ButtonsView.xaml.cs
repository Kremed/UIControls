namespace UIControls;

public partial class ButtonsView : ContentPage
{
    public ButtonsView()
    {
        InitializeComponent();
    }
    int counter = 0;
    void OnButtonClicked(object sender, EventArgs e)
    {
        if (counter != 3)
        {
            DisplayAlert("Event Triggered", $"Button Clicked {counter}", "OK");
            counter = counter + 1;
            return;
        }
        //Clicked: يحدث عند النقر على الزر.
        DisplayAlert("Event Triggered", "Ok You are Here", "OK");
        counter = 0;
    }

    void OnButtonPressed(object sender, EventArgs e)
    {
        //Pressed: يحدث عند الضغط على الزر ولكن قبل تحريره.
        DisplayAlert("Event Triggered", "Button Pressed", "OK");
    }


    //Released: يحدث عند تحرير الزر بعد الضغط عليه.
    void OnButtonReleased(object sender, EventArgs e)
    {
        DisplayAlert("Event Triggered", "Button Released", "OK");
        myButton.IsVisible = true;
    }

    //Focused: يحدث عند تركيز الزر، مثلًا عندما يحصل على التركيز بواسطة لوحة المفاتيح أو اللمس.
    //void OnButtonFocused(object sender, FocusEventArgs e)
    //{
    //    DisplayAlert("Event Triggered", "Button Focused", "OK");
    //}

    //Unfocused: يحدث عند فقدان الزر للتركيز.
    //void OnButtonUnfocused(object sender, FocusEventArgs e)
    //{
    //    DisplayAlert("Event Triggered", "Button Unfocused", "OK");
    //}
}