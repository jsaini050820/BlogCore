using System;

namespace blogcore.Models
{
    public class ErrorViewModel
    {
        //variables
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
