create database M_P
go
use  M_P
go

create table cargo_login
(
id_cargo int identity (1,1) primary key,
cargo nvarchar(50)
)
go
create table login_ingreso
(
id_login int identity (1,1) primary key,
usuario nvarchar(50),
passwordd nvarchar(50),
id_cargo int,
nombre nvarchar(50),
apellido nvarchar(50),
email nvarchar(50),
codigo nvarchar(50),

foreign key (id_cargo) references cargo_login(id_cargo)
)
go

------------------------------------------------------------------------------
go
create table escaner
(
numero_documetno char(20),
escaner image
)
create table tipo_docume
(
id_tipodocumento int identity (1,1) primary key ,
Tipo_Documento nvarchar(150)
)

create table documento_isquierdo
(
id_documento_isquierdo int identity (1,1) primary key ,
N_Correlativa int,
fecha date,
N_Mesa_Partes nvarchar(50),
id_tipodocumento int,
N_Documento nvarchar(50),
Folio nvarchar(50),
Procedencia_Documento nvarchar(180),
foreign key (id_tipodocumento) references tipo_docume(id_tipodocumento),
)
create table P_doctorado
(
id_doctorado int identity (1,1) primary key ,
Doctorado nvarchar(150),

)
create table P_ciencias
(
id_ciencias int identity (1,1) primary key ,
Facultad_Ciencias nvarchar(150),

)
create table P_ingenieria
(
id_ingenieria int identity (1,1) primary key ,
Facultad_Ingenieria nvarchar(150),

)
create table P_salud
(
id_salud int identity (1,1) primary key ,
Facultad_Salud nvarchar(150),
)
create table P_sede
(
id_sede int identity (1,1) primary key ,
Filial nvarchar(150),

)
create table P_otros
(
id_otros int identity (1,1) primary key ,
Nombres nvarchar(150),
)
create table documento_derecho
(
id_documento_derecho int identity (1,1) primary key ,
Asunto_Documento nvarchar(400),
Observaciones nvarchar(100),
id_documento_isquierdo  int ,
id_doctorado int ,
id_ciencias int,
id_salud int,
id_sede int,
id_otros int,
id_ingenieria int,
foreign key (id_documento_isquierdo) references documento_isquierdo(id_documento_isquierdo),
foreign key (id_doctorado) references P_doctorado(id_doctorado),
foreign key (id_ciencias) references P_ciencias(id_ciencias),
foreign key (id_salud) references P_salud (id_salud),
foreign key (id_sede) references P_sede (id_sede),
foreign key (id_otros) references P_otros (id_otros),
foreign key (id_ingenieria) references P_ingenieria (id_ingenieria),

)

insert into tipo_docume values (''),('oficio'),('carta'),('otro')
insert into P_doctorado values (''),('Vice Rectorado Academico'),('Vice Rectorado Investigacion'),('Oficina Control Interno'),('Oficina de Asesoramiento Juridica'),('Oficina de Planeacion Desarrollo Universitario'),('Oficina Coperacion tecnica relacion interuniversitaria'),('Direcion General Adminitracion'),('Sub Direcion de Contabilidad'),('Sub Direcion De Tesoreria')
insert into P_salud values (''),('Escuela de emfermeria'),('Escuela de estatomalogia')
insert into P_ciencias values (''),('Escuela de derecho'),('Escuela de contabilidad'),('Escuela de educacion'),('Escuela de turismo')
insert into P_ingenieria values (''),('Escuela de ing sistememas e informatica'),('Escuela de ing civil'),('Escuela de ing agronomia'),('Escuela de ing ambiental')
insert into P_sede values (''),('sub sede andahuylas'),('sub sede cusco')
insert into P_otros values (''),('comision central de admision'),('comite electoral unicersitario'),('medisina basica'),('defensoria universitaria'),('direcion de investigacion'),('oficina de tecnologia e imformacion oti'),('departamento academico de ingenieria'),('otro')

create proc doctorado
as
select id_doctorado,Doctorado from P_doctorado order by Doctorado asc  
go
create proc salud
as
select id_salud,Facultad_Salud from P_salud order by Facultad_Salud asc  
go
create proc ciencias
as
select id_ciencias,Facultad_Ciencias from P_ciencias order by Facultad_Ciencias asc  
go
create proc ingenieria
as
select id_ingenieria,Facultad_Ingenieria from P_ingenieria order by Facultad_Ingenieria asc  
go
create proc sede
as
select id_sede,Filial from P_sede order by Filial asc  
go
create proc otros
as
select id_otros,Nombres from P_otros order by Nombres asc  
go
select*from documento_derecho

