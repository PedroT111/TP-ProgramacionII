
USE TP_PROGII2

CREATE TABLE materias(
id_materia int identity,
nombre_materia varchar(100),
CONSTRAINT PK_materia PRIMARY KEY (id_materia))

CREATE TABLE carreras(
id_carrera int,
nombre_carrera varchar(100),
CONSTRAINT PK_carrera PRIMARY KEY (id_carrera))

CREATE TABLE detalles_carrera(
id_detalle int identity,
anio_cursado int,
cuatrimestre int,
id_materia int not null,
id_carrera int not null,
CONSTRAINT PK_detalle PRIMARY KEY (id_detalle),
CONSTRAINT FK_det_materia FOREIGN KEY (id_materia) references materias (id_materia),
CONSTRAINT FK_det_carrera FOREIGN KEY (id_carrera) references carreras (id_carrera))

CREATE TABLE USERS(
id_usuario int not null,
usuario varchar(50),
pass varchar(50),
CONSTRAINT pk_user PRIMARY KEY (id_usuario))

--STORED PROCEDURE GET MATERIAS
CREATE PROCEDURE CONSULTAR_MATERIAS
AS
SELECT * FROM materias

--STORED PROCEDURE GET CARRERAS
CREATE PROCEDURE CONSULTAR_CARRERAS
AS
SELECT * FROM carreras


--STORED PROCEDURE INSERTAR DETALLE CARRERA
create PROCEDURE SP_INSERTAR_DETALLE_CARRERA 
	@anio_cursado int ,
	@cuatrimestre int, 
	@id_materia int, 
	@id_carrera int
AS
BEGIN
	INSERT INTO detalles_carrera(anio_cursado, cuatrimestre, id_materia, id_carrera)
    VALUES (@anio_cursado, @cuatrimestre, @id_materia, @id_carrera);  
END


--STORED PROCEDURE INSERTAR CARRERA
CREATE PROCEDURE [dbo].[SP_INSERTAR_CARRERA] 
	@nombre varchar(100), 
	@id_carrera int
AS
BEGIN
	INSERT INTO carreras(id_carrera, nombre_carrera)
    VALUES (@id_carrera, @nombre);	
END


INSERT INTO materias values ('Programacion I'), ('Programacion II'),('Programacion III'), ('Laboratorio I'), ('Laboratorio II'),
							('Laboratorio III'),('Ingles I'), ('Ingles II'),('Ingles III'), ('Estadistica'),('Matematica'),
							('Metodologia de Investigacion'), ('Arquitectura Sitemas Operativos'), ('Administracion Bases de Datos'),
							('Sistemas de Procesamiento de Datos'),('Organización Empresarial'),('Organización Contable'),
							('Legislación'), ('Metodología de Sistemas I'),('Ética Profesional'), ('Economía'), ('Gestión de Datos'),
							('Interfaz Gráfica de Usuario'), ('Técnicas de Dibujo'), ('Historia y Análisis de los Videojuegos'), 
							('Animación 1'), ('Edición de Imágenes Digitales'), ('Edición digital de Video'), ('Motores Gráficos'),
							('Laboratorio de Videojuegos'), ('Sonido y Musicalización'), ('Práctica Profesionalizante'), ('Animación 2'),
							('Animación 3'), ('Computación Aplicada')
INSERT INTO carreras values (1,'Tecnicatura en Programación'), (2,'Analista en Sistemas'), (3,'Tecnicatura en Simulaciones Virtuales')
INSERT INTO USERS(1, 'grupo6', '123456')

GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_CARRERAS]    Script Date: 4/11/2021 18:15:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CONSULTAR_CARRERAS]
AS
SELECT * FROM carreras

GO

CREATE PROCEDURE [dbo].[CONSULTAR_MATERIAS]
AS
SELECT * FROM materias

GO
CREATE PROC [dbo].[CREAR_MATERIA](  
@nombre_materia varchar(100)  
)  
AS  
BEGIN  
INSERT INTO materias values(@nombre_materia)  
END

GO
CREATE PROC [dbo].[DELETE_MATERIA]
@id_materia int
AS
BEGIN
DELETE FROM detalles_carrera WHERE id_materia = @id_materia
DELETE FROM materias WHERE id_materia = @id_materia
END
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_PLAN_POR_ID]
	@nro int	
AS
BEGIN
	SELECT *
	FROM carreras c, detalles_carrera dc, materias m
	WHERE c.id_carrera = dc.id_carrera
	AND m.id_materia = dc.id_materia
	AND c.id_carrera = @nro;
END
GO
CREATE PROC [dbo].[SP_EDITAR_CARRERA]
@id_carrera int, 
@nombre varchar(100)
AS 
BEGIN
UPDATE carreras
SET nombre_carrera = @nombre
WHERE id_carrera = @id_carrera
DELETE from detalles_carrera
WHERE id_carrera = @id_carrera
END
GO
CREATE PROC [dbo].[SP_EDITAR_MATERIA]
@id int,
@nombre varchar(100)
AS
BEGIN
UPDATE materias
SET nombre_materia = @nombre
WHERE id_materia = @id
END
GO
CREATE PROC [dbo].[SP_ELIMINAR_PLAN_DE_ESTUDIO]
@nro int
AS
BEGIN
	delete from detalles_carrera
	where id_carrera = @nro
	delete from carreras
	where id_carrera = @nro
END
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_CARRERA] 
	@nombre varchar(100), 
	@id_carrera int
AS
BEGIN
	INSERT INTO carreras(id_carrera, nombre_carrera)
    VALUES (@id_carrera, @nombre);	
END
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE_CARRERA] 
	@anio_cursado int ,
	@cuatrimestre int, 
	@id_materia int, 
	@id_carrera int
AS
BEGIN
	INSERT INTO detalles_carrera(anio_cursado, cuatrimestre, id_materia, id_carrera)
    VALUES (@anio_cursado, @cuatrimestre, @id_materia, @id_carrera);  
END
GO
CREATE PROC [dbo].[SP_LOGIN]
@user varchar(50),
@pass varchar(50)
AS
BEGIN
SELECT * FROM USERS WHERE usuario = @user and pass = @pass
END
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID_CARRERA]  
@next int OUTPUT  
AS  
BEGIN  
 SET @next = (SELECT COUNT(*)+1  FROM carreras);  
END
GO
CREATE PROC [dbo].[CARRERA_ID]
(@nro int)
AS
BEGIN
SELECT * from carreras c join detalles_carrera dc on c.id_carrera = dc.id_carrera
join materias m on m.id_materia = dc.id_materia
WHERE c.id_carrera = @nro
END

CREATE PROC [dbo].[SP_REGISTRO]
	@user varchar(50),
	@pass varchar(50),
	@exito bit output
AS
	IF not exists (SELECT * FROM USERS WHERE usuario=@user)
	BEGIN
		INSERT INTO USERS (id_usuario,usuario,pass)
		VALUES ((select MAX(id_usuario)+1 from USERS),@user,@pass)
		SELECT @exito = 1
	END
	ELSE
	BEGIN
		SELECT @exito = 0
	END


