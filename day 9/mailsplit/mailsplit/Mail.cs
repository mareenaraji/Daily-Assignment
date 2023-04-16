using System;

namespace mailsplit
{
     class Mail
    {
        private long _id;
        private string _to;
        private string _from;
        private string _subject;
        private string _content;
        private DateTime _receivedDate;
        private double _size;

        public long Id
        {
            get { return _id; }
            set { _id = value; }    
        }
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        public string From
        {
            get { return _from; }
            set
            {
                _from = value;
            }
        }
        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
            }
        }
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
            }
        }
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set
            {
                _receivedDate = value;
            }
        }
        public double Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }
        public Mail()
        {

        }
        public Mail(long id, string to, string from, string subject, string content, DateTime receivedDate, double size, long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
        {
            Id = id;
            To = to;
            From = from;
            Subject = subject;
            Content = content;
            ReceivedDate = receivedDate;
            Size = size;
            Id = id;
            To = to;
            From = from;
            Subject = subject;
            Content = content;
            ReceivedDate = receivedDate;
            Size = size;
        }
        public override string ToString()
        {
            return string.Format("Id{0}\n To:{1}\n From:{2}\nSubject:{3}\n Content:{4}\n ReceivedDate:{5}\n Size:{6}\n",Id,To, From, Subject, Content, ReceivedDate.ToString("dd-MM-yyyy",null), Size.ToString("0.0"));
        }
        public override bool Equals(object obj)
        {
            return base.Equals(object obj)

        }
    }
}
