create view [dbo].[DepartmentMajorCount] as
	select  [Departments].DepartmentName, count(*) as NumberOfMajors
	from [Departments] join [Students] on [Departments].DepartmentCode = [Students].StudentMajor
	group by [Departments].DepartmentName
	

