create table PublishingHouses
(
	Id int identity primary key,
	Title nvarchar(25),
	IsDeleted bit DEFAULT 'false'
);

create table Bindings
(
	Id int identity primary key,
	Title nvarchar(10),
	IsDeleted bit DEFAULT 'false'
);

create table Categories
(	
	Id int identity primary key,
	Title nvarchar(25),
	ParentCategory int references Categories(Id),
	IsDeleted bit DEFAULT 'false'
);


create table Books
(
	Id int identity primary key,
	Title nvarchar(80) NOT NULL,
	Description nvarchar(250)  DEFAULT 'No description given.',
	ActualPrice money  NOT NULL,
	DiscountPrice money NOT NULL,
	PublisherHouseId int REFERENCES PublishingHouses(Id),
	StockCount int,
	ArticleCode char(10),
	BindingId int REFERENCES Bindings(Id),
	PageCount int NOT NULL,
	CategoryId int REFERENCES Categories(Id),
	IsDeleted bit DEFAULT 'false'
);


create table Authors
(
	Id int identity primary key,
	Name nvarchar(25) NOT NULL,
	Surname nvarchar(25),
	IsDeleted bit DEFAULT 'false'
);

create table BookAuthors
(
	Id int identity primary key,
	BookId int references Books(Id),
	AuthorId int references Authors(Id)
);

create table Genres
(
	Id int identity primary key,
	Title nvarchar(25),
	IsDeleted bit DEFAULT 'false'
);


create table Languages
(
	Id int identity primary key,
	Title nvarchar(25),
	IsDeleted bit DEFAULT 'false'
);


create table BooksLanguages
(
	Id int identity primary key,
	BookId int references Books(Id),
	AuthorId int references Authors(Id)
);


create table Comments
(
	Id int identity primary key,
	Description nvarchar(250),
	BookId int references Books(Id),
	Rating tinyint CHECK(Rating BETWEEN 0 AND 5),
	Name nvarchar(25) NOT NULL,
	Email nvarchar(25) NOT NULL,
	ImageUrl nvarchar(max),
	IsDeleted bit DEFAULT 'false'
);

-- INSERT PROCEDURES START

CREATE PROCEDURE AddAuthor
@Name nvarchar(25), @Surname nvarchar(25)
AS
BEGIN
	INSERT INTO Authors
	(Name, Surname)
	VALUES
	(@Name,@Surname);
END

CREATE PROCEDURE AddPublisherHouse
@Title nvarchar(25)
AS
BEGIN
	INSERT INTO PublishingHouses
	(Title)
	VALUES
	(@Title);
END

CREATE PROCEDURE AddLanguage
@Title nvarchar(25)
AS
BEGIN
	INSERT INTO Languages
	(Title)
	VALUES
	(@Title);
END

CREATE PROCEDURE AddCategory
@Title nvarchar(25), @ParentCategoryId int
AS
BEGIN
	INSERT INTO Categories
	(Title,ParentCategory)
	VALUES
	(@Title,@ParentCategoryId);
END




ALTER PROCEDURE AddBook 
@Title nvarchar(80), @Description nvarchar(250), @ActualPrice money,
@DiscountPrice money, @PublisherHouseId int, @StockCount int,
@ArticleCode char(10), @BindingId int, @PageCount int, @CategoryId int
AS
BEGIN
	INSERT INTO Books
	(Title,Description,ActualPrice,DiscountPrice,PublisherHouseId,StockCount,Articlecode,BindingId,CategoryId)
	VALUES
	(@Title,@Description,@ActualPrice,@DiscountPrice,@PublisherHouseId,@StockCount,@ArticleCode,@BindingId,@CategoryId);
END

CREATE PROCEDURE AddBinding
@Title nvarchar(10)
AS
BEGIN
	INSERT INTO Bindings (Title) VALUES (@Title)
END

CREATE PROCEDURE AddGenre
@Title nvarchar(25)
AS
BEGIN
	INSERT INTO Genres (Title) VALUES (@Title)
END

-- INSERT PROCEDURES END

-- UPDATE PROCEDURES START

CREATE PROCEDURE UpdateGenre
@Id int, @Title nvarchar(25)
AS
BEGIN
	UPDATE Genres
	SET Title = @Title
	WHERE Id = @Id
END

CREATE PROCEDURE UpdateLanguage
@Id int, @Title nvarchar(25)
AS
BEGIN
	UPDATE Languages
	SET Title = @Title
	WHERE Id = @Id
END

CREATE PROCEDURE UpdateLanguage
@Id int, @Title nvarchar(25)
AS
BEGIN
	UPDATE Languages
	SET Title = @Title
	WHERE Id = @Id
END


CREATE PROCEDURE UpdateBinding
@Id int, @Title nvarchar(25)
AS
BEGIN
	UPDATE Bindings
	SET Title = @Title
	WHERE Id = @Id
END



-- UPDATE PROCEDURES END

