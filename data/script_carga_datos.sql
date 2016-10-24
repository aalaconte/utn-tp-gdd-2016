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
	usu_nro_doc,
	usu_apellido,
	usu_nombre,
	usu_tipo_doc,
	usu_direccion,
	usu_telefono,
	usu_mail,
	usu_fecha_nac,
	usu_sexo,
	usu_habilitado
	)
select distinct
	Paciente_Dni DNI,
	Paciente_Apellido APELLIDO,
	Paciente_Nombre NOMBRE,
	'DNI' TIPO_DOC,
	Paciente_Direccion DIREECION,
	Paciente_Telefono TELEFONO,
	Paciente_Mail MAIL,
	Paciente_Fecha_Nac FECHA_NAC,
	'M' SEXO,
	1 HABILITADO
from gd_esquema.Maestra
where paciente_apellido is not null
union 
select distinct	
	medico_dni,
	Medico_Apellido,
	medico_nombre,
	'DNI' TIPO_DOC,
	Medico_Direccion,
	Medico_Telefono,
	Medico_Mail,
	Medico_Fecha_Nac,
	'F',
	1
from gd_esquema.Maestra
	where medico_apellido is not null
print ('usuario ok');

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
insert into pico_y_pala.rol (rol_nombre,rol_habilitado) values ('Administrativo',1)
insert into pico_y_pala.rol (rol_nombre,rol_habilitado) values ('Afiliado',1)
insert into pico_y_pala.rol (rol_nombre,rol_habilitado) values ('Profesional',1)
print ('rol ok');

--FUNCIONALIDAD
insert into pico_y_pala.funcionalidad (fun_desc) values ('ABM de Rol')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Login y Seguridad')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Registro de Usuario')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Abm Afiliado')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Abm Profesional')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Abm Especialidades Medicas')
insert into pico_y_pala.funcionalidad (fun_desc) values ('Abm de Planes')
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
	roles.rol_nombre = 'Administrativo'
	and fun.fun_desc in ('ABM de Rol','Login y Seguridad','Registro de Usuario','Abm Afiliado','Abm Profesional'
	,'Abm Especialidades Medicas','Abm de Planes','Registro de llegadas para atención médica','Listado Estadistico')
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
	,afi_eci_id
	,afi_pla_codigo
	,afi_nro_consulta
	,afi_activo
	,afi_fecha_baja
	)
select distinct
	maestra.Paciente_Dni
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

--ROL_USUARIO (faltan administrativos)
insert into pico_y_pala.rol_usuario
	(
		rus_rol_id,
		rus_usu_nro_doc
	)
select distinct
	roles.rol_id,
	afi.afi_nro_doc --usar tabla afialiado
from pico_y_pala.afiliado afi, pico_y_pala.rol roles
where roles.rol_nombre = 'Afiliado'
union
select distinct
	roles.rol_id,
	prof.pro_nro_doc
from pico_y_pala.profesional prof, pico_y_pala.rol roles
where roles.rol_nombre = 'Profesional'
--faltan los administrativos!
print ('rol_usuario ok')

--TURNO
insert into pico_y_pala.turno
	(
	tur_id
	,tur_afi_nro_doc
	,tur_pro_nro_doc
	,tur_fecha_hora
	)
select distinct
	maestra.Turno_Numero
	,maestra.paciente_dni
	,maestra.Medico_Dni
	,maestra.Turno_Fecha
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
	,count (*)
	,0 precio					--ANALIZAR
	,Compra_Bono_Fecha
from gd_esquema.Maestra
where compra_bono_fecha is not null
group by Paciente_Dni
	,Compra_Bono_Fecha
order by 1,4
print ('compra ok');

--BONO
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
print ('bono ok');

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

--CONSULTA


