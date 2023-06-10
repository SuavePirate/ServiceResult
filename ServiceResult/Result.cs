﻿using System;
using System.Collections.Generic;

namespace ServiceResult
{
    /// <summary>
    /// Result model to contain data, result type, and errors
    /// </summary>
    public abstract class Result
    {
        public abstract ResultType ResultType { get; }
        public abstract List<string> Errors { get; }
    }
}
