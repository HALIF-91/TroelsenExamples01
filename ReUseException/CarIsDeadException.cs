using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseException
{
    public class CarIsDeadException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }

    // специальный тип исключения, соответствующий наилучшим рекомендациям .NET
    [Serializable]
    public class CustomRightException : ApplicationException
    {
        public CustomRightException() { }
        public CustomRightException(string message) : base(message) { }
        public CustomRightException(string message, Exception inner) : base(message, inner) { }
        protected CustomRightException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
