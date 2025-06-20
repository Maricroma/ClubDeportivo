-- Creación de la base de datos 

DROP DATABASE IF EXISTS ClubDeportivo;
CREATE DATABASE ClubDeportivo;
USE ClubDeportivo;

-- Creación e inserción de datos de la tabla roles

CREATE TABLE roles(
RolUsu INT,
NomRol VARCHAR(30),
CONSTRAINT PRIMARY KEY(RolUsu)
);

INSERT INTO roles VALUES
(120,'Administrador'),
(121,'Empleado');

-- Creación e inserción de datos de la tabla usuario

CREATE TABLE usuario(
CodUsu INT AUTO_INCREMENT,
NombreUsu VARCHAR (20) UNIQUE,
PassUsu VARCHAR (15),
RolUsu INT,
Activo BOOLEAN DEFAULT TRUE,
CONSTRAINT pk_usuario PRIMARY KEY (CodUsu),
CONSTRAINT fk_usuario FOREIGN KEY(RolUsu) REFERENCES roles(RolUsu)
);

INSERT INTO usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
('admin','123456',120);

-- Creación de la tabla cliente

CREATE TABLE cliente (
    Id BIGINT PRIMARY KEY AUTO_INCREMENT,
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

-- Creación de la tabla cuota

CREATE TABLE cuota (
    Id BIGINT PRIMARY KEY AUTO_INCREMENT,
    ClienteId BIGINT NOT NULL,
    Fecha DATE NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    FormaPago VARCHAR(50) NOT NULL,
    
    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
        ON DELETE CASCADE
);

-- Creación e inserción de datos de la tabla actividad

CREATE TABLE actividad (
    Id BIGINT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL
);

INSERT INTO actividad(Nombre, Precio) values
('Fútbol', 3500.00),
('Básquet', 3200.00),
('Tenis', 4000.00),
('Natación', 4500.00),
('Remo', 4600.00),
('Gimnasio', 3000.00),
('Yoga', 2800.00),
('Pilates', 2900.00),
('Zumba', 2700.00),
('Vóley', 3100.00);

-- Creación de la tabla pagoActividad

CREATE TABLE pagoActividad (
    Id BIGINT PRIMARY KEY AUTO_INCREMENT,
    ClienteId BIGINT NOT NULL,
    Fecha DATE NOT NULL,
    ActividadId BIGINT NOT NULL,

    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
        ON DELETE CASCADE,
    FOREIGN KEY (ActividadId) REFERENCES Actividad(Id)
        ON DELETE CASCADE
);

--------------------- PROCEDURE LOGIN -------------------------
/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracter 
*************************************************   */

delimiter //  
create procedure LoginUsuario(in Usu varchar(20),in Pass varchar(15))

/* =============================================================================
Se colocan dos parametros de entrada:
uno para el nombre de usuario y el otro para la contraseña
observar que la longitud debe ser igual que la longitud del atributo de la tabla
===================================================================================  */
BEGIN
  SELECT u.CodUsu, u.NombreUsu, u.PassUsu, r.NomRol
  FROM usuario u
  INNER JOIN roles r ON u.RolUsu = r.RolUsu
  WHERE u.NombreUsu = Usu
    AND u.PassUsu = Pass
    AND u.Activo = 1;
END 
//

/* ==========================
si queremos probar el procedure se usa call

call LoginUsuario('dato1', 'dato2')//

si los datos de los parametros existen la consulta arroja 1 FILA
si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */

--------------------- PROCEDURE ALTA DE CLIENTE -------------------------

delimiter // 

create procedure AltaCliente(in Nombre varchar(100),in Apellido varchar(100),in Doc varchar(20), in Telefono varchar(20), in Email varchar(50), in FichaMedica tinyint(1), in FechaInscripcion date, in EsSocio tinyint(1), in Carnet tinyint(1), in FechaProximoPago date, out rta int)

begin
	declare filas int default 0;
	declare existe int default 0;

	set filas = (select count(*) from cliente);
	if filas = 0 then
	set filas = 452; /* consideramos a este numero como el primer numero de cliente */
	else
	/* -------------------------------------------------------------------------------
	buscamos el ultimo numero de cliente almacenado para sumarle una unidad y
	considerarla como PRIMARY KEY de la tabla
___________________________________________________________________________ */
	set filas = (select max(Id) + 1 from cliente);
	
	/* ---------------------------------------------------------
		para saber si ya esta almacenado el cliente
	------------------------------------------------------- */	
	set existe = (select count(*) from cliente where Dni = Doc);
	end if;
	
	if existe = 0 then	 
		insert into cliente values(filas,Nombre,Apellido,Doc,Telefono,Email,FichaMedica,FechaInscripcion,EsSocio,Carnet,FechaProximoPago);
		set rta  = filas;
	else
		set rta = existe;
	end if;		 
    
end //



