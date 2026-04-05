-- =============================================
-- BASE DE DATOS: BDSistemaFacturacion
-- =============================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'BDSistemaFacturacion')
    DROP DATABASE BDSistemaFacturacion;
GO

CREATE DATABASE BDSistemaFacturacion;
GO

USE BDSistemaFacturacion;
GO

------------------------------------------------
-- TABLAS
------------------------------------------------

CREATE TABLE Categorias (
    IdCategoria     INT IDENTITY(1,1) PRIMARY KEY,
    NombreCategoria NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Clientes (
    IdCliente  INT IDENTITY(1,1) PRIMARY KEY,
    Nombre     NVARCHAR(150) NOT NULL,
    Documento  NVARCHAR(20)  NOT NULL,
    Direccion  NVARCHAR(200),
    Correo     NVARCHAR(100)
);
GO

CREATE TABLE Roles (
    IdRol       INT IDENTITY(1,1) PRIMARY KEY,
    NombreRol   NVARCHAR(50) NOT NULL UNIQUE
);
GO

CREATE TABLE Empleados (
    IdEmpleado    INT IDENTITY(1,1) PRIMARY KEY,
    Nombre        NVARCHAR(150) NOT NULL,
    Documento     NVARCHAR(20),
    Direccion     NVARCHAR(200),
    Telefono      NVARCHAR(20),
    Email         NVARCHAR(100),
    IdRol         INT,
    FechaIngreso  DATE,
    FechaRetiro   DATE,
    Detalles      NVARCHAR(500),
    FOREIGN KEY (IdRol) REFERENCES Roles(IdRol)
);
GO

CREATE TABLE Usuarios (
    IdUsuario   INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpleado  INT          NOT NULL,
    Usuario     NVARCHAR(50) NOT NULL UNIQUE,
    Clave       NVARCHAR(100) NOT NULL,
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);
GO

CREATE TABLE Productos (
    IdProducto     INT IDENTITY(1,1) PRIMARY KEY,
    Codigo         NVARCHAR(50)  NOT NULL,
    NombreProducto NVARCHAR(150) NOT NULL,
    PrecioCompra   DECIMAL(10,2) NOT NULL,
    PrecioVenta    DECIMAL(10,2) NOT NULL,
    Stock          INT           NOT NULL DEFAULT 0,
    RutaImagen     NVARCHAR(300),
    Detalles       NVARCHAR(500),
    IdCategoria    INT,
    FOREIGN KEY (IdCategoria) REFERENCES Categorias(IdCategoria)
);
GO

------------------------------------------------
-- DATOS INICIALES
------------------------------------------------

INSERT INTO Categorias (NombreCategoria) VALUES
    ('General'), ('Electronica'), ('Ropa'), ('Alimentos');

INSERT INTO Roles (NombreRol) VALUES
    ('Administrador'),
    ('Empleado'),
    ('Usuario'),
    ('Vendedor'),
    ('Supervisor'),
    ('Cliente');

INSERT INTO Empleados (Nombre, Documento, IdRol) VALUES
    ('Administrador', '000000001', 1);

INSERT INTO Usuarios (IdEmpleado, Usuario, Clave) VALUES
    (1, 'admin', 'admin123');

INSERT INTO Productos (Codigo, NombreProducto, PrecioCompra, PrecioVenta, Stock, RutaImagen, Detalles, IdCategoria) VALUES
    ('PROD-001', 'Producto Demo',        10.00,  15.00, 100, '', 'Producto de ejemplo por defecto', 1),
    ('PROD-002', 'Laptop HP 15',        700.00, 950.00,  20, '', 'Laptop 15 pulgadas, Core i5',      2),
    ('PROD-003', 'Mouse Inalámbrico',     8.00,  18.00,  50, '', 'Mouse óptico inalámbrico',          2),
    ('PROD-004', 'Camiseta Básica',       5.00,  12.00,  80, '', 'Camiseta 100% algodón',             3),
    ('PROD-005', 'Arroz 5kg',             4.00,   7.50,  60, '', 'Arroz blanco premium',              4);

INSERT INTO Empleados (Nombre, Documento, Direccion, Telefono, Email, IdRol, FechaIngreso) VALUES
    ('Carlos Pérez',  '12345678', 'Calle 10 #5-20', '3001234567', 'carlos@empresa.com', 4, '2024-01-15'),
    ('Ana Gómez',     '87654321', 'Cra 7 #20-30',   '3109876543', 'ana@empresa.com',    4, '2024-03-01');

INSERT INTO Clientes (Nombre, Documento, Direccion, Correo) VALUES
    ('Juan Rodríguez',  '11111111', 'Av. Principal 100', 'juan@gmail.com'),
    ('María López',     '22222222', 'Calle 5 #3-40',     'maria@hotmail.com'),
    ('Empresa ABC Ltda','33333333', 'Zona Industrial 55', 'compras@abc.com');
GO

------------------------------------------------
-- STORED PROCEDURES - LOGIN
------------------------------------------------

CREATE OR ALTER PROCEDURE sp_ValidarLogin
    @Usuario NVARCHAR(50),
    @Clave   NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT u.IdUsuario, u.Usuario, e.Nombre, r.NombreRol AS Rol
    FROM Usuarios u
    INNER JOIN Empleados e ON u.IdEmpleado = e.IdEmpleado
    LEFT  JOIN Roles     r ON e.IdRol      = r.IdRol
    WHERE u.Usuario = @Usuario AND u.Clave = @Clave;
END;
GO

------------------------------------------------
-- STORED PROCEDURES - CLIENTES
------------------------------------------------

CREATE OR ALTER PROCEDURE sp_ListarClientes
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdCliente, Nombre, Documento, Direccion, Correo
    FROM Clientes
    ORDER BY Nombre;
END;
GO

CREATE OR ALTER PROCEDURE sp_BuscarClientes
    @Criterio NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdCliente, Nombre, Documento, Direccion, Correo
    FROM Clientes
    WHERE Nombre    LIKE '%' + @Criterio + '%'
       OR Documento LIKE '%' + @Criterio + '%'
    ORDER BY Nombre;
END;
GO

CREATE OR ALTER PROCEDURE sp_ObtenerClientePorId
    @IdCliente INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdCliente, Nombre, Documento, Direccion, Correo
    FROM Clientes
    WHERE IdCliente = @IdCliente;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertarCliente
    @Nombre    NVARCHAR(150),
    @Documento NVARCHAR(20),
    @Direccion NVARCHAR(200),
    @Correo    NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Clientes (Nombre, Documento, Direccion, Correo)
    VALUES (@Nombre, @Documento, @Direccion, @Correo);
END;
GO

CREATE OR ALTER PROCEDURE sp_ActualizarCliente
    @IdCliente INT,
    @Nombre    NVARCHAR(150),
    @Documento NVARCHAR(20),
    @Direccion NVARCHAR(200),
    @Correo    NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Clientes
    SET Nombre    = @Nombre,
        Documento = @Documento,
        Direccion = @Direccion,
        Correo    = @Correo
    WHERE IdCliente = @IdCliente;
END;
GO

CREATE OR ALTER PROCEDURE sp_EliminarCliente
    @IdCliente INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Clientes WHERE IdCliente = @IdCliente;
END;
GO

------------------------------------------------
-- STORED PROCEDURES - PRODUCTOS
------------------------------------------------

CREATE OR ALTER PROCEDURE sp_ListarProductos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT p.IdProducto, p.Codigo, p.NombreProducto, p.PrecioCompra,
           p.PrecioVenta, p.Stock, p.RutaImagen, p.Detalles,
           p.IdCategoria, c.NombreCategoria
    FROM Productos p
    LEFT JOIN Categorias c ON p.IdCategoria = c.IdCategoria
    ORDER BY p.NombreProducto;
END;
GO

CREATE OR ALTER PROCEDURE sp_BuscarProductos
    @Criterio NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT p.IdProducto, p.Codigo, p.NombreProducto, p.PrecioCompra,
           p.PrecioVenta, p.Stock, p.RutaImagen, p.Detalles,
           p.IdCategoria, c.NombreCategoria
    FROM Productos p
    LEFT JOIN Categorias c ON p.IdCategoria = c.IdCategoria
    WHERE p.NombreProducto LIKE '%' + @Criterio + '%'
       OR p.Codigo         LIKE '%' + @Criterio + '%'
    ORDER BY p.NombreProducto;
END;
GO

CREATE OR ALTER PROCEDURE sp_ObtenerProductoPorId
    @IdProducto INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdProducto, Codigo, NombreProducto, PrecioCompra,
           PrecioVenta, Stock, RutaImagen, Detalles, IdCategoria
    FROM Productos
    WHERE IdProducto = @IdProducto;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertarProducto
    @Codigo         NVARCHAR(50),
    @NombreProducto NVARCHAR(150),
    @PrecioCompra   DECIMAL(10,2),
    @PrecioVenta    DECIMAL(10,2),
    @Stock          INT,
    @RutaImagen     NVARCHAR(300),
    @Detalles       NVARCHAR(500),
    @IdCategoria    INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Productos (Codigo, NombreProducto, PrecioCompra, PrecioVenta, Stock, RutaImagen, Detalles, IdCategoria)
    VALUES (@Codigo, @NombreProducto, @PrecioCompra, @PrecioVenta, @Stock, @RutaImagen, @Detalles, @IdCategoria);
END;
GO

CREATE OR ALTER PROCEDURE sp_ActualizarProducto
    @IdProducto     INT,
    @Codigo         NVARCHAR(50),
    @NombreProducto NVARCHAR(150),
    @PrecioCompra   DECIMAL(10,2),
    @PrecioVenta    DECIMAL(10,2),
    @Stock          INT,
    @RutaImagen     NVARCHAR(300),
    @Detalles       NVARCHAR(500),
    @IdCategoria    INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Productos
    SET Codigo         = @Codigo,
        NombreProducto = @NombreProducto,
        PrecioCompra   = @PrecioCompra,
        PrecioVenta    = @PrecioVenta,
        Stock          = @Stock,
        RutaImagen     = @RutaImagen,
        Detalles       = @Detalles,
        IdCategoria    = @IdCategoria
    WHERE IdProducto = @IdProducto;
END;
GO

CREATE OR ALTER PROCEDURE sp_EliminarProducto
    @IdProducto INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Productos WHERE IdProducto = @IdProducto;
END;
GO

CREATE OR ALTER PROCEDURE sp_ListarCategorias
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdCategoria, NombreCategoria FROM Categorias ORDER BY NombreCategoria;
END;
GO

------------------------------------------------
-- STORED PROCEDURES - SEGURIDAD
------------------------------------------------

CREATE OR ALTER PROCEDURE sp_ListarRoles
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdRol, NombreRol FROM Roles ORDER BY NombreRol;
END;
GO

CREATE OR ALTER PROCEDURE sp_ListarEmpleados
AS
BEGIN
    SET NOCOUNT ON;
    SELECT e.IdEmpleado, e.Nombre, e.Documento, e.Telefono, e.Email,
           r.NombreRol AS Rol, e.FechaIngreso
    FROM Empleados e
    LEFT JOIN Roles r ON e.IdRol = r.IdRol
    ORDER BY e.Nombre;
END;
GO

CREATE OR ALTER PROCEDURE sp_BuscarEmpleados
    @Criterio NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT e.IdEmpleado, e.Nombre, e.Documento, e.Telefono, e.Email,
           r.NombreRol AS Rol, e.FechaIngreso
    FROM Empleados e
    LEFT JOIN Roles r ON e.IdRol = r.IdRol
    WHERE e.Nombre     LIKE '%' + @Criterio + '%'
       OR e.Documento  LIKE '%' + @Criterio + '%'
       OR e.Email      LIKE '%' + @Criterio + '%'
    ORDER BY e.Nombre;
END;
GO

CREATE OR ALTER PROCEDURE sp_ObtenerEmpleadoPorId
    @IdEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdEmpleado, Nombre, Documento, Direccion, Telefono, Email,
           IdRol, FechaIngreso, FechaRetiro, Detalles
    FROM Empleados
    WHERE IdEmpleado = @IdEmpleado;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertarEmpleado
    @Nombre       NVARCHAR(150),
    @Documento    NVARCHAR(20),
    @Direccion    NVARCHAR(200),
    @Telefono     NVARCHAR(20),
    @Email        NVARCHAR(100),
    @IdRol        INT,
    @FechaIngreso DATE,
    @FechaRetiro  DATE = NULL,
    @Detalles     NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Empleados (Nombre, Documento, Direccion, Telefono, Email,
                           IdRol, FechaIngreso, FechaRetiro, Detalles)
    VALUES (@Nombre, @Documento, @Direccion, @Telefono, @Email,
            @IdRol, @FechaIngreso, @FechaRetiro, @Detalles);
END;
GO

CREATE OR ALTER PROCEDURE sp_ActualizarEmpleado
    @IdEmpleado   INT,
    @Nombre       NVARCHAR(150),
    @Documento    NVARCHAR(20),
    @Direccion    NVARCHAR(200),
    @Telefono     NVARCHAR(20),
    @Email        NVARCHAR(100),
    @IdRol        INT,
    @FechaIngreso DATE,
    @FechaRetiro  DATE = NULL,
    @Detalles     NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Empleados
    SET Nombre       = @Nombre,
        Documento    = @Documento,
        Direccion    = @Direccion,
        Telefono     = @Telefono,
        Email        = @Email,
        IdRol        = @IdRol,
        FechaIngreso = @FechaIngreso,
        FechaRetiro  = @FechaRetiro,
        Detalles     = @Detalles
    WHERE IdEmpleado = @IdEmpleado;
END;
GO

CREATE OR ALTER PROCEDURE sp_EliminarEmpleado
    @IdEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Empleados WHERE IdEmpleado = @IdEmpleado;
END;
GO

CREATE OR ALTER PROCEDURE sp_ListarUsuariosSistema
AS
BEGIN
    SET NOCOUNT ON;
    SELECT u.IdUsuario, u.Usuario, e.Nombre AS NombreEmpleado
    FROM Usuarios u
    INNER JOIN Empleados e ON u.IdEmpleado = e.IdEmpleado
    ORDER BY u.Usuario;
END;
GO

CREATE OR ALTER PROCEDURE sp_ActualizarUsuario
    @IdUsuario INT,
    @Usuario   NVARCHAR(50),
    @Clave     NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Usuarios
    SET Usuario = @Usuario, Clave = @Clave
    WHERE IdUsuario = @IdUsuario;
END;
GO

CREATE OR ALTER PROCEDURE sp_ObtenerUsuarioPorEmpleado
    @IdEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdUsuario, Usuario, Clave
    FROM Usuarios
    WHERE IdEmpleado = @IdEmpleado;
END;
GO

CREATE OR ALTER PROCEDURE sp_ActualizarSeguridad
    @IdEmpleado INT,
    @Usuario    NVARCHAR(50),
    @Clave      NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM Usuarios WHERE IdEmpleado = @IdEmpleado)
    BEGIN
        UPDATE Usuarios
        SET Usuario = @Usuario, Clave = @Clave
        WHERE IdEmpleado = @IdEmpleado;
    END
    ELSE
    BEGIN
        INSERT INTO Usuarios (IdEmpleado, Usuario, Clave)
        VALUES (@IdEmpleado, @Usuario, @Clave);
    END
