#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Recipe
#------------------------------------------------------------

CREATE TABLE Recipe(
        ID               int (11) Auto_increment  NOT NULL ,
        Entitled         Varchar (50) NOT NULL ,
        Preparation_time Int ,
        Cooking_time     Int ,
        Rest_time        Int ,
        ID_Recipe_type   Int ,
        PRIMARY KEY (ID )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Recipe_type
#------------------------------------------------------------

CREATE TABLE Recipe_type(
        ID       int (11) Auto_increment  NOT NULL ,
        Entitled Varchar (50) NOT NULL ,
        PRIMARY KEY (ID )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Stock
#------------------------------------------------------------

CREATE TABLE Stock(
        ID              int (11) Auto_increment  NOT NULL ,
        Expiration_date Date ,
        Quantity        Int NOT NULL ,
        ID_Ingredient   Int ,
        PRIMARY KEY (ID )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Ingredient
#------------------------------------------------------------

CREATE TABLE Ingredient(
        ID              int (11) Auto_increment  NOT NULL ,
        Entitled        Varchar (50) NOT NULL ,
        ID_Type_storage Int ,
        PRIMARY KEY (ID )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Type_storage
#------------------------------------------------------------

CREATE TABLE Type_storage(
        ID       int (11) Auto_increment  NOT NULL ,
        Entitled Varchar (50) NOT NULL ,
        PRIMARY KEY (ID )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Stage
#------------------------------------------------------------

CREATE TABLE Stage(
        ID              int (11) Auto_increment  NOT NULL ,
        Description     Char (100) NOT NULL ,
        Ordre_number    Int NOT NULL ,
        Quantity        Int ,
        ID_Recipe       Int ,
        ID_Utensil_used Int ,
        ID_Ingredient   Int ,
        PRIMARY KEY (ID )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Utensil_used
#------------------------------------------------------------

CREATE TABLE Utensil_used(
        ID       int (11) Auto_increment  NOT NULL ,
        Entitled Varchar (50) NOT NULL ,
        PRIMARY KEY (ID )
)ENGINE=InnoDB;

ALTER TABLE Recipe ADD CONSTRAINT FK_Recipe_ID_Recipe_type FOREIGN KEY (ID_Recipe_type) REFERENCES Recipe_type(ID);
ALTER TABLE Stock ADD CONSTRAINT FK_Stock_ID_Ingredient FOREIGN KEY (ID_Ingredient) REFERENCES Ingredient(ID);
ALTER TABLE Ingredient ADD CONSTRAINT FK_Ingredient_ID_Type_storage FOREIGN KEY (ID_Type_storage) REFERENCES Type_storage(ID);
ALTER TABLE Stage ADD CONSTRAINT FK_Stage_ID_Recipe FOREIGN KEY (ID_Recipe) REFERENCES Recipe(ID);
ALTER TABLE Stage ADD CONSTRAINT FK_Stage_ID_Utensil_used FOREIGN KEY (ID_Utensil_used) REFERENCES Utensil_used(ID);
ALTER TABLE Stage ADD CONSTRAINT FK_Stage_ID_Ingredient FOREIGN KEY (ID_Ingredient) REFERENCES Ingredient(ID);
