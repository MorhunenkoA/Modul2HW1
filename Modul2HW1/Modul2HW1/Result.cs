using System;

namespace Modul2HW1
{
    public class Result
    {
        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }

        public Result(bool status)
        {
            Status = status;
        }

        public Result()
        {
        }

        public bool Status { get; set; }
        public string Message { get; set; }
    }
}