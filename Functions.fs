namespace FuncApp

open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Extensions.Http

module Functions =

    [<FunctionName("HelloWorld")>]
    let HelloWorld 
        ([<HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)>] request : HttpRequest) 
        (logger : ILogger) =
        
        OkObjectResult("Hello World!") :> IActionResult 