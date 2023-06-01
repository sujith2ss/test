
namespace Sample
{
    public enum Colours
    {
        Red,
        Green,
    }

    public partial class Test : ContentPage
    {
        private Colours _colourSelected;

        public List<Colours> colorTypes = new List<Colours>
        {
            Colours.Green, Colours.Red
        };

        public Test()
        {
            InitializeComponent();
            pickerColors.SelectedIndexChanged += pickerConnectionType_SelectedIndexChanged;
            var colourTypes = new List<string>
            {
                Colours.Green.ToString(), Colours.Red.ToString()
            };
            pickerColors.ItemsSource = colourTypes;
            pickerColors.SelectedIndex = 0;
        }

        void pickerConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(pickerColors.Items[pickerColors.SelectedIndex], out _colourSelected);
            labelColorName.Text = _colourSelected.ToString();
        }
    }
}
