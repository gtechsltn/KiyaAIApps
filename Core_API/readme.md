# DAL

- Dapper
	- COnneection
	- Query
		- CRUD Operations 
		- Async Methods
			- ExecuteAsync(Query, Parameters) 
			- Query()
	- The CLI Command
		- dotnet app pakage Dapper 
-  System.Data.SqlClient - v6.0.0

# API COntroller Guidelines

1. Model Validations
	- Domain Specific Validations
2. Security Check
3. Exceptions
4. Logging
5. Any such object that is directly used through HttpContext

# Blazor COmponents

1. Form Components
		- Type Def COmponents
			- Input Family
			InputText for string
			InputNumber for Number
			InputSelet for Collections
				USes the HTML option
			- Depending on @foreach loop to generate DOM 
			InputRAdio
			InputCheck
		- The  'value' property as '@bind-value' wth One-way-to-source binding
			- Listen to 'VauleChange' event and update the 'Model' property
			- ValueExpression and ValueChanged 
				- USed in Case of Explict Value Update  
				- ValueExpression, is an input from End-USer for value bound to Input Component
				- ValueChanged, is an event that emit the changed value to Form
	- EditForm
		- Mapped with HTML Form
		- Map with Action to Create an Instance of Model Object 


