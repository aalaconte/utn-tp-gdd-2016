/*
Top 5 de los profesionales más consultados por Plan, detallando también bajo
que Especialidad.

nota: tarda bastante, voy a ver de mejorarla.
no poder hacer selects en el from me complicó la existencia
*/

select
	planes.pla_desc
	,pro.pro_nro_doc
	,usupro.usu_apellido +', '+usupro.usu_nombre profesional
	,count (pro.pro_nro_doc) cantidad_de_consultas
	,row_number() over (partition by planes.pla_desc order by count (pro.pro_nro_doc) desc) ranking
from pico_y_pala.consulta consul
		inner join pico_y_pala.turno turno on turno.tur_id = consul.con_tur_id
		inner join pico_y_pala.profesional pro on pro.pro_nro_doc = turno.tur_pro_nro_doc
		inner join pico_y_pala.usuario usupro on usupro.usu_nro_doc = pro.pro_nro_doc
		inner join pico_y_pala.usuario usu on usu.usu_nro_doc = pro.pro_nro_doc
		inner join pico_y_pala.afiliado afi on afi.afi_nro_doc = turno.tur_afi_nro_doc
		inner join pico_y_pala.planes planes on planes.pla_codigo = afi.afi_pla_codigo
group by 
	pro.pro_nro_doc
	,usupro.usu_apellido +', '+usupro.usu_nombre 
	,planes.pla_desc
having 
	pro.pro_nro_doc in
	(
	select top 5
		turno2.tur_pro_nro_doc
	from pico_y_pala.consulta consul2
		inner join pico_y_pala.turno turno2 on turno2.tur_id = consul2.con_tur_id
		inner join pico_y_pala.afiliado afi2 on afi2.afi_nro_doc = turno2.tur_afi_nro_doc
		inner join pico_y_pala.planes planes2 on planes2.pla_codigo = afi2.afi_pla_codigo
	where planes2.pla_desc = planes.pla_desc
	group by 
		turno2.tur_pro_nro_doc
		,planes2.pla_desc
	order by 
			planes2.pla_desc
			,count (turno2.tur_pro_nro_doc) desc
	)
order by 
	planes.pla_desc
	,count (pro.pro_nro_doc) desc

/*
Top 5 de los afiliados con mayor cantidad de bonos comprados, detallando si
pertenece a un grupo familiar
*/
--insert into pico_y_pala.gf_afiliado (agf_gpo_id,agf_afi_nro_doc) values (553,58654126)

select top 5 
	afi_nro_doc
	,usu.usu_apellido + ', ' + usu.usu_nombre Apellido_y_Nombre
	--,gf.gpo_id
	,count (*) cantidad_de_bonos_comprados
	,case
		when (select count (*) from pico_y_pala.gf_afiliado gfaux where gfaux.agf_gpo_id = gf.gpo_id) >1
				 then 'tiene grupo familiar'
		else 'no tiene grupo familiar'
	end esta_en_grupo
from pico_y_pala.afiliado afi 
inner join pico_y_pala.usuario usu on afi.afi_nro_doc = usu_nro_doc
inner join pico_y_pala.gf_afiliado gfa on gfa.agf_afi_nro_doc = afi.afi_nro_doc
inner join pico_y_pala.grupo_familiar gf on gf.gpo_id = gfa.agf_gpo_id
inner join pico_y_pala.bono bono on afi.afi_nro_doc = bono.bon_afiliado_compra

group by 
	afi_nro_doc
	,usu.usu_apellido + ', ' + usu.usu_nombre
	,gf.gpo_id
order by count (*) desc


/*
Top 5 de las especialidades de médicos con más bonos de consultas
utilizados.
*/

select 
	esp.esp_desc
	,count (cons.con_bono_utilizado)
from pico_y_pala.especialidad esp
inner join pico_y_pala.profesional_especialidad pes on pes.pes_esp_id = esp.esp_id
inner join pico_y_pala.profesional pro on pro.pro_nro_doc = pes.pes_pro_nro_doc
inner join pico_y_pala.turno turno on turno.tur_pro_nro_doc = pro.pro_nro_doc
inner join pico_y_pala.consulta cons on cons.con_tur_id = turno.tur_id
group by esp.esp_desc
order by count (cons.con_bono_utilizado) desc