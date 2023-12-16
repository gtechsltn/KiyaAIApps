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
