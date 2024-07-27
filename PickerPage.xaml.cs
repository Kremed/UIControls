namespace UIControls;

public partial class PickerPage : ContentPage
{
    string[] studentsList = new string[7]
    {
       "المعتصم بالله كريميد",
       "الياس بن شعبان",
       "رامي التقــاز",
       " احمد البوزيدي",
       "محمد الامير بدوي",
       "ســالم محمد حـافظ",
       "محمود جعفر محمود"
    };
    public PickerPage()
    {
        InitializeComponent();
        StudentsPicker.ItemsSource = studentsList;
    }

    private void StudentsPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        if (StudentsPicker.SelectedIndex != -1)
        {
            LblStudentResult.Text =
                "تم اختيار: " + StudentsPicker.Items[StudentsPicker.SelectedIndex] + " معرف الطالب: " + StudentsPicker.SelectedIndex;
        }
        else
        {
            LblStudentResult.Text = "الاسم المختار سيظهر هنا ..... ";
        }



        //if (StudentsPicker.SelectedItem is not null)
        //{
        //    LblStudentResult.Text =
        //      "تم اختيار: " + StudentsPicker.SelectedItem + " معرف الطالب: " + StudentsPicker.SelectedIndex;
        //}
    }
}