go
create proc mostrar_documentaciom
as
select dq.id_documento_isquierdo,Asunto_Documento,Observaciones,Doctorado,Facultad_Ciencias,Facultad_Ingenieria
,Facultad_Salud,Nombres,Filial,id_documento_derecho from documento_derecho dr 
inner join documento_isquierdo dq on dq.id_documento_isquierdo=dr.id_documento_isquierdo
inner join P_doctorado pd on pd.id_doctorado=dr.id_doctorado
inner join P_ciencias ci on ci.id_ciencias=dr.id_ciencias
inner join P_salud ps on ps.id_salud=dr.id_salud
inner join P_ingenieria pim on pim.id_ingenieria=dr.id_ingenieria
inner join P_otros po on po.id_otros=dr.id_otros
inner join P_sede ped on ped.id_sede=dr.id_sede

go
 exec motr
create proc tipo_domun
as
select id_tipodocumento,tipo_documento from tipo_docume order by tipo_documento asc  
go
create proc mostrar_documento_isquierdo
as
select id_documento_isquierdo,N_Correlativa,fecha,N_Mesa_Partes,tipo_documento,N_Documento,Folio,Procedencia_Documento from documento_isquierdo di inner join  tipo_docume td
on di.id_tipodocumento=td.id_tipodocumento
go

create proc insertrar_documento_isiquierdo
@correlativa int,
@fecha date,
@mesa_partes nvarchar(50),
@tipodocumento int,
@documento nvarchar(50),
@folio nvarchar(50),
@procedencia nvarchar(50)
as
insert into documento_isquierdo values(@correlativa,@fecha,@mesa_partes,@tipodocumento,@documento,@folio,@procedencia)
go
 exec insertrar_documento_isiquierdo 3,'2018-10-07','rewrewrew',2,'3213213','dw','dwadw'
 go
create proc editar_documentacioisqueir
@correlativa int,
@fecha date,
@mesa_partes nvarchar(50),
@tipodocumento int,
@documento nvarchar(50),
@folio nvarchar(50),
@procedencia nvarchar(50),
@id_solitante int
as
update  documento_isquierdo set N_Correlativa=@correlativa,fecha=@fecha,N_Mesa_Partes=@mesa_partes,id_tipodocumento=@tipodocumento,N_Documento=@documento,
Folio=@folio,Procedencia_Documento=@procedencia
where id_documento_isquierdo=@id_solitante
go

create proc elimar_documetacionistquierda

@id_docum int
as
delete from documento_isquierdo where id_documento_isquierdo=@id_docum
go

create proc insertrar_documento_derecho
@asunto nvarchar(400),
@obeservacion nvarchar(100),
@doctorado int,
@ciencia int,
@salud int,
@sede int,
@otros int,
@inieria int,
@solicitante int
as
insert into documento_derecho values(@asunto,@obeservacion,@doctorado,@ciencia,@salud,@sede,@otros,@inieria,@solicitante)
go
exec insertrar_documento_derecho  '212','121',1,1,1,1,2,1,2
create proc editar_documenderecho
@asunto nvarchar(400),
@obeservacion nvarchar(100),
@doctorado int,
@ciencia int,
@salud int,
@sede int,
@otros int,
@inieria int,
@solicitante int,
@doderecha int

as
update  documento_derecho set Asunto_Documento =@asunto,Observaciones=@obeservacion,id_doctorado=@doctorado,id_ciencias=@ciencia,id_salud=@salud,
id_sede=@sede,id_otros=@otros,id_ingenieria=@inieria,id_documento_isquierdo=@solicitante
where id_documento_derecho=@doderecha
go

create proc elimar_documetderecha

@id_docum int
as
delete from documento_derecho where id_documento_derecho=@id_docum
go
select*from documento_derecho





-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
insert into cargo_login values (''),('administrador'),('usuario_principal'),('usuario_secundario')
insert into cargo_login values (''),('administrador'),('usuario_principal'),('usuario_secundario')
-------------------------------------------------------------------------------
insert into login_ingreso values ('admin','root',2,'andy','cuellar quino','andisistemas12@gmail.com','acq')
insert into login_ingreso values ('admin','123',3,'poluco','pepe quispe','andisistemas12@gmail.com','acq')
select*from login_ingreso
go
create proc admin
@usuario nvarchar (50),
@passowor nvarchar (50)
as
select*from login_ingreso
where usuario=@usuario and passwordd=@passowor
go
exec admin 'admin','root'
-------------------------------------------------------------------------------
create proc cargo
as
select id_cargo,cargo from cargo_login order by cargo asc
go

