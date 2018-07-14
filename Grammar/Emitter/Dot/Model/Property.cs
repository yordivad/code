namespace Mobilize.Grammar.Emitter.Dot.Model
{
    public class Property
    {
        public Property(string label, string value)
        {
            Label = label;
            Value = value;
        }

        public string Label { get; }

        public string Value { get; }
    }
}