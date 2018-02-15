using System;
namespace Lands.Models
{
    public class Response
    {
        public bool IsSuccess
        {
            get;
            set;
        }

        public String Message
        {
            get;
            set;
        }

        public object Result
        {
            get;
            set;
        }

    }
}
