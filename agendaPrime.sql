CREATE TABLE a_agenda_tb 
(
id serial not null,
nome text,
rg text,
cpf text,
endereco text,
complemento text,
numero_celular text,
numero_telefone text,
tipo_cliente text,
observacao text,
constraint u_agenda_tb_pk primary key (id)
);