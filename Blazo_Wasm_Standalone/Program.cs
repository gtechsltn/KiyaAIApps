using Blazo_Wasm_Standalone;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
// DEfault Host env.
var builder = WebAssemblyHostBuilder.CreateDefault(args);
/*
   the HTML DOM Interface to 'LoadComponent' aka The Render Tree
  The 'App' is root Component that managed 
1. RenderTree using UI Thread
2. All UI CHanges
 */
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// DI Container
// HttpClient
// 
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// USe the Origin for Blazor Wasm App to ACcess Remote API


// INitialize the .NET Runtime and Component depedencies to execute the app in browser 
await builder.Build().RunAsync();
