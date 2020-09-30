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


CREATE TABLE a_historico_tb(
id_log serial not null,
tipo_movimento int not null,
data_log timestamp with time zone,
id_registro int not null,
nome_antigo text,
rg_antigo text,
cpf_antigo text,
endereco_antigo text,
complemento_antigo text,
numero_celular_antigo text,
numero_telefone_antigo text,
tipo_cliente_antigo text,
observacao_antigo text,
constraint u_log_tb_pk primary key (id_log),
constraint u_agenda_tb_fk foreign key(id_registro)
references a_agenda_tb(id)
);

