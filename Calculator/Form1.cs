namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool _IsOperationClicked = true;
        private bool _IsDotClicked = false;
        private bool _IsCalculateClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _IsCalculateClicked = false;
            _IsOperationClicked = true;
            _IsDotClicked = false;
            _IsCalculateClicked = false;
            textBoxDisplay.Text = string.Empty;
        }

        private void buttonDelChar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDisplay.Text) && !_IsCalculateClicked)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Substring(0, textBoxDisplay.Text.Length - 1);
            }
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (!_IsCalculateClicked)
            {
                Button button = (Button)sender;

                textBoxDisplay.Text += button.Text;

                _IsOperationClicked = false;
            }

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!_IsCalculateClicked)
            {
                StringToCommandConverter converter = new StringToCommandConverter();

                List<Command> commands = converter.Convert(textBoxDisplay.Text);

                Calculator calculator = new Calculator();

                textBoxDisplay.Text += " = " + calculator.GetResult(commands);

                _IsCalculateClicked = true;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!_IsDotClicked && !_IsCalculateClicked)
            {
                _IsDotClicked = true;
                textBoxDisplay.Text += '.';
            }
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            if ((!_IsOperationClicked || !_IsDotClicked) && !_IsCalculateClicked)
            {
                _IsDotClicked = false;
                _IsOperationClicked = true;
                Button button = (Button)sender;
                textBoxDisplay.Text += button.Text;
            }
        }
    }
}