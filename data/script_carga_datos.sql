/*
Script de carga de datos
*/

-- TIPO_ESPECIALIDAD
insert into pico_y_pala.tipo_especialidad
		(tes_id,tes_desc)
select distinct
	Tipo_Especialidad_Codigo,
	Tipo_Especialidad_Descripcion
from gd_esquema.Maestra
	where Tipo_Especialidad_Codigo is not null;
print ('tipo_especialidad ok');

--ESPECIALIDAD
insert into pico_y_pala.especialidad
		(
		esp_id,
		esp_desc,
		esp_tes_id
		)
select distinct
	Especialidad_Codigo,
	Especialidad_Descripcion,
	Tipo_Especialidad_Codigo	
from gd_esquema.Maestra
	where Especialidad_Codigo is not null;
print ('especialidad ok');

--USUARIO
insert into pico_y_pala.usuario
	(
	usu_username,
	usu_nro_doc,
	usu_password,
	usu_apellido,
	usu_nombre,
	usu_tipo_doc,
	usu_direccion,
	usu_telefono,
	usu_mail,
	usu_fecha_nac,
	usu_sexo,
	usu_habilitado,
	usu_intentos_fallidos
	)
select distinct
	Paciente_Dni USERNAME,
	Paciente_Dni DNI,
	'A1159E9DF3670D549D04524532629F5477CEB7DEEC9B45E47E8C009506ECB2C8' PASSWORD,
	Paciente_Apellido APELLIDO,
	Paciente_Nombre NOMBRE,
	'DNI' TIPO_DOC,
	Paciente_Direccion DIREECION,
	Paciente_Telefono TELEFONO,
	Paciente_Mail MAIL,
	Paciente_Fecha_Nac FECHA_NAC,
	'M' SEXO,
	1 HABILITADO,
	0 INTENTOS_FALLIDOS
from gd_esquema.Maestra
where paciente_apellido is not null
union 
select distinct	
	medico_dni,
	medico_dni,
	'A1159E9DF3670D549D04524532629F5477CEB7DEEC9B45E47E8C009506ECB2C8',
	Medico_Apellido,
	medico_nombre,
	'DNI' TIPO_DOC,
	Medico_Direccion,
	Medico_Telefono,
	Medico_Mail,
	Medico_Fecha_Nac,
	'F',
	1,
	0
from gd_esquema.Maestra
	where medico_apellido is not null
print ('usuario ok');
--Administrador
insert into pico_y_pala.usuario
	(
	usu_username,
	usu_password,
	usu_habilitado,
	usu_intentos_fallidos
	) values
	(
	'admin',
	'E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7',
	1,
	0
	)
print ('admin ok');
--PLAN
insert into pico_y_pala.planes
		(
		pla_codigo,
		pla_desc,
		pla_precio_consulta,
		pla_precio_farmacia
		)
select distinct
	Plan_Med_Codigo
	,Plan_Med_Descripcion
	,Plan_Med_Precio_Bono_Consulta
	,Plan_Med_Precio_Bono_Farmacia
from gd_esquema.Maestra
order by 1
print ('planes ok');

--ESTADO_CIVIL
insert into pico_y_pala.estado_civil (eci_desc) values ('Soltero')
insert into pico_y_pala.estado_civil (eci_desc) values ('Casado')
insert into pico_y_pala.estado_civil (eci_desc) values ('Divorciado')	
insert into pico_y_pala.estado_civil (eci_desc) values ('Viudo')
print ('estado_civil ok');

--ROL
insert into pico_y_pala.rol (rol_nombre,rol_habilitado) values ('Administrador',1)
insert into pico_y_pala.rol (rol_nombre,rol_habilitado) values ('Administrativo',1)
insert into pico_y_pala.rol (rol_nombre,rol_habilitado) values ('Afiliado',1)
insert into pico_y_pala.rol (rol_nombre,rol_habilitado) values ('Profesional',1)
print ('rol ok');

