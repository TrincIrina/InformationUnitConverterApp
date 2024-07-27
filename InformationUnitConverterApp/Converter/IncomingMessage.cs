namespace InformationUnitConverterApp.Converter
{
    public class IncomingMessage
    {
        public string Initial { get; set; } = string.Empty;
        public string Convert { get; set; } = string.Empty;
        public double Amount { get; set; }
        public IncomingMessage() { }        
    }
}
