CREATE TABLE [dbo].[Departments]
(	
	[DepartmentCode] char(10) unique,
	[DepartmentName] nvarchar(50) not null,
	constraint [PK_Department] primary key([DepartmentCode])
)
