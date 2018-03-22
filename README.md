# ServiceResult
A set of models used to follow the service result pattern in C#. Allows for wrapping response data and/or errors in a single model. Use this to avoid bubbling exceptions to the client - great for Client side .NET development, and API development.

## Installation

It's on NuGet!

```
Install-Package ServiceResult
```
Or using the cli
```
dotnet add package ServiceResult
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
We created a NuGet package for that too!
```
Install-Package ServiceResult.ApiExtensions
```
Or using the cli
```
dotnet add package ServiceResult.ApiExtensions
```

Then use the extension method in your `Controller`:

``` csharp
using ServiceResult.ApiExtensions;

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
        return this.FromResult(result); // using extension
    }
}
```

## Contributing

Want a type of `Result<T>` that isn't here already? Create on yourself and contribute it back to the repository!

## Contributors

- Alex Dunn (https://github.com/SuavePirate)
- Patrick Dunn (https://github.com/patwritescode)