END;
GO

------------------------------------------------
-- TABLAS DE FACTURACION
------------------------------------------------

CREATE TABLE Facturas (
    IdFactura      INT IDENTITY(1,1) PRIMARY KEY,
    NumeroFactura  NVARCHAR(20)  NOT NULL UNIQUE,
    IdCliente      INT           NOT NULL,
    IdEmpleado     INT           NOT NULL,
    FechaFactura   DATE          NOT NULL DEFAULT GETDATE(),
    Descuento      DECIMAL(10,2) NOT NULL DEFAULT 0,
    Subtotal       DECIMAL(10,2) NOT NULL DEFAULT 0,
    IVA            DECIMAL(10,2) NOT NULL DEFAULT 0,
    Total          DECIMAL(10,2) NOT NULL DEFAULT 0,
    Estado         NVARCHAR(20)  NOT NULL DEFAULT 'Pendiente',
    FOREIGN KEY (IdCliente)  REFERENCES Clientes(IdCliente),
    FOREIGN KEY (IdEmpleado) REFERENCES Empleados(IdEmpleado)
);
GO

CREATE TABLE FacturaDetalles (
    IdDetalle      INT IDENTITY(1,1) PRIMARY KEY,
    IdFactura      INT           NOT NULL,
    IdProducto     INT           NOT NULL,
    Cantidad       INT           NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Subtotal       DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdFactura)  REFERENCES Facturas(IdFactura),
    FOREIGN KEY (IdProducto) REFERENCES Productos(IdProducto)
);
GO

