/*
Script de creacion inicial
*/

USE [GD2C2016]
GO

CREATE SCHEMA [pico_y_pala] AUTHORIZATION [gd]
GO


create table pico_y_pala.funcionalidad 
(
	fun_id int identity (1,1)
	,fun_desc varchar (100)
	,constraint PK_fun_id primary key (fun_id)
);

create table pico_y_pala.rol
(
	rol_id int identity (1,1)
	,rol_nombre varchar (50)
	,rol_habilitado bit
	,constraint PL_rol_id primary key (rol_id)
);

create table pico_y_pala.rol_funcionalidad
(
	rfu_rol_id int
	,rfu_fun_id int 
	,constraint PK_rol_funcionalidad primary key (rfu_rol_id,rfu_fun_id)
	,constraint FK_rfu_rol_id foreign key (rfu_rol_id) references pico_y_pala.rol (rol_id)
	,constraint FK_rfu_fun_id foreign key (rfu_fun_id) references pico_y_pala.funcionalidad(fun_id)
);

create table pico_y_pala.usuario
(
	usu_username varchar (50) 
	,usu_nro_doc numeric (18,0) unique
	,usu_password varchar (64) 
	,usu_nombre varchar (255)
	,usu_apellido varchar (255)
	,usu_tipo_doc varchar (3)
	,usu_direccion varchar (255)
	,usu_telefono numeric (18,0)
	,usu_mail varchar (255)
	,usu_fecha_nac datetime
	,usu_sexo char (1)
	,usu_habilitado bit
	,usu_intentos_fallidos int
	,constraint PK_usu_username primary key (usu_username)
);

create table pico_y_pala.rol_usuario
(
	rus_rol_id int 
	,rus_usu_username varchar (50) 
	,constraint PK_rol_usuario primary key (rus_rol_id,rus_usu_username)
	,constraint FK_rus_usu_username foreign key (rus_usu_username) references pico_y_pala.usuario(usu_username)
	,constraint FK_rus_fun_id foreign key (rus_rol_id) references pico_y_pala.rol (rol_id)
);

create table pico_y_pala.profesional 
(
	pro_nro_doc numeric (18,0) 
	,pro_matricula numeric (18,0) identity (1,1)
	,constraint PK_pro_nro_doc primary key (pro_nro_doc)
	,constraint FK_pro_nro_doc foreign key (pro_nro_doc) references pico_y_pala.usuario(usu_nro_doc)
);

create table pico_y_pala.tipo_especialidad
(
	tes_id int
	,tes_desc varchar(255)
	constraint tes_id primary key (tes_id)
);

create table pico_y_pala.especialidad
(
	esp_id int
	,esp_desc varchar (255)
	,esp_tes_id int 
	,constraint PK_esp_id primary key (esp_id)
	,constraint FK_esp_tes_id foreign key (esp_tes_id) references pico_y_pala.tipo_especialidad(tes_id),
);

create table pico_y_pala.profesional_especialidad
(
	pes_pro_nro_doc numeric (18,0) 
	,pes_esp_id int 
	,constraint PK_profesional_especialidad primary key (pes_pro_nro_doc, pes_esp_id)
	,constraint FK_pes_pro_nro_doc foreign key (pes_pro_nro_doc) references pico_y_pala.profesional(pro_nro_doc)
	,constraint FK_pes_esp_id foreign key (pes_esp_id) references pico_y_pala.especialidad (esp_id)
);

create table pico_y_pala.agenda
(
	age_id numeric (18,0) identity (1,1)
	,age_pro_nro_doc numeric (18,0)
	,age_esp_id int
	,constraint PK_agenda primary key (age_id,age_pro_nro_doc,age_esp_id)
	,constraint FK_agenda foreign key (age_pro_nro_doc,age_esp_id) references pico_y_pala.profesional_especialidad (pes_pro_nro_doc,pes_esp_id)
);

create table pico_y_pala.dia
(
	dia_id int identity (1,1)
	,dia_nombre char (10)
	,constraint PK_dia_id primary key (dia_id)
);

