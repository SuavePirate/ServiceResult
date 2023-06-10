using System;
using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Result model to contain data, result type, and errors
    /// </summary>
    public abstract class Result<T> : Result
    {
        public abstract T Data { get; }
    }
}
