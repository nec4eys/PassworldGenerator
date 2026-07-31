namespace PassworldGenerator
{
    internal interface IView
    {
        int PassworldLength { get; }

        bool Uppercase { get; }
        bool Lowercase { get; }
        bool Numbers { get; }
        bool Symbol { get; }

        event Action GenerateTextEvent;
        event Action<string> CopyResultText;

        void SetResultText(string text);

        void GenerateText(object sender, EventArgs e);
        void CopyText(object sender, EventArgs e);
    }
}