create table pico_y_pala.dia_por_agenda
(
	dpa_pro_nro_doc numeric (18,0)
	,dpa_age_id numeric (18,0)
	,dpa_esp_id int
	,dpa_dia int 
	,dpa_deste datetime
	,dpa_hasta datetime
	,constraint PK_dia_por_agenda primary key (dpa_pro_nro_doc,dpa_esp_id)
	,constraint FK_dia_por_agenda foreign key (dpa_age_id,dpa_pro_nro_doc,dpa_esp_id) references pico_y_pala.agenda (age_id,age_pro_nro_doc,age_esp_id)
	,constraint FK_dpa_dia foreign key (dpa_dia) references pico_y_pala.dia (dia_id)
);

create table pico_y_pala.estado_civil
(
	eci_id int identity (1,1)
	,eci_desc varchar (100)
	,constraint PK_eci_id primary key (eci_id)
);

create table pico_y_pala.planes
(
	--pla_id numeric (18,0)
	pla_codigo numeric (18,0)
	,pla_desc varchar (100)
	,pla_precio_consulta numeric (18,0)
	,pla_precio_farmacia numeric (18,0)
	--constraint PK_pla_id primary key (pla_id)
	constraint PK_pla_id primary key (pla_codigo)
);

create table pico_y_pala.grupo_familiar
(
	gpo_id numeric (18,0) identity (1,1)
	,gpo_titular numeric (18,0)
	,constraint PL_gpo_id primary key (gpo_id) 
);

create table pico_y_pala.afiliado
(
	afi_nro_doc numeric (18,0) 
	,afi_nro_afiliado numeric (18,0) identity (1,1)
	,afi_eci_id int  
	,afi_pla_codigo numeric (18,0)
	,afi_nro_consulta numeric (18,0)
	,afi_activo bit
	,afi_fecha_baja datetime 
	,constraint PK_afi_nro_doc primary key (afi_nro_doc)
	,constraint FK_afi_nro_doc foreign key (afi_nro_doc) references pico_y_pala.usuario(usu_nro_doc)
	,constraint FK_afi_eci_id foreign key (afi_eci_id) references pico_y_pala.estado_civil (eci_id)
	,constraint FK_afi_pla_id foreign key (afi_pla_codigo) references pico_y_pala.planes (pla_codigo)
)

create table pico_y_pala.gf_afiliado
(
	agf_gpo_id numeric (18,0)
	,agf_afi_nro_doc numeric (18,0) 
	,constraint PK_gf_afiliado primary key (agf_gpo_id,agf_afi_nro_doc)
	,constraint FK_agf_gpo_id foreign key (agf_gpo_id) references pico_y_pala.grupo_familiar (gpo_id)
	,constraint FK_agf_afi_nro_doc foreign key (agf_afi_nro_doc) references pico_y_pala.afiliado (afi_nro_doc)
)

alter table pico_y_pala.grupo_familiar 
add constraint FK_gpo_afi foreign key (gpo_titular) references pico_y_pala.afiliado (afi_nro_doc)

create table pico_y_pala.audit_cambio_plan
(
	acp_id numeric (18,0) identity (1,1)
	,acp_afiliado numeric (18,0) 
	,acp_fecha datetime
	,acp_motivo varchar (255)
	,acp_plan_anterior numeric (18,0)
	,acp_plan_nuevo numeric (18,0) 
	,constraint PK_acp_id primary key (acp_id)
	,constraint FK_acp_afiliado foreign key (acp_afiliado) references pico_y_pala.afiliado (afi_nro_doc)
	,constraint FK_acp_plan_anterior foreign key (acp_plan_anterior) references pico_y_pala.planes (pla_codigo)
	,constraint FK_acp_plan_nuevo foreign key (acp_plan_nuevo) references pico_y_pala.planes (pla_codigo)
);

create table pico_y_pala.tipo_cancelacion
(
	tca_id int identity (1,1)
	,tca_desc varchar (255)
	,constraint PK_tca_id primary key (tca_id)
);

create table pico_y_pala.cancelacion
(
	can_id numeric (18,0) identity (1,1)
	,can_tca_id int
	,can_motivo varchar (255)
	,constraint PK_can_id primary key (can_id)
	,constraint FK_can_tca_id foreign key (can_tca_id) references pico_y_pala.tipo_cancelacion (tca_id)
);

