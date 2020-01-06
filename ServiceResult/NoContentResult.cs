using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// No content result.
    /// </summary>
    public class NoContentResult : Result<object>
    {
        public NoContentResult()
        {
        }

        public override ResultType ResultType => ResultType.NoContent;

        public override List<string> Errors => new List<string>();

        public override object Data => default(object);
    }
}
