using System;

namespace repos.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public DateTime TimeStamp {get;set;}

        public Guid Id {get;set;}
    }
}