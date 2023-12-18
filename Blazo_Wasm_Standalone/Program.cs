using Blazo_Wasm_Standalone;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Services;
// DEfault Host env.
var builder = WebAssemblyHostBuilder.CreateDefault(args);
/*
   the HTML DOM Interface to 'LoadComponent' aka The Render Tree
  The 'App' is root Component that managed 
1. RenderTree using UI Thread
2. All UI CHanges
3. AN Interaction with DOM UI THread from Blazor
    3.a. The Blazor Object Model is Bound to UI Thread using .NET Web Assemby through dotnet.js
    - JavaSCript InterOp
 */
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// DI Container, used to make all Registration Available for UI THread for each StateChange
// HttpClient
// 
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// USe the Origin for Blazor Wasm App to ACcess Remote API

builder.Services.AddScoped<LazyAssemblyLoader>();

// REgister the Global State Object
builder.Services.AddSingleton<GlobalAppState>();


// INitialize the .NET Runtime and Component depedencies to execute the app in browser 
await builder.Build().RunAsync();
