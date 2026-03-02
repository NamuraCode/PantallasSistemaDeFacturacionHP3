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
    Correo     NVARCHAR(100),
    Email      NVARCHAR(100)
);
GO

CREATE TABLE Empleados (
    IdEmpleado    INT IDENTITY(1,1) PRIMARY KEY,
    Nombre        NVARCHAR(150) NOT NULL,
    Documento     NVARCHAR(20),
    Direccion     NVARCHAR(200),
    Telefono      NVARCHAR(20),
    Email         NVARCHAR(100),
    Rol           NVARCHAR(50),
    FechaIngreso  DATE,
    FechaRetiro   DATE,
    Detalles      NVARCHAR(500)
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

INSERT INTO Empleados (Nombre, Documento, Rol) VALUES
    ('Administrador', '000000001', 'Admin');

INSERT INTO Usuarios (IdEmpleado, Usuario, Clave) VALUES
    (1, 'admin', 'admin123');
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
    SELECT u.IdUsuario, u.Usuario, e.Nombre, e.Rol
    FROM Usuarios u
    INNER JOIN Empleados e ON u.IdEmpleado = e.IdEmpleado
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
    SELECT IdCliente, Nombre, Documento, Direccion, Correo, Email
    FROM Clientes
    ORDER BY Nombre;
END;
GO

CREATE OR ALTER PROCEDURE sp_BuscarClientes
    @Criterio NVARCHAR(150)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdCliente, Nombre, Documento, Direccion, Correo, Email
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
    SELECT IdCliente, Nombre, Documento, Direccion, Correo, Email
    FROM Clientes
    WHERE IdCliente = @IdCliente;
END;
GO

CREATE OR ALTER PROCEDURE sp_InsertarCliente
    @Nombre    NVARCHAR(150),
    @Documento NVARCHAR(20),
    @Direccion NVARCHAR(200),
    @Correo    NVARCHAR(100),
    @Email     NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Clientes (Nombre, Documento, Direccion, Correo, Email)
    VALUES (@Nombre, @Documento, @Direccion, @Correo, @Email);
END;
GO

CREATE OR ALTER PROCEDURE sp_ActualizarCliente
    @IdCliente INT,
    @Nombre    NVARCHAR(150),
    @Documento NVARCHAR(20),
    @Direccion NVARCHAR(200),
    @Correo    NVARCHAR(100),
    @Email     NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Clientes
    SET Nombre    = @Nombre,
        Documento = @Documento,
        Direccion = @Direccion,
        Correo    = @Correo,
        Email     = @Email
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

CREATE OR ALTER PROCEDURE sp_ListarEmpleados
AS
BEGIN
    SET NOCOUNT ON;
    SELECT IdEmpleado, Nombre FROM Empleados ORDER BY Nombre;
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
