/*
 * ER/Studio Data Architect 11.0 SQL Code Generation
 * Project :      der.DM1
 *
 * Date Created : Wednesday, September 16, 2015 01:29:34
 * Target DBMS : Microsoft SQL Server 2012
 */

/* 
 * TABLE: Aeronave 
 */

CREATE TABLE Aeronave(
    id                        int               IDENTITY(1,1),
    numero                    numeric(18, 0)    NULL,
    matricula                 nvarchar(255)     NULL,
    modelo                    nvarchar(255)     NULL,
    kilogramos_disponibles    numeric(18, 0)    NULL,
    fabricante                nvarchar(255)     NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Aeronave') IS NOT NULL
    PRINT '<<< CREATED TABLE Aeronave >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Aeronave >>>'
go

/* 
 * TABLE: Baja_Aeronave 
 */

CREATE TABLE Baja_Aeronave(
    fecha_baja        datetime    NULL,
    fecha_reinicio    datetime    NULL,
    aeronave_id       int         NULL,
    tipo_baja_id      int         NULL
)
go



IF OBJECT_ID('Baja_Aeronave') IS NOT NULL
    PRINT '<<< CREATED TABLE Baja_Aeronave >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Baja_Aeronave >>>'
go

/* 
 * TABLE: Butaca 
 */

CREATE TABLE Butaca(
    id             int               IDENTITY(1,1),
    numero         numeric(18, 0)    NULL,
    tipo           nvarchar(255)     NULL,
    piso           numeric(18, 0)    NULL,
    aeronave_id    int               NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Butaca') IS NOT NULL
    PRINT '<<< CREATED TABLE Butaca >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Butaca >>>'
go

/* 
 * TABLE: Cancelacion 
 */

CREATE TABLE Cancelacion(
    id               int               IDENTITY(1,1),
    fecha            datetime          NULL,
    motivo           nvarchar(255)     NULL,
    numero_compra    numeric(18, 0)    NULL,
    CONSTRAINT PK16 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Cancelacion') IS NOT NULL
    PRINT '<<< CREATED TABLE Cancelacion >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cancelacion >>>'
go

/* 
 * TABLE: Cancelacion_Paquete 
 */

CREATE TABLE Cancelacion_Paquete(
    id                int    NOT NULL,
    cancelacion_id    int    NULL,
    paquete_id        int    NULL,
    CONSTRAINT PK18 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Cancelacion_Paquete') IS NOT NULL
    PRINT '<<< CREATED TABLE Cancelacion_Paquete >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cancelacion_Paquete >>>'
go

/* 
 * TABLE: Cancelacion_Pasaje 
 */

CREATE TABLE Cancelacion_Pasaje(
    id                int    IDENTITY(1,1),
    cancelacion_id    int    NULL,
    pasaje_id         int    NULL,
    CONSTRAINT PK17 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Cancelacion_Pasaje') IS NOT NULL
    PRINT '<<< CREATED TABLE Cancelacion_Pasaje >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cancelacion_Pasaje >>>'
go

/* 
 * TABLE: Canje 
 */

CREATE TABLE Canje(
    id             int               IDENTITY(1,1),
    cantidad       numeric(18, 0)    NULL,
    fecha          datetime          NULL,
    cliente_id     int               NULL,
    catalogo_id    int               NULL,
    CONSTRAINT PK20 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Canje') IS NOT NULL
    PRINT '<<< CREATED TABLE Canje >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Canje >>>'
go

/* 
 * TABLE: Catalogo 
 */

CREATE TABLE Catalogo(
    id             int               IDENTITY(1,1),
    descripcion    nvarchar(255)     NULL,
    costo          numeric(18, 0)    NULL,
    stock          numeric(18, 0)    NULL,
    CONSTRAINT PK19 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Catalogo') IS NOT NULL
    PRINT '<<< CREATED TABLE Catalogo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Catalogo >>>'
go

/* 
 * TABLE: Ciudad 
 */

CREATE TABLE Ciudad(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
    CONSTRAINT PK13 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Ciudad') IS NOT NULL
    PRINT '<<< CREATED TABLE Ciudad >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Ciudad >>>'
go

/* 
 * TABLE: Cliente 
 */

CREATE TABLE Cliente(
    id                  int               IDENTITY(1,1),
    puntos              numeric(18, 0)    NULL,
    nombre              nvarchar(255)     NULL,
    apellido            nvarchar(255)     NULL,
    dni                 numeric(18, 0)    NULL,
    direccion           nvarchar(255)     NULL,
    telefono            numeric(18, 0)    NULL,
    mail                nvarchar(255)     NULL,
    fecha_nacimiento    datetime          NULL,
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Cliente') IS NOT NULL
    PRINT '<<< CREATED TABLE Cliente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Cliente >>>'
go

/* 
 * TABLE: Funcionalidad 
 */

CREATE TABLE Funcionalidad(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
    CONSTRAINT PK10 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Funcionalidad') IS NOT NULL
    PRINT '<<< CREATED TABLE Funcionalidad >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Funcionalidad >>>'
go

/* 
 * TABLE: Funcionalidad_Rol 
 */

CREATE TABLE Funcionalidad_Rol(
    id                  int    IDENTITY(1,1),
    funcionalidad_id    int    NULL,
    rol_id              int    NULL,
    CONSTRAINT PK11 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Funcionalidad_Rol') IS NOT NULL
    PRINT '<<< CREATED TABLE Funcionalidad_Rol >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Funcionalidad_Rol >>>'
go

/* 
 * TABLE: Paquete 
 */

CREATE TABLE Paquete(
    id              int               IDENTITY(1,1),
    codigo          numeric(18, 0)    NULL,
    precio          numeric(18, 2)    NULL,
    kg              numeric(18, 0)    NULL,
    fecha_compra    datetime          NULL,
    viaje_id        int               NULL,
    cliente_id      int               NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Paquete') IS NOT NULL
    PRINT '<<< CREATED TABLE Paquete >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Paquete >>>'
go

/* 
 * TABLE: Pasaje 
 */

CREATE TABLE Pasaje(
    id              int               IDENTITY(1,1),
    codigo          numeric(18, 0)    NULL,
    precio          numeric(18, 2)    NULL,
    fecha_compra    datetime          NULL,
    butaca_id       int               NULL,
    cliente_id      int               NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Pasaje') IS NOT NULL
    PRINT '<<< CREATED TABLE Pasaje >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Pasaje >>>'
go

/* 
 * TABLE: Rol 
 */

CREATE TABLE Rol(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Rol') IS NOT NULL
    PRINT '<<< CREATED TABLE Rol >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Rol >>>'
go

/* 
 * TABLE: Ruta 
 */

CREATE TABLE Ruta(
    id                     int               IDENTITY(1,1),
    codigo                 numeric(18, 0)    NULL,
    precio_base_kg         numeric(18, 2)    NULL,
    precio_base_pasajes    numeric(18, 2)    NULL,
    ciudad_origen_id       int               NULL,
    ciudad_destino_id      int               NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Ruta') IS NOT NULL
    PRINT '<<< CREATED TABLE Ruta >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Ruta >>>'
go

/* 
 * TABLE: Tipo_Baja 
 */

CREATE TABLE Tipo_Baja(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
    CONSTRAINT PK14 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Tipo_Baja') IS NOT NULL
    PRINT '<<< CREATED TABLE Tipo_Baja >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tipo_Baja >>>'
go

/* 
 * TABLE: Tipo_Servicio 
 */

CREATE TABLE Tipo_Servicio(
    descripcion    nvarchar(255)    NULL
)
go



IF OBJECT_ID('Tipo_Servicio') IS NOT NULL
    PRINT '<<< CREATED TABLE Tipo_Servicio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Tipo_Servicio >>>'
go

/* 
 * TABLE: Usuario 
 */

CREATE TABLE Usuario(
    id          int              IDENTITY(1,1),
    username    nvarchar(255)    NULL,
    password    nvarchar(255)    NULL,
    rol_id      int              NULL,
    CONSTRAINT PK12 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Usuario') IS NOT NULL
    PRINT '<<< CREATED TABLE Usuario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Usuario >>>'
go

/* 
 * TABLE: Viaje 
 */

CREATE TABLE Viaje(
    id                        int         IDENTITY(1,1),
    fecha_salida              datetime    NULL,
    fecha_llegada             datetime    NULL,
    fecha_llegada_estimada    datetime    NULL,
    ruta_id                   int         NULL,
    aeronave_id               int         NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (id)
)
go



IF OBJECT_ID('Viaje') IS NOT NULL
    PRINT '<<< CREATED TABLE Viaje >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Viaje >>>'
go

/* 
 * TABLE: Baja_Aeronave 
 */

ALTER TABLE Baja_Aeronave ADD CONSTRAINT RefAeronave1 
    FOREIGN KEY (aeronave_id)
    REFERENCES Aeronave(id)
go

ALTER TABLE Baja_Aeronave ADD CONSTRAINT RefTipo_Baja2 
    FOREIGN KEY (tipo_baja_id)
    REFERENCES Tipo_Baja(id)
go


/* 
 * TABLE: Butaca 
 */

ALTER TABLE Butaca ADD CONSTRAINT RefAeronave12 
    FOREIGN KEY (aeronave_id)
    REFERENCES Aeronave(id)
go


/* 
 * TABLE: Cancelacion_Paquete 
 */

ALTER TABLE Cancelacion_Paquete ADD CONSTRAINT RefCancelacion23 
    FOREIGN KEY (cancelacion_id)
    REFERENCES Cancelacion(id)
go

ALTER TABLE Cancelacion_Paquete ADD CONSTRAINT RefPaquete24 
    FOREIGN KEY (paquete_id)
    REFERENCES Paquete(id)
go


/* 
 * TABLE: Cancelacion_Pasaje 
 */

ALTER TABLE Cancelacion_Pasaje ADD CONSTRAINT RefCancelacion20 
    FOREIGN KEY (cancelacion_id)
    REFERENCES Cancelacion(id)
go

ALTER TABLE Cancelacion_Pasaje ADD CONSTRAINT RefPasaje22 
    FOREIGN KEY (pasaje_id)
    REFERENCES Pasaje(id)
go


/* 
 * TABLE: Canje 
 */

ALTER TABLE Canje ADD CONSTRAINT RefCliente25 
    FOREIGN KEY (cliente_id)
    REFERENCES Cliente(id)
go

ALTER TABLE Canje ADD CONSTRAINT RefCatalogo26 
    FOREIGN KEY (catalogo_id)
    REFERENCES Catalogo(id)
go


/* 
 * TABLE: Funcionalidad_Rol 
 */

ALTER TABLE Funcionalidad_Rol ADD CONSTRAINT RefFuncionalidad5 
    FOREIGN KEY (funcionalidad_id)
    REFERENCES Funcionalidad(id)
go

ALTER TABLE Funcionalidad_Rol ADD CONSTRAINT RefRol6 
    FOREIGN KEY (rol_id)
    REFERENCES Rol(id)
go


/* 
 * TABLE: Paquete 
 */

ALTER TABLE Paquete ADD CONSTRAINT RefViaje16 
    FOREIGN KEY (viaje_id)
    REFERENCES Viaje(id)
go

ALTER TABLE Paquete ADD CONSTRAINT RefCliente19 
    FOREIGN KEY (cliente_id)
    REFERENCES Cliente(id)
go


/* 
 * TABLE: Pasaje 
 */

ALTER TABLE Pasaje ADD CONSTRAINT RefButaca14 
    FOREIGN KEY (butaca_id)
    REFERENCES Butaca(id)
go

ALTER TABLE Pasaje ADD CONSTRAINT RefCliente15 
    FOREIGN KEY (cliente_id)
    REFERENCES Cliente(id)
go


/* 
 * TABLE: Ruta 
 */

ALTER TABLE Ruta ADD CONSTRAINT RefCiudad8 
    FOREIGN KEY (ciudad_origen_id)
    REFERENCES Ciudad(id)
go

ALTER TABLE Ruta ADD CONSTRAINT RefCiudad9 
    FOREIGN KEY (ciudad_destino_id)
    REFERENCES Ciudad(id)
go

/* 
 * TABLE: Usuario 
 */

ALTER TABLE Usuario ADD CONSTRAINT RefRol7 
    FOREIGN KEY (rol_id)
    REFERENCES Rol(id)
go


/* 
 * TABLE: Viaje 
 */

ALTER TABLE Viaje ADD CONSTRAINT RefRuta3 
    FOREIGN KEY (ruta_id)
    REFERENCES Ruta(id)
go

ALTER TABLE Viaje ADD CONSTRAINT RefAeronave4 
    FOREIGN KEY (aeronave_id)
    REFERENCES Aeronave(id)
go



