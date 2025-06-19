drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(26,'Mari2023','123456',120);

CREATE TABLE Cliente (
    Id BIGINT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Dni VARCHAR(20) NOT NULL UNIQUE,
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    FichaMedica BIT NOT NULL,
    FechaInscripcion DATE NOT NULL,

    -- Campo para distinguir entre Socio y NoSocio
    EsSocio BIT NOT NULL,

    -- Atributos exclusivos de Socio
    Carnet BIT,
    FechaProximoPago DATE
    -- Nota: No se incluyen listas (como Cuotas o Actividades) aquí,
    -- ya que se modelan con tablas relacionadas.
);

CREATE TABLE Cuota (
    Id BIGINT PRIMARY KEY,
    ClienteId BIGINT NOT NULL,
    Fecha DATE NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    FormaPago VARCHAR(50) NOT NULL,
    
    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
        ON DELETE CASCADE
);

CREATE TABLE Actividad (
    Id BIGINT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL
);

CREATE TABLE PagoActividad (
    Id BIGINT PRIMARY KEY,
    ClienteId BIGINT NOT NULL,
    Fecha DATE NOT NULL,
    ActividadId BIGINT NOT NULL,

    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
        ON DELETE CASCADE,
    FOREIGN KEY (ActividadId) REFERENCES Actividad(Id)
        ON DELETE CASCADE
);



