namespace ServiceResult
{
    public enum ResultType
    {
        Ok,
        Unexpected,
        NotFound,
        Unauthorized,
        Invalid,

        Conflict,
        Created,
        Forbid,
        UnprocessableEntity
    }
}
