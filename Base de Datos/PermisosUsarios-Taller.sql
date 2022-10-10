CREATE DATABASE PermisosTaller;

/*Tablas manipulables de la base de datos*/
CREATE TABLE productos(
CodigoBarras VARCHAR(100) PRIMARY KEY NOT NULL,
Nombre VARCHAR(100),
Descripcion VARCHAR(100),
Marca VARCHAR(100));

CREATE TABLE herramientas(
CodigoHerramienta INT PRIMARY KEY AUTO_INCREMENT,
Nombre VARCHAR(100),
Medida DOUBLE,
Marca VARCHAR(100),
Descripcion VARCHAR(100));

/*Usuarios y asignacion de permisos*/
CREATE TABLE usuarios(
idusuario INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(100),
apellidop VARCHAR(100),
apellidom VARCHAR(100),
fechanac DATE,
rfc VARCHAR(13),
contrasena VARCHAR(100));

CREATE TABLE asignacion_p(
idasignacion INT PRIMARY KEY AUTO_INCREMENT,
fkidusuario INT,
modulo VARCHAR(100),
permisolectura BOOLEAN,
permisoescritura BOOLEAN, 
permisoeliminacion BOOLEAN,
permisoactualizacion BOOLEAN,
FOREIGN KEY(fkidusuario) REFERENCES usuarios(idusuario));


/*Dando de alta el primer ususario junto con sus respectivos permisos de administrador*/
INSERT INTO usuarios VALUES(NULL,"admin","admin","admin","2002-06-06","admin","123");
INSERT INTO asignacion_p VALUES(NULL,1,"Refacciones",TRUE,TRUE,TRUE,TRUE),(NULL,1,"Taller",TRUE,TRUE,TRUE,TRUE);
/*Guardando la consulta utilizada para verificar la existencia del usuario en la parte del Login
SELECT COUNT(*) from usuarios where nombre='admin' AND contrasena="123";*/*/
/*Guardando la consulta para la validacion de permisos
SELECT permisolectura,permisoescritura,permisoeliminacion,permisoactualizacion FROM asignacion_p JOIN usuarios ON usuarios.idusuario=asignacion_p.fkidusuario WHERE usuarios.nombre='admin' AND usuarios.contrasena='123' AND asignacion_p.modulo='productos';*/

/*PROCEDIMIENTOS PARA USUARIO*/
/*GUARDAR Y ACTUALIZAR*/
delimiter ;;
CREATE PROCEDURE InsertOrUpdateUsuario(
IN p_nombre VARCHAR(100),
IN p_apellidop VARCHAR(100),
IN p_apellidom VARCHAR(100),
IN p_fechanac DATE,
IN p_rfc VARCHAR(13),
IN p_contrasena VARCHAR(100),
IN p_idusuario INT)
BEGIN 
DECLARE x INT;
SELECT COUNT(*) FROM usuarios WHERE idusuario=p_idusuario INTO X;
if X=0 AND p_idusuario<0 then
INSERT INTO usuarios VALUES(NULL,p_nombre,p_apellidop,p_apellidom,p_fechanac,p_rfc,p_contrasena);
ELSE if X=0 AND p_idusuario>0 then 
UPDATE usuarios SET nombre=p_nombre,apellidop=p_apellidop,apellidom=p_apellidom,fechanac=p_fechanac,rfc=p_rfc,contrasena=p_contrasena WHERE idusuario=p_idusuario;
ELSE
UPDATE usuarios SET nombre=p_nombre,apellidop=p_apellidop,apellidom=p_apellidom,fechanac=p_fechanac,rfc=p_rfc,contrasena=p_contrasena WHERE idusuario=p_idusuario;
END if;
END if;
END;;
/*ELIMINAR*/
delimiter ;;
CREATE PROCEDURE DeleteUsuario(
IN p_idusuario INT)
BEGIN
DELETE FROM usuarios WHERE idusuario=p_idusuario;
END;;
/*MOSTRAR*/
delimiter ;;
CREATE PROCEDURE ShowUsuario(
IN p_nombre VARCHAR(100))
BEGIN
SELECT idusuario AS 'ID',nombre AS 'Nombre del Usuario', apellidop AS 'Apellido paterno',apellidom AS 'Apellido materno',fechanac,rfc AS 'RFC',contrasena from usuarios WHERE nombre LIKE p_nombre ORDER BY nombre;
END;;

