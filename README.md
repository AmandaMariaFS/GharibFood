# GharibFood

Site desenvolvido por estudantes do 3º ano do Técnico em informática integrado ao ensino médio

## Como rodar o site:

Clone os códigos presentes no repositório e rode no vscode. No mySql, crie um usuário "estudante" com senha "estudante" e rode no banco de dados "estudante" o seguinte repositório:

```
USE estudante;

CREATE TABLE Receitas(
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

CREATE TABLE Ingredientes(
	id INT PRIMARY KEY,
	id_receita INT REFERENCES Receitas(id_receita),
    ing VARCHAR(130)
);


CREATE TABLE Usuarios(
	id VARCHAR(14) PRIMARY KEY,
    nome VARCHAR(200) NOT NULL,
    email VARCHAR(200) NOT NULL,
    senha VARCHAR(20) NOT NULL,
    tipo VARCHAR(100)
);  

CREATE TABLE Comentarios(
	id INT PRIMARY KEY,
    user VARCHAR(14) REFERENCES Usuarios(user_name),
    id_receita INT REFERENCES Receitas(id_receita),
    coment VARCHAR(280),
    data VARCHAR(30)
); 

CREATE TABLE Favoritos (
	id INT PRIMARY KEY,
	id_receita INT REFERENCES Receitas(id_receita),
    user VARCHAR(14) REFERENCES Usuarios(user_name)
); 

INSERT INTO Usuarios
VALUES('Mandinha', 'Amanda Maria', 'a@gmail.com', '12345', 'Adm');

INSERT INTO Receitas
VALUES(1, 'Arroz negro à brasileira', '../imagens/arroznegro.jpg', 
'imagem de arroz negro à brasileira', 'Salgado', 'America', 'https://www.youtube.com/embed/diKgUdmj0m8',
'Para preparar seu arroz negro, comece por levar ao fogo médio uma panela com o azeite. Quando estiver quente, adicione a cebola e o alho picados e deixe refogar por 2-3 minutos, mexendo de vez em quando, para não deixar queimar.
Depois adicione o arroz, sem precisar lavar, e misture com o refogado por 1 minuto - esse é um dos truques para conseguir um arroz soltinho depois de cozinhar! Acrescente as 3 xícaras de água fervente e o sal, baixe um pouco o fogo e tampe a panela.
Deixe o arroz negro cozinhar por 20 minutos com a panela tampada ou até a água secar e o arroz estiver cozido. Se a água secar ao fim desse tempo, mas o arroz ainda estiver cru, acrescente mais um pouco de água fervente para terminar de cozinhar. Sirva do jeito que preferir e bom apetite!', 'O arroz negro é um excelente alimento para equilibrar o nível de glicose no sangue e regular 
o intestino. Devido a sua grande quantidade de fibras presente até mesmo em pequenas porções, esse cereal se 
torna uma ótima fonte para regular as funções do organismo e ainda consegue promover a sensação de saciedade 
gerada pelos alimentos integrais.', '30 min', '4 porções', 1, 5, 2); 

INSERT INTO Ingredientes
VALUES(1, 1,  '1 xícara de arroz negro'); 

INSERT INTO Ingredientes
VALUES(2, 1, ' 3 xícaras de água fervente');

INSERT INTO Ingredientes
VALUES(3, 1, '2 colheres de chá de sal');

INSERT INTO Ingredientes
VALUES(4, 1, '1 cebola picada');

INSERT INTO Ingredientes
VALUES(5, 1, '1 dente de alho picado');

INSERT INTO Ingredientes
VALUES(6, 1, '1 fio de azeite de oliva');

INSERT INTO Comentarios
VALUES(1, 'Analu', 1, 'Adorei essa receita', CONVERT(sysdate(), CHAR));

INSERT INTO Comentarios
VALUES(2, 'Mandinha', 1, 'MDS ESSE SITE É MUITO BOM!!! MERECE NOTA 10', CONVERT(sysdate(), CHAR));

INSERT INTO Favoritos
VALUES(1, 1, 'Mandinha');

/* Tartar */

INSERT INTO Receitas
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

INSERT INTO Ingredientes
VALUES(7, 2, '½ quilograma de Salmão fresco');

INSERT INTO Ingredientes
VALUES(8, 2, '2 Abacates');

INSERT INTO Ingredientes
VALUES(9, 2, '1 Cebola');

INSERT INTO Ingredientes
VALUES(10, 2, '1 Manga');

INSERT INTO Ingredientes
VALUES(11, 2, '1 Limão');

INSERT INTO Ingredientes
VALUES(12, 2, '1 colher de café de Mostarda');

INSERT INTO Ingredientes
VALUES(13, 2, '4 colheres de sopa de Shoyu');

INSERT INTO Ingredientes
VALUES(14, 2, '2 colheres de sopa de Azeite de oliva');

/* Torta de abobora de noz e peca */

INSERT INTO Receitas
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

INSERT INTO Ingredientes
VALUES(15, 3, '1 massa de torta de manteiga (ou use uma massa comprada em loja)');

INSERT INTO Ingredientes
VALUES(16, 3, '1 taça purê de abóbora');

INSERT INTO Ingredientes
VALUES(17, 3, '3 ovos (à temperatura ambiente)');

INSERT INTO Ingredientes
VALUES(18, 3, '⅓ de copo de açúcar');

INSERT INTO Ingredientes
VALUES(19, 3, '2 colher de sopa açúcar mascavado claro (embalado)');

INSERT INTO Ingredientes
VALUES(20, 3, '3 colher de sopa manteiga (derretido, dividido)');

INSERT INTO Ingredientes
VALUES(21, 3, '½ de copo de xarope de milho');

INSERT INTO Ingredientes
VALUES(22, 3, '½ colher de sopa extrato de baunilha');

INSERT INTO Ingredientes
VALUES(23, 3, '1 copo de nozes picadas');

/* Dakos */

INSERT INTO Receitas
VALUES(4, 'Dakos', '../imagens/dakos.png', 
'imagem de Dakos', 'Salgado', 'Europa', 'https://www.youtube.com/embed/fzBkeChLJL8',
'Reúna os ingredientes.
Pulverize a fatia de pão com água para umedecer.
Rale o tomate com um ralador de vegetais em um coador sobre uma tigela para que a maior parte do líquido escorra.
Espalhe o tomate coado e ralado no pão e cubra com queijo. Polvilhe com a pimenta e uma boa quantidade de orégãos e regue com azeite.', 
'O dakos é um prato vegetariano tradicional da ilha de Creta, perfeito para se realizar uma refeição leve. Ele é preparado com ingredientes 
mediterrâneos muito comuns não somente na Grécia, mas em outros países como a Itália e a Turquia. A culinária grega é muito apreciada por diversas 
pessoas porque seus ingredientes possuem muitas verduras e temperos simples como o azeite e ervas aromáticas.', '15 min', '60 porções', 0, 5, 0);

INSERT INTO Ingredientes
VALUES(24, 4, '1 fatia de pão de cevada torrado de 10cm de diâmetro com 1,5cm de altura');

INSERT INTO Ingredientes
VALUES(25, 4, '2 tomates sem pele');

INSERT INTO Ingredientes
VALUES(26, 4, '3 colheres de sopa de queijo feta ');

INSERT INTO Ingredientes
VALUES(27, 4, '3 colheres de chá de azeite extra-virgem');

INSERT INTO Ingredientes
VALUES(28, 4, 'Pimenta preta moída na hora, a gosto');

INSERT INTO Ingredientes
VALUES(29, 4, 'Orégano a gosto');

/* MAKROUT */

INSERT INTO Receitas
VALUES(5, 'Markrout', '../imagens/markrout.png', 'Imagem do markrout', 'Doce', 'Africa', 
'https://www.youtube.com/embed/0UxaYP7SsrM', 'Baseado em semolina, a preparação destes bolos ghiotto 
issimi prevê a utilização de ingredientes muito suculentos e ajuda Makroud a dar um aroma e sabor irresistível. 
Depois de uma dúzia de dates pitted, cortá-los em pedaços, é necessário para preparar uma mistura que inclui em 
sua primeira fase, um banho de água para dissolver metade de um copo de ghee (manteiga clarificada, ou manteiga, 
a água privada, típica da Índia e da Ásia) 1⁄2 xícara de margarina, em seguida, adicione uma pitada de sal e três 
xícaras de farinha de aveia, em seguida, misture adicionando um pouco de água de cada vez para que a massa é bastante
 substancial. Mais uma vez, formar cilindros longos em que você deve inserir a data ou a amêndoa, os pequenos cilindros devem 
 ser cortadas na diagonal para a mistura dando assim uma forma elegante, pronto para ser cozido em uma panela ao fogo baixo, até 
 que tome uma boa cor dourada . Finalmente, o makroud deve ser imerso numa mistura de mel e de água quente antes de ser deixado a arrefecer e pronto para ser saboreado.', 
 'Uma especialidade típica da cidade tunisiana de Kairouan e que se espalhou para várias partes do norte da África, como Argélia e partes da Líbia, um ranking da especialidade como 
 um património mundial.', '30 min', '6 porções', 0, 5, 0);
 
INSERT INTO Ingredientes
VALUES(30, 5, '800g de sêmola média');

INSERT INTO Ingredientes
VALUES(31, 5, '30 g de açúcar');

INSERT INTO Ingredientes
VALUES(32, 5, '1 pitada de sal');

INSERT INTO Ingredientes
VALUES(33, 5, '1 tigela de manteiga derretida');

INSERT INTO Ingredientes
VALUES(34, 5, '250g de tâmaras em pasta');

INSERT INTO Ingredientes
VALUES(35, 5, '1 colher de chá de canela');

INSERT INTO Ingredientes
VALUES(36, 5, '2 colheres de sopa de flor de laranjeira');

INSERT INTO Ingredientes
VALUES(37, 5, 'mel');

INSERT INTO Ingredientes
VALUES(38, 5, 'óleo para fritar');

/* Zaalouk */

INSERT INTO Receitas
VALUES(6, 'Zaalouk', '../imagens/zaalouk.png', 'Imagem do Zaalouk', 'Salgado', 'Africa', 
'https://www.youtube.com/embed/CwAv1s3JKbw', 'Leve ao fogo uma frigideira grande, adicione a manteiga ghee e doure os dentes de alho picados; acrescente as berinjelas cortadas em cubos e quando elas murcharem adicione os tomates picados em cubos  e o alho poró fatiado, misture bem e acrescente a páprica defumada, sal ,o cominho , 
o açafrão e, o segredinho 1/2 limão espremido.', 'O zaalouk é uma comida típica do Marrocos que você vai encontrar em todos os cantos do país. Servida com pão, esta pasta é saboreada em qualquer período 
do dia.', '1h05', '8 porções', 0, 5, 0);

INSERT INTO Ingredientes
VALUES(39, 6, '1 - 2 onças de berinjela, carbonizada (aprox. 2 lbs)');

INSERT INTO Ingredientes
VALUES(40, 6, '½  de azeite extra virgem, mais extra para untar');

INSERT INTO Ingredientes
VALUES(41, 6, '5 dentes de alho');

INSERT INTO Ingredientes
VALUES(42, 6, '2 tomates em cubos enlatados ou  picados');

INSERT INTO Ingredientes
VALUES(43, 6, '1 ½ colher de chá de páprica');

INSERT INTO Ingredientes
VALUES(44, 6, '½ colher de chá de cominho moído');

INSERT INTO Ingredientes
VALUES(45, 6, '½ colher de chá de açafrão moído');

INSERT INTO Ingredientes
VALUES(46, 6, '½ colher de chá de sal, a gosto');

INSERT INTO Ingredientes
VALUES(47, 6, '⅛ colher de chá de pimenta-do-reino moída, a gosto');

INSERT INTO Ingredientes
VALUES(48, 6, '½ de limão espremido');

INSERT INTO Ingredientes
VALUES(49, 6, 'folhas de salsa ou  coentro, para decorar');

/* Coquitos */

INSERT INTO Receitas
VALUES(7, 'Coquitos', '../imagens/coquitos.png', 'Imagem dos coquitos', 'Doce', 'America', 
'https://www.youtube.com/embed/yhXG2zokAhM', 'Em um recipiente, misture bem a manteiga com o açúcar, acrescente os ovos, o creme de confeiteiro, o coco ralado e a essência de baunilha.
Trabalhe até que todos os ingredientes estejam integrados.
Coloque a massa em uma manga com bico crespo e em um prato untado com manteiga faça beijinhos e leve ao forno até dourar.
Quando saírem do forno, pinte-os com geléia de damasco.
', 'Os coquitos, também conhecidos como bolinhos de coco assados, são um doce ideal com o qual costumamos acompanhar a refeição após o jantar. Esse doce é tradicional em várias regiões do mundo, 
especialmente na América Latina e em Angola.', '15 min', '20 porções', 0, 5, 0);

INSERT INTO Ingredientes
VALUES(50, 7, '200 g manteiga');

INSERT INTO Ingredientes
VALUES(51, 7, '250 g açúcar');

INSERT INTO Ingredientes
VALUES(52, 7, '5 ovos');

INSERT INTO Ingredientes
VALUES(53, 7, '250 g creme pasteleiro');

INSERT INTO Ingredientes
VALUES(54, 7, '300 g coco ralado');

INSERT INTO Ingredientes
VALUES(55, 7, 'Extrato de baunilha');

/* Pique Macho */

INSERT INTO Receitas
VALUES(8, 'Pique Macho', '../imagens/pique.png', 'Imagem do Pique Macho', 'Salgado', 'America', 
'https://www.youtube.com/embed/LnBarfQp830', 'Corte o filé em tiras não muito finas, tempere com o limão, cheiro verde, aji-no-moto, sal a gosto e a pimenta calabresa (deixe a carne por pelo menos 1 hora nesta solução).
Corte a salsicha em rodelas e reserve.
Corte os pimentões, a cebola e 3 tomates em tiras. Cozinhe os ovos e frite as batatas.
Em uma panela grande, com fogo alto, aqueça o azeite em quantidade suficiente para fritar a carne (no momento da fritura, escorra a carne da solução de limão, deixando-a o mais seca possível). Deixe a carne fritar até o ponto do seu gosto (o caldo que a carne vai soltar deve ser mantido) e acrescente as salsichas. Quando a carne estiver quase no ponto, acrescente as verduras e frite mais um pouco sem deixá-las murchar.
Em um refratário ou bandeja, coloque as batatas fritas e despeje a carne e as verduras em cima. Corte os ovos cozidos em rodelas e coloque sobre a carne. Faça um quadriculado com a maionese e sirva a seguir. Não necessita de acompanhamento.
', 'O "pique" faz referência à maneira que a carne bovina é servida (toda picadinha) e "a lo macho", à virilidade da pessoa que vai provar o prato, isso porque, no país de origem, a comida vem coberta por uma pimenta fortíssima que só "machos" conseguem comer.
', '60 min', '8 porções', 0, 5, 0);

INSERT INTO Ingredientes
VALUES(56, 8, '1 filé');

INSERT INTO Ingredientes
VALUES(57, 8, '2 pacotes de salsicha');

INSERT INTO Ingredientes
VALUES(58, 8, '4 cebolas');

INSERT INTO Ingredientes
VALUES(59, 8, '1 cebolinha (cheiro verde)');

INSERT INTO Ingredientes
VALUES(67, 8, '2 pimentões vermelhos');

INSERT INTO Ingredientes
VALUES(61, 8, '2 pimentões amarelos');

INSERT INTO Ingredientes
VALUES(62, 8, '2 pimentões verdes');

INSERT INTO Ingredientes
VALUES(63, 8, '5 tomates');

INSERT INTO Ingredientes
VALUES(64, 8, '1 kg de batatas');

INSERT INTO Ingredientes
VALUES(65, 8, '5 limões');

INSERT INTO Ingredientes
VALUES(66, 8, '6 ovos');

/* Basbousa */

INSERT INTO Receitas
VALUES(9, 'Basbousa', '../imagens/basbousa.png', 'Imagem Basbousa', 'Doce', 'Asia', 
'https://www.youtube.com/embed/2Xpqkq9L_Uk', 'Misture a semolina, o fermento, 1/2 xícara de açúcar e as amêndoas picadas até ficar homogêneo. Junte o iogurte, o óleo vegetal e a água de rosas até formar uma massa macia. Cubra a tigela com filme plástico e deixe descansar em temperatura ambiente por 30 minutos.
Pré-aqueça o forno a 350 graus F (175 graus C). Pressione a massa em uma assadeira quadrada de 25 centímetros e alise a superfície. Marque a parte superior da massa para criar 15 quadrados de 1 polegada e, em seguida, cubra cada quadrado com uma metade de amêndoa.
Asse em forno pré-aquecido até o topo estufado e dourar, cerca de 20 minutos. O basbousa é feito quando o topo estiver dourado e o centro firmar. Quando terminar, retire do forno e deixe esfriar na assadeira por 20 minutos.
Enquanto o basbousa está esfriando, coloque água e 2 xícaras de açúcar em uma panela. Leve para ferver e cozinhe por 5 minutos. Junte 1 colher de chá de água de rosas e suco de limão e retire do fogo.
Para servir, corte o basbousa quente em 15 quadrados e coloque em uma travessa grande; despeje a calda de água de rosas por cima, certificando-se de que todos os pedaços estejam úmidos.
', 'Tradicionalmente também se pode adicionar um pouco de coco.', '1h40', '6 porções', 0, 5, 0);

INSERT INTO Ingredientes
VALUES(69, 9, '1 xícara de farinha de semolina');

INSERT INTO Ingredientes
VALUES(70, 9, '1 ½ colher de chá de fermento em pó');

INSERT INTO Ingredientes
VALUES(71, 9, '½ xícara de açúcar branco');

INSERT INTO Ingredientes
VALUES(72, 9, '½ xícara de amêndoas picadas');

INSERT INTO Ingredientes
VALUES(73, 9, '½ xícara de iogurte natural com leite integral');

INSERT INTO Ingredientes
VALUES(74, 9, '½ xícara de óleo vegetal');

INSERT INTO Ingredientes
VALUES(75, 9, '1 colher de sopa de água de rosas');

INSERT INTO Ingredientes
VALUES(76, 9, '15 metades de amêndoas escaldadas para enfeitar');

INSERT INTO Ingredientes
VALUES(77, 9, '1 xícara de água');

INSERT INTO Ingredientes
VALUES(78, 9, '2 xícaras de açúcar branco');

INSERT INTO Ingredientes
VALUES(79, 9, '1 colher de chá de água de rosas');

INSERT INTO Ingredientes
VALUES(80, 9, '1 colher de chá de suco de limão');

/* Pad Thai */

INSERT INTO receitas
VALUES(10, 'Pad Thai', '../imagens/pad.png', 'Imagem de Pad Thai', 'Salgado', 'Asia', 
'https://www.youtube.com/embed/4rQ6JK4bn0A', '	Leve uma frigideira wok para aquecer em fogo alto. Adicione 2 col. de sopa de óleo, em seguida os camarões. Deixe dourar por 1 min de cada lado. Retire os camarões da wok e reserve.
	Na mesma frigideira, adicione mais 2 col. de sopa de óleo e frite o tofu picado em cubos até ficar dourado. Cuidado para não mexer muito o tofu e despedaçar.
	Adicione a cebola e o camarão seco e refogue bem.
	Adicione o noodle. Em seguida, acrescente o açúcar, o suco de tamarindo e o molho de peixe. Vá mexendo e virando o noodle até que absorva todo o líquido.
	Prove o noodle para checar o ponto de cozimento. Se precisar, adicione um pouco de água e continue mexendo até absorver o líquido novamente.
	Puxe o noodle para as laterais da Wok, deixando um espaço vazio no centro.
	Quebre os ovos no espaço vazio e mexa até espalhar bem por todo o centro da wok.
	Cozinhe os ovos por 20 segundos
	Mexa os ovos bruscamente com a espátula.
	Volte o noodle para o centro, mexa bem para que o os ovos se misturem bem com o noodle.
	Adicione o broto de feijão, a cebolinha cortada, os camarões grelhados e o amendoim moído. Desligue o fogo e mexa bem até misturar todos os ingredientes.
', 'Pad Thai é uma comida de rua clássica da Tailândia. Os camarões frescos podem ser substituídos por cubos de frango ou porco.', '20 min', '2 porções', 0, 5, 0);


INSERT INTO Ingredientes
VALUES(81, 10, '120 g macarrão de arroz seco - próx. 5mm de largura');

INSERT INTO Ingredientes
VALUES(82, 10, '6-8 camarões médios - limpos e frescos');

INSERT INTO Ingredientes
VALUES(83, 10, '1/2 xíc.  tofu firme - picado em cubos pequenos');

INSERT INTO Ingredientes
VALUES(84, 10, '2 ovos');

INSERT INTO Ingredientes
VALUES(85, 10, '2 col. de sopa camarão seco - picado');

INSERT INTO Ingredientes
VALUES(86, 10, '2 col. de sopa nabo fermentado doce - (opcional)');

INSERT INTO Ingredientes
VALUES(87, 10, '2 xíc. broto de feijão (moyashi)');

INSERT INTO Ingredientes
VALUES(88, 10, '10 nirás ou 6 cebolinhas - picados em pedaços de 3cm');

INSERT INTO Ingredientes
VALUES(89, 10, '1 chalota - ou 1/2 cebola roxa picada');

INSERT INTO Ingredientes
VALUES(90, 10, '3 col. de sopa amendoim torrado - moído grosseiramente');

INSERT INTO Ingredientes
VALUES(91, 10, '4 col. de sopa molho de peixe - tailandês – Nam Pla');

INSERT INTO Ingredientes
VALUES(92, 10, '4 col. de sopa suco de tamarindo - (ou 1 col. de sopa de polpa de tamarindo – ver instruções)');

INSERT INTO Ingredientes
VALUES(93, 10, '2 col. de sopa açúcar de coco - pode ser substituído por açúcar mascavo');

INSERT INTO Ingredientes
VALUES(94, 10, '4 col. de sopa óleo vegetal');

INSERT INTO Ingredientes
VALUES(95, 10, '1 limão');

INSERT INTO Ingredientes
VALUES(96, 10, 'pimenta vermelha em flocos - a gosto');

```