------------------------------------------------
-- STORED PROCEDURES - FACTURAS
------------------------------------------------

CREATE OR ALTER PROCEDURE sp_GenerarNumeroFactura
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Numero INT;
    SELECT @Numero = ISNULL(MAX(CAST(SUBSTRING(NumeroFactura, 5, LEN(NumeroFactura)) AS INT)), 0) + 1
    FROM Facturas;
    SELECT 'FAC-' + RIGHT('0000' + CAST(@Numero AS NVARCHAR(10)), 4) AS NumeroFactura;
END;
GO

CREATE OR ALTER PROCEDURE sp_ListarFacturas
AS
BEGIN
    SET NOCOUNT ON;
    SELECT f.IdFactura, f.NumeroFactura,
           c.Nombre    AS Cliente,
           e.Nombre    AS Empleado,
           f.FechaFactura, f.Subtotal, f.Descuento, f.IVA, f.Total, f.Estado
    FROM Facturas f
    INNER JOIN Clientes  c ON f.IdCliente  = c.IdCliente
    INNER JOIN Empleados e ON f.IdEmpleado = e.IdEmpleado
    ORDER BY f.IdFactura DESC;
END;
GO

CREATE OR ALTER PROCEDURE sp_BuscarFacturas
    @Criterio NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT f.IdFactura, f.NumeroFactura,
           c.Nombre    AS Cliente,
           e.Nombre    AS Empleado,
           f.FechaFactura, f.Subtotal, f.Descuento, f.IVA, f.Total, f.Estado
    FROM Facturas f
    INNER JOIN Clientes  c ON f.IdCliente  = c.IdCliente
    INNER JOIN Empleados e ON f.IdEmpleado = e.IdEmpleado
    WHERE f.NumeroFactura LIKE '%' + @Criterio + '%'
       OR c.Nombre        LIKE '%' + @Criterio + '%'
    ORDER BY f.IdFactura DESC;
