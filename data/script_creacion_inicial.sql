USE [GD2C2015]
GO


CREATE SCHEMA [BIEN_MIGRADO_RAFA]
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Aeronave(
    id                        int               IDENTITY(1,1),
    numero                    numeric(18, 0)    NULL,
    matricula                 nvarchar(255)     NULL,
    modelo                    nvarchar(255)     NULL,
    kilogramos_disponibles    numeric(18, 0)    NULL,
    fabricante                nvarchar(255)     NULL,
    CONSTRAINT PK7 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Baja_Aeronave(
    fecha_baja        datetime    NULL,
    fecha_reinicio    datetime    NULL,
    aeronave_id       int         NULL,
    tipo_baja_id      int         NULL
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Butaca(
    id             int               IDENTITY(1,1),
    numero         numeric(18, 0)    NULL,
    tipo           nvarchar(255)     NULL,
    piso           numeric(18, 0)    NULL,
    aeronave_id    int               NULL,
    CONSTRAINT PK3 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Cancelacion(
    id               int               IDENTITY(1,1),
    fecha            datetime          NULL,
    motivo           nvarchar(255)     NULL,
    numero_compra    numeric(18, 0)    NULL,
    CONSTRAINT PK16 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Cancelacion_Paquete(
    id                int    NOT NULL,
    cancelacion_id    int    NULL,
    paquete_id        int    NULL,
    CONSTRAINT PK18 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Cancelacion_Pasaje(
    id                int    IDENTITY(1,1),
    cancelacion_id    int    NULL,
    pasaje_id         int    NULL,
    CONSTRAINT PK17 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Canje(
    id             int               IDENTITY(1,1),
    cantidad       numeric(18, 0)    NULL,
    fecha          datetime          NULL,
    cliente_id     int               NULL,
    cataloGO_id    int               NULL,
    CONSTRAINT PK20 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.CataloGO(
    id             int               IDENTITY(1,1),
    descripcion    nvarchar(255)     NULL,
    costo          numeric(18, 0)    NULL,
    stock          numeric(18, 0)    NULL,
    CONSTRAINT PK19 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Ciudad(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
    CONSTRAINT PK13 PRIMARY KEY NONCLUSTERED (id)
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
    CONSTRAINT PK1 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Funcionalidad(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
    CONSTRAINT PK10 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Funcionalidad_Rol(
    id                  int    IDENTITY(1,1),
    funcionalidad_id    int    NULL,
    rol_id              int    NULL,
    CONSTRAINT PK11 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Paquete(
    id              int               IDENTITY(1,1),
    codiGO          numeric(18, 0)    NULL,
    precio          numeric(18, 2)    NULL,
    kg              numeric(18, 0)    NULL,
    fecha_compra    datetime          NULL,
    viaje_id        int               NULL,
    cliente_id      int               NULL,
    CONSTRAINT PK4 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Pasaje(
    id              int               IDENTITY(1,1),
    codiGO          numeric(18, 0)    NULL,
    precio          numeric(18, 2)    NULL,
    fecha_compra    datetime          NULL,
    butaca_id       int               NULL,
    cliente_id      int               NULL,
    CONSTRAINT PK2 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Rol(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
    CONSTRAINT PK9 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Ruta(
    id                     int               IDENTITY(1,1),
    codiGO                 numeric(18, 0)    NULL,
    precio_base_kg         numeric(18, 2)    NULL,
    precio_base_pasajes    numeric(18, 2)    NULL,
    ciudad_origen_id       int               NULL,
    ciudad_destino_id      int               NULL,
    CONSTRAINT PK6 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Tipo_Baja(
    id             int              IDENTITY(1,1),
    descripcion    nvarchar(255)    NULL,
    CONSTRAINT PK14 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Tipo_Servicio(
    descripcion    nvarchar(255)    NULL
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Usuario(
    id          int              IDENTITY(1,1),
    username    nvarchar(255)    NULL,
    password    nvarchar(255)    NULL,
    rol_id      int              NULL,
    CONSTRAINT PK12 PRIMARY KEY NONCLUSTERED (id)
)
GO


CREATE TABLE BIEN_MIGRADO_RAFA.Viaje(
    id                        int         IDENTITY(1,1),
    fecha_salida              datetime    NULL,
    fecha_llegada             datetime    NULL,
    fecha_llegada_estimada    datetime    NULL,
    ruta_id                   int         NULL,
    aeronave_id               int         NULL,
    CONSTRAINT PK5 PRIMARY KEY NONCLUSTERED (id)
)
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


ALTER TABLE BIEN_MIGRADO_RAFA.Canje ADD CONSTRAINT RefCataloGO26 
    FOREIGN KEY (cataloGO_id)
    REFERENCES BIEN_MIGRADO_RAFA.CataloGO(id)
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