--FUNCIONALIDAD
insert into pico_y_pala.funcionalidad (fun_desc) values ('ABM de Rol')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Abm Afiliado')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Abm Profesional')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Registrar Agenda del Medico')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Comprar Bonos')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Pedir Turno')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Registro de llegadas para atención médica')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Registrar resultado para atencion medica')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Cancelar atencion medica')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Listado Estadistico')
print ('funcionalidad ok');

--ROL_FUNCIONALIDAD

insert into pico_y_pala.rol_funcionalidad
	(
	rfu_rol_id,
	rfu_fun_id
	)
select 
	roles.rol_id,
	fun.fun_id
	from pico_y_pala.rol roles, pico_y_pala.funcionalidad fun
where
	roles.rol_nombre = 'Administrador'
	and fun.fun_desc in ('ABM de Rol','Login y Seguridad','Registro de Usuario','Abm Afiliado','Abm Profesional'
	,'Abm Especialidades Medicas','Abm de Planes','Registrar Agenda del Medico','Registro de llegadas para atención médica','Cancelar atencion medica','Listado Estadistico')
union
select 
	roles.rol_id,
	fun.fun_id
	from pico_y_pala.rol roles, pico_y_pala.funcionalidad fun
where
	roles.rol_nombre = 'Administrativo'
	and fun.fun_desc in ('ABM de Rol','Login y Seguridad','Registro de Usuario','Abm Afiliado','Abm Profesional'
	,'Abm Especialidades Medicas','Abm de Planes','Registrar Agenda del Medico', 'Registro de llegadas para atención médica','Listado Estadistico')
union
select 
	roles.rol_id,
	fun.fun_id
	from pico_y_pala.rol roles, pico_y_pala.funcionalidad fun
where
	roles.rol_nombre = 'Afiliado'
	and fun.fun_desc in ('Login y Seguridad','Comprar Bonos','Pedir Turno','Cancelar atencion medica')
union
select 
	roles.rol_id,
	fun.fun_id
	from pico_y_pala.rol roles, pico_y_pala.funcionalidad fun
where
	roles.rol_nombre = 'Profesional'
	and fun.fun_desc in ('Login y Seguridad','Registrar Agenda del Medico','Cancelar atencion medica',
	'Registrar resultado para atencion medica')

print ('rol_funcionalidad ok');

--PROFESIONAL
insert into pico_y_pala.profesional	
	(
	pro_nro_doc
	)
select distinct
	medico_dni
from gd_esquema.Maestra
where medico_dni is not null
order by 1
print ('profesional ok')

--PROFESIONAL_ESPECIALIDAD
insert into pico_y_pala.profesional_especialidad
	(
	pes_pro_nro_doc,
	pes_esp_id
	)
select distinct
	medico_dni,
	Especialidad_Codigo
from gd_esquema.Maestra
where medico_dni is not null
order by 1
print ('profesional_especialidad ok')

--AFILIADO
insert into pico_y_pala.afiliado
	(
	afi_nro_doc
	,afi_nro_afiliado
	,afi_eci_id
	,afi_pla_codigo
	,afi_nro_consulta
	,afi_activo
	,afi_fecha_baja
	)
select distinct
	maestra.Paciente_Dni
	,(maestra.Paciente_Dni*100+1) --Nro de afiliado = DNI+01(todos titulares de Grupo Familiar)
	,ecivil.eci_id
	,maestra.plan_med_codigo
	,0 nro_consultas  --analizar!
	,1 activo
	,null
from 
	gd_esquema.Maestra maestra
	,pico_y_pala.estado_civil ecivil	
where 
	ecivil.eci_desc = 'Soltero'
order by 1
print ('afiliado ok')

--Creo Grupo Familiar con todos como titular
insert into pico_y_pala.grupo_familiar
	(
	gpo_titular
	)
select distinct
	maestra.Paciente_Dni
from 
	gd_esquema.Maestra maestra
order by 1
print ('grupo familiar ok')

--Asocio Afiliado con grupo familiar
insert into pico_y_pala.gf_afiliado
	(
	agf_afi_nro_doc,
	agf_gpo_id
	)
select distinct
	maestra.Paciente_Dni
	,gf.gpo_id
