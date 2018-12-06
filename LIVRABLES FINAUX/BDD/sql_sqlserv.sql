/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: Recipe
------------------------------------------------------------*/
CREATE TABLE Recipe(
	ID               INT IDENTITY (1,1) NOT NULL ,
	Entitled         VARCHAR (50) NOT NULL ,
	Preparation_time INT   ,
	Cooking_time     INT   ,
	Rest_time        INT   ,
	ID_Recipe_type   INT   ,
	CONSTRAINT prk_constraint_Recipe PRIMARY KEY NONCLUSTERED (ID)
);


/*------------------------------------------------------------
-- Table: Recipe_type
------------------------------------------------------------*/
CREATE TABLE Recipe_type(
	ID       INT IDENTITY (1,1) NOT NULL ,
	Entitled VARCHAR (50) NOT NULL ,
	CONSTRAINT prk_constraint_Recipe_type PRIMARY KEY NONCLUSTERED (ID)
);


/*------------------------------------------------------------
-- Table: Stock
------------------------------------------------------------*/
CREATE TABLE Stock(
	ID              INT IDENTITY (1,1) NOT NULL ,
	Expiration_date DATETIME  ,
	Quantity        INT  NOT NULL ,
	ID_Ingredient   INT   ,
	CONSTRAINT prk_constraint_Stock PRIMARY KEY NONCLUSTERED (ID)
);


/*------------------------------------------------------------
-- Table: Ingredient
------------------------------------------------------------*/
CREATE TABLE Ingredient(
	ID              INT IDENTITY (1,1) NOT NULL ,
	Entitled        VARCHAR (50) NOT NULL ,
	ID_Type_storage INT   ,
	CONSTRAINT prk_constraint_Ingredient PRIMARY KEY NONCLUSTERED (ID)
);


/*------------------------------------------------------------
-- Table: Type_storage
------------------------------------------------------------*/
CREATE TABLE Type_storage(
	ID       INT IDENTITY (1,1) NOT NULL ,
	Entitled VARCHAR (50) NOT NULL ,
	CONSTRAINT prk_constraint_Type_storage PRIMARY KEY NONCLUSTERED (ID)
);


/*------------------------------------------------------------
-- Table: Stage
------------------------------------------------------------*/
CREATE TABLE Stage(
	ID              INT IDENTITY (1,1) NOT NULL ,
	Description     CHAR (100)  NOT NULL ,
	Ordre_number    INT  NOT NULL ,
	Quantity        INT   ,
	ID_Recipe       INT   ,
	ID_Utensil_used INT   ,
	ID_Ingredient   INT   ,
	CONSTRAINT prk_constraint_Stage PRIMARY KEY NONCLUSTERED (ID)
);


/*------------------------------------------------------------
-- Table: Utensil_used
------------------------------------------------------------*/
CREATE TABLE Utensil_used(
	ID       INT IDENTITY (1,1) NOT NULL ,
	Entitled VARCHAR (50) NOT NULL ,
	CONSTRAINT prk_constraint_Utensil_used PRIMARY KEY NONCLUSTERED (ID)
);



ALTER TABLE Recipe ADD CONSTRAINT FK_Recipe_ID_Recipe_type FOREIGN KEY (ID_Recipe_type) REFERENCES Recipe_type(ID);
ALTER TABLE Stock ADD CONSTRAINT FK_Stock_ID_Ingredient FOREIGN KEY (ID_Ingredient) REFERENCES Ingredient(ID);
ALTER TABLE Ingredient ADD CONSTRAINT FK_Ingredient_ID_Type_storage FOREIGN KEY (ID_Type_storage) REFERENCES Type_storage(ID);
ALTER TABLE Stage ADD CONSTRAINT FK_Stage_ID_Recipe FOREIGN KEY (ID_Recipe) REFERENCES Recipe(ID);
ALTER TABLE Stage ADD CONSTRAINT FK_Stage_ID_Utensil_used FOREIGN KEY (ID_Utensil_used) REFERENCES Utensil_used(ID);
ALTER TABLE Stage ADD CONSTRAINT FK_Stage_ID_Ingredient FOREIGN KEY (ID_Ingredient) REFERENCES Ingredient(ID);
