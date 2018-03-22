# ServiceResult
A set of models used to follow the service result pattern in C#. Allows for wrapping response data and/or errors in a single model. Use this to avoid bubbling exceptions to the client - great for Client side .NET development, and API development.

## Installation

It's on NuGet!

```
Install-Package ServiceResult
```

## Usage

Use the different result models to create a verbose response:

``` csharp
// successful result
var myData = _someService.DoSomeStuff();
return new SuccessResult<MyData>(myData);
...

// error wrapped
try
{
    var myData = _someService.DoSomeStuff();
    if(myData == null)
    {
        return new NotFoundResult<MyData>("Can't find your data!");
    }
    
    return new SuccessResult<MyData>(myData);
}
catch(Exception ex)
{
    // do something with the error first like logging
    return new UnexpectedResult<MyData>(ex.Message);
}
```

Want to use this in your API and return the proper HTTP responses?

``` csharp
protected ActionResult FromResult<T>(Result<T> result)
{
    switch (result.Type)
    {
        case ResultType.Ok:
            return Ok(result.Data);
        case ResultType.NotFound:
            return NotFound(result.Errors);
        case ResultType.Invalid:
            return BadRequest(result.Errors);
        case ResultType.Unexpected:
            return BadRequest(result.Errors);
        case ResultType.Unauthorized:
            return Unauthorized();
        default:
            throw new Exception("An unhandled result has occurred as a result of a service call.");
    }
}
```

Then use it in your controller endpoint

``` csharp
public class MyController : Controller
{
    private readonly IMyService _service;
    public MyController(IMyService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        // returns a Result<T>
        var result = await _service.GetSomeData();
        return FromResult(result);
    }
}
```

## TODO

- Create extension NuGet package for HTTP messages as above

## Contributing

Want a type of `Result<T>` that isn't here already? Create on yourself and contribute it back to the repository!
