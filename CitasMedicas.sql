Create database CitasMedicas;
go

use CitasMedicas;
go

CREATE TABLE Especialidades (
    IdEspecialidad INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100)
);
go

CREATE TABLE Medicos (
    IdMedico INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100),
    IdEspecialidad INT FOREIGN KEY REFERENCES Especialidades(IdEspecialidad)
);
go

CREATE TABLE Pacientes (
    IdPaciente INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100),
    Telefono VARCHAR(20),
    Correo VARCHAR(100)
);
go

CREATE TABLE Citas (
    IdCita INT IDENTITY PRIMARY KEY,
    IdMedico INT FOREIGN KEY REFERENCES Medicos(IdMedico),
    IdPaciente INT FOREIGN KEY REFERENCES Pacientes(IdPaciente),
    FechaHora DATETIME,
    Motivo VARCHAR(255),
    Estado VARCHAR(20) DEFAULT 'Programada'
);
go