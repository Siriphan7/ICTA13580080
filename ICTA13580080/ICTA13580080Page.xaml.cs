using Xamarin.Forms;

namespace ICTA13580080
{
    public partial class ICTA13580080Page : ContentPage
    {
        public ICTA13580080Page()
        {
            InitializeComponent();
            okButton.Clicked += OkButton_Clicked;


            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");


            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;

        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();

        }

        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
 