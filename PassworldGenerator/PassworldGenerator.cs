
namespace PassworldGenerator
{
    public partial class MainForm : Form, IView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int PassworldLength => (int)passworldLength.Value;

        public bool Uppercase => uppercaseCheck.Checked;

        public bool Lowercase => lowercaseCheck.Checked;

        public bool Numbers => numbersCheck.Checked;

        public bool Symbol => symbolsCheck.Checked;

        public event Action GenerateTextEvent;
        public event Action<string> CopyResultText;

        public void SetResultText(string text)
        {
            resultText.Text = text;
        }

        public void GenerateText(object sender, EventArgs e)
        {
            GenerateTextEvent?.Invoke();
        }

        public void CopyText(object sender, EventArgs e)
        {
            CopyResultText?.Invoke(resultText.Text);
        }
    }
}