--------------------------------------------------------------
create proc insetlogin
@usuario nvarchar(50),
@passowr nvarchar(50),
@cargo int,
@nombre nvarchar(50),
@apellido nvarchar(50),
@email nvarchar(50),
@codigo nvarchar(50)
as
insert into login_ingreso values (@usuario,@passowr,@cargo,@nombre,@apellido,@email,@codigo)


go
create proc recuperar_usuario
@usuario nvarchar(50)
as
select*from login_ingreso
where usuario=@usuario
go


create proc mostrad_adminitrador_login
as
select id_login as Numero,nombre AS Nombres,apellido as Apellido,cargo as Cargo
,usuario,passwordd,email as Email
from login_ingreso og inner join cargo_login ca on og.id_cargo=ca.id_cargo
go


create proc elimar_adminitrador_login

@id_login int
as
delete from login_ingreso where id_login=@id_login
go

select*from documento_isquierdo

go
create proc documento_todo
as
select  N_Documento ,fecha, dq.id_documento_isquierdo,Asunto_Documento,Observaciones from documento_derecho dr 
inner join documento_isquierdo dq on dq.id_documento_isquierdo=dr.id_documento_isquierdo
inner join P_doctorado pd on pd.id_doctorado=dr.id_doctorado
inner join P_ciencias ci on ci.id_ciencias=dr.id_ciencias
inner join P_salud ps on ps.id_salud=dr.id_salud
inner join P_ingenieria pim on pim.id_ingenieria=dr.id_ingenieria
inner join P_otros po on po.id_otros=dr.id_otros
inner join P_sede ped on ped.id_sede=dr.id_sede
go
create proc fecha_todo
@fecha date
as
select  N_Documento ,fecha,Asunto_Documento,Observaciones from documento_derecho dr 
inner join documento_isquierdo dq on dq.id_documento_isquierdo=dr.id_documento_isquierdo
inner join P_doctorado pd on pd.id_doctorado=dr.id_doctorado
inner join P_ciencias ci on ci.id_ciencias=dr.id_ciencias
inner join P_salud ps on ps.id_salud=dr.id_salud
inner join P_ingenieria pim on pim.id_ingenieria=dr.id_ingenieria
inner join P_otros po on po.id_otros=dr.id_otros
inner join P_sede ped on ped.id_sede=dr.id_sede
where  fecha=@fecha
go
exec fecha_todo @fecha='2018-07-02'


create proc numero
@numer_sede int out ,
@umero_salud int out,
@numero_otro int out,
@numer_ingenieria int out ,
@umero_ciencias int out,
@numero_doctorado int out,
@numero_total int out
as
set @numer_sede=(select COUNT(id_sede) from P_sede where Filial   like's%')
set @umero_salud=(select count(id_salud)  from P_salud where Facultad_Salud   like'e%'  )
set @numero_otro=(select count(id_otros)  from P_otros )
set @umero_ciencias=(select COUNT(id_ciencias) from P_ciencias where Facultad_Ciencias   like'e%')
set @numer_ingenieria=(select count(id_ingenieria)  from P_ingenieria where Facultad_Ingenieria   like'e%'  )
set @numero_doctorado=(select count(id_doctorado)  from P_doctorado )
set @numero_total=(select count(id_documento_isquierdo)  from documento_isquierdo )
go

create proc repomotrar
as
select N_Correlativa,fecha,N_Mesa_Partes,tipo_documento,N_Documento,Folio,Procedencia_Documento,
Asunto_Documento,Observaciones,Doctorado,Facultad_Ciencias,Facultad_Ingenieria
,Facultad_Salud,Nombres,Filial from documento_derecho dr 
inner join documento_isquierdo dq on dq.id_documento_isquierdo=dr.id_documento_isquierdo
inner join P_doctorado pd on pd.id_doctorado=dr.id_doctorado
inner join P_ciencias ci on ci.id_ciencias=dr.id_ciencias
inner join P_salud ps on ps.id_salud=dr.id_salud
inner join P_ingenieria pim on pim.id_ingenieria=dr.id_ingenieria
inner join P_otros po on po.id_otros=dr.id_otros
inner join P_sede ped on ped.id_sede=dr.id_sede
inner join tipo_docume qq on qq.id_tipodocumento=dq.id_tipodocumento
go