create table pico_y_pala.compra
(
	com_id numeric (18,0) identity (1,1)
	,com_afi_compro numeric (18,0)
	,com_cant numeric (18,0)
	,com_precio numeric (18,0)
	,com_fecha datetime
	,constraint PK_com_id primary key (com_id)
	,constraint FK_com_afi_compro foreign key (com_afi_compro) references pico_y_pala.afiliado (afi_nro_doc)
);

create table pico_y_pala.bono
(
	bon_id numeric (18,0) 
	,bon_afiliado_compra numeric (18,0) 
	,bon_pla_id numeric (18,0) 
	,bon_nro_consultas_afiliado numeric (18,0)
	,bon_afiliado_utilizo numeric (18,0) 
	,bon_fecha_utilizo datetime
	,bon_com_id numeric (18,0) 
	,constraint PK_bon_id primary key (bon_id)
	,constraint FK_bon_afiliado_compra foreign key (bon_afiliado_compra) references pico_y_pala.afiliado (afi_nro_doc)
	,constraint FK_bon_pla_id foreign key (bon_pla_id) references pico_y_pala.planes (pla_codigo)
	,constraint FK_bon_afiliado_utilizo foreign key (bon_afiliado_utilizo) references pico_y_pala.afiliado (afi_nro_doc)
	,constraint FK_bon_com_id foreign key (bon_com_id) references pico_y_pala.compra (com_id)
);

create table pico_y_pala.turno
(
	tur_id numeric (18,0)
	,tur_afi_nro_doc numeric (18,0) 
	,tur_pro_nro_doc numeric (18,0) 
	,tur_fecha_hora datetime
	,tur_can_id numeric (18,0) 
	,constraint PK_tur_id primary key (tur_id)
	,constraint FK_tur_afi_username foreign key (tur_afi_nro_doc) references pico_y_pala.afiliado (afi_nro_doc)
	,constraint FK_tur_pro_username foreign key (tur_pro_nro_doc) references pico_y_pala.profesional (pro_nro_doc)
);

create table pico_y_pala.consulta
(
	con_id numeric (18,0) identity (1,1)
	,con_tur_id numeric (18,0) 
	,con_bono_utilizado numeric (18,0)
	,con_fecha_llegada datetime
	,con_fecha_consulta datetime
	,constraint PK_con_id primary key (con_id)
	,constraint FK_con_tur_id foreign key (con_tur_id) references pico_y_pala.turno (tur_id)
	,constraint FK_con_bono_utilizado foreign key (con_bono_utilizado)references pico_y_pala.bono (bon_id)
);

create table pico_y_pala.sintoma
(
	sin_id numeric (18,0) identity (1,1)
	,sin_desc varchar (255)	
	,constraint PK_sin_id primary key (sin_id)
);

create table pico_y_pala.consulta_sintoma
(
	csi_con_id numeric (18,0) 
	,csi_sin_id numeric (18,0) 
	,constraint PK_consulta_sintoma primary key (csi_con_id,csi_sin_id)
	,constraint FK_csi_con_id foreign key (csi_con_id) references pico_y_pala.consulta (con_id)
	,constraint FK_csi_sin_id foreign key (csi_sin_id) references pico_y_pala.sintoma (sin_id)
);

create table pico_y_pala.enfermedad
(
	enf_id numeric (18,0) identity (1,1)
	,enf_desc varchar (255)	
	,constraint PK_enf_id primary key (enf_id)
);

create table pico_y_pala.consulta_enfermedad
(
	cen_con_id numeric (18,0) 
	,cen_enf_id numeric (18,0) 
	,constraint PK_consulta_enfermedad primary key (cen_con_id,cen_enf_id)
	,constraint FK_cen_con_id foreign key (cen_con_id) references pico_y_pala.consulta (con_id)
	,constraint FK_cen_sin_id foreign key (cen_enf_id) references pico_y_pala.enfermedad (enf_id)
);
GO
--STORE PROCEDURES

