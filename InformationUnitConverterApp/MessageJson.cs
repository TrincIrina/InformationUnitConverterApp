namespace InformationUnitConverterApp
{
    public class MessageJson
    {
        public string Message { get; set; } = string.Empty;
        public DateTime dateNow { get; set; }
        public MessageJson() { }
        public override string ToString()
        {
            return $"{Message} - {dateNow}";
        }
    }
}
