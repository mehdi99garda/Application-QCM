create database qcm
use qcm 


create table formateur(
nom_prenom varchar(30),
matricule varchar(15) ,
CIN varchar(15),
etabli varchar(15),
users varchar(15),
pass varchar(15))


insert into formateur values('mehdi el','matricule 1','HA2135','OFPPT','mehdi10','1234')

create table filiere_module(
id int primary  key identity ,
filiere varchar(15),
module varchar(15))

select * from filiere_module

insert into filiere_module values ('','')

create table question_qcm (
id int ,
num int,
question text,
rep text,
choix1 text,
choix2 text,
choix3 text)

update question_qcm set question='',rep='',choix1='',choix2='',choix3=''

select  num as numero , question , rep as reponse 
from question_qcm 
where id in(
select id from filiere_module 
where filiere='' and module='')

select * from question_qcm


insert into question_qcm values(1,1,'q','r','c','c','c')

create table sessione(
filiere varchar(15) primary key,
img1 varchar(60),
modul1 varchar(60),
img2 varchar(60),
modul2 varchar(60),
img3 varchar(60),
modul3 varchar(60))

update sessione set img1='',modul1='',img2='',modul2='',img3='',modul3='' where filiere=''
select * from sessione
insert into sessione values('f','i1','m1','i2','m2','i3','m3')
select count(*) from formateur where users='' and pass=''

drop table reussite(
Nom_Prenom varchar(20),
CIN varchar(20),
filiere varchar(20),
module varchar(20),
Note int,
La_Date date
)

update question_qcm set question='debut de deuxieme gurre',
rep='1939',
choix1='1945',
 choix2='1936',
 choix3='1939' 
 where id=5 and num=3

 ALTER TABLE question_qcm
ALTER COLUMN choix3 text;

create table certif(
filiere varchar(30),
module varchar(30),
nom text ,
cin varchar(20) ,
note int ,
datt date
)
insert into certif values('f','m','n','c',1,'10/10/2019')
select * from  certif