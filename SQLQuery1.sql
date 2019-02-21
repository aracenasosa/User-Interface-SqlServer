
Create Table Usuarios(

IdUsuarios int not null Identity(1,1),
Nombre Varchar(100) not null,
Apellido Varchar(100) not null,
Sexo Char(1) Check(Sexo in ('M','F')),
Username Varchar(100) not null unique,
Pass Varchar(100) not null,
Identification_Card Varchar(14) unique,
Constraint pk_Usuario Primary Key(IdUsuario)

);

Insert Into Usuarios Values('Miguelito','Rosario','M','La real Melaza','1234','102-1578-4888');

Select * from Usuarios;