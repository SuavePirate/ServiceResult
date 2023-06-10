﻿using System;
using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Invalid result.
    /// </summary>
    public class InvalidResult : Result
    {
        private string _error;
        public InvalidResult(string error)
        {
            _error = error;
        }
        public override ResultType ResultType => ResultType.Invalid;

        public override List<string> Errors => new List<string> { _error ?? "The input was invalid." };
    }
}
