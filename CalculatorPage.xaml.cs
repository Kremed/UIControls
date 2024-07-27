namespace UIControls;

public partial class CalculatorPage : ContentPage
{
    double FirstNumber = 0;
    double SecoundNumber = 0;
    string SelectedOperation = "";

    public CalculatorPage()
    {
        InitializeComponent(); 
        Btn0_Clicked(sender,e);
    }

    private void Btn0_Clicked(object sender, EventArgs e)
    {
        if (LblMoniter.Text == "0")
            return;

        LblMoniter.Text = LblMoniter.Text + "0";
    }

    private void Btn1_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "1";
    }
    private void Btn2_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "2";
    }
    private void Btn3_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "3";
    }

    private void Btn4_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "4";
    }
    private void Btn5_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "5";
    }


    private void Btn6_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "6";
    }
    private void Btn7_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "7";
    }
    private void Btn8_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "8";
    }

    private void Btn9_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = LblMoniter.Text + "9";
    }

    private void BtnClear_Clicked(object sender, EventArgs e)
    {
        LblMoniter.Text = "";
        LblHistory.Text = "";
        LblResult.Text = "";
        FirstNumber = 0;
        SecoundNumber = 0;
        SelectedOperation = "";
    }

    private void BtnPoint_Clicked(object sender, EventArgs e)
    {
        if (LblMoniter.Text == "")
        {
            LblMoniter.Text = "0.";
            return;
        }

        if (LblMoniter.Text.Contains("."))
        {
            return;
        }

        LblMoniter.Text = LblMoniter.Text + ".";

        //foreach (var charecter in LblMoniter.Text)
        //{
        //    if (charecter == '.')
        //    {

        //    }
        //}


    }

    private void BtnOperation_Clicked(object sender, EventArgs e)
    {
        //object aaa = new ContentPage();
        if (LblMoniter.Text == "")
            return;



        var OperationButton = sender as Button;

        SelectedOperation = OperationButton.Text;

        if (OperationButton.Text == "*")
        {

        }
        else if (OperationButton.Text == "/")
        {

        }
        else if (OperationButton.Text == "+")
        {
            if (FirstNumber == 0)
            {
                var isNumber = double.TryParse(LblMoniter.Text, out FirstNumber);

                LblHistory.Text = LblHistory.Text + " " + LblMoniter.Text + " " + SelectedOperation;

                LblMoniter.Text = "";
            }
            else
            {
                double.TryParse(LblMoniter.Text, out SecoundNumber);

                LblHistory.Text = LblHistory.Text + " " + LblMoniter.Text + " " + SelectedOperation;

                LblResult.Text = (FirstNumber + SecoundNumber).ToString();

                FirstNumber = (FirstNumber + SecoundNumber);

                SecoundNumber = 0;

                LblMoniter.Text = "";
            }

        }
        else if (OperationButton.Text == "-")
        {

        }


    }

    private void BtnEquel_Clicked(object sender, EventArgs e)
    {
        //TO DO ADD MATH LOGIC
        LblMoniter.Text = "";
        LblHistory.Text = LblResult.Text;

        SecoundNumber = 0;

        //LblMoniter.Text = "";
    }
}