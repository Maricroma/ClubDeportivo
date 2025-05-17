

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
		para saber si ya esta almacenado el postulante
	------------------------------------------------------- */	
	set existe = (select count(*) from cliente where where Dni = Doc);
	end if;
	
	if existe = 0 then	 
		cliente values(filas,Nombre,Apellido,Doc,Telefono,Email,FichaMedica,FechaInscripcion,EsSocio,Carnet,FechaProximoPago);
		set rta  = filas;
	else
		set rta = existe;
	end if;		 
    
end //
