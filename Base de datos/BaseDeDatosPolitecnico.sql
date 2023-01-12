CREATE DATABASE NotasPolitecnicoInternacional;

USE NotasPolitecnicoInternacional;


CREATE TABLE tecnologiaDesarrolloSoftware(

id int IDENTITY(1,1) primary key,
NombreEstudiante varchar(50),
Corte1 varchar(10),
Corte2 varchar(10), 
Corte3 varchar(10), 
Definitiva varchar(10) 
);


select * from tecnologiaDesarrolloSoftware;

