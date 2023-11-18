namespace Itmo.ObjectOrientedProgramming.Lab3;

public class Message
{
    private Message() { }

    public string? Title { get; init; }
    public string? Text { get; init; }
    public ImportanceLevels ImportanceFilter { get; init; }

    public class MessageBuilder
    {
        private string? _title;
        private string? _text;
        private ImportanceLevels _importanceFilter;

        public MessageBuilder SetTitle(string title)
        {
            _title = title;
            return this;
        }

        public MessageBuilder SetText(string text)
        {
            _text = text;
            return this;
        }

        public MessageBuilder SetLevel(ImportanceLevels filter)
        {
            _importanceFilter = filter;
            return this;
        }

        public Message Build()
        {
            return new Message()
            {
                Title = _title,
                Text = _text,
                ImportanceFilter = _importanceFilter,
            };
        }
    }
}
