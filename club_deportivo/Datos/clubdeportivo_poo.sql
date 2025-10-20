-- ==========================================================
--  BASE DE DATOS ClubDeportivo1 (FINAL?)
-- ==========================================================

-- DROP DATABASE IF EXISTS ClubDeportivo1;
-- CREATE DATABASE IF NOT EXISTS ClubDeportivo1;
USE ClubDeportivo1;

-- ==================================================
--  Clase Persona (Herencia) (Superclase)
 -- ==================================================

-- Tabla Persona (Superclase)
CREATE TABLE IF NOT EXISTS Persona (
  PersonaId INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(100) NOT NULL,
  Apellido VARCHAR(100) NOT NULL,
  TipoDni VARCHAR(50) NULL, -- Identifica el tipo de documento (DNI, Pasaporte)
  NroDni VARCHAR(50) NOT NULL UNIQUE, -- DNI como identificador único
  FechaNacimiento DATE NULL, 
  Telefono VARCHAR(50) NULL,
  Email VARCHAR(50) NULL
);

-- Tabla Socio (Clase Socio Hereda de Persona)
CREATE TABLE IF NOT EXISTS Socio (
  SocioId INT PRIMARY KEY, -- Hereda PersonaId
  FechaAltaSocio DATE NOT NULL, 
  NroCarnet VARCHAR(50) NOT NULL UNIQUE,
  FOREIGN KEY (SocioId) REFERENCES Persona(PersonaId) ON DELETE CASCADE
);

-- Tabla NoSocio (Clase NoSocio hereda de Persona)
CREATE TABLE IF NOT EXISTS NoSocio (
  NoSocioId INT PRIMARY KEY,
  FOREIGN KEY (NoSocioId) REFERENCES Persona(PersonaId) ON DELETE CASCADE
);

-- Tabla Profesor (Staff/Actividad) Eliminada 

-- ==================================================
--  Seguridad & Inicialización (Registro, Login)
-- ==================================================

-- Tabla Roles (Para permisos como Administrador y Staff)
CREATE TABLE IF NOT EXISTS Roles (
  RolId INT PRIMARY KEY,
  NombreRol VARCHAR(50) NOT NULL UNIQUE
);

-- Tabla Usuario (login y registro)
CREATE TABLE IF NOT EXISTS Usuario (
  UsuarioId INT AUTO_INCREMENT PRIMARY KEY,
  Username VARCHAR(50) NOT NULL UNIQUE,
  PasswordHash VARBINARY(256) NOT NULL, -- Guardar hash real en producción
  EmpleadoNombre VARCHAR(150) NULL,
  RolId INT NOT NULL,
  Activo BIT NOT NULL DEFAULT 1,
  PersonaId INT NULL, -- Relación opcional con Persona
  FOREIGN KEY (RolId) REFERENCES Roles(RolId),
  FOREIGN KEY (PersonaId) REFERENCES Persona(PersonaId)
);

-- ==========================================================
--  Clase Actividad (UML) 
-- ==========================================================

-- Tabla Actividad (Única)
CREATE TABLE IF NOT EXISTS Actividad (
  ActividadId INT AUTO_INCREMENT PRIMARY KEY,
  NombreActividad VARCHAR(100) NOT NULL UNIQUE,
  MontoActividad DECIMAL(10, 2) NOT NULL,
  CostoSocio DECIMAL(10, 2) NOT NULL DEFAULT 0.00 -- Para lógica de negocio profesional
);

-- Tabla Profesor_Actividad (Eliminada) 

-- ==================================================
--  Gestión de pagos (UML)
-- ==================================================

-- Tabla PagoRealizado (Registro maestro de transacción)
CREATE TABLE IF NOT EXISTS PagoRealizado (
  PagoRealizadoId INT AUTO_INCREMENT PRIMARY KEY,
  FechaPago DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  MontoTotal DECIMAL(10, 2) NOT NULL,
  TipoConcepto VARCHAR(50) NOT NULL, -- 'Cuota', 'Diario'
  MedioPago VARCHAR(50) NOT NULL,
  ReferenciaId INT NOT NULL -- SocioId o NoSocioId según tipo
);

-- Tabla PagoCuota (Detalle de pagos mensuales)
CREATE TABLE IF NOT EXISTS PagoCuota (
  CuotaId INT AUTO_INCREMENT PRIMARY KEY,
  SocioId INT NOT NULL,
  FechaVencimientoCuota DATE NOT NULL,
  EstadoCuota VARCHAR(50) NOT NULL, -- 'Pagado', 'Pendiente', etc.
  MontoCuota DECIMAL(10, 2) NOT NULL,
  MedioPago VARCHAR(50) NULL,
  PagoRealizadoId INT NULL UNIQUE, -- Relación opcional con PagoRealizado
  MesCuota INT AS (MONTH(FechaVencimientoCuota)) STORED,
  AnioCuota INT AS (YEAR(FechaVencimientoCuota)) STORED,
  FOREIGN KEY (SocioId) REFERENCES Socio(SocioId) ON DELETE CASCADE,
  FOREIGN KEY (PagoRealizadoId) REFERENCES PagoRealizado(PagoRealizadoId)
);

-- DROP INDEX UX_CUOTA_Socio_Periodo ON PagoCuota;

-- Índice único por Socio y periodo (mes/año)
CREATE UNIQUE INDEX UX_CUOTA_Socio_Periodo ON PagoCuota(
  SocioId, MesCuota, AnioCuota
);

