#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Produit
#------------------------------------------------------------

CREATE TABLE Produit(
        id    Int  Auto_increment  NOT NULL ,
        nom   Varchar (150) ,
        type  Varchar (50) ,
        stock Int NOT NULL
	,CONSTRAINT Produit_PK PRIMARY KEY (id)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: Recette
#------------------------------------------------------------

CREATE TABLE Recette(
        recetteNom   Varchar (150) NOT NULL ,
        Produits     Varchar (250) ,
        prix         DECIMAL (15,3)  ,
        instructions Varchar (150) NOT NULL ,
        categorie    Varchar (50) NOT NULL
	,CONSTRAINT Recette_PK PRIMARY KEY (recetteNom)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: UTILISER
#------------------------------------------------------------

CREATE TABLE UTILISER(
        id         Int NOT NULL ,
        recetteNom Varchar (150) NOT NULL ,
        quantite   Int NOT NULL
	,CONSTRAINT UTILISER_PK PRIMARY KEY (id,recetteNom)

	,CONSTRAINT UTILISER_Produit_FK FOREIGN KEY (id) REFERENCES Produit(id)
	,CONSTRAINT UTILISER_Recette0_FK FOREIGN KEY (recetteNom) REFERENCES Recette(recetteNom)
)ENGINE=InnoDB;

