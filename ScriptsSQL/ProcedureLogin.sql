
/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracater 
*************************************************   */

delimiter //  
create procedure LoginUsuario(in Usu varchar(20),in Pass varchar(15))

/* =============================================================================
Se colocan dos parametros de entrada por eso son in
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
====================================================== */

call LoginUsuario('dato1', 'dato2')//

/* ===============================
si los datos de los parametros existen la consulta arroja 1 FILA
si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */
