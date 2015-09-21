USE [GD2C2015]
GO

SET NOCOUNT	ON
GO

--SCHEMA

CREATE SCHEMA [BIEN_MIGRADO_RAFA]
GO

--TABLES
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE BIEN_MIGRADO_RAFA.Aeronave(
    id                        int               IDENTITY(1,1),
    matricula                 nvarchar(255)     NULL,
    modelo                    nvarchar(255)     NULL,
    kilogramos_disponibles    numeric(18, 0)    NULL,
    fabricante                nvarchar(255)     NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Baja_Aeronave(
	id				  int		  IDENTITY(1,1),
    fecha_baja        datetime    NULL,
    fecha_reinicio    datetime    NULL,
    aeronave_id       int         NULL,
    tipo_baja_id      int         NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Butaca(
    id             int               IDENTITY(1,1),
    numero         numeric(18, 0)    NULL,
    tipo           nvarchar(255)     NULL,
    piso           numeric(18, 0)    NULL,
    aeronave_id    int               NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Cancelacion(
    id               int               IDENTITY(1,1),
    fecha            datetime          NULL,
    motivo           nvarchar(255)     NULL,
    numero_compra    numeric(18, 0)    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Cancelacion_Paquete(
    id                int    NOT NULL,
    cancelacion_id    int    NULL,
    paquete_id        int    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Cancelacion_Pasaje(
    id                int    IDENTITY(1,1),
    cancelacion_id    int    NULL,
    pasaje_id         int    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Canje(
    id             int               IDENTITY(1,1),
    cantidad       numeric(18, 0)    NULL,
    fecha          datetime          NULL,
    cliente_id     int               NULL,
    catalogo_id    int               NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Catalogo(
    id             int               IDENTITY(1,1),
    descripcion    nvarchar(255)     NULL,
    costo          numeric(18, 0)    NULL,
    stock          numeric(18, 0)    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Ciudad(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Cliente(
    id                  int               IDENTITY(1,1),
    puntos              numeric(18, 0)    NULL,
    nombre              nvarchar(255)     NULL,
    apellido            nvarchar(255)     NULL,
    dni                 numeric(18, 0)    NULL,
    direccion           nvarchar(255)     NULL,
    telefono            numeric(18, 0)    NULL,
    mail                nvarchar(255)     NULL,
    fecha_nacimiento    datetime          NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Funcionalidad(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Funcionalidad_Rol(
    id                  int    IDENTITY(1,1),
    funcionalidad_id    int    NULL,
    rol_id              int    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Paquete(
    id              int               IDENTITY(1,1),
    codigo          numeric(18, 0)    NULL,
    precio          numeric(18, 2)    NULL,
    kg              numeric(18, 0)    NULL,
    fecha_compra    datetime          NULL,
    viaje_id        int               NULL,
    cliente_id      int               NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Pasaje(
    id              int               IDENTITY(1,1),
    codigo          numeric(18, 0)    NULL,
    precio          numeric(18, 2)    NULL,
    fecha_compra    datetime          NULL,
    butaca_id       int               NULL,
    cliente_id      int               NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Rol(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Ruta(
    id                     int               IDENTITY(1,1),
    codigo                 numeric(18, 0)    NULL,
    precio_base_kg         numeric(18, 2)    NULL,
    precio_base_pasajes    numeric(18, 2)    NULL,
    ciudad_origen_id       int               NULL,
    ciudad_destino_id      int               NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Tipo_Baja(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Tipo_Servicio(
	id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Usuario(
    id          int              IDENTITY(1,1),
    username    nvarchar(255)    NULL	UNIQUE,
    password    nvarchar(255)    NULL,
    rol_id      int              NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Viaje(
    id                        int         IDENTITY(1,1),
    fecha_salida              datetime    NULL,
    fecha_llegada             datetime    NULL,
    fecha_llegada_estimada    datetime    NULL,
    ruta_id                   int         NULL,
    aeronave_id               int         NULL,
)
GO

--End Tables



 
--MIGRATION
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
 
--cursor
DECLARE crs CURSOR FOR SELECT * FROM gd_esquema.Maestra

--Table variables	
DECLARE @Cli_Nombre nvarchar(255);
DECLARE @Cli_Apellido nvarchar(255);
DECLARE @Cli_Dni numeric(18,0);
DECLARE @Cli_Dir nvarchar(255);
DECLARE @Cli_Telefono numeric(18,0);
DECLARE @Cli_Mail nvarchar(255);
DECLARE @Cli_Fecha_Nac datetime;
DECLARE @Pasaje_Codigo numeric(18,0);
DECLARE @Pasaje_Precio numeric(18,2);
DECLARE @Pasaje_FechaCompra datetime;
DECLARE @Butaca_Nro numeric(18,0);
DECLARE @Butaca_Tipo nvarchar(255);
DECLARE @Butaca_Piso numeric(18,0);
DECLARE @Paquete_Codigo numeric(18,0);
DECLARE @Paquete_Precio numeric(18,2);
DECLARE @Paquete_KG numeric(18,0);
DECLARE @Paquete_FechaCompra datetime;
DECLARE @FechaSalida datetime;
DECLARE @Fecha_LLegada_Estimada datetime;
DECLARE @FechaLLegada datetime;
DECLARE @Ruta_Codigo numeric(18,0);
DECLARE @Ruta_Precio_BaseKG numeric(18,2);
DECLARE @Ruta_Precio_BasePasaje numeric(18,2);
DECLARE @Ruta_Ciudad_Origen nvarchar(255);
DECLARE @Ruta_Ciudad_Destino nvarchar(255);
DECLARE @Aeronave_Matricula nvarchar(255);
DECLARE @Aeronave_Modelo nvarchar(255);
DECLARE @Aeronave_KG_Disponibles numeric(18,0);
DECLARE @Aeronave_Fabricante nvarchar(255);
DECLARE @Tipo_Servicio nvarchar(255)

--Aux Variables
DECLARE @Butaca_Id int;
DECLARE @Cliente_Id int;
DECLARE @Ciudad_Destino_Id int;
DECLARE @Ciudad_Origen_Id int;
DECLARE @Aeronave_Id int;
DECLARE @Ruta_Id int;
DECLARE @Viaje_Id int;

OPEN crs;
	
FETCH NEXT FROM crs INTO 

@Cli_Nombre, @Cli_Apellido, @Cli_Dni, @Cli_Dir, @Cli_Telefono, @Cli_Mail, @Cli_Fecha_Nac, 
@Pasaje_Codigo, @Pasaje_Precio, @Pasaje_FechaCompra,
@Butaca_Nro, @Butaca_Tipo, @Butaca_Piso,
@Paquete_Codigo, @Paquete_Precio, @Paquete_KG, @Paquete_FechaCompra, 
@FechaSalida, @Fecha_LLegada_Estimada, @FechaLLegada,
@Ruta_Codigo, @Ruta_Precio_BaseKG, @Ruta_Precio_BasePasaje, @Ruta_Ciudad_Origen, @Ruta_Ciudad_Destino,
@Aeronave_Matricula, @Aeronave_Modelo, @Aeronave_KG_Disponibles, @Aeronave_Fabricante, 
@Tipo_Servicio;

WHILE @@FETCH_STATUS = 0
BEGIN

	SELECT @Cliente_Id = id FROM BIEN_MIGRADO_RAFA.Cliente c WHERE c.dni = @Cli_Dni
	SELECT @Aeronave_Id = id FROM BIEN_MIGRADO_RAFA.Aeronave a WHERE a.matricula = @Aeronave_Matricula
	SELECT @Ciudad_Origen_Id = id FROM BIEN_MIGRADO_RAFA.Ciudad c WHERE c.descripcion = @Ruta_Ciudad_Origen
	SELECT @Ciudad_Destino_Id = id FROM BIEN_MIGRADO_RAFA.Ciudad c WHERE c.descripcion = @Ruta_Ciudad_Destino	
	SELECT @Butaca_Id = id FROM BIEN_MIGRADO_RAFA.Butaca b WHERE b.aeronave_id = @Aeronave_Id AND b.numero = @Butaca_Nro AND @Butaca_Piso = @Butaca_Piso AND b.tipo = @Butaca_Tipo
	SELECT @Ruta_Id = id FROM BIEN_MIGRADO_RAFA.Ruta r WHERE r.codigo = @Ruta_Codigo
	SELECT @Viaje_Id = id FROM BIEN_MIGRADO_RAFA.Viaje v WHERE v.aeronave_id = @Aeronave_Id AND v.ruta_id = @Ruta_Id

	--tablas sin FK
	--Cliente
	IF (@Cliente_Id IS NULL)
	BEGIN
		INSERT INTO BIEN_MIGRADO_RAFA.Cliente (nombre, apellido, dni, direccion, telefono, mail, fecha_nacimiento)
		VALUES (@Cli_Nombre, @Cli_Apellido, @Cli_Dni, @Cli_Dir, @Cli_Telefono, @Cli_Mail, @Cli_Fecha_Nac)
		SELECT @Cliente_Id = id FROM BIEN_MIGRADO_RAFA.Cliente c WHERE c.dni = @Cli_Dni
	END
	
	--Aeronave
	IF (@Aeronave_Id IS NULL)
	BEGIN
		INSERT INTO BIEN_MIGRADO_RAFA.Aeronave (matricula, modelo, kilogramos_disponibles, fabricante)
		VALUES (@Aeronave_Matricula, @Aeronave_Modelo, @Aeronave_KG_Disponibles, @Aeronave_Fabricante)
		SELECT @Aeronave_Id = id FROM BIEN_MIGRADO_RAFA.Aeronave a WHERE a.matricula = @Aeronave_Matricula
	END
	
	--Tipo_Servicio
	IF (NOT(EXISTS (SELECT 1 FROM BIEN_MIGRADO_RAFA.Tipo_Servicio t WHERE t.descripcion = @Tipo_Servicio )))
	BEGIN
		INSERT INTO BIEN_MIGRADO_RAFA.Tipo_Servicio (descripcion)
		VALUES (@Tipo_Servicio)
	END 

	--Ciudad (Origen)
	IF (@Ciudad_Origen_Id IS NULL)
	BEGIN
		INSERT INTO BIEN_MIGRADO_RAFA.Ciudad(descripcion)
		VALUES (@Ruta_Ciudad_Origen)
		SELECT @Ciudad_Origen_Id = id FROM BIEN_MIGRADO_RAFA.Ciudad c WHERE c.descripcion = @Ruta_Ciudad_Origen
	END
	
	--Ciudad (Destino)
	IF (@Ciudad_Destino_Id IS NULL)
	BEGIN
		INSERT INTO BIEN_MIGRADO_RAFA.Ciudad(descripcion)
		VALUES (@Ruta_Ciudad_Destino)
		SELECT @Ciudad_Destino_Id = id FROM BIEN_MIGRADO_RAFA.Ciudad c WHERE c.descripcion = @Ruta_Ciudad_Destino
	END
	

	--tablas con FK
	--Butaca
	IF (@Butaca_Tipo != '0')
	BEGIN
		IF (@Butaca_Id IS NULL)
		BEGIN
			INSERT INTO BIEN_MIGRADO_RAFA.Butaca(numero, tipo, piso, aeronave_id)
			VALUES (@Butaca_Nro, @Butaca_Tipo, @Butaca_Piso, @Aeronave_Id)
			SELECT @Butaca_Id = id FROM BIEN_MIGRADO_RAFA.Butaca b WHERE b.aeronave_id = @Aeronave_Id AND b.numero = @Butaca_Nro AND @Butaca_Piso = @Butaca_Piso AND b.tipo = @Butaca_Tipo
		END
	END
		
	--Ruta
	IF (@Ruta_Id IS NULL)
	BEGIN
		INSERT INTO BIEN_MIGRADO_RAFA.Ruta(codigo, precio_base_kg, precio_base_pasajes, ciudad_destino_id, ciudad_origen_id)
		VALUES (@Ruta_Codigo, @Ruta_Precio_BaseKG, @Ruta_Precio_BasePasaje, @Ciudad_Destino_Id, @Ciudad_Origen_Id)
		SELECT @Ruta_Id = id FROM BIEN_MIGRADO_RAFA.Ruta r WHERE r.codigo = @Ruta_Codigo
	END 
	
	--Viaje
	IF (@Viaje_Id IS NULL)
	BEGIN
		INSERT INTO BIEN_MIGRADO_RAFA.Viaje(fecha_llegada, fecha_llegada_estimada, fecha_salida, aeronave_id, ruta_id)
		VALUES (@FechaLLegada, @Fecha_LLegada_Estimada, @FechaSalida, @Aeronave_Id, @Ruta_Id)
		SELECT @Viaje_Id = id FROM BIEN_MIGRADO_RAFA.Viaje v WHERE v.aeronave_id = @Aeronave_Id AND v.ruta_id = @Ruta_Id
	END
	
	--Paquete
	IF (@Paquete_Codigo != '0')
	BEGIN
		IF (NOT(EXISTS (SELECT 1 FROM BIEN_MIGRADO_RAFA.Paquete p 
						WHERE p.cliente_id = @Cliente_Id 
						AND p.viaje_id = @Viaje_Id 
						AND p.codigo = @Paquete_Codigo --capaz no hace falta viaje y cliente
		)))
		BEGIN
			INSERT INTO BIEN_MIGRADO_RAFA.Paquete(codigo, fecha_compra, kg, precio, cliente_id, viaje_id)
			VALUES (@Paquete_Codigo, @Paquete_FechaCompra, @Paquete_KG, @Paquete_Precio, @Cliente_Id, @Viaje_Id)
		END
	END
	
	--Pasaje (Sin NOT EXISTS, no hay duplicados)
	IF (@Pasaje_Codigo != '0')
	BEGIN
		BEGIN
			INSERT INTO BIEN_MIGRADO_RAFA.Pasaje(codigo, precio, fecha_compra, cliente_id, butaca_id) 
			VALUES (@Pasaje_Codigo, @Pasaje_Precio, @Pasaje_FechaCompra, @Cliente_Id, @Butaca_Id)
		END   
	END

	FETCH NEXT FROM crs INTO
	
	@Cli_Nombre, @Cli_Apellido, @Cli_Dni, @Cli_Dir, @Cli_Telefono, @Cli_Mail, @Cli_Fecha_Nac, 
	@Pasaje_Codigo, @Pasaje_Precio, @Pasaje_FechaCompra,
	@Butaca_Nro, @Butaca_Tipo, @Butaca_Piso,
	@Paquete_Codigo, @Paquete_Precio, @Paquete_KG, @Paquete_FechaCompra, 
	@FechaSalida, @Fecha_LLegada_Estimada, @FechaLLegada,
	@Ruta_Codigo, @Ruta_Precio_BaseKG, @Ruta_Precio_BasePasaje, @Ruta_Ciudad_Origen, @Ruta_Ciudad_Destino,
	@Aeronave_Matricula, @Aeronave_Modelo, @Aeronave_KG_Disponibles, @Aeronave_Fabricante, 
	@Tipo_Servicio;

END

CLOSE crs;
DEALLOCATE crs;

GO

 
 --END MIGRATION

 --PKS & INDEXES 
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
 
 --PKS

ALTER TABLE BIEN_MIGRADO_RAFA.Aeronave
ADD CONSTRAINT PK7 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Baja_Aeronave
ADD CONSTRAINT PK666 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Butaca
ADD CONSTRAINT PK3 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Cancelacion
ADD CONSTRAINT PK16 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Cancelacion_Paquete
ADD CONSTRAINT PK18 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Cancelacion_Pasaje
ADD CONSTRAINT PK17 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Canje
ADD CONSTRAINT PK20 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Catalogo
ADD CONSTRAINT PK19 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Ciudad
ADD CONSTRAINT PK13 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Cliente
ADD CONSTRAINT PK1 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Funcionalidad
ADD CONSTRAINT PK10 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Funcionalidad_Rol
ADD CONSTRAINT PK11 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Paquete
ADD CONSTRAINT PK4 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Pasaje
ADD CONSTRAINT PK2 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Rol
ADD CONSTRAINT PK9 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Ruta
ADD CONSTRAINT PK6 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Tipo_Baja
ADD CONSTRAINT PK14 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Tipo_Servicio
ADD CONSTRAINT PK667 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Usuario
ADD CONSTRAINT PK12 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Viaje
ADD CONSTRAINT PK5 PRIMARY KEY CLUSTERED (id)
GO


--INDEXES

CREATE NONCLUSTERED INDEX [NonClusteredIndex-20150921-065350] ON [BIEN_MIGRADO_RAFA].[Ciudad]
(
	[descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [NonClusteredIndex-20150921-065145] ON [BIEN_MIGRADO_RAFA].[Tipo_Servicio]
(
	[descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO


 

 --FOREIGN KEYS
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------------------

ALTER TABLE BIEN_MIGRADO_RAFA.Baja_Aeronave ADD CONSTRAINT RefAeronave1 
    FOREIGN KEY (aeronave_id)
    REFERENCES BIEN_MIGRADO_RAFA.Aeronave(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Baja_Aeronave ADD CONSTRAINT RefTipo_Baja2 
    FOREIGN KEY (tipo_baja_id)
    REFERENCES BIEN_MIGRADO_RAFA.Tipo_Baja(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Butaca ADD CONSTRAINT RefAeronave12 
    FOREIGN KEY (aeronave_id)
    REFERENCES BIEN_MIGRADO_RAFA.Aeronave(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Cancelacion_Paquete ADD CONSTRAINT RefCancelacion23 
    FOREIGN KEY (cancelacion_id)
    REFERENCES BIEN_MIGRADO_RAFA.Cancelacion(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Cancelacion_Paquete ADD CONSTRAINT RefPaquete24 
    FOREIGN KEY (paquete_id)
    REFERENCES BIEN_MIGRADO_RAFA.Paquete(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Cancelacion_Pasaje ADD CONSTRAINT RefCancelacion20 
    FOREIGN KEY (cancelacion_id)
    REFERENCES BIEN_MIGRADO_RAFA.Cancelacion(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Cancelacion_Pasaje ADD CONSTRAINT RefPasaje22 
    FOREIGN KEY (pasaje_id)
    REFERENCES BIEN_MIGRADO_RAFA.Pasaje(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Canje ADD CONSTRAINT RefCliente25 
    FOREIGN KEY (cliente_id)
    REFERENCES BIEN_MIGRADO_RAFA.Cliente(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Canje ADD CONSTRAINT RefCatalogo26 
    FOREIGN KEY (catalogo_id)
    REFERENCES BIEN_MIGRADO_RAFA.Catalogo(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Funcionalidad_Rol ADD CONSTRAINT RefFuncionalidad5 
    FOREIGN KEY (funcionalidad_id)
    REFERENCES BIEN_MIGRADO_RAFA.Funcionalidad(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Funcionalidad_Rol ADD CONSTRAINT RefRol6 
    FOREIGN KEY (rol_id)
    REFERENCES BIEN_MIGRADO_RAFA.Rol(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Paquete ADD CONSTRAINT RefViaje16 
    FOREIGN KEY (viaje_id)
    REFERENCES BIEN_MIGRADO_RAFA.Viaje(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Paquete ADD CONSTRAINT RefCliente19 
    FOREIGN KEY (cliente_id)
    REFERENCES BIEN_MIGRADO_RAFA.Cliente(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Pasaje ADD CONSTRAINT RefButaca14 
    FOREIGN KEY (butaca_id)
    REFERENCES BIEN_MIGRADO_RAFA.Butaca(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Pasaje ADD CONSTRAINT RefCliente15 
    FOREIGN KEY (cliente_id)
    REFERENCES BIEN_MIGRADO_RAFA.Cliente(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Ruta ADD CONSTRAINT RefCiudad8 
    FOREIGN KEY (ciudad_origen_id)
    REFERENCES BIEN_MIGRADO_RAFA.Ciudad(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Ruta ADD CONSTRAINT RefCiudad9 
    FOREIGN KEY (ciudad_destino_id)
    REFERENCES BIEN_MIGRADO_RAFA.Ciudad(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Usuario ADD CONSTRAINT RefRol7 
    FOREIGN KEY (rol_id)
    REFERENCES BIEN_MIGRADO_RAFA.Rol(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Viaje ADD CONSTRAINT RefRuta3 
    FOREIGN KEY (ruta_id)
    REFERENCES BIEN_MIGRADO_RAFA.Ruta(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Viaje ADD CONSTRAINT RefAeronave4 
    FOREIGN KEY (aeronave_id)
    REFERENCES BIEN_MIGRADO_RAFA.Aeronave(id)
GO

 --END FOREIGN KEYS