-- Tabla PagoDiario (Detalle de pases diarios)
CREATE TABLE IF NOT EXISTS PagoDiario (
  PagoDiarioId INT AUTO_INCREMENT PRIMARY KEY,
  NoSocioId INT NOT NULL,
  ActividadId INT NOT NULL,
  FechaPago DATE NOT NULL,
  MontoPagado DECIMAL(10, 2) NOT NULL,
  PagoRealizadoId INT NULL UNIQUE, -- Relación opcional con PagoRealizado
  FOREIGN KEY (NoSocioId) REFERENCES NoSocio(NoSocioId) ON DELETE CASCADE,
  FOREIGN KEY (ActividadId) REFERENCES Actividad(ActividadId) ON DELETE RESTRICT,
  FOREIGN KEY (PagoRealizadoId) REFERENCES PagoRealizado(PagoRealizadoId)
);

-- ==================================================
--  Roles predefinidos para el sistema
-- ==================================================

INSERT INTO Roles (RolId, NombreRol) 
VALUES 
(100, 'Administrador'),
(200, 'Staff');

-- Crear usuario de prueba (PersonaId)
INSERT INTO Usuario (Username, PasswordHash, EmpleadoNombre, RolId, Activo)
VALUES (
  'admin', -- Marcos
  CAST('admin123' AS BINARY), -- En producción, reemplazar por hash seguro
  'Administrador',
  100,
  1
);

-- ==================================================
-- INSERCIÓN DE DATOS INICIALES Y DE PRUEBA
-- ==================================================

-- Datos de Personas/Socios/NoSocios de prueba
INSERT INTO Persona (PersonaID, Nombre, Apellido, NroDni)
VALUES 
(1, 'Annie', 'Socio', '111111222'),
(2, 'Marisol', 'NoSocio', '23456789'),
(3, 'Jhona', 'Socio', '34556721');

INSERT INTO Socio (SocioId, FechaAltaSocio, NroCarnet) 
VALUES
(1, CURDATE(), 'SC001'),
(3, CURDATE(), 'SC003');

INSERT INTO NoSocio (NoSocioID) 
VALUES
(2);

-- Datos de Actividades de prueba
INSERT INTO Actividad (ActividadId, NombreActividad, MontoActividad, CostoSocio) VALUES
(1, 'Natacion Libre', 5000.00, 3000.00),
(2, 'Clase de Spinning', 3500.00, 2500.00);

-- ==================================================
-- PROCEDIMIENTOS ALMACENADOS
-- ==================================================

DELIMITER //

CREATE PROCEDURE IngresoLogin(
    IN Usu VARCHAR(50),
    IN Pass VARCHAR(50)
)
BEGIN
    SELECT * 
    FROM Usuario
    WHERE Username = Usu
      AND PasswordHash = CAST(Pass AS BINARY);
END //

DELIMITER ;

-- ===========================================================================
--  Consulta unificada: Pagoss de cuota (Socios) y Pagos diarios (NoSocios)
-- ============================================================================

SELECT '--- Reporte unificcado de pagos ---' AS 'Verificación';
( 
-- Pagos de Cuotas (Socios)
  SELECT 
  pr.PagoRealizadoId AS Comprobante,
  pr.FechaPago,
  pr.MontoTotal AS Monto,
  pr.TipoConcepto AS Tipo,
  pr.MedioPago,
  concat(p.Nombre, '', p.Apellido) AS NombreCompleto,
  'Socio' AS TipoPersona,
  pc.FechaVencimientoCuota AS FechaDetalle,  -- Usamos para el Vencimiento
  NULL AS ActividadNombre
  FROM pagorealizado pr
  JOIN pagocuota pc ON pr.PagoRealizadoId = pc.PagoRealizadoId
  JOIN Socio s ON pc.SocioId = s.SocioId
  JOIN Persona p ON s.SocioId = p.PersonaId
)
UNION ALL
(
-- Pagos diarios (NoSocios)
SELECT
  pr.PagoRealizadoId AS Comprobante,
  pr.FechaPago,
  pr.MontoTotal AS Monto,
  pr.TipoConcepto AS Tipo,   -- 'Diario'
  pr.MedioPago,
  CONCAT(p.Nombre, '', p.Apellido) AS NombreComplleto, 
  'NoSocio' AS TipoPersona,
  NULL AS FechaDetalle,                 -- NULL para campos de Cuota
  a.NombreActividad AS ActividadNombre  -- Usamos para Actividad
  FROM pagorealizado pr
  JOIN pagodiario pd ON pr.PagoRealizadoId = pd.PagoRealizadoId
  JOIN nosocio ns ON pd.NoSocioId = ns.NoSocioId
  JOIN Persona p ON ns.NoSocioId = p.PersonaId
  JOIN actividad a ON pd.ActividadId = a.ActividadId
)
ORDER BY FechaPago DESC;

-- ===========================================================================
--  Verificación final
-- ============================================================================

USE ClubDeportivo1;
SELECT '--- Tablas Esenciales Creadas ---' AS 'Estado';
SELECT * FROM Usuario;
SELECT * FROM Roles;
SELECT * FROM Persona;
SELECT * FROM Actividad;

GRANT EXECUTE ON ClubDeportivo1.* TO 'root'@'localhost';
FLUSH PRIVILEGES;

-- SHOW PROCEDURE STATUS WHERE Db='ClubDeportivo1';

-- CALL IngresoLogin('admin','admin123');

-- SHOW PROCEDURE STATUS WHERE Db='ClubDeportivo1';

-- =======================================================================

