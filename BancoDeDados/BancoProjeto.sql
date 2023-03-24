create database dbControleGastos;

use dbControleGastos;

create table pessoa(
		codPessoa int not null primary key identity,
		nome varchar(80) not null,
		email varchar(50) not null,
		cpf varchar(11) not null,
);

create table receita(
		codReceita  int not null primary key identity,
		codPessoa  int not null foreign key references pessoa(codPessoa),
		tipoRenda varchar(50) not null,
		valorRenda decimal(10,2) not null,
		
);

create table despesa(
		codDespesa int not null primary key identity,
		codPessoa int not null foreign key references pessoa(codPessoa),
		tipoDespesa varchar(50) not null,
		valorDespesa decimal(10,2) not null,
		
);

alter table receita add dataReceita date;
alter table despesa add dataDespesa date;

drop table receita;
drop table despesa;
drop table pessoa;



select * from pessoa;

Update receita set codPessoa = @codPessoa, valorRenda = @valorRenda, tipoRenda = @tipoRenda " +
                " Where codReceita = @codReceita;



select*from despesa;

select * from despesa where codPessoa = 10;


select*from receita;

delete  from gestao;
delete from pessoa;



select  pessoa.nome ,tipoDespesa as 'Tipo da Despesa', valorDespesa as 'Valor da Despesa' from despesa, pessoa 
where despesa.codPessoa = pessoa.codPessoa;


select pessoa.nome, tipoRenda as 'Tipo de Receita', valorRenda as 'Valor da Receita' from receita, pessoa 
where receita.codPessoa = pessoa.codPessoa;


select receita.valorRenda, receita.tipoRenda, pessoa.codPessoa from ((receita 
inner join pessoa on receita.codPessoa = 7));




select * from pessoa;
select * from receita;
select * from despesa;


