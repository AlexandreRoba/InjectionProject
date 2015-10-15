namespace HelloCrowd.Events
{
    public class NewsCreated
    {
        public NewsCreated(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }

        public override string ToString()
        {
            return $"This is our news :{Message}";
        }
    }
}