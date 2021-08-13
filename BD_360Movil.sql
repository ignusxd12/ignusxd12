
-- tablas
create table eir_container(
eir varchar(15) primary key not null,
contenedor varchar(20) null,
sello varchar(20),
responsable int,
empresa int
)

create table responsable(
responsable int primary key not null,
responsable_nombre varchar(80)
)

create table empresa(
empresa int primary key,
empresa_nombre varchar(80)
)


-- procedimiento

use [360Movil]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<ignacio muñoz>
-- Create date: <12-08-2021>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_get_eir_datos]
@EIR varchar(15)=NULL	
AS
BEGIN

SELECT e.eir,e.contenedor,e.sello,e.responsable,r.responsable_nombre,emp.empresa_nombre FROM eir_container e
inner join empresa emp on emp.empresa=e.empresa
inner join responsable r on r.responsable=e.responsable
where e.eir=@EIR
	
END
GO

--Datos
insert into eir_container values('1','contenedor 1','sello 1',1,1)
insert into eir_container values('2','contenedor 2','sello 2',2,2)
insert into eir_container values('3','contenedor 3','sello 3',3,3)

insert into empresa values(1,'Facebook')
insert into empresa values(2,'Netflix')
insert into empresa values(3,'Amazon')

insert into responsable values(1,'Ignacio')
insert into responsable values(2,'Felipe')
insert into responsable values(3,'Elias')


