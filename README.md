# JsConsole
Javascript console library for server-side Blazor projects.  Depends on Microsoft.JSInterop

# Usage
Available as a NuGet package.
```
Install-Package JsConsole
``` 
or 
```
dotnet add package JsConsole 
```
or add JsConsole.cs to your solution, and add `using JsConsole`.

Or just copy/paste the code.

In your Blazor code, inject an instance of IJSRuntime and pass this as the first argument to any call to JsConsole, like below:
```
@page "/"
@using JsConsole
@inject IJSRuntime js
 
<h1>Hello, world!</h1>

Welcome to your new app.

<SurveyPrompt Title="How is Blazor working for you?" />

<button @onclick="Warn">Warn</button>

@code {
    void Warn()
    {
        JsConsole.Warn(js, "warning");
    }
}
```
