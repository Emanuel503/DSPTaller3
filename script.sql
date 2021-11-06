create database registroEnvios;
use registroEnvios;

create table empleado(
	idEmpleado int identity(1,1) not null primary key,
	nombre varchar(max)not null,
	documento varchar(max)not null ,
	fechaNacimiento varchar(max)not null,
	correo varchar(max)not null,
	areaTrabajo varchar(max)not null,
	sueldo float not null,
);

create table horario(
	idHorario int identity(1,1) not null primary key,
	tipo varchar(max) not null,
	cantidad int not null,
	costoHoraNormal float not null, 
	costoHoraExtra float not null,
);

create table horarioEmpleado(
	idHorarioEmpleado int identity(1,1) not null primary key,
	idEmpleado int foreign key references empleado(idEmpleado),
	idHorario int foreign key references horario(idHorario),
	mes varchar(max) not null,
	ano varchar(max) not null,
	semanaMes varchar(max) not null,
	horaExtraTrabajadas int not null,
);