END;
GO

CREATE OR ALTER PROCEDURE sp_ObtenerFacturaPorId
    @IdFactura INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdFactura, NumeroFactura, IdCliente, IdEmpleado,
           FechaFactura, Descuento, Subtotal, IVA, Total, Estado
    FROM Facturas
    WHERE IdFactura = @IdFactura;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertarFactura
    @NumeroFactura NVARCHAR(20),
    @IdCliente     INT,
    @IdEmpleado    INT,
    @FechaFactura  DATE,
    @Descuento     DECIMAL(10,2),
    @Subtotal      DECIMAL(10,2),
    @IVA           DECIMAL(10,2),
    @Total         DECIMAL(10,2),
    @Estado        NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Facturas (NumeroFactura, IdCliente, IdEmpleado, FechaFactura,
                          Descuento, Subtotal, IVA, Total, Estado)
    VALUES (@NumeroFactura, @IdCliente, @IdEmpleado, @FechaFactura,
            @Descuento, @Subtotal, @IVA, @Total, @Estado);
    SELECT SCOPE_IDENTITY() AS IdFactura;
END;
GO

CREATE OR ALTER PROCEDURE sp_ActualizarFactura
    @IdFactura    INT,
    @IdCliente    INT,
    @IdEmpleado   INT,
    @FechaFactura DATE,
    @Descuento    DECIMAL(10,2),
    @Subtotal     DECIMAL(10,2),
    @IVA          DECIMAL(10,2),
    @Total        DECIMAL(10,2),
    @Estado       NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Facturas
    SET IdCliente    = @IdCliente,
        IdEmpleado   = @IdEmpleado,
        FechaFactura = @FechaFactura,
        Descuento    = @Descuento,
        Subtotal     = @Subtotal,
        IVA          = @IVA,
        Total        = @Total,
        Estado       = @Estado
    WHERE IdFactura = @IdFactura;
