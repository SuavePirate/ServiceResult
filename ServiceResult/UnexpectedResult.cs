using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceResult
{
    /// <summary>
    /// Unexpected result.
    /// </summary>
    public class UnexpectedResult<T> : Result<T>
    {
        private List<string> _errors;
        public UnexpectedResult(string error)
        {
            _errors = new List<string>();

            if (!string.IsNullOrEmpty(error))
            {
                _errors.Add(error);
            }
        }

        public UnexpectedResult(List<string> errors)
        {
            _errors = errors;
        }

        public UnexpectedResult()
        {

        }

        public override ResultType ResultType => ResultType.Unexpected;

        public override List<string> Errors => (_errors != null && _errors.Any()) ? _errors : new List<string> { "There was an unexpected problem." };

        public override T Data => default(T);
    }
}
