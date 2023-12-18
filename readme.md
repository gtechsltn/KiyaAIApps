# Share Data Across COmponents

- Using Routing with Expliit Navigation
	- NavigationManager class
		- Navigate("URI", Loading of COmponent)
		- The URI of the COmponent aka @page MUST define the Route Parameter of 'int' type
		- The Target COmponent MUST define property that match with the name of the ROute Parameter
- Using the Blazor Session Storage or Blazor Local Storage
	- Install Nuget PAckages for Session and Location Storage 
- Push Data from Sender to Server using HTTP and load it from server to receiver using HTTP
	- HTTP Calls using HttpCLient and CORS
- Using CLient-Side Application State Management
	- DEfine a Singleton Registered Global Object
	- The State Property
		- a public/private object
	- A Notifier using and 'Action' Delegate (generally) 
		- Subscribed by Component to Notify the State Update
	- A Method that will be responsible to accept state from the Sender
		- THis method will Raise an event that will be subscribed by the Receiver 


# Blazor Need based Implementation cases
1. Using Lazy Loading (WASM as well as Server Hosted)
	- while using third-party component library
	- If a COmponent is Heavy Loaded
2. JS Interop
	- IJSRuntime
		- A JavaScript File loaded and used in WASM App
			- Refer file on index.html aftre blazor.webassembly.js load
				- Provide an instance of IJSRntime to Browser 
		- In Blazor Server Hosted App
			- Load  blazor.server.js file
			- The Custom JS file 



