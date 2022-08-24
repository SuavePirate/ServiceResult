using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Unexpected result.
    /// </summary>
    public class UnexpectedResult<T> : Result<T>
    {

        private readonly string _error;
        public UnexpectedResult(string error)
        {
            _error = error;
        }
        public UnexpectedResult()
        {

        }
        public override ResultType ResultType => ResultType.Unexpected;

        public override List<string> Errors => new List<string> { _error ?? "There was an unexpected problem" };

        public override T Data => default(T);
    }
}