END;
GO

CREATE OR ALTER PROCEDURE sp_EliminarFactura
    @IdFactura INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM FacturaDetalles WHERE IdFactura = @IdFactura;
    DELETE FROM Facturas         WHERE IdFactura = @IdFactura;
END;
GO

------------------------------------------------
-- STORED PROCEDURES - DETALLE FACTURA
------------------------------------------------

CREATE OR ALTER PROCEDURE sp_ListarDetallesFactura
    @IdFactura INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT fd.IdDetalle, fd.IdProducto, p.NombreProducto,
           fd.Cantidad, fd.PrecioUnitario, fd.Subtotal
    FROM FacturaDetalles fd
    INNER JOIN Productos p ON fd.IdProducto = p.IdProducto
    WHERE fd.IdFactura = @IdFactura;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertarDetalleFactura
    @IdFactura      INT,
    @IdProducto     INT,
    @Cantidad       INT,
    @PrecioUnitario DECIMAL(10,2),
    @Subtotal       DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO FacturaDetalles (IdFactura, IdProducto, Cantidad, PrecioUnitario, Subtotal)
    VALUES (@IdFactura, @IdProducto, @Cantidad, @PrecioUnitario, @Subtotal);
END;
GO

CREATE OR ALTER PROCEDURE sp_EliminarDetallesFactura
    @IdFactura INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM FacturaDetalles WHERE IdFactura = @IdFactura;
