﻿use PollDB

INSERT INTO Judet (numeJudet)
VALUES
    ('Alba'),
    ('Arad'),
    ('Arges'),
    ('Bacau'),
    ('Bihor'),
    ('Bistrita-Nasaud'),
    ('Botosani'),
    ('Braila'),
    ('Brasov'),
    ('Bucuresti'),
    ('Buzau'),
    ('Calarasi'),
    ('Caras-Severin'),
    ('Cluj'),
    ('Constanta'),
    ('Covasna'),
    ('Dambovita'),
    ('Dolj'),
    ('Galati'),
    ('Giurgiu')

INSERT INTO Municipiu (numeMunicipiu, judetID)
VALUES
    ('Alba Iulia', 1),
    ('Arad', 2),
    ('Pitesti', 3),
    ('Bacau', 4),
    ('Oradea', 5),
    ('Bistrita', 6),
    ('Botosani', 7),
    ('Braila', 8),
    ('Brasov', 9),
    ('Bucuresti', 10),
    ('Buzau', 11),
    ('Calarasi', 12),
    ('Resita', 13),
    ('Cluj-Napoca', 14),
    ('Constanta', 15),
    ('Sfantu Gheorghe', 16),
    ('Targoviste', 17),
    ('Craiova', 18),
    ('Galati', 19),
    ('Giurgiu', 20)

INSERT INTO Oras (numeOras, municipiuID)
VALUES
    ('Zlatna', 1),
    ('Arad', 2),
    ('Curtea de Arges', 3),
    ('Bacau', 4),
    ('Beius', 5),
    ('Bistrita', 6),
    ('Botosani', 7),
    ('Braila', 8),
    ('Brasov', 9),
    ('Bucuresti', 10),
    ('Buzau', 11),
    ('Calarasi', 12),
    ('Caransebes', 13),
    ('Cluj-Napoca', 14),
    ('Constanta', 15),
    ('Sfantu Gheorghe', 16),
    ('Targoviste', 17),
    ('Craiova', 18),
    ('Galati', 19),
    ('Giurgiu', 20),
    ('Abrud', 1),
    ('Ineu', 2),
    ('Topoloveni', 3),
    ('Moinesti', 4),
    ('Marghita', 5),
    ('Nasaud', 6),
    ('Saveni', 7),
    ('Faurei', 8),
    ('Codlea', 9),
    ('Pantelimon', 10),
    ('Ramnicu Sarat', 11),
    ('Lehliu Gara', 12),
    ('Moldova Noua', 13),
    ('Dej', 14),
    ('Eforie Nord', 15),
    ('Covasna', 16),
	('Timisoara', 17),
	('Brasov', 18),
	('Constanta', 19),
	('Iasi', 20)

INSERT INTO Persoana (Nume, Prenume, sex, studii, email, DataNasterii, judetID, municipiuID, orasID, Casatorit, Divortat, Participant)
VALUES
	('Popescu', 'Ion', 'M', 'Facultate', 'ion.popescu@gmail.com', '1980-01-01', 1, 1, 1, 0, 0, 1),
	('Ionescu', 'Maria', 'F', 'Master', 'maria.ionescu@yahoo.com', '1990-02-15', 2, 2, 2, 1, 0, 1),
	('Popa', 'George', 'M', 'Doctorat', 'george.popa@gmail.com', '1975-06-20', 3, 3, 3, 1, 0, 1),
	('Andrei', 'Alexandra', 'F', 'Facultate', 'alexandra.andrei@gmail.com', '2000-09-05', 4, 4, 4, 0, 0, 1),
	('Gheorghe', 'Marius', 'M', 'Master', 'marius.gheorghe@yahoo.com', '1985-12-31', 5, 5, 5, 1, 1, 1)

INSERT INTO Tematica (Tematica)
VALUES
	('Arta'),
	('Politica'),
	('Sport'),
	('Tehnologie'),
	('Moda'),
	('Calatorii'),
	('Gastronomie'),
	('Educatie'),
	('Muzica'), 
	('Divertisment'), 
	('Sanatate'), 
	('Mediu'), 
	('Afaceri'), 
	('Stiinta'), 
	('Religie');

