using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class CustomException: Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        ExceptionType type;
        public CustomException(ExceptionType type, string messege) : base(messege)
        {
            this.type = type;
        }
    }
}
