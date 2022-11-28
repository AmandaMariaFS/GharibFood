# GharibFood

Site desenvolvido por estudantes do 3º ano do Técnico em informática integrado ao ensino médio

## Como rodar o site:

Clone os códigos presentes no repositório e rode no vscode. No mySql, crie um usuário "estudante" com senha "estudante" e rode no banco de dados "estudante" o seguinte repositório:

```
USE estudante;

CREATE TABLE receitas(
	id INT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    imagem VARCHAR(100),
    text_alt VARCHAR(200),
    categoria VARCHAR(7),
    continente VARCHAR(7),
    video VARCHAR(200),
    preparo VARCHAR(1300),
    curiosidade VARCHAR(1000),
    tempo VARCHAR(6),
    rendimento VARCHAR(12),
    favoritos INT,
    estrelas INT,
    comentarios INT
);  

CREATE TABLE ingredientes(
	id INT PRIMARY KEY,
	id_receita INT REFERENCES Receitas(id_receita),
    ing VARCHAR(130)
); 


CREATE TABLE usuarios(
	id VARCHAR(14) PRIMARY KEY,
    nome VARCHAR(200) NOT NULL,
    email VARCHAR(200) NOT NULL,
    senha VARCHAR(20) NOT NULL,
    foto VARCHAR(100)
);  

CREATE TABLE comentarios(
	id INT PRIMARY KEY,
    user VARCHAR(14) REFERENCES Usuarios(user_name),
    id_receita INT REFERENCES Receitas(id_receita),
    coment VARCHAR(280),
    data VARCHAR(30)
); 

CREATE TABLE favoritos (
	id INT PRIMARY KEY,
	id_receita INT REFERENCES Receitas(id_receita),
    user VARCHAR(14) REFERENCES Usuarios(user_name)
); 

INSERT INTO usuarios
VALUES('Mandinha', 'Amanda Maria', 'a@gmail.com', '12345', 'Sem foto');

INSERT INTO receitas
VALUES(1, 'Arroz negro à brasileira', '../imagens/arroznegro.jpg', 
'imagem de arroz negro à brasileira', 'Salgado', 'America', 'https://www.youtube.com/embed/diKgUdmj0m8',
'Para preparar seu arroz negro, comece por levar ao fogo médio uma panela com o azeite. Quando estiver quente, adicione a cebola e o alho picados e deixe refogar por 2-3 minutos, mexendo de vez em quando, para não deixar queimar.
Depois adicione o arroz, sem precisar lavar, e misture com o refogado por 1 minuto - esse é um dos truques para conseguir um arroz soltinho depois de cozinhar! Acrescente as 3 xícaras de água fervente e o sal, baixe um pouco o fogo e tampe a panela.
Deixe o arroz negro cozinhar por 20 minutos com a panela tampada ou até a água secar e o arroz estiver cozido. Se a água secar ao fim desse tempo, mas o arroz ainda estiver cru, acrescente mais um pouco de água fervente para terminar de cozinhar. Sirva do jeito que preferir e bom apetite!', 'O arroz negro é um excelente alimento para equilibrar o nível de glicose no sangue e regular 
o intestino. Devido a sua grande quantidade de fibras presente até mesmo em pequenas porções, esse cereal se 
torna uma ótima fonte para regular as funções do organismo e ainda consegue promover a sensação de saciedade 
gerada pelos alimentos integrais.', '30 min', '4 porções', 0, 0, 0); 

INSERT INTO ingredientes
VALUES(1, 1,  '1 xícara de arroz negro'); 

INSERT INTO ingredientes
VALUES(2, 1, ' 3 xícaras de água fervente');

INSERT INTO ingredientes
VALUES(3, 1, '2 colheres de chá de sal');

INSERT INTO ingredientes
VALUES(4, 1, '1 cebola picada');

INSERT INTO ingredientes
VALUES(5, 1, '1 dente de alho picado');

INSERT INTO ingredientes
VALUES(6, 1, '1 fio de azeite de oliva');

INSERT INTO comentarios
VALUES(1, 'Analu', 1, 'Adorei essa receita', CONVERT(sysdate(), CHAR));

INSERT INTO comentarios
VALUES(2, 'Mandinha', 1, 'MDS ESSE SITE É MUITO BOM!!! MERECE NOTA 10', CONVERT(sysdate(), CHAR));
```