INSERT INTO Intrebare (Intrebare, tematicaID)
VALUES
	('Care este artistul tău preferat?', 1),
	('Ce opinie ai despre politica actuală?', 2),
	('Care este sportul tău preferat?', 3),
	('Ce gadget tehnologic nu ai putea trăi fără?', 4),
	('Ce stil vestimentar preferi?', 5),
	('Care este cea mai frumoasă destinație de călătorie pe care ai vizitat-o?', 6),
	('Ce fel de mâncare preferi?', 7),
	('Ce subiect ți-ar plăcea să înveți mai mult despre?', 8),
	('Care este melodia ta preferată?', 9),	
	('Care este filmul sau serialul tău preferat?', 10),
	('Ce ai făcut recent pentru a-ți menține sănătatea?', 11),
	('Ce crezi despre încălzirea globală și schimbările climatice?', 12),
	('Ai vreo afacere sau idee de afacere pe care ți-ar plăcea să o începi?', 13),
	('Care este cel mai interesant lucru pe care l-ai învățat recent?', 14),
	('Ce înseamnă religia pentru tine?', 15);

INSERT INTO Raspuns (Raspuns, intrebareID, presoanaID)
VALUES
	('Michael Jackson', 1, 1),
	('Ed Sheeran', 1, 2),
	('Adele', 1, 3),
	('Queen', 1, 4),
	('Coldplay', 1, 5),
	('Nu sunt interesat de politică', 2, 1),
	('Sunt dezamăgit de politica actuală', 2, 2),
	('Cred că sunt necesare reforme politice majore', 2, 3),
	('Consider că politica ar trebui să se concentreze mai mult pe nevoile cetățenilor', 2, 4),
	('Sunt mulțumit de situația politică actuală', 2, 5),
	('Fotbal', 3, 1),
	('Tenis', 3, 2),
	('Volei', 3, 3),
	('Ciclism', 3, 4),
	('Înot', 3, 5),
	('Telefonul mobil', 4, 1),
	('Laptopul', 4, 2),
	('Tableta', 4, 3),
	('Smartwatch-ul', 4, 4),
	('Drona', 4, 5),
	('Casual', 5, 1),
	('Elegant', 5, 2),
	('Sport', 5, 3),
	('Hippy', 5, 4),
	('Urban', 5, 5),
	('Toscana, Italia', 6, 1),
	('New York, SUA', 6, 2),
	('Tokyo, Japonia', 6, 3),
	('Bali, Indonezia', 6, 4),
	('Maldivele', 6, 5),
	('Pizza', 7, 1),
	('Sushi', 7, 2),
	('Burger', 7, 3),
	('Paste', 7, 4),
	('Friptură', 7, 5),
	('Istorie', 8, 1),
	('Psihologie', 8, 2),
	('Arta culinară', 8, 3),
	('Programare', 8, 4),
	('Design grafic', 8, 5),
	('Bohemian Rhapsody - Queen', 9, 1),
	('Stairway to Heaven - Led Zeppelin', 9, 2),
	('Smells Like Teen Spirit - Nirvana', 9, 3),
	('Nothing Else Matters - Metallica', 9, 4),
	('November Rain - Guns N Roses', 9, 5),
	('The Godfather', 10, 1),
	('Breaking Bad', 10, 2),
	('Game of Thrones', 10, 3),
	('The Shawshank Redemption', 10, 4),
	('The Big Bang Theory', 10, 5),
	('M-am înscris la un club de fitness', 11, 1),
	('Mănânc mai sănătos', 11, 2),
	('Am început să alerg în parc', 11, 3),
	('Fac yoga', 11, 4),
	('Am început să merg la sală de fitness', 11, 5),
	('Este un fenomen real și preocupant', 12, 1),
	('Este o invenție a mass-mediei', 12, 2),
	('Nu cred ca o atat de importanta', 12, 3),
	('Nu am o opinie', 12, 4),
	('Este extrem de important sa atragem atenția aspura acestei probleme', 12, 5)

INSERT INTO Limba (Limba)
VALUES
	('Engleza'), 
	('Franceza'), 
	('Germana'), 
	('Spaniola'), 
	('Italiana'), 
	('Româna'), 
	('Rusa')

INSERT INTO Sondaj(raspunsID, limbaID)
VALUES 
(1, 7), (2, 2), (3, 5), (4, 1), (5, 7), (6, 3), (7, 5), (8, 6), (9, 7), (10, 3), 
(11, 1), (12, 6), (13, 3), (14, 4), (15, 1), (16, 6), (17, 4), (18, 6), (19, 4), (20, 6), 
(21, 5), (22, 4), (23, 6), (24, 1), (25, 4), (26, 2), (27, 6), (28, 2), (29, 6), (30, 1), 
(31, 5), (32, 4), (33, 1), (34, 7), (35, 2), (36, 3), (37, 1), (38, 7), (39, 2), (40, 5), 
(41, 1), (42, 6), (43, 7), (44, 1), (45, 5), (46, 6), (47, 7), (48, 2), (49, 5), (50, 1), 
(51, 3), (52, 6), (53, 2), (54, 3), (55, 7), (56, 2), (57, 3), (58, 7), (59, 6), (60, 4);

