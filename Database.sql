CREATE TABLE Vyrobce(
id int primary key identity(1,1),
nazev varchar(20) not null UNIQUE,
email varchar(50) not null UNIQUE check(email like '%@%')
);

CREATE TABLE Vyrobek(
id int primary key identity(1,1),
vyrobce_id int NOT NULL foreign key references Vyrobce(id),
typ varchar(20) NOT NULL,
nazev varchar(20) NOT NULL,
cena_ks int NOT NULL check(cena_ks > 0)
);

CREATE TABLE Zakaznik(
id int primary key identity(1,1),
prijmeni varchar(20) not null,
email varchar(50) not null UNIQUE check(email like '%@%')
);

CREATE TABLE Objednavka(
id int primary key identity(1,1),
zak_id int NOT NULL foreign key references Zakaznik(id),
cis_obj int NOT NULL UNIQUE,
datum date NOT NULL,
cena_objednavky int NOT NULL check(cena_objednavky > 0)
);

CREATE TABLE Polozka(
id int primary key identity(1,1),
obj_id int NOT NULL foreign key references Objednavka(id),
vyrobek_id int NOT NULL foreign key references Vyrobek(id),
pocet_ks int NOT NULL,
cena_polozky int NOT NULL check(cena_polozky > 0)
);

select * from Vyrobce;
select * from Vyrobek;
select * from Polozka;
select * from Zakaznik;
select * from Objednavka;