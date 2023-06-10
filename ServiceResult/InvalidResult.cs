using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceResult
{
    /// <summary>
    /// Invalid result.
    /// </summary>
    public class InvalidResult<T> : Result<T>
    {
        private List<string> _errors;
        public InvalidResult(string error)
        {
            _errors = new List<string>();

            if (!string.IsNullOrEmpty(error))
            { 
                _errors.Add(error);
            }
        }

        public InvalidResult(List<string> errors)
        { 
            _errors = errors;
        }

        public override ResultType ResultType => ResultType.Invalid;

        public override List<string> Errors => (_errors != null && _errors.Any()) ? _errors : new List<string> { "The input was invalid." };

        public override T Data => default(T);
    }
}