/*PROCEDIMIENTOS PARA ASIGNACION_P*/
/*GUARDAR Y ACTUALIZAR*/
delimiter ;;
CREATE PROCEDURE InsertOrUpdatePermisos(
IN p_fkidusuario INT,
IN p_modulo VARCHAR(100),
IN p_permisolectura BOOLEAN,
IN p_permisoescritura BOOLEAN, 
IN p_permisoeliminacion BOOLEAN,
IN p_permisoactualizacion BOOLEAN,
IN p_idasignacion INT)
BEGIN 
DECLARE x INT;
SELECT COUNT(*) FROM asignacion_p WHERE idasignacion=p_idasignacion INTO X;
if X=0 AND p_idasignacion<0 then
INSERT INTO asignacion_p VALUES(NULL,p_fkidusuario,p_modulo,p_permisolectura,p_permisoescritura,p_permisoeliminacion,p_permisoactualizacion);
ELSE if X=0 AND p_idasignacion>0 then 
UPDATE asignacion_p SET fkidusuario=p_fkidusuario,modulo=p_modulo,permisolectura=p_permisolectura,permisoescritura=p_permisoescritura,permisoeliminacion=p_permisoeliminacion,permisoactualizacion=p_permisoactualizacion WHERE idasignacion=p_idasignacion;
ELSE
UPDATE asignacion_p SET fkidusuario=p_fkidusuario,modulo=p_modulo,permisolectura=p_permisolectura,permisoescritura=p_permisoescritura,permisoeliminacion=p_permisoeliminacion,permisoactualizacion=p_permisoactualizacion WHERE idasignacion=p_idasignacion;
END if;
END if;
END;;
/*ELIMINAR*/
delimiter ;;
CREATE PROCEDURE DeletePermisos(
IN p_idasignacion INT)
BEGIN
DELETE FROM asignacion_p WHERE idasignacion=p_idasignacion;
END;;
/*MOSTRAR*/
delimiter ;;
CREATE PROCEDURE ShowPermisos(
IN p_usuario VARCHAR(100))
BEGIN
SELECT idasignacion AS 'ID',usuarios.nombre AS 'NOMBRE DEL USUARIO', modulo,permisolectura, permisoescritura,permisoeliminacion,permisoactualizacion 
FROM asignacion_p JOIN usuarios ON usuarios.idusuario=asignacion_p.fkidusuario WHERE usuarios.nombre LIKE p_usuario;
END;;


/*PROCEDIMIENTOS PARA PRODUCTOS*/
/*GUARDAR Y ACTUALIZAR*/
delimiter ;;
CREATE PROCEDURE InsertOrUpdateProductos(
IN p_CodigoBarras VARCHAR(100),
IN p_Nombre VARCHAR(100),
IN p_Descripcion VARCHAR(100),
IN p_Marca VARCHAR(100),
IN p_Opcion INT)
BEGIN 
DECLARE x INT;
SELECT COUNT(*) FROM productos WHERE CodigoBarras=p_CodigoBarras INTO X;
if X=0 AND p_Opcion<0 then
INSERT INTO productos VALUES(p_CodigoBarras,p_Nombre,p_Descripcion,p_Marca);
ELSE if X=0 AND p_Opcion>0 then 
UPDATE productos SET Nombre=p_Nombre,Descripcion=p_Descripcion,Marca=p_Marca WHERE CodigoBarras=p_CodigoBarras;
ELSE
UPDATE productos SET Nombre=p_Nombre,Descripcion=p_Descripcion,Marca=p_Marca WHERE CodigoBarras=p_CodigoBarras;
END if;
END if;
END;;
/*ELIMINAR*/
delimiter ;;
CREATE PROCEDURE DeleteProductos(
IN p_CodigoBarras VARCHAR(100))
BEGIN
DELETE FROM productos WHERE CodigoBarras=p_CodigoBarras;
END;;
/*MOSTRAR*/
delimiter ;;
CREATE PROCEDURE ShowProductos(
IN p_Nombre VARCHAR(100))
BEGIN
SELECT * FROM productos WHERE Nombre LIKE p_Nombre;
END;;

/*PROCEDIMIENTOS PARA HERRAMIENTAS*/
/*GUARDAR Y ACTUALIZAR*/
delimiter ;;
CREATE PROCEDURE InsertOrUpdateHerramientas(
IN p_Nombre VARCHAR(100),
IN p_Medida DOUBLE,
IN p_Marca VARCHAR(100),
IN p_Descripcion VARCHAR(100),
IN p_CodigoHerramienta INT)
BEGIN 
DECLARE x INT;
SELECT COUNT(*) FROM herramientas WHERE CodigoHerramienta=p_CodigoHerramienta INTO X;
if X=0 AND p_CodigoHerramienta<0 then
INSERT INTO herramientas VALUES(NULL,p_Nombre,p_Medida,p_Marca,p_Descripcion);
ELSE if X=0 AND p_CodigoHerramienta>0 then 
UPDATE herramientas SET Nombre=p_Nombre,Medida=p_Medida,Marca=p_Marca,Descripcion=p_Descripcion WHERE CodigoHerramienta=p_CodigoHerramienta;
ELSE
UPDATE herramientas SET Nombre=p_Nombre,Medida=p_Medida,Marca=p_Marca,Descripcion=p_Descripcion WHERE CodigoHerramienta=p_CodigoHerramienta;
END if;
END if;
END;;
/*ELIMINAR*/
delimiter ;;
CREATE PROCEDURE DeleteHerramientas(
IN p_CodigoHerramienta INT)
BEGIN
DELETE FROM herramientas WHERE CodigoHerramienta=p_CodigoHerramienta;
END;;
/*MOSTRAR*/
delimiter ;;
CREATE PROCEDURE ShowHerramientas(
IN p_Nombre VARCHAR(100))
BEGIN
SELECT * FROM herramientas WHERE Nombre LIKE p_Nombre;
END;;