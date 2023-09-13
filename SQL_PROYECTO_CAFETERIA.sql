CREATE DATABASE cafeteria_2023
USE cafeteria_2023
---------------------------------------
CREATE TABLE usuarios(
	id int IDENTITY(1,1) NOT NULL,
	nom_usr varchar(20) NOT NULL,
	ci_usr varchar(20) NOT NULL,
	nombres varchar(30) NOT NULL,
	apellidos varchar(30) NOT NULL,
	pass varchar(20) NOT NULL,
	email varchar(60) NOT NULL,
	img varchar(100) NULL,
	nivel varchar(10) NOT NULL,
	estado int,
	PRIMARY KEY (id)
);

--datos
--usuarios 
INSERT INTO usuarios VALUES ('cris', '4477665', 'Cristian', 'Tantani Aguilar', '12345', 'cris@hotmail.com', 'f:\fotos\foto.jpg', 'admin',1);


--sp para listar a todos los usuarios
CREATE PROCEDURE spu_listado_usuarios_ci
  @ci_usr VARCHAR(20)
  --@mensaje VARCHAR(50) OUTPUT
AS	
	--IF(exists(SELECT * FROM usuarios WHERE ci_usr=@ci_usr))
	 --BEGIN 
	  SELECT * FROM usuarios WHERE ci_usr=@ci_usr
	  --SELECT * FROM usuarios WHERE ci_usr LIKE '%9%'
    --  SET @mensaje = '1'	  
    --END
    --ELSE      
    --  SET @mensaje = '0'	        
GO

DECLARE @mensaje VARCHAR (50)
SET @mensaje = ''
EXEC spu_listado_usuarios_ci '4477665',@mensaje OUTPUT
PRINT @mensaje

CREATE PROCEDURE spu_listado_usuarios

AS
	SELECT * FROM usuarios
GO


--sp para registrar a un usuario
CREATE PROCEDURE spu_registrar_usuario  
  @nom_usr VARCHAR(20),
  @ci_usr VARCHAR(20),
  @nombres VARCHAR(30),
  @apellidos VARCHAR(30),
  @pass VARCHAR(20),
  @email VARCHAR(60),
  @img VARCHAR(100),
  @nivel VARCHAR(10),  
  @estado INT,  
  @mensaje VARCHAR(50) OUTPUT 
AS
BEGIN  
  IF(exists(SELECT * FROM usuarios WHERE ci_usr=@ci_usr))
    SET @mensaje = '0' --el ci del usuario ya existe	  
  ELSE
  BEGIN
    INSERT INTO usuarios VALUES(@nom_usr,@ci_usr,@nombres,@apellidos,@pass,@email,@img,@nivel,@estado)  
    SET @mensaje = '1' --registrado correctamente	  
  END
END  
GO


--sp para verificar el nombre y contraena de un usuario 
CREATE PROCEDURE spu_verifica_usuario  
  @nom_usr VARCHAR(20),  
  @pass VARCHAR(20),     
  @mensaje VARCHAR(50) OUTPUT 
AS
BEGIN  
  IF(exists(SELECT * FROM usuarios WHERE nom_usr = @nom_usr AND pass=@pass))
    SET @mensaje = '1'	 --encontrado
  ELSE    
    SET @mensaje = '0'   --no encontrado
END  
GO


--sp para modificar datos de un usuario 
CREATE PROCEDURE spu_modificar_usuario  
  @id INT,
  @nom_usr VARCHAR(20),
  @ci_usr VARCHAR(20),
  @nombres VARCHAR(30),
  @apellidos VARCHAR(30),
  @pass VARCHAR(20),
  @email VARCHAR(60),
  @img VARCHAR(100),
  @nivel VARCHAR(10),  
  @estado INT,  
  @mensaje VARCHAR(50) OUTPUT 
AS
BEGIN  
  IF (exists(SELECT * FROM usuarios WHERE id=@id))
  BEGIN          
    
    UPDATE usuarios SET nom_usr=@nom_usr, ci_usr=@ci_usr, nombres=@nombres, apellidos=@apellidos, pass=@pass,email=@email,img=@img, nivel=@nivel,estado=@estado
    WHERE id=@id  
    SET @mensaje = '1' --modificado
  END
  ELSE    
  BEGIN        
    SET @mensaje = '0' --no modificado
  END
END  
GO

DECLARE @mensaje VARCHAR (50)
SET @mensaje = ''
EXEC spu_modificar_usuario 'juanp','4477665','Juana','Perez','12345','juan@gamil.com','f:\fotos\foto.jpg','admin','1',@mensaje OUTPUT
PRINT @mensaje

--SP para eliminar un usuario en base a su id
CREATE PROCEDURE spu_eliminar_usuario
@id INT,
@mensaje VARCHAR(50) OUTPUT
AS
BEGIN
  IF(exists(SELECT id FROM usuarios WHERE id=@id))
    BEGIN
      DELETE FROM usuarios WHERE id=@id   
      SET @mensaje='1' --eliminado
    END    
  ELSE
    SET @mensaje='0' --no eliminado
END
GO
---------------------------------
-------------------------------------------------
---------------------------------------------------------
CREATE TABLE Almacen
(
cod_almacen VARCHAR(20) PRIMARY KEY NOT NULL,  --String --codigo del Almacen(id)
stock_prod  INT NOT NULL,--int -- stock del producto

);
----------------------------------------------------------------
CREATE TABLE Categoria
(
id_cate     VARCHAR(20) PRIMARY KEY NOT NULL,   --String --id 
nombre_cate VARCHAR(50) NOT NULL,--String --Nombre de la categoria
cod_almacen VARCHAR(20) NOT NULL,
FOREIGN KEY (cod_almacen) REFERENCES Almacen(cod_almacen), -- stock del producto -- tabla almacen 
);
----------------------------------------------------------------
CREATE TABLE Producto
(
--id_prod INT PRIMARY KEY NOT NULL,  --Int     --id
cod_prod VARCHAR(20) PRIMARY KEY NOT NULL,  --String --codigo
nom_prod  VARCHAR(50) NOT NULL,--String --NOMBRE
prec_prod INT NOT NULL,--Int --precio
img_prod  VARBINARY(MAX), --String "VARBINARY(MAX)"--imagen del producto
id_cate VARCHAR(20) NOT NULL,
FOREIGN KEY (id_cate) REFERENCES Categoria(id_cate),   --String -- Tabla categoria
);
----------------------------------------------------------------
----------------------------------------------------------------     
Tabla Cliente

ci_cliente String --ci del cliente

----------------------------------------------------------------
Tabla Mesas

id_mesa int            --numero de la mesa
mesa_disp int          -- valor a disponibilidad de mesa
----------------------------------------------------------------
Tabla Pedido

id_pedido        --int -- id del pedido
selec_cant       -- int -- cantidad del producto a elegir
list_prod String -- lista de producto pedido o descripcion
sum_prec         --int -- precio total de los productos consumidos
ped_servido int -- valor que determina si el pedido esta servido o no
Forenkey (cod_prod) -- cod de producto
Forenkey (id_mesa)-- numero de mesa
Forenkey (ci_cliente) -- ci del cliente
----------------------------------------------------------------
Tabla pago

id_pago int 
Forenkey (id_pedido)--tabla pedido
-----------------------------------------------------------------
-----------------------------------------------------------------
Tabla Usuario

  	id        --Int 
	nom_usr   --String
	ci_usr    --String
	nombres   --String
	apellidos --String
	pass      --String
	email     --String
	img       --String
	nivel     --String
	estado    --int
	PRIMARY KEY (id) 
-----------------------------------------------------------------
