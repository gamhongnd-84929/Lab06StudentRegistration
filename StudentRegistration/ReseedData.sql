/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

use StudentRegistration
go

INSERT INTO Departments([DepartmentCode],[DepartmentName]) VALUES('ACCT', 'Accounting');
INSERT INTO Departments([DepartmentCode],[DepartmentName]) VALUES('FINC', 'Finance');
INSERT INTO Departments([DepartmentCode],[DepartmentName]) VALUES('MKTG', 'Marketing');
INSERT INTO Departments([DepartmentCode],[DepartmentName]) VALUES('CSIS', 'Computing Studies and Information Systems');
go

INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Troy','Acosta','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Kevyn','Newman','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Lillith','Johnston','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Hayfa','Guerra','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Brenden','Norton','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Kevin','Best','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Shad','Malone','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Colleen','Nielsen','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Zane','May','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Garth','Newman','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Illiana','Baird','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Ariel','Guerra','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Lynn','Carroll','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Jeanette','Ratliff','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Reese','Quinn','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Herman','Serrano','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Sophia','Sutton','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Brett','Blair','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Hop','Vang','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Uta','Anthony','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Sean','Bates','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Lucas','Guy','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Pandora','Brock','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Virginia','Molina','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Drake','Black','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Fredericka','Fernandez','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Hoyt','Le','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Gavin','Logan','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Raja','Browning','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Beck','Oneil','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Erin','Ewing','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Keelie','Weiss','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Upton','Hewitt','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Marshall','Irwin','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Caleb','Hooper','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Simon','Harmon','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Elton','Turner','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Felicia','Puckett','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Jada','Kim','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Tatyana','Silva','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Hashim','Pacheco','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Skyler','Cherry','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Driscoll','Morris','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Quyn','Raymond','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Rhona','Marsh','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Nash','Sellers','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Wynne','Horn','MKTG');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Nathan','Cooke','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Sarah','Brady','CSIS');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Nehru','Carlson','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Macaulay','Bell','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Tanner','Morgan','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Leilani','Lloyd','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Wynne','Thompson','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Ivor','Fry','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Patience','Bennett','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Isaac','Duffy','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Sawyer','Guerra','ACCT');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Clementine','Lopez','FINC');
INSERT INTO Students([StudentFirstName],[StudentLastName],[StudentMajor]) VALUES('Hyacinth','Burch','ACCT');
go