from 
	gd_esquema.Maestra maestra
	,pico_y_pala.grupo_familiar gf
where 
	maestra.Paciente_Dni = gf.gpo_titular
order by 1
print ('gf_afiliado ok')

--ROL_USUARIO (faltan administrativos)
insert into pico_y_pala.rol_usuario
	(
		rus_rol_id,
		rus_usu_username
	)
select distinct
	roles.rol_id,
	CAST(afi.afi_nro_doc as varchar(50))--usar tabla afialiado
from pico_y_pala.afiliado afi, pico_y_pala.rol roles
where roles.rol_nombre = 'Afiliado'
union
select distinct
	roles.rol_id,
	CAST(prof.pro_nro_doc as varchar(50))
from pico_y_pala.profesional prof, pico_y_pala.rol roles
where roles.rol_nombre = 'Profesional'
union
select distinct
	roles.rol_id,
	'admin'
from pico_y_pala.rol roles
where roles.rol_nombre = 'Administrador'
--faltan los administrativos!
print ('rol_usuario ok')

--TURNO
insert into pico_y_pala.turno
	(
	tur_id
	,tur_afi_nro_doc
	,tur_pro_nro_doc
	,tur_fecha_hora
	,tur_esp_id
	)
select distinct
	maestra.Turno_Numero
	,maestra.paciente_dni
	,maestra.Medico_Dni
	,maestra.Turno_Fecha
	,maestra.Especialidad_Codigo
from gd_esquema.Maestra maestra
	where maestra.Turno_Numero is not null
print ('turno ok');

--COMPRA
insert into pico_y_pala.compra
	(
	com_afi_compro
	,com_cant
	,com_precio
	,com_fecha
	)
select 
	Paciente_Dni
	,count (*) cantidad_consultas
	,sum (Plan_Med_Precio_Bono_Consulta) precio
	,Compra_Bono_Fecha
from gd_esquema.Maestra
where compra_bono_fecha is not null 
--and not Plan_Med_Precio_Bono_Consulta = 0
group by Paciente_Dni
	,Compra_Bono_Fecha
order by 1,4
print ('compra ok');

--BONO
set IDENTITY_INSERT pico_y_pala.bono ON
insert into pico_y_pala.bono
	(
		bon_id
		,bon_afiliado_compra
		,bon_pla_id
		,bon_nro_consultas_afiliado
		,bon_afiliado_utilizo
		,bon_fecha_utilizo
		,bon_com_id
	)
select 
	Bono_Consulta_Numero
	,Paciente_Dni
	,Plan_Med_Codigo
	,0 consultas				--ANALIZAR
	,Paciente_Dni
	,Bono_Consulta_Fecha_Impresion
	,comp.com_id
from gd_esquema.Maestra
	inner join pico_y_pala.compra comp on comp.com_afi_compro = paciente_dni
										and comp.com_fecha = Compra_Bono_Fecha
where Bono_Consulta_Numero is not null
order by 1
set IDENTITY_INSERT pico_y_pala.bono OFF
print ('bono ok');

--CONSULTA
insert into pico_y_pala.consulta
	(
	con_tur_id
	,con_bono_utilizado
	,con_fecha_llegada
	,con_fecha_consulta
	,con_atendio
	)
select
	Turno_Numero
	,Bono_Consulta_Numero
	,Turno_Fecha
	,DATEADD(MINUTE,30,Turno_Fecha)				--ANALIZAR
	,1 Atendio
from gd_esquema.Maestra
where Turno_Numero is not null 
	and Bono_Consulta_Numero is not null
order by 1
print ('consulta ok')

--SINTOMA
insert into pico_y_pala.sintoma	
	(
	sin_desc
	)
select distinct
	consulta_sintomas
from gd_esquema.Maestra
where consulta_sintomas is not null
print ('sintoma ok')

--ENFERMEDAD
insert into pico_y_pala.enfermedad	
	(
	enf_desc
	)
select distinct
	consulta_enfermedades
from gd_esquema.Maestra
where consulta_enfermedades is not null
print ('enfermedad ok')

