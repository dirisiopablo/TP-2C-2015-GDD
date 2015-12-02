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
	id							int             IDENTITY(1,1),
	matricula					nvarchar(255)   NULL,
	modelo_id					int				NULL,
	kilogramos_disponibles		numeric(18, 0)  NULL,
	fabricante_id				int				NULL,
	tipo_servicio_id			int			    NULL,
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
    numero_compra    nvarchar(255)     NULL,
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
	activo			bit				null DEFAULT(1)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Cliente(
    id                  int               IDENTITY(1,1),
    nombre              nvarchar(255)     NULL,
    apellido            nvarchar(255)     NULL,
    dni                 numeric(18, 0)    NULL,
    direccion           nvarchar(255)     NULL,
    telefono            numeric(18, 0)    NULL,
    mail                nvarchar(255)     NULL,
    fecha_nacimiento    datetime          NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Compra(
    id                   int              IDENTITY(1,1),
    PNR                  nvarchar(255)    NULL,
	fecha_compra         datetime         NULL,
	numero_tarjeta       int              NULL,
	codigo_tarjeta       int              NULL,
	vencimiento_tarjeta  int              NULL,
	cant_cuotas          int              NULL,
	cliente_id           int              NULL,
	medio_pago_id        int              NULL,
	tipo_tarjeta_id      int              NULL,
	
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Compra_Pasaje(
    id                  int    IDENTITY(1,1),
    compra_id           int    NULL,
    pasaje_id           int    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Compra_Paquete(
    id                  int    IDENTITY(1,1),
    compra_id           int    NULL,
    paquete_id          int    NULL,
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

CREATE TABLE BIEN_MIGRADO_RAFA.Intentos_Login(
	id					int	   IDENTITY(1,1),
	usuario_id          int    NULL,
	intentos            int    NULL DEFAULT (0),
)


CREATE TABLE BIEN_MIGRADO_RAFA.Medio_Pago(
	id					int	             IDENTITY(1,1),
    descripcion         nvarchar(255)    NULL,
)


CREATE TABLE BIEN_MIGRADO_RAFA.Paquete(
    id              int               IDENTITY(1,1),
    codigo          numeric(18, 0)    NULL,
    precio          numeric(18, 2)    NULL,
    kg              numeric(18, 0)    NULL,
    fecha_compra    datetime          NULL,
	activo			bit				  NULL DEFAULT(1),
    viaje_id        int               NULL,
    cliente_id      int               NULL
	
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Pasaje(
    id              int               IDENTITY(1,1),
    codigo          numeric(18, 0)    NULL,
    precio          numeric(18, 2)    NULL,
    fecha_compra    datetime          NULL,
	activo			bit				  NULL DEFAULT(1),
    butaca_id       int               NULL,
    viaje_id        int               NULL,
    cliente_id      int               NULL
	
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Rol(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
	activo		   bit              NULL DEFAULT (1)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Ruta(
    id                     int               IDENTITY(1,1),
    codigo                 numeric(18, 0)    NULL,
    precio_base_kg         numeric(18, 2)    NULL,
    precio_base_pasajes    numeric(18, 2)    NULL,
    ciudad_origen_id       int               NULL,
    ciudad_destino_id      int               NULL,
	activo		   		   bit               NULL DEFAULT (1)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Tipo_Baja(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Tipo_Servicio(
	id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
	porcentaje     numeric(18, 2)   NULL DEFAULT(1)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Usuario(
    id          int              IDENTITY(1,1),
    username    nvarchar(255)    NULL	UNIQUE,
    password    nvarchar(255)    NULL,
    rol_id      int              NULL,
	activo		bit              NULL DEFAULT (1)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Viaje(
    id                        int         IDENTITY(1,1),
    fecha_salida              datetime    NULL,
    fecha_llegada             datetime    NULL,
    fecha_llegada_estimada    datetime    NULL,
    ruta_id                   int         NULL,
    aeronave_id               int         NULL
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Modelo(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Fabricante(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL
)
GO

CREATE TABLE BIEN_MIGRADO_RAFA.Tipo_Tarjeta(
	id					int	             IDENTITY(1,1),
    descripcion         nvarchar(255)    NULL,
)

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
 

--tablas sin FK
--Cliente
INSERT INTO BIEN_MIGRADO_RAFA.Cliente (apellido, nombre, direccion, dni, fecha_nacimiento, mail, telefono)
SELECT DISTINCT Cli_Apellido, Cli_Nombre, Cli_Dir, Cli_Dni, Cli_Fecha_Nac, Cli_Mail, Cli_Telefono FROM gd_esquema.Maestra
GO

--Tipo servicio
INSERT INTO BIEN_MIGRADO_RAFA.Tipo_Servicio (descripcion)
SELECT DISTINCT Tipo_Servicio FROM gd_esquema.Maestra
GO

--Fabricante
INSERT INTO BIEN_MIGRADO_RAFA.Fabricante (descripcion)
SELECT DISTINCT Aeronave_Fabricante FROM gd_esquema.Maestra
GO

--Modelo
INSERT INTO BIEN_MIGRADO_RAFA.Modelo (descripcion)
SELECT DISTINCT Aeronave_Modelo FROM gd_esquema.Maestra
GO

--Aeronave
INSERT INTO BIEN_MIGRADO_RAFA.Aeronave (fabricante_id, kilogramos_disponibles, matricula, modelo_id, tipo_servicio_id)
SELECT DISTINCT f.id, m.Aeronave_KG_Disponibles, m.Aeronave_Matricula, mo.id, t.id 
FROM gd_esquema.Maestra m
JOIN BIEN_MIGRADO_RAFA.Tipo_Servicio t ON t.descripcion = tipo_servicio
JOIN BIEN_MIGRADO_RAFA.Fabricante f ON f.descripcion = m.Aeronave_Fabricante
JOIN BIEN_MIGRADO_RAFA.Modelo mo ON mo.descripcion = m.Aeronave_Modelo
GO

--Ciudad
INSERT INTO BIEN_MIGRADO_RAFA.Ciudad (descripcion)
SELECT DISTINCT Ruta_Ciudad_Destino AS Ciudad FROM gd_esquema.Maestra 
UNION 
SELECT DISTINCT Ruta_Ciudad_Origen FROM gd_esquema.Maestra
GO

--Butaca
INSERT INTO BIEN_MIGRADO_RAFA.Butaca (numero, piso, tipo, aeronave_id)
SELECT DISTINCT m.Butaca_Nro, m.Butaca_Piso, m.Butaca_Tipo, a.id FROM gd_esquema.Maestra m
JOIN BIEN_MIGRADO_RAFA.Aeronave a ON m.Aeronave_Matricula = a.matricula
WHERE m.Butaca_Nro != '0'
GO

--Ruta
INSERT INTO BIEN_MIGRADO_RAFA.Ruta(codigo, precio_base_kg, precio_base_pasajes, ciudad_destino_id, ciudad_origen_id)
select m.codigo, max(m.baseKG), max(m.basePasaje), c.id, c2.id
from (SELECT DISTINCT m.Ruta_Codigo codigo, m.Ruta_Ciudad_Destino destino, m.Ruta_Ciudad_Origen origen, m.Ruta_Precio_BasePasaje basePasaje, m.Ruta_Precio_BaseKG baseKG 
	FROM gd_esquema.Maestra m) m
JOIN BIEN_MIGRADO_RAFA.Ciudad c ON c.descripcion = destino
JOIN BIEN_MIGRADO_RAFA.Ciudad c2 ON c2.descripcion = origen
group by codigo, c.id, c2.id
GO

--Viaje
INSERT INTO BIEN_MIGRADO_RAFA.Viaje(fecha_llegada, fecha_llegada_estimada, fecha_salida, aeronave_id, ruta_id)
SELECT DISTINCT m.fechaLLegada, m.fechaLlegadaEstimada, m.fechaSalida, a.id, r.id
FROM (SELECT DISTINCT m2.FechaSalida fechaSalida, m2.Fecha_LLegada_Estimada fechaLlegadaEstimada, m2.FechaLLegada fechaLlegada, m2.Ruta_Codigo rutaCodigo, m2.Ruta_Ciudad_Destino ciudadDestino, m2.Ruta_Ciudad_Origen ciudadOrigen, m2.Aeronave_Matricula matricula
		FROM gd_esquema.Maestra m2) m
JOIN BIEN_MIGRADO_RAFA.Aeronave a ON a.matricula = m.matricula
JOIN BIEN_MIGRADO_RAFA.Ruta r ON r.codigo = m.rutaCodigo
WHERE r.ciudad_destino_id = (SELECT id from BIEN_MIGRADO_RAFA.Ciudad where descripcion = m.ciudadDestino) AND r.ciudad_origen_id = (SELECT id from BIEN_MIGRADO_RAFA.Ciudad where descripcion = m.ciudadOrigen)
GO

--Paquete
INSERT INTO BIEN_MIGRADO_RAFA.Paquete(codigo, fecha_compra, kg, precio, cliente_id, viaje_id)
SELECT DISTINCT m.Paquete_Codigo, m.Paquete_FechaCompra, m.Paquete_KG, m.Paquete_Precio, c.id, v.id 
FROM (SELECT	Paquete_Codigo, 
				Paquete_FechaCompra, 
				Paquete_KG, 
				Paquete_Precio, 
				Ruta_Codigo rutaCodigo, 
				Ruta_Ciudad_Destino ciudadDestino, 
				Ruta_Ciudad_Origen ciudadOrigen,
				Aeronave_Matricula matricula,
				Cli_Dni,
				Cli_Apellido,
				Cli_Nombre,
				Cli_Telefono,
				Fecha_LLegada_Estimada,
				FechaLLegada,
				FechaSalida    
		FROM gd_esquema.Maestra where Paquete_KG != 0) m
JOIN BIEN_MIGRADO_RAFA.Ruta r ON r.codigo = m.rutaCodigo
JOIN BIEN_MIGRADO_RAFA.Aeronave a ON a.matricula = m.matricula
JOIN BIEN_MIGRADO_RAFA.Cliente c ON c.dni = m.Cli_Dni and m.Cli_Telefono = c.telefono
JOIN BIEN_MIGRADO_RAFA.Viaje v ON v.aeronave_id = a.id AND v.ruta_id = r.id AND v.fecha_llegada_estimada = m.Fecha_LLegada_Estimada AND v.fecha_llegada = m.FechaLLegada AND v.fecha_salida = m.FechaSalida
WHERE r.ciudad_destino_id = (SELECT id from BIEN_MIGRADO_RAFA.Ciudad where descripcion = m.ciudadDestino) 
AND r.ciudad_origen_id = (SELECT id from BIEN_MIGRADO_RAFA.Ciudad where descripcion = m.ciudadOrigen)
GO


--Pasaje
INSERT INTO BIEN_MIGRADO_RAFA.Pasaje(codigo, precio, fecha_compra, cliente_id, butaca_id, viaje_id)
SELECT DISTINCT m.Pasaje_Codigo, m.Pasaje_Precio, m.Pasaje_FechaCompra, c.id, (SELECT id FROM BIEN_MIGRADO_RAFA.Butaca where numero = m.Butaca_Nro and aeronave_id = a.id), v.id 
FROM (SELECT	Pasaje_Codigo, 
				Pasaje_Precio, 
				Pasaje_FechaCompra, 
				Ruta_Codigo rutaCodigo, 
				Ruta_Ciudad_Destino ciudadDestino, 
				Ruta_Ciudad_Origen ciudadOrigen,
				Aeronave_Matricula matricula,
				Cli_Dni,
				Cli_Apellido,
				Cli_Nombre,
				Cli_Telefono,
				Butaca_Nro,
				Fecha_LLegada_Estimada,
				FechaLLegada,
				FechaSalida   
		FROM gd_esquema.Maestra where Pasaje_Codigo != 0 and Butaca_Nro != 0) m
JOIN BIEN_MIGRADO_RAFA.Ruta r ON r.codigo = m.rutaCodigo
JOIN BIEN_MIGRADO_RAFA.Aeronave a ON a.matricula = m.matricula
JOIN BIEN_MIGRADO_RAFA.Cliente c ON c.dni = m.Cli_Dni and m.Cli_Telefono = c.telefono
JOIN BIEN_MIGRADO_RAFA.Viaje v ON v.aeronave_id = a.id AND v.ruta_id = r.id AND v.fecha_llegada_estimada = m.Fecha_LLegada_Estimada AND v.fecha_llegada = m.FechaLLegada AND v.fecha_salida = m.FechaSalida
WHERE r.ciudad_destino_id = (SELECT id from BIEN_MIGRADO_RAFA.Ciudad where descripcion = m.ciudadDestino) 
AND r.ciudad_origen_id = (SELECT id from BIEN_MIGRADO_RAFA.Ciudad where descripcion = m.ciudadOrigen)

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

ALTER TABLE BIEN_MIGRADO_RAFA.Modelo
ADD CONSTRAINT PK9999 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Fabricante
ADD CONSTRAINT PK9998 PRIMARY KEY CLUSTERED (id)
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

ALTER TABLE BIEN_MIGRADO_RAFA.Compra
ADD CONSTRAINT PK668 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Funcionalidad
ADD CONSTRAINT PK10 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Funcionalidad_Rol
ADD CONSTRAINT PK11 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Intentos_Login
ADD CONSTRAINT PK79 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Medio_Pago
ADD CONSTRAINT PK669 PRIMARY KEY CLUSTERED (id)
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

ALTER TABLE BIEN_MIGRADO_RAFA.Tipo_Tarjeta
ADD CONSTRAINT PK700 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Usuario
ADD CONSTRAINT PK12 PRIMARY KEY CLUSTERED (id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Viaje
ADD CONSTRAINT PK5 PRIMARY KEY CLUSTERED (id)
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

ALTER TABLE BIEN_MIGRADO_RAFA.Aeronave ADD CONSTRAINT RefTipoServicio1
    FOREIGN KEY (tipo_servicio_id)
    REFERENCES BIEN_MIGRADO_RAFA.Tipo_Servicio(id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Aeronave ADD CONSTRAINT RefModelo1
    FOREIGN KEY (modelo_id)
    REFERENCES BIEN_MIGRADO_RAFA.Modelo(id)
GO

ALTER TABLE BIEN_MIGRADO_RAFA.Aeronave ADD CONSTRAINT RefFabricante1
    FOREIGN KEY (fabricante_id)
    REFERENCES BIEN_MIGRADO_RAFA.Fabricante(id)
GO

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


ALTER TABLE BIEN_MIGRADO_RAFA.Compra ADD CONSTRAINT RefCliente98 
    FOREIGN KEY (cliente_id)
    REFERENCES BIEN_MIGRADO_RAFA.Cliente(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Compra ADD CONSTRAINT RefMedioPago98 
    FOREIGN KEY (medio_pago_id)
    REFERENCES BIEN_MIGRADO_RAFA.Medio_Pago(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Compra ADD CONSTRAINT TipoTarjeta33 
    FOREIGN KEY (tipo_tarjeta_id)
    REFERENCES BIEN_MIGRADO_RAFA.Tipo_Tarjeta(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Funcionalidad_Rol ADD CONSTRAINT RefFuncionalidad5 
    FOREIGN KEY (funcionalidad_id)
    REFERENCES BIEN_MIGRADO_RAFA.Funcionalidad(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Funcionalidad_Rol ADD CONSTRAINT RefRol6 
    FOREIGN KEY (rol_id)
    REFERENCES BIEN_MIGRADO_RAFA.Rol(id)
GO


ALTER TABLE BIEN_MIGRADO_RAFA.Intentos_Login ADD CONSTRAINT RefUsuario77
    FOREIGN KEY (usuario_id)
    REFERENCES BIEN_MIGRADO_RAFA.Usuario(id)
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


ALTER TABLE BIEN_MIGRADO_RAFA.Pasaje ADD CONSTRAINT RefViaje17
    FOREIGN KEY (viaje_id)
    REFERENCES BIEN_MIGRADO_RAFA.Viaje(id)
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


 -- START FIXTURE
INSERT INTO [BIEN_MIGRADO_RAFA].[Tipo_Baja]
           ([descripcion])
     VALUES
           ('Fuera de servicio')
GO

INSERT INTO [BIEN_MIGRADO_RAFA].[Tipo_Baja]
           ([descripcion])
     VALUES
           ('Baja definitiva')
GO

INSERT INTO [BIEN_MIGRADO_RAFA].Rol
           ([descripcion], [activo])
     VALUES
           ('Administrador', 1)
GO

INSERT INTO [BIEN_MIGRADO_RAFA].[Usuario]
           ([username], [password], [rol_id])
     VALUES
           ('admin1', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1)
GO

INSERT INTO [BIEN_MIGRADO_RAFA].[Intentos_Login]
           ([usuario_id], [intentos])
     VALUES
           (1, 0)
GO

INSERT INTO [BIEN_MIGRADO_RAFA].[Funcionalidad]
           ([descripcion])
     VALUES
           ('ABM_Rol'),
		   ('ABM_Aeronave'),
		   ('ABM_Ruta'),
		   ('Generar_Viaje'),
		   ('Devolucion')
GO

INSERT INTO [BIEN_MIGRADO_RAFA].[Funcionalidad_Rol]
           ([funcionalidad_id], [rol_id])
     VALUES
           (1, 1),
		   (2, 1),
		   (3, 1),
		   (4, 1),
		   (5, 1)
GO

INSERT INTO [BIEN_MIGRADO_RAFA].[Catalogo]
           ([descripcion], [costo], [stock])
     VALUES
           ('Cafetera', 450, 35),
		   ('Home Theater', 1200, 15),
		   ('Monitor Led 23"', 600, 20)
GO

INSERT INTO [BIEN_MIGRADO_RAFA].[Medio_Pago]
           ([descripcion])
     VALUES
           ('Efectivo'),
		   ('Tarjeta de Credito')
		   
GO

INSERT INTO [BIEN_MIGRADO_RAFA].[Tipo_Tarjeta]
           ([descripcion])
     VALUES
           ('Tipo 1'),
		   ('Tipo 2')
		   
GO