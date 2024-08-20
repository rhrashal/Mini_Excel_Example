1-  To start using MiniExcel in your .NET project, you can install it via NuGet.

		dotnet add package MiniExcel

2- 

    c#
	`
		using MiniExcelLibs;
		var employees = new List<dynamic>
		{
			new { EmployeeID = 1, Name = "Alice", Department = "HR" },
			new { EmployeeID = 2, Name = "Bob", Department = "IT" },
			new { EmployeeID = 3, Name = "Charlie", Department = "Finance" }
		};
		// Write the list to an Excel file
		MiniExcel.SaveAs("Employees.xlsx", employees);
	`