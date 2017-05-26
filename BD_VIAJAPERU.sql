use master
go 

if db_id('BD_VIAJAPERU') is not null
	drop database BD_VIAJAPERU
go

create database BD_VIAJAPERU
go

use BD_VIAJAPERU
go

if OBJECT_ID('tb_tipo_usuario') is not null
	drop table tb_tipo_usuario
go
create table tb_tipo_usuario(
id_tipo int primary key,
des_tipo char(30) not null
)

insert into tb_tipo_usuario values(0, 'Administrador')
insert into tb_tipo_usuario values(1, 'Counter')
insert into tb_tipo_usuario values(2, 'sistemas')
insert into tb_tipo_usuario values(3, 'Chofer')
insert into tb_tipo_usuario values(4, 'Guia')
if OBJECT_ID('tb_usuario') is not null
	drop table tb_usuario
go
create table tb_usuario(
id_cliente int primary key identity(1,1),
nom_cliente varchar(30) not null,
apepat_cliente varchar(30) not null,
apemat_cliente varchar(30) not null,
sexo_cliente int not null,
dni_cliente varchar(8) not null,
correo_cliente varchar(30) not null,
direccion_cliente varchar(30) not null,
nrotarjeta_cliente varchar(19) not null,
fecnac_cliente date not null,
usuario_cliente varchar(10) not null,
contra_cliente varchar(30) not null,
id_tipo int references tb_tipo_usuario default 2
)
insert into tb_usuario values ('Luis', 'Acosta', 'Argote',0,'70844569','holamundo', 'calle 46','1234-5678-9012-3456', getdate(),'lacosta', 'Demo1234', 2)
go

select * from tb_usuario
if OBJECT_ID('tb_trabajador') is not null
	drop table tb_trabajador
go
create table tb_trabajador(
id_trabajador int primary key identity(1,1),
nom_trabajador varchar(30) not null,
apepat_trabajador varchar(30) not null,
apemat_trabajador varchar(30) not null,
sexo_trabajador int not null,
dni_trabajador varchar(8) not null,
correo_trabajador varchar(30) not null,
fecnac_trabajador date not null,
feccom_trabajador date not null,
estado_trabajador int not null,/*Activo o no activo*/
direccion_trabajador varchar(30),
usuario_trabajador varchar(30),
contra_trabajador varchar(30),
id_tipo int references tb_tipo_usuario
)

if OBJECT_ID('tb_hoteles') is not null
	drop table tb_hoteles
go
create table tb_hoteles(
id_hotel int primary key,
nom_hotel varchar(30) not null,
nrohabitacion_hotel int not null,
direccion_hotel varchar(30) not null,
ubicacion_hotel varchar(30) not null,
precio_hotel decimal not null
)

if OBJECT_ID('tb_movilidad') is not null
	drop table tb_movilidad
go
create table tb_movilidad(
id_movilidad int primary key,
nomchofer_movilidad varchar(30) not null,
numplaca_movilidad varchar(30) not null,
direccionchofer_movilidad varchar(30) not null,
precio_movilidad decimal not null
)

if OBJECT_ID('tb_gturistica') is not null
	drop table tb_gturistica
go
create table tb_gturistica(
id_gturistica int primary key,
nom_gturistica varchar(30) not null,
numdias_gturistica int not null,
lugar_gturistica varchar(30) not null,
precio_gturistica decimal not null
)

if OBJECT_ID('tb_paquetes') is not null
	drop table tb_paquetes
go
create table tb_paquetes(
id_paquete int primary key identity(1,1),
precio_paquete decimal not null,
id_hotel int references tb_hoteles,
id_movilidad int references tb_movilidad,
id_gturistica int references tb_gturistica
)

if OBJECT_ID('tb_mediotrans') is not null
	drop table tb_mediotrans
go
create table tb_mediotrans(
id_mediotrans int primary key,
des_mediotrans varchar(30) not null
)

if OBJECT_ID('tb_itinerario') is not null
	drop table tb_itinerario
go
create table tb_itinerario(
id_itinerario int primary key identity(1,1),
fecsalida_itinerario date not null,
fecllegada_itinerario date not null,
lugardestino_itinerario varchar(30) not null,
lugarllegada_itinerario varchar(30) not null,
precio_itinerario decimal not null,
estado_itinerario int not null,
--references
id_mediotrans int references tb_mediotrans,
id_paquete int references tb_paquetes not null,
id_usuario int references tb_usuario not null,
id_trabajador int references tb_trabajador not null
)


if OBJECT_ID('tb_mediopago') is not null
	drop table tb_mediopago
go
create table tb_mediopago(
id_mediopago int primary key,
des_mediopago varchar(30) not null
)


if OBJECT_ID('tb_comprobante') is not null
	drop table tb_comprobante
go
create table tb_comprobante(
id_comprobante int primary key,
--references
id_mediopago int references tb_mediopago,
id_itinerario int references tb_itinerario
)