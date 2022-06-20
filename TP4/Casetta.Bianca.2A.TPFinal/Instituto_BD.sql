create database Instituto;
go
use Instituto;
go
create table Cursos
(
Nivel varchar(20) primary key not null,
Cuota int not null,
Horarios varchar(50) not null,
Docente varchar(50) not null
);
go
insert into Cursos (Nivel, Cuota, Horarios, Docente) values
('Primer_Año', 3000, 'Martes y Jueves 18hs','Esteban Laporte'),
('Segundo_Año', 3500, 'Lunes y Jueves 16hs','Laura Perez'),
('Tercer_Año', 4000, 'Miercoles y Viernes 16hs','Silvia Canelo'),
('Cuarto_Año', 4500, 'Viernes 15hs','Mariano Torres'),
('Quinto_Año', 5000, 'Martes y Miercoles 17hs','Osvaldo Alegre'),
('Sexto_Año', 5500, 'Jueves y Viernes 17hs','Alejandro Castiglione');
go
create table EstudiantesCurso
(
Nombre varchar(20) not null,
Apellido varchar(20) not null,
DNI int primary key not null,
Nivel_Curso varchar(20) foreign key references Cursos(Nivel) not null
);
go
insert into EstudiantesCurso (Nombre, Apellido, DNI, Nivel_Curso) values
('Abelard', 'Brannigan', 33581341,  'Primer_Año'),
('Gerrie', 'Cassedy', 44693784, 'Primer_Año'),
('Fawn', 'Tolerton', 52814400, 'Primer_Año'),
('Flossi', 'Porritt', 16312131, 'Segundo_Año'),
('Elnore', 'Rumin', 15301496, 'Segundo_Año'),
('Torin', 'Sansbury', 24319383, 'Tercer_Año'),
('Nissie', 'Winskill', 28296556, 'Tercer_Año'),
('Jacynth', 'Brecknall', 52268822, 'Cuarto_Año'),
('Sam', 'Speed', 54589614, 'Quinto_Año'),
('Gilles', 'Ailward', 10319701, 'Quinto_Año'),
('Nilson', 'Shrubshall', 19903597, 'Sexto_Año'),
('Rosina', 'Tapply', 43744444, 'Sexto_Año'),
('Bianca', 'Casetta', 39642326, 'Sexto_Año');