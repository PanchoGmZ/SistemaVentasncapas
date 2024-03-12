CREATE DATABASE VENTASBD


CREATE TABLE PERSONA (
    idpersona INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    nombre VARCHAR(50)NOT NULL,
    apellidos VARCHAR(55)NOT NULL,
    telefonos VARCHAR(8)NOT NULL,
    ci VARCHAR(9)NOT NULL,
    correo VARCHAR(30)NOT NULL,
    estado VARCHAR(10)NOT NULL
);

CREATE TABLE USUARIO (
    idusuario INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    idpersona INT,
    nombre_user VARCHAR(30) NOT NULL,
    contrasena VARCHAR(15) NOT NULL,
    fecha_registro DATETIME NOT NULL,
    FOREIGN KEY (idpersona) REFERENCES PERSONA (idpersona)
);
CREATE TABLE ROL (
	idrol INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (30) NOT NULL,
	estado varchar (30) NOT NULL,
);
CREATE TABLE USUARIOROL (
	idusuariorol INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	idusuario INT,
	idrol INT,
	fecha_asignada DATETIME NOT NULL,
	estado varchar (15),
	FOREIGN KEY (idusuario) REFERENCES USUARIO (idusuario)
);
CREATE TABLE CLIENTE (
	idcliente INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	idpersona INT,
	tipocliente varchar (30) NOT NULL,
	codigocliente varchar (20) NOT NULL,
	estado varchar (15) NOT NULL
	FOREIGN KEY (idpersona) REFERENCES PERSONA (idpersona)
);

CREATE TABLE VENTA (
    idventa INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
    idcliente INT,
    idvendedor INT,
    fecha DATE,
    total DECIMAL(10, 2) NOT NULL,
    estado VARCHAR(50)NOT NULL,
    FOREIGN KEY (idcliente) REFERENCES cliente(idcliente),
    FOREIGN KEY (idvendedor) REFERENCES usuario(idusuario)
);
CREATE TABLE TIPOPROD (
	idtiprod INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	nombre varchar (50) NOT NULL,
	estado varchar (20) NOT NULL,
);
CREATE TABLE MARCA (
	idmarca INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	nombre varchar (50) NOT NULL,
	estado varchar (20) NOT NULL,
);
CREATE TABLE PRODUCTO (
	idproducto INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	idtipoprod INT,
	nombre varchar (50) NOT NULL,
	codigobarra varchar (30) NOT NULL,
	idmarca INT,
	unidad varchar (15) not null,
	descripcion varchar (100) not null,
	estado varchar (15) not null,
	FOREIGN KEY (idtipoprod) REFERENCES TIPOPROD (idtiprod),
	FOREIGN KEY (idmarca) REFERENCES MARCA (idmarca)
);
CREATE TABLE detalleventa (
    iddetalleventa INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    idventa INT,
    idproducto INT,
    cantidad INT,
    precioventa DECIMAL(10, 2) NOT NULL,
    subtotal DECIMAL(10, 2) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    FOREIGN KEY (idventa) REFERENCES venta(idventa),
    FOREIGN KEY (idproducto) REFERENCES PRODUCTO (idproducto)
);
CREATE TABLE PROVEEDOR (
	idproveedor INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	nombre varchar (30) NOT NULL,
	telefono varchar (8) NOT NULL,
	direccion varchar (50) not null,
	estado varchar (15) not null,
);
CREATE TABLE PROVEE (
	idprovee INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	idproducto INT,
	idproveedor INT,
	fecha DATETIME,
	precio DECIMAL (10,2),
	FOREIGN KEY (idproducto) REFERENCES PRODUCTO (idproducto),
	FOREIGN KEY (idproveedor) REFERENCES PROVEEDOR (idproveedor)
);
CREATE TABLE INGRESO (
	idingreso INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	idproveedor INT,
	fechaingreso DATETIME NOT NULL,
	total DECIMAL (10,2) not null,
	estado varchar (15) not null,
	FOREIGN KEY (idproveedor) REFERENCES PROVEEDOR (idproveedor)
);
CREATE TABLE DETALLEINGRESO (
	iddetalleing INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	idproducto INT,
	idingreso INT,
	fechavencimiento DATETIME NOT NULL,
	cantidad varchar (100) not null,
	preciocosto DECIMAL (10,2) not null,
	subtotal decimal (10,2) not null,
	estado varchar (15) not null,
	FOREIGN KEY (idproducto) REFERENCES PRODUCTO (idproducto),
	FOREIGN KEY (idingreso) REFERENCES INGRESO (idingreso)
);