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
