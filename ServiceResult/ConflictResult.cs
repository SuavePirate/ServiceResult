using System.Collections.Generic;

namespace ServiceResult
{
    public class ConflictResult<T> : Result<T>
    {
        private readonly string _error;
        public ConflictResult(string error)
        {
            _error = error;
        }
        public override ResultType ResultType => ResultType.Conflict;

        public override List<string> Errors => new List<string> { _error ??
            "The request could not be processed because of conflict in the request, " +
            "such as the requested resource is not in the expected state, " +
            "or the result of processing the request would create a conflict within the resource." };

        public override T Data => default(T);
    }
}