CREATE PROCEDURE PICO_Y_PALA.checkLoginAndUpdateFailures(@user VARCHAR(50), @pass VARCHAR(64), @ok BIT OUTPUT, @enabled BIT OUTPUT)
AS
BEGIN
	DECLARE @passReal VARCHAR(64), @intentosFallidos TINYINT;
	SET @ok = 0;
	SELECT @passReal=usu_password, @enabled=usu_habilitado, @intentosFallidos=usu_intentos_fallidos FROM PICO_Y_PALA.usuario WHERE USU_USERNAME=@user;
	IF @passReal IS NOT NULL AND @passReal <> ''
		BEGIN
			IF @enabled = 1
				BEGIN
					IF @passReal=@pass
						BEGIN
							SET @ok=1;
							UPDATE PICO_Y_PALA.usuario SET usu_intentos_fallidos=0 WHERE usu_username=@user;
						END
					ELSE
						BEGIN
							IF @intentosFallidos=2
								BEGIN
									UPDATE PICO_Y_PALA.usuario SET usu_habilitado=0 WHERE usu_username=@user;
									SET @enabled=0;
								END;
							UPDATE PICO_Y_PALA.usuario SET usu_intentos_fallidos=@intentosFallidos+1 WHERE usu_username=@user;
						END
				END
		END
	ELSE
		SET @enabled = 1 --Si entra por esta rama, no existe el usuario. Se devuelve por defecto enabled=true
END;
GO

--Crea un rol y lo relaciona con la funcionalidad base de Login
CREATE PROCEDURE PICO_Y_PALA.crearRol (@rol_nombre VARCHAR(255))
AS
BEGIN
	IF exists (SELECT * FROM PICO_Y_PALA.rol WHERE rol_nombre=@rol_nombre)
	BEGIN
		RAISERROR('Ya hay un rol con el nombre solicitado',16,1)
		RETURN
	END
	INSERT INTO PICO_Y_PALA.rol(rol_habilitado,rol_nombre) VALUES (1,@rol_nombre)
	INSERT INTO PICO_Y_PALA.rol_funcionalidad(rfu_fun_id,rfu_rol_id) VALUES (1,(SELECT rol_id FROM PICO_Y_PALA.rol WHERE rol_nombre = @rol_nombre));
END
GO

--Crea un asociacion rol_funcionalidad
CREATE PROCEDURE PICO_Y_PALA.crearRolFuncionalidad (@rol_nombre VARCHAR(255), @fun_nombre VARCHAR(255))
AS
BEGIN
	DECLARE @rol_id INT, @fun_id INT,@message VARCHAR(255)
	SELECT @rol_id = rol_id FROM PICO_Y_PALA.rol WHERE rol_nombre = @rol_nombre
	SELECT @fun_id = fun_id FROM PICO_Y_PALA.funcionalidad WHERE fun_desc = @fun_nombre
	INSERT INTO PICO_Y_PALA.rol_funcionalidad(rfu_fun_id,rfu_rol_id) VALUES (@fun_id,@rol_id)
END
GO

CREATE PROCEDURE PICO_Y_PALA.borrarRolFuncionalidad (@rol_nombre VARCHAR(255), @fun_nombre VARCHAR(255))
AS
BEGIN
	DECLARE @rol_id INT, @fun_id INT,@message VARCHAR(255)
	SELECT @rol_id = rol_id FROM PICO_Y_PALA.rol WHERE rol_nombre = @rol_nombre
	SELECT @fun_id = fun_id FROM PICO_Y_PALA.funcionalidad WHERE fun_desc = @fun_nombre
	DELETE FROM PICO_Y_PALA.rol_funcionalidad WHERE rfu_fun_id = @fun_id AND rfu_rol_id = @rol_id
END
GO

CREATE PROCEDURE PICO_Y_PALA.deshabilitarRol (@idRol INT)
AS
BEGIN
	UPDATE PICO_Y_PALA.rol SET rol_habilitado=0 WHERE rol_id = @idRol;
	DELETE FROM PICO_Y_PALA.rol_usuario WHERE rus_rol_id = @idRol;
END
GO

CREATE PROCEDURE PICO_Y_PALA.habilitarRol (@idRol INT)
AS
BEGIN
	UPDATE PICO_Y_PALA.rol SET rol_habilitado=1 WHERE rol_id = @idRol;
END
GO

CREATE PROCEDURE PICO_Y_PALA.cambiarNombreRol (@idRol INT, @rol_nombre_nuevo VARCHAR(255))
AS
BEGIN
	UPDATE PICO_Y_PALA.rol SET rol_nombre=@rol_nombre_nuevo WHERE rol_id = @idRol;
END
GO