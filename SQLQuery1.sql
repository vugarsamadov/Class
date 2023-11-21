CREATE TABLE Movies
(
	Id int identity PRIMARY KEY,
  	Name nvarchar(50),
  	Rate int,
  	CHECK(Rate BETWEEN 0 AND 10)
);

CREATE TABLE Directors
(
	Id int identity PRIMARY KEY,
  	Name nvarchar(50),
  	Surname nvarchar(50),
	Age int,
	CHECK(Age >= 18)
);

CREATE TABLE Genres
(
	Id int identity primary key,
	Name nvarchar(50)
);

CREATE TABLE Actors
(
	Id int identity primary key,
	Name nvarchar(50),
	Surname nvarchar(50),
	Age int,
	CHECK(Age >= 18)
);

CREATE TABLE MoviesDirectors
(
	Id int identity primary key,
	MovieId int references Movies(Id),
	DirectorId int references Directors(Id)
);

CREATE TABLE MovieGenres
(
	Id int identity primary key,
	MovieId int references Movies(Id),
	GenreId int references Genres(Id)
);


CREATE TABLE MoviesActors
(
	Id int identity primary key,
	MovieId int references Movies(Id),
	ActorId int references Actors(Id)
);



INSERT INTO Directors (Name, Surname, Age)
VALUES
('Steven', 'Spielberg', 75),
('Christopher', 'Nolan', 51),
('Quentin', 'Tarantino', 58),
('James', 'Cameron', 67),
('Martin', 'Scorsese', 79);


INSERT INTO Movies (Name, Rate)
VALUES
('Jurassic Dark', 8.1), -- 7
('Inception', 8.8),
('Pulp Fiction', 8.9),
('Avatar', 7.8),
('The Departed', 8.5),
('The Dark Knight', 9.0),
('Titanic', 7.8);


INSERT INTO Genres (Name)
VALUES
('Action'),
('Adventure'),
('Sci-Fi'),
('Crime'),
('Drama');


INSERT INTO Actors (Name, Surname, Age)
VALUES
('Sam', 'Neill', 74),
('Leonardo', 'DiCaprio', 47),
('Ellen', 'Page', 34),
('John', 'Travolta', 67),
('Uma', 'Thurman', 51),
('Zoe', 'Saldana', 43),
('Matt', 'Damon', 51),
('Christian', 'Bale', 47),
('Kate', 'Winslet', 46),
('Jack', 'Nicholson', 84);


INSERT INTO MoviesDirectors (MovieId, DirectorId)
VALUES
(7,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,2),
(7,4);
 

INSERT INTO MovieGenres (MovieId, GenreId)
VALUES
(1,1),
(1,2),
(1,3),
(2,1),
(2,3),
(3,1),
(3,4),
(3,5),
(4,1),
(4,2),
(4,3),
(5,4),
(5,5),
(6,1),
(6,4),
(7,2),
(7,5);

INSERT INTO MoviesActors ( MovieId, ActorId)
VALUES
(1,1),
(2,2),
(2,3),
(3,4),
(3,5),
(4,6),
(5,2),
(5,7),
(5,10),
(6,2),
(6,8),
(7,2),
(7,9);


-- 1

SELECT * FROM Movies WHERE Rate > 8;

-- 2

SELECT M.Name, M.Rate FROM Movies M 

-- 3

SELECT * FROM Actors WHERE Age > 40
UNION ALL
SELECT * FROM Directors WHERE Age > 40

-- 4

SELECT Directors.Name,Directors.Surname,COUNT(*) FROM Directors 
left join MoviesDirectors ON Directors.Id = MoviesDirectors.DirectorId
GROUP BY Directors.Name,Directors.Surname

-- 5 

SELECT M.Name, M.Rate, 
concat(D.Name,' ',D.Surname) as DirectorFullName, 
concat(A.Name,' ',A.Surname) as ActorFullName
FROM Movies M left join MoviesDirectors MD ON M.Id = MD.MovieId 
left join Directors D on D.Id = MD.DirectorId
left join MoviesActors MA on MA.MovieId = M.Id
left join Actors A ON A.Id = MA.ActorId

-- 6


