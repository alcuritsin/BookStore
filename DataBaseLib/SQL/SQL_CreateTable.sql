create table table_role
(
	id int auto_increment,
	Name nvarchar(50) not null comment 'Наименование роли',
	constraint table_role_pk
		primary key (id)
)
comment 'Роли пользователей';

INSERT INTO host1323541_pd3.table_role (Name)
VALUES ('admin');

INSERT INTO host1323541_pd3.table_role (Name)
VALUES ('buyer');

INSERT INTO host1323541_pd3.table_role (Name)
VALUES ('seller');