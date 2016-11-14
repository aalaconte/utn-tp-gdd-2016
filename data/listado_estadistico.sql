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
