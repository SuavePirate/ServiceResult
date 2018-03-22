using System;
using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Invalid result.
    /// </summary>
    public class InvalidResult<T> : Result<T>
    {
        private string _error;
        public InvalidResult(string error)
        {
            _error = error;
        }
        public override ResultType Type => ResultType.Invalid;

        public override List<string> Errors => new List<string> { _error ?? "The input was invalid." };

        public override T Data => default(T);
    }
}
