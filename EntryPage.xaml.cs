namespace UIControls;

public partial class EntryPage : ContentPage
{
	public EntryPage()
	{
		InitializeComponent();
        TxtPassword.Focus();
	}

    private void TxtName_Completed(object sender, EventArgs e)
    {

    }

    private void TxtName_DescendantAdded(object sender, ElementEventArgs e)
    {

    }

    private void TxtName_DescendantRemoved(object sender, ElementEventArgs e)
    {

    }


    private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
    {
        TxtName.Text = e.NewTextValue.ToString();
    }

    private void TxtName_Unfocused(object sender, FocusEventArgs e)
    {
        TxtName.Text = "123";
    }

    private void TxtName_Focused(object sender, FocusEventArgs e)
    {

    }

    private void TxtPassword_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void TxtPassword_Focused(object sender, FocusEventArgs e)
    {

    }

    private void TxtPassword_Unfocused(object sender, FocusEventArgs e)
    {

    }
}