--CONSULTA_SINTOMA
insert into pico_y_pala.consulta_sintoma
	(
	csi_con_id
	,csi_sin_id
	)
select
	con.con_id
	,sint.sin_id
from gd_esquema.Maestra
inner join pico_y_pala.sintoma sint on sint.sin_desc = Consulta_Sintomas
inner join pico_y_pala.consulta con on con_tur_id = Turno_Numero
print ('consulta_sintoma ok')

--CONSULTA_ENFERMEDAD
insert into pico_y_pala.consulta_enfermedad
	(
	cen_con_id
	,cen_enf_id
	)
select
	con.con_id
	,enf.enf_id
from gd_esquema.Maestra
inner join pico_y_pala.enfermedad enf on enf.enf_desc = Consulta_Enfermedades
inner join pico_y_pala.consulta con on con_tur_id = Turno_Numero
print ('consulta_enfermedad ok')


--DIA
insert into pico_y_pala.dia (dia_id,dia_nombre) values (1,'Domingo')
insert into pico_y_pala.dia (dia_id,dia_nombre) values (2,'Lunes')
insert into pico_y_pala.dia (dia_id,dia_nombre) values (3,'Martes')
insert into pico_y_pala.dia (dia_id,dia_nombre) values (4,'Miercoles')
insert into pico_y_pala.dia (dia_id,dia_nombre) values (5,'Jueves')
insert into pico_y_pala.dia (dia_id,dia_nombre) values (6,'Viernes')
insert into pico_y_pala.dia (dia_id,dia_nombre) values (7,'Sabado')
print ('dia ok');

--Agenda
insert into pico_y_pala.agenda
	(
		age_pro_nro_doc
		,age_esp_id
	)
select distinct
	maestra.Medico_Dni
	,maestra.Especialidad_Codigo
from gd_esquema.Maestra
where maestra.Medico_Dni is not null
order by 1,2
print ('agenda ok');

--dia_por_agenda
insert into pico_y_pala.dia_por_agenda
	(
		dpa_pro_nro_doc
		,dpa_esp_id
		,dpa_dia
		,dpa_desde
		,dpa_hasta
		,dpa_fecha_desde
		,dpa_fecha_hasta
	)
select 
	maestra.Medico_Dni
	,maestra.Especialidad_Codigo
	,dia.dia_id
	,(select cast (min(distinct maestra2.Turno_Fecha)as time (0)) from gd_esquema.Maestra maestra2 where maestra2.Medico_Dni = maestra.Medico_Dni and maestra2.Especialidad_Codigo=maestra.Especialidad_Codigo) horamin
	,(select cast (max(distinct maestra2.Turno_Fecha)as time (0)) from gd_esquema.Maestra maestra2 where maestra2.Medico_Dni = maestra.Medico_Dni and maestra2.Especialidad_Codigo=maestra.Especialidad_Codigo) horamax
	,(select cast (min(distinct maestra2.Turno_Fecha)as date) from gd_esquema.Maestra maestra2 where maestra2.Medico_Dni = maestra.Medico_Dni and maestra2.Especialidad_Codigo=maestra.Especialidad_Codigo) fechamin
	,(select cast (max(distinct maestra3.Turno_Fecha)as date) from gd_esquema.Maestra maestra3 where maestra3.Medico_Dni = maestra.Medico_Dni and maestra3.Especialidad_Codigo=maestra.Especialidad_Codigo) fechamax
from gd_esquema.Maestra maestra
inner join pico_y_pala.dia dia on dia.dia_id = datepart (weekday , maestra.Turno_Fecha)
group by 
	dia.dia_id
	,maestra.Medico_Dni
	,maestra.Especialidad_Codigo
order by 
	maestra.Medico_Dni
	,maestra.Especialidad_Codigo
	,dia.dia_id
print ('dia_por_agenda ok');

--tipo_cancelacion
insert into pico_y_pala.tipo_cancelacion (tca_desc) values ('Ausencia doctor')
insert into pico_y_pala.tipo_cancelacion (tca_desc) values ('Ausencia paciente')
