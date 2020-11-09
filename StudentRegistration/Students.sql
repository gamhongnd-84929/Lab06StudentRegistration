CREATE TABLE [dbo].[Students]
(
	[StudentId] INT NOT NULL identity(1,1),
	[StudentFirstName] nvarchar(50) not null,
	[StudentLastName] nvarchar(50) not null,
	[StudentMajor] char(10) not null,
	constraint [PK_Students] primary key([StudentId]),
	constraint [FK_Students_Department] foreign key([StudentMajor]) references [Departments]([DepartmentCode])

)
