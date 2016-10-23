/*
Script de creacion tablas
*/

USE [GD2C2016]
GO

CREATE SCHEMA [pico_y_pala] AUTHORIZATION [gd]
GO



create table pico_y_pala.funcionalidad 
(
	fun_id numeric (18,0) primary key,
	fun_desc varchar (100)
);

create table pico_y_pala.rol
(
	rol_id numeric (18,0) primary key,
	rol_nombre varchar (50),
	rol_habilitado bit
);

create table pico_y_pala.rol_funcionalidad
(
	rfu_rol_id numeric (18,0) foreign key references pico_y_pala.rol (rol_id),
	rfu_fun_id numeric (18,0) foreign key references pico_y_pala.funcionalidad(fun_id),
	primary key (rfu_rol_id,rfu_fun_id)
);

create table pico_y_pala.usuario
(
	usu_nro_doc numeric (18,0) primary key,
	usu_password varchar (50), --analizar tipo
	usu_nombre varchar (255),
	usu_apellido varchar (255),
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
	rfu_rol_id numeric (18,0) foreign key references pico_y_pala.rol (rol_id),
	rfu_fun_id numeric (18,0) foreign key references pico_y_pala.usuario(usu_nro_doc),
	primary key (rfu_rol_id,rfu_fun_id)
);

create table pico_y_pala.profesional 
(
	pro_nro_doc numeric (18,0) primary key,
	pro_matricula numeric (18,0), 
	foreign key (pro_nro_doc) references pico_y_pala.usuario(usu_nro_doc)
);

create table pico_y_pala.tipo_especialidad
(
	tes_id numeric(18,0) primary key,
	tes_desc varchar(255)
);

create table pico_y_pala.especialidad
(
	esp_id numeric (18,0) primary key,
	esp_desc varchar (255),
	esp_tes_id numeric (18,0) foreign key references pico_y_pala.tipo_especialidad(tes_id),
);

create table pico_y_pala.profesional_especialidad
(
	pes_pro_nro_doc numeric (18,0) foreign key references pico_y_pala.profesional(pro_nro_doc),
	pes_esp_id numeric (18,0) foreign key references pico_y_pala.especialidad (esp_id),
	primary key (pes_pro_nro_doc, pes_esp_id)
);

create table pico_y_pala.agenda
(
	age_id numeric (18,0),
	age_pro_nro_doc numeric (18,0), 
	age_esp_id numeric (18,0), 
	primary key (age_id,age_pro_nro_doc,age_esp_id),
	foreign key (age_pro_nro_doc,age_esp_id) references pico_y_pala.profesional_especialidad (pes_pro_nro_doc,pes_esp_id)
);

create table pico_y_pala.dia
(
	dia_id int primary key,
	dia_nombre char (10)
);

create table pico_y_pala.dia_por_agenda
(
	dpa_pro_nro_doc numeric (18,0),
	dpa_age_id numeric (18,0),
	dpa_esp_id numeric (18,0),
	dpa_dia int foreign key references pico_y_pala.dia (dia_id),
	dpa_deste datetime,
	dpa_hasta datetime,
	primary key (dpa_pro_nro_doc,dpa_esp_id),
	foreign key (dpa_age_id,dpa_pro_nro_doc,dpa_esp_id) references pico_y_pala.agenda (age_id,age_pro_nro_doc,age_esp_id)
);

create table pico_y_pala.estado_civil
(
	eci_id numeric (18,0) primary key,
	eci_desc varchar (100)
);

create table pico_y_pala.planes
(
	pla_id numeric (18,0) primary key,
	pla_codigo numeric (18,0),
	pla_desc varchar (100),
	pla_precio_consulta numeric (18,0),
	pla_precio_farmacia numeric (18,0)
);

create table pico_y_pala.grupo_familiar
(
	gpo_id numeric (18,0) primary key,
	gpo_titular numeric (18,0) 
);

