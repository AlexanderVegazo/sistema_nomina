

create table NOMINA (
 ID_NOMINA int PRIMARY KEY,
 DESCRIPCION VARCHAR (50) NOT NULL
 
 )





create table CUENTA_CONTABLE (
 ID_CUENTA int PRIMARY KEY,
 DESCRIPCION VARCHAR (50) NOT NULL,
 PERMITE_MOV VARCHAR (1) NOT NULL,
 TIPO INT ,
 NIVEL INT ,
 BALANCE DECIMAL (18,2) NOT NULL,
 CUENTA_MAYOR INT

 
 FOREIGN KEY (CUENTA_MAYOR) REFERENCES CUENTA_CONTABLE(ID_CUENTA)
 
 )





create table EMPLEADO (
 ID_EMPLEADO int IDENTITY(1,1) PRIMARY KEY,
 CEDULA VARCHAR (11) NOT NULL,
 NOMBRE VARCHAR (60) NOT NULL,
 DEPARTAMENTO VARCHAR (50),
 PUESTO VARCHAR (50),
 SALARIO_MENSUAL DECIMAL (18,2) NOT NULL,
 ID_NOMINA INT,

 FOREIGN KEY ID_NOMINA REFERENCES NOMINA(ID_NOMINA)
 )

 create table TIPO_INGRESO (
 ID_TIPO_INGRESO int IDENTITY(1,1) PRIMARY KEY,
 DESCRIPCION VARCHAR (60) NOT NULL,
 DEPENDE_SALARIO BIT NOT NULL,
 ESTADO VARCHAR (2) NOT NULL)

  create table TIPO_DEDUCCION (
 ID_TIPO_DED int IDENTITY(1,1) PRIMARY KEY,
 DESCRIPCION VARCHAR (60) NOT NULL,
 DEPENDE_SALARIO BIT NOT NULL,
 ESTADO VARCHAR (2) NOT NULL)

 
  create table TRANSACCION (
 ID_TRANSACCION int IDENTITY(1,1) PRIMARY KEY,
 ID_EMPLEADO INT,
 ID_TIPO_MOV INT,
 TIPO_TRANSACCION VARCHAR (60) NOT NULL,
 FECHA DATETIME,
 MONTO DECIMAL(18,2),
 ESTADO VARCHAR (2) NOT NULL,
 
 FOREIGN KEY (ID_EMPLEADO) REFERENCES EMPLEADO(ID_EMPLEADO)
 )