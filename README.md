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
    preparo VARCHAR(1600),
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
gerada pelos alimentos integrais.', '30 min', '4 porções', 1, 5, 2); 

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

INSERT INTO favoritos
VALUES(1, 1, 'Mandinha');

/* Tartar */

INSERT INTO receitas
VALUES(2, 'Tartar de salmão, manga e avocado', '../imagens/tartar.jpg', 
'imagem de tartar de salmão, manga e avocado', 'Salgado', 'Africa', 'https://www.youtube.com/embed/OhiMLGrulKk',
'Comece por limpar bem o salmão, removendo a sua pele completamente, e cortá-lo em pequenos cubos de aproximadamente 1 cm de cada lado.
Descasque e pique finamente a cebola, como pode observar na imagem seguinte.
Para marinar o salmão do tartar, em uma tigela funda misture o salmão em cubos com a cebola picada. Regue com suco do limão, mostarda, shoyu e azeite de oliva. Misture tudo muito bem.
Cubra a tigela com filme plástico, selando bem, e deixe marinar para que o salmão cozinhe com os ingredientes cítricos. Deixe na geladeira por uma hora.
Enquanto isso, prepare o acompanhamento para o salmão. Em seguida, pegue o abacate e a manga e corte em pequenos cubos do mesmo tamanho do salmão, com aproximadamente 1 cm de cada lado. Reserve por um momento.
Passado o tempo de descanso, retire o salmão marinado da geladeira. O tartar de salmão com manga pode ser servido com camadas de manga e abacate, como na imagem, ou misturado.', 
'Um dos ingredientes desse tartar é o salmão: um alimento que é rico em ômega 3, possui ação antiinflamatória, beneficia o controle do colesterol e a saúde mental. Além disso,  pode ser uma boa fonte de iodo, cuidando da saúde da tireoide.', 
'1h30', '6 porções', 0, 5, 0);

INSERT INTO ingredientes
VALUES(7, 2, '½ quilograma de Salmão fresco');

INSERT INTO ingredientes
VALUES(8, 2, '2 Abacates');

INSERT INTO ingredientes
VALUES(9, 2, '1 Cebola');

INSERT INTO ingredientes
VALUES(10, 2, '1 Manga');

INSERT INTO ingredientes
VALUES(11, 2, '1 Limão');

INSERT INTO ingredientes
VALUES(12, 2, '1 colher de café de Mostarda');

INSERT INTO ingredientes
VALUES(13, 2, '4 colheres de sopa de Shoyu');

INSERT INTO ingredientes
VALUES(14, 2, '2 colheres de sopa de Azeite de oliva');

/* Torta de abobora de noz e peca */

INSERT INTO receitas
VALUES(3, 'Torta de abóbora de noz e pecã', '../imagens/torta-abobora-nozes.png', 
'imagem de torta de abóbora de noz e pecã', 'Doce', 'America', 'https://www.youtube.com/embed/Pv6qx9nnBHg',
'Pré-aqueça o forno (215 ° C), enfarinhe sua superfície de trabalho e estenda sua massa de torta em um disco de 14 polegadas.
Transfira a massa para uma forma de torta de 10 polegadas. Pressione suavemente a massa no fundo e nas laterais da forma. Corte o excesso de massa usando uma faca afiada ou rolando o rolo na parte superior da assadeira. Encaixe a massa perfurando-a várias vezes com um garfo, cobrindo toda a área da base dela.
Asse a massa por 5 minutos. Retire do forno e deixe esfriar por 10 minutos enquanto prepara o recheio.
Enquanto isso, enquanto a crosta está esfriando, reduza a temperatura do forno para 175 ° C.
Em uma tigela grande, misture o purê de abóbora, 1 dos ovos, 1 colher de sopa de açúcar granulado, açúcar mascavo claro, 2 colheres de sopa de manteiga derretida e o tempero da torta de abóbora. Despeje a mistura na massa.
Em uma tigela separada, misture o xarope de milho, o extrato de baunilha, os 2 ovos restantes, ⅓ xícara de açúcar granulado e a 1 colher de sopa restante de manteiga derretida. Mexa até ficar homogêneo. Acrescente delicadamente as nozes picadas e despeje lentamente a mistura sobre o recheio de abóbora.
Asse no forno pré-aquecido 175 ° C por 40-45 minutos ou até que o centro esteja definido.
Retire a torta do forno e deixe esfriar completamente antes de servir.', 
'Um dos principais ingredientes desta deliciosa torta são as nozes. Elas que são um ingrediente típico do inverno, acumulam muitas calorias e já foram consideradas inimigas da alimentação humana por serem ricas em gorduras. Atualmente, contudo, elas passaram a ser recomendadas por trazerem o grande 
benefício à saúde de ajudar a controlar o colesterol ruim e, assim, proteger o coração;  podem compor tanto receitas doces quanto salgadas.', '55 min', '6 porções', 0, 5, 0);

INSERT INTO ingredientes
VALUES(15, 3, '1 massa de torta de manteiga (ou use uma massa comprada em loja)');

INSERT INTO ingredientes
VALUES(16, 3, '1 taça purê de abóbora');

INSERT INTO ingredientes
VALUES(17, 3, '3 ovos (à temperatura ambiente)');

INSERT INTO ingredientes
VALUES(18, 3, '⅓ de copo de açúcar');

INSERT INTO ingredientes
VALUES(19, 3, '2 colher de sopa açúcar mascavado claro (embalado)');

INSERT INTO ingredientes
VALUES(20, 3, '3 colher de sopa manteiga (derretido, dividido)');

INSERT INTO ingredientes
VALUES(21, 3, '½ de copo de xarope de milho');

INSERT INTO ingredientes
VALUES(22, 3, '½ colher de sopa extrato de baunilha');

INSERT INTO ingredientes
VALUES(23, 3, '1 copo de nozes picadas');

/* Dakos */

INSERT INTO receitas
VALUES(5, 'Dakos', '../imagens/dakos.png', 
'imagem de Dakos', 'Salgado', 'Europa', 'https://www.youtube.com/embed/fzBkeChLJL8',
'Reúna os ingredientes.
Pulverize a fatia de pão com água para umedecer.
Rale o tomate com um ralador de vegetais em um coador sobre uma tigela para que a maior parte do líquido escorra.
Espalhe o tomate coado e ralado no pão e cubra com queijo. Polvilhe com a pimenta e uma boa quantidade de orégãos e regue com azeite.', 
'O dakos é um prato vegetariano tradicional da ilha de Creta, perfeito para se realizar uma refeição leve. Ele é preparado com ingredientes 
mediterrâneos muito comuns não somente na Grécia, mas em outros países como a Itália e a Turquia. A culinária grega é muito apreciada por diversas 
pessoas porque seus ingredientes possuem muitas verduras e temperos simples como o azeite e ervas aromáticas.', '15 min', '60 porções', 0, 5, 0);

INSERT INTO ingredientes
VALUES(24, 4, '1 fatia de pão de cevada torrado de 10cm de diâmetro com 1,5cm de altura');

INSERT INTO ingredientes
VALUES(25, 4, '2 tomates sem pele');

INSERT INTO ingredientes
VALUES(26, 4, '3 colheres de sopa de queijo feta ');

INSERT INTO ingredientes
VALUES(27, 4, '3 colheres de chá de azeite extra-virgem');

INSERT INTO ingredientes
VALUES(28, 4, 'Pimenta preta moída na hora, a gosto');

INSERT INTO ingredientes
VALUES(29, 4, 'Orégano a gosto');

/* */
```