create table pico_y_pala.afiliado
(
	afi_nro_doc numeric (18,0) primary key,
	afi_nro_afiliado numeric (18,0),
	afi_eci_id numeric (18,0) foreign key references pico_y_pala.estado_civil (eci_id),
	afi_gpo_id numeric (18,0) foreign key references pico_y_pala.grupo_familiar (gpo_id),
	afi_pla_id numeric (18,0) foreign key references pico_y_pala.planes (pla_id),
	afi_nro_consulta numeric (18,0),
	afi_activo bit,
	afi_fecha_baja datetime
)

create table pico_y_pala.gf_afiliado
(
	agf_gpo_id numeric (18,0) foreign key references pico_y_pala.grupo_familiar (gpo_id),
	agf_afi_nro_doc numeric (18,0) foreign key references pico_y_pala.afiliado (afi_nro_doc),
	primary key (agf_gpo_id,agf_afi_nro_doc)
)

alter table pico_y_pala.grupo_familiar 
add foreign key (gpo_titular) references pico_y_pala.afiliado (afi_nro_doc)

create table pico_y_pala.audit_cambio_plan
(
	acp_id numeric (18,0) primary key,
	acp_afiliado numeric (18,0) foreign key references pico_y_pala.afiliado (afi_nro_doc),
	acp_fecha datetime,
	acp_motivo varchar (255),
	acp_plan_anterior numeric (18,0) foreign key references pico_y_pala.planes (pla_id),
	acp_plan_nuevo numeric (18,0) foreign key references pico_y_pala.planes (pla_id)
);


create table pico_y_pala.tipo_cancelacion
(
	tca_id numeric (18,0) primary key,
	tca_desc varchar (255),
);

create table pico_y_pala.cancelacion
(
	can_id numeric (18,0) primary key,
	can_tca_id numeric (18,0) foreign key references pico_y_pala.tipo_cancelacion (tca_id),
	can_motivo varchar (255)
);

create table pico_y_pala.compra
(
	com_id numeric (18,0) primary key,
	com_cant numeric (18,0),
	com_precio numeric (18,0),
	com_fecha datetime
);

create table pico_y_pala.bono
(
	bon_id numeric (18,0) primary key,
	bon_afiliado_compra numeric (18,0) foreign key references pico_y_pala.afiliado (afi_nro_doc),
	bon_pla_id numeric (18,0) foreign key references pico_y_pala.planes (pla_id),
	bon_nro_consultas_afiliado numeric (18,0),
	bon_afiliado_utilizo numeric (18,0) foreign key references pico_y_pala.afiliado (afi_nro_doc),
	bon_fecha_utilizo datetime,
	bon_com_id numeric (18,0) foreign key references pico_y_pala.compra (com_id)
);

create table pico_y_pala.turno
(
	tur_id numeric (18,0) primary key,
	tur_afi_username numeric (18,0) foreign key references pico_y_pala.afiliado (afi_nro_doc),
	tur_pro_username numeric (18,0) foreign key references pico_y_pala.profesional (pro_nro_doc),
	tur_fecha_hora datetime,
	tur_can_id numeric (18,0) foreign key references pico_y_pala.cancelacion (can_id)
);

create table pico_y_pala.consulta
(
	con_id numeric (18,0) primary key,
	con_tur_id numeric (18,0) foreign key references pico_y_pala.turno (tur_id),
	con_bono_utilizado numeric (18,0) foreign key references pico_y_pala.bono (bon_id),
	con_fecha_llegada datetime,
	con_fecha_consulta datetime
);

create table pico_y_pala.sintoma
(
	sin_id numeric (18,0) primary key,
	sin_desc varchar (255)	
);

create table pico_y_pala.consulta_sintoma
(
	csi_con_id numeric (18,0) foreign key references pico_y_pala.consulta (con_id), 
	csi_sin_id numeric (18,0) foreign key references pico_y_pala.sintoma (sin_id),
	primary key (csi_con_id,csi_sin_id)
);

create table pico_y_pala.enfermedad
(
	enf_id numeric (18,0) primary key,
	enf_desc varchar (255)	
);

create table pico_y_pala.consulta_enferemedad
(
	cen_con_id numeric (18,0) foreign key references pico_y_pala.consulta (con_id), 
	cen_sin_id numeric (18,0) foreign key references pico_y_pala.enfermedad (enf_id),
	primary key (cen_con_id,cen_sin_id)
);