END;
GO

------------------------------------------------
-- DATOS DE EJEMPLO - FACTURAS
------------------------------------------------

-- Factura 1: Juan Rodríguez compra Mouse + Camiseta
INSERT INTO Facturas (NumeroFactura, IdCliente, IdEmpleado, FechaFactura, Descuento, Subtotal, IVA, Total, Estado)
VALUES ('FAC-0001', 1, 2, '2026-03-10', 0.00, 30.00, 5.70, 35.70, 'Pagada');

INSERT INTO FacturaDetalles (IdFactura, IdProducto, Cantidad, PrecioUnitario, Subtotal) VALUES
    (1, 3, 1, 18.00, 18.00),
    (1, 4, 1, 12.00, 12.00);

-- Factura 2: María López compra Laptop + Mouse  (descuento $50)
INSERT INTO Facturas (NumeroFactura, IdCliente, IdEmpleado, FechaFactura, Descuento, Subtotal, IVA, Total, Estado)
VALUES ('FAC-0002', 2, 3, '2026-03-25', 50.00, 968.00, 173.22, 1091.22, 'Pagada');

INSERT INTO FacturaDetalles (IdFactura, IdProducto, Cantidad, PrecioUnitario, Subtotal) VALUES
    (2, 2, 1, 950.00, 950.00),
    (2, 3, 1,  18.00,  18.00);

-- Factura 3: Empresa ABC compra Arroz x5 + Producto Demo x3
INSERT INTO Facturas (NumeroFactura, IdCliente, IdEmpleado, FechaFactura, Descuento, Subtotal, IVA, Total, Estado)
VALUES ('FAC-0003', 3, 2, '2026-04-01', 0.00, 82.50, 15.68, 98.18, 'Pendiente');

INSERT INTO FacturaDetalles (IdFactura, IdProducto, Cantidad, PrecioUnitario, Subtotal) VALUES
    (3, 5, 5,  7.50, 37.50),
    (3, 1, 3, 15.00, 45.00);
GO
