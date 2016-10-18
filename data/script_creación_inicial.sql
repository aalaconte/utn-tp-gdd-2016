/*
Script de creacion inicial
*/

USE [GD2C2016]
GO

CREATE SCHEMA [pico_y_pala] AUTHORIZATION [gd]
GO

create table pico_y_pala.funcionalidad 
(
	fun_id int primary key,
	fun_desc varchar (100)
);

create table pico_y_pala.rol
(
	rol_id int primary key,
	rol_nombre varchar (50),
	rol_habilitado bit
);

create table pico_y_pala.rol_funcionalidad
(
	rfu_rol_id int foreign key references pico_y_pala.rol (rol_id),
	rfu_fun_id int foreign key references pico_y_pala.funcionalidad(fun_id),
	primary key (rfu_rol_id,rfu_fun_id)
);

create table pico_y_pala.usuario
(
	usu_username varchar (50) primary key,
	usu_password varchar (50), --analizar tipo
	usu_nombre varchar (255),
	usu_apellido varchar (255),
	usu_nro_doc numeric (18,0),
	usu_tipo_doc varchar (3),  --es necesario? no aclara que haya mas de un tipo de doc.	
	usu_direccion varchar (255),
	usu_telefono numeric (18,0),
	usu_mail varchar (255),
	usu_fecha_nac datetime,
	usu_sexo char (1),   --random?
	usu_habilitado bit
);

create table pico_y_pala.rol_usuario
(
	rfu_rol_id int foreign key references pico_y_pala.rol (rol_id),
	rfu_fun_id varchar (50) foreign key references pico_y_pala.usuario(usu_username),
	primary key (rfu_rol_id,rfu_fun_id)
);

create table pico_y_pala.profesional 
(
	pro_username varchar(50),
	pro_matricula int, --ver como generarlo
	primary key (pro_username),
	foreign key (pro_username) references pico_y_pala.usuario(usu_username)
);

create table pico_y_pala.tipo_especialidad
(
	tes_id int primary key,
	tes_desc varchar(100)
);

create table pico_y_pala.especialidad
(
	esp_id int primary key,
	esp_desc varchar (100),
	esp_test_id int foreign key references pico_y_pala.tipo_especialidad(tes_id),
);

create table pico_y_pala.profesional_especialidad
(
	pes_pro_username  varchar(50) foreign key references pico_y_pala.profesional(pro_username),
	pes_esp_id int foreign key references pico_y_pala.especialidad (esp_id),
	primary key (pes_pro_username, pes_esp_id)
);

create table pico_y_pala.agenda
(
	age_id int,
	age_pro_username varchar (50), 
	age_esp_id int, 
	age_deste datetime,
	age_hasta datetime,
	primary key (age_id,age_pro_username,age_esp_id),
	foreign key (age_pro_username,age_esp_id) references pico_y_pala.profesional_especialidad (pes_pro_username,pes_esp_id)
);

create table pico_y_pala.dia
(
	dia_id int primary key,
	dia_nombre char (10)
);

create table pico_y_pala.dia_por_agenda
(
	pes_pro_username varchar (50),
	pes_age_id int, --agregada
	pes_esp_id int,
	pes_dia int foreign key references pico_y_pala.dia (dia_id),
	primary key (pes_pro_username,pes_esp_id),
	foreign key (pes_age_id,pes_pro_username,pes_esp_id) references pico_y_pala.agenda (age_id,age_pro_username,age_esp_id)
);

create table pico_y_pala.estado_civil
(
	eci_id int primary key,
	eci_desc varchar (100)
);

create table pico_y_pala.planes
(
	pla_id int primary key,
	pla_codigo int,
	pla_desc varchar (100),
	pla_precio_consulta int,
	pla_precio_farmacia int
);

create table pico_y_pala.grupo_familiar
(
	gpo_id int primary key,
	gpo_titular varchar (50)
);

create table pico_y_pala.afiliado
(
	afi_username varchar (50) primary key,
	afi_nro_afiliado int,
	afi_eci_id int foreign key references pico_y_pala.estado_civil (eci_id),
	afi_gpo_id int foreign key references pico_y_pala.grupo_familiar (gpo_id),
	afi_pla_id int foreign key references pico_y_pala.planes (pla_id),
	afi_nro_consulta int,
	afi_activo bit,
	afi_fecha_baja datetime
)

alter table pico_y_pala.grupo_familiar 
add foreign key (gpo_titular) references pico_y_pala.afiliado (afi_username)

create table pico_y_pala.audit_cambio_plan
(
	acp_id int primary key,
	acp_afiliado varchar (50) foreign key references pico_y_pala.afiliado (afi_username),
	acp_fecha datetime,
	acp_motivo varchar (100),
	acp_plan_anterior int foreign key references pico_y_pala.planes (pla_id),
	acp_plan_nuevo int foreign key references pico_y_pala.planes (pla_id)
);


create table pico_y_pala.tipo_cancelacion
(
	tca_id int primary key,
	tca_desc varchar (100),
);

create table pico_y_pala.cancelacion
(
	can_id int primary key,
	can_tca_id int foreign key references pico_y_pala.tipo_cancelacion (tca_id),
	can_motivo varchar (100)
);

create table pico_y_pala.compra
(
	com_id int primary key,
	com_cant int,
	com_precio int,
	com_fecha datetime
);

create table pico_y_pala.bono
(
	bon_id int primary key,
	bon_afiliado_compra varchar (50) foreign key references pico_y_pala.afiliado (afi_username),
	bon_pla_id int foreign key references pico_y_pala.planes (pla_id),
	bon_nro_consultas_afiliado int,
	bon_afiliado_utilizo varchar (50) foreign key references pico_y_pala.afiliado (afi_username),
	bon_fecha_utilizo datetime
);

create table pico_y_pala.bono_compra
(
	bco_bon_id int foreign key references pico_y_pala.bono (bon_id),
	bco_com_id int foreign key references pico_y_pala.compra (com_id),
	primary key (bco_bon_id,bco_com_id)
);


create table pico_y_pala.turno
(
	tur_id int primary key,
	tur_afi_username varchar (50) foreign key references pico_y_pala.afiliado (afi_username),
	tur_pro_username varchar (50) foreign key references pico_y_pala.profesional (pro_username),
	tur_fecha_hora datetime,
	tur_can_id int foreign key references pico_y_pala.cancelacion (can_id)
);

create table pico_y_pala.consulta
(
		con_id int primary key,
		con_tur_id int foreign key references pico_y_pala.turno (tur_id),
		con_bono_utilizado int foreign key references pico_y_pala.bono (bon_id),
		con_fecha_llegada datetime,
		con_fecha_consulta datetime,
		con_sintoma varchar (255),
		con_enfermedad varchar (255)
);
