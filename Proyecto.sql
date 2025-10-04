
-- DROP DATABASE IF EXISTS Proyecto;
-- CREATE DATABASE Proyecto;

USE Proyecto;

-- ==================================================
--  Clase Persona (Herencia UML) (Superclase)
-- ==================================================

-- Tabla Persona
CREATE TABLE Persona (
  PersonaId INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(100) NOT NULL,
  Apellido VARCHAR(100) NOT NULL,
  TipoDni VARCHAR(50) NULL, -- Usamos como identificar DNI como documento universal (como el pasaporte) 
  NroDni VARCHAR(50) NOT NULL UNIQUE, -- DNI como identificador único.
  FechaNacimiento DATE NULL, 
  Telefono VARCHAR(50) NULL,
  Email VARCHAR(50) NULL
);

-- Tabla Socio (Clase Socio Hereda de Persona)
CREATE TABLE Socio (
  SocioId INT PRIMARY KEY,
  FechaAltaSocio DATE NOT NULL, 
  NroCarnet VARCHAR(50) NOT NULL UNIQUE,
  FOREIGN KEY (SocioId) REFERENCES Persona(PersonaId) ON DELETE CASCADE
);

-- Tabla NoSocio (Clase NoSocio Hereda de Persona)
CREATE TABLE NoSocio (
  NoSocioId INT PRIMARY KEY,
  FOREIGN KEY (NoSocioId) REFERENCES Persona(PersonaId) ON DELETE CASCADE
);

-- Tabla Profesor (Staff/Actividad)
CREATE TABLE Profesor (
  ProfesorId INT PRIMARY KEY, -- Hereda de Persona para que no se duplique el DNI
  Especialidad VARCHAR(100) NULL,
  FOREIGN KEY (ProfesorId) REFERENCES Persona(PersonaId) ON DELETE CASCADE
);


-- ==========================================================
--  Clase Actividad (UML) 
-- Asignación de profesores y actividades (Muchos a Muchos)
-- ==========================================================

-- Tabla Actividad
CREATE TABLE Actividad (
  ActividadId INT AUTO_INCREMENT PRIMARY KEY,
  NombreActividad VARCHAR(100) NOT NULL UNIQUE,
  MontoActividad DECIMAL(10, 2) NOT NULL,
  CostoSocio DECIMAL(10, 2) NOT NULL DEFAULT 0.00 -- Añadido CostoSocio para lógica de negocio profesional
);

-- Tabla Profesor_Actividad 
CREATE TABLE Profesor_Actividad (
  ProfesorActividadId INT AUTO_INCREMENT PRIMARY KEY,
  ProfesorId INT NOT NULL,
  ActividadId INT NOT NULL,
  FOREIGN KEY (ProfesorId) REFERENCES Profesor(ProfesorId),
  FOREIGN KEY (ActividadId) REFERENCES Actividad(ActividadId),
  UNIQUE (ProfesorId, ActividadId)
);

-- ==================================================
--  Gestion de pagos (UML)
-- ==================================================

-- Tabla Pago Realizado 
CREATE TABLE PagoRealizado (
  PagoRealizadoId INT AUTO_INCREMENT PRIMARY KEY,
  FechaPago DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  MontoTotal DECIMAL(10, 2) NOT NULL,
  TipoConcepto VARCHAR(50) NOT NULL, -- 'Cuota', 'Diario'
  MedioPago VARCHAR(50) NOT NULL,
  ReferenciaId INT NOT NULL -- 'SocioId', 'NoSocioId' 
);


-- Tabla PagoCuota
CREATE TABLE PagoCuota (
  CuotaId INT AUTO_INCREMENT PRIMARY KEY,
  SocioId INT NOT NULL,
  FechaVencimientoCuota DATE NOT NULL,
  EstadoCuota VARCHAR(50) NOT NULL,
  MontoCuota DECIMAL(10, 2) NOT NULL,
  MedioPago VARCHAR(50) NULL,
  PagoRealizadoId INT NULL UNIQUE, 
  MesCuota INT AS (MONTH(fechaVencimientoCuota)) STORED,
  AnioCuota INT AS (YEAR(fechaVencimientoCuota)) STORED,
  FOREIGN KEY (SocioId) REFERENCES Socio(SocioId) ON DELETE CASCADE, 
  FOREIGN KEY (PagoRealizadoID) REFERENCES PagoRealizado(PagoRealizadoID) -- Registro de pago.
);

CREATE UNIQUE INDEX UX_CUOTA_Socio_Periodo ON PagoCuota(
  SocioId, MesCuota, Aniocuota
);

-- Tabla PagoDiario
CREATE TABLE PagoDiario (
  PagoDiarioId INT AUTO_INCREMENT PRIMARY KEY,
  NoSocioId INT NOT NULL,
  ActividadId INT NOT NULL,
  FechaPago DATE NOT NULL,
  MontoPagado DECIMAL(10, 2) NOT NULL,
  PagoRealizadoId INT NULL UNIQUE, 
  FOREIGN KEY (NoSocioId) REFERENCES NoSocio(NoSocioId) ON DELETE CASCADE,
  FOREIGN KEY (ActividadId) REFERENCES Actividad(ActividadId) ON DELETE RESTRICT,
  FOREIGN KEY (PagoRealizadoID) REFERENCES PagoRealizado(PagoRealizadoID) -- Apunta devuelta a registro de pago
);

-- ==================================================
-- Seguridad & Inicialización (Registro, Login)
-- ==================================================

-- Tabla Roles (Para permisos como Administrador y staff(profesores))
CREATE TABLE Roles (
  RolId INT PRIMARY KEY,
  NombreRol VARCHAR(50) NOT NULL UNIQUE
);
---
-- Tabla Usuario (login y registro)
-- IMPORTANTE: Se cambia PasswordHash de VARBINARY a VARCHAR(15)
-- para que coincida con el tipo de dato que se inserta y se compara.
CREATE TABLE Usuario (
  UsuarioId INT AUTO_INCREMENT PRIMARY KEY,
  Username VARCHAR(50) NOT NULL UNIQUE,
  -- Tipo de dato ajustado para la inserción simple '123456'
  PasswordHash VARCHAR(15) NOT NULL,
  EmpleadoNombre VARCHAR(150) NULL,
  RolId INT NOT NULL,
  Activo BIT NOT NULL DEFAULT 1,
  -- PersonaId no puede tener una FK si no se crea la tabla Persona
  -- Por ahora la dejamos como NULL para que el código funcione
  PersonaId INT NULL, 
  FOREIGN KEY (RolId) REFERENCES Roles(RolId)
  -- NOTA: Si descomentas la siguiente línea, debes crear la tabla 'Persona'
  -- FOREIGN KEY (PersonaId) REFERENCES Persona(PersonaId)
);

---
-- ==================================================
-- Roles 
-- ==================================================

-- Roles consolidados para el sistema
INSERT INTO Roles (RolId, NombreRol) 
VALUES 
(100, 'Administrador'),
(200, 'Staff');

---
-- ==================================================
-- Creación del adminitrador por defecto (SOLUCIÓN)
-- ==================================================

-- Se agrega la columna RolId (obligatoria) con el valor 100
insert into Usuario(UsuarioId,Username,PasswordHash,EmpleadoNombre, RolId) values
(01,'marcos','123456','Administrador', 100);

---
-- ==================================================
-- PROCEDURE QUE UTILIZA EL PROYECTO
-- ==================================================

delimiter // 
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))
begin
  -- La lógica de la consulta es correcta: se busca el NombreRol
  select NombreRol
    from Usuario u inner join Roles r on u.RolId = r.RolId
        where Username = Usu and PasswordHash = Pass
            and Activo = 1;
end 
//

-- ==========================

-- Restablecer el delimitador por defecto
delimiter ;