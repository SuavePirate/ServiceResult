using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceResult
{
    /// <summary>
    /// Not found result.
    /// </summary>
    public class NotFoundResult<T> : Result<T>
    {
        private List<string> _errors;
        public NotFoundResult(string error)
        {
            _errors = new List<string>();

            if (!string.IsNullOrEmpty(error))
            {
                _errors.Add(error);
            }
        }

        public NotFoundResult(List<string> errors)
        {
            _errors = errors;
        }

        public override ResultType ResultType => ResultType.NotFound;

        public override List<string> Errors => (_errors != null && _errors.Any()) ? _errors : new List<string> { "The entity you're looking for cannot be found." };

        public override T Data => default(T);
    }
}
