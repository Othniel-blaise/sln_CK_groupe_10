

-- Création de la table CKGROUPE10
CREATE TABLE CKGROUPE10 (
    CKgroupe10_Id INT PRIMARY KEY IDENTITY(1,1), -- Remplacer AUTO_INCREMENT par IDENTITY
    CKgroupe10_NomPrenoms VARCHAR(50),
    CKgroupe10_Date DATETIME,
    CKgroupe10_Taille DECIMAL(10, 2), -- Précision pour DECIMAL
    categorield VARCHAR(10)
);
GO

-- Création de la table CKCATEGORIE10
CREATE TABLE CKCATEGORIE10 (
    categorield VARCHAR(10) PRIMARY KEY,
    catDesignation VARCHAR(50)
);
GO

-- Procédures CRUD pour CKCATEGORIE10

-- Sélectionner toutes les catégories
CREATE PROCEDURE SPX_CKCATEGORIE10_SelectAll
AS
BEGIN
    SELECT * FROM CKCATEGORIE10;
END;
GO

-- Obtenir une catégorie par categorield
CREATE PROCEDURE SPX_CKCATEGORIE10_Get
    @categorield VARCHAR(10)
AS
BEGIN
    SELECT * FROM CKCATEGORIE10
    WHERE categorield = @categorield;
END;
GO

-- Insérer une nouvelle catégorie
CREATE PROCEDURE SPX_CKCATEGORIE10_Insert
    @categorield VARCHAR(10),
    @catDesignation VARCHAR(50)
AS
BEGIN
    INSERT INTO CKCATEGORIE10 (categorield, catDesignation)
    VALUES (@categorield, @catDesignation);
END;
GO

-- Mettre à jour une catégorie
CREATE PROCEDURE SPX_CKCATEGORIE10_Update
    @categorield VARCHAR(10),
    @catDesignation VARCHAR(50)
AS
BEGIN
    UPDATE CKCATEGORIE10
    SET catDesignation = @catDesignation
    WHERE categorield = @categorield;
END;
GO

-- Supprimer une catégorie
CREATE PROCEDURE SPX_CKCATEGORIE10_Delete
    @categorield VARCHAR(10)
AS
BEGIN
    DELETE FROM CKCATEGORIE10
    WHERE categorield = @categorield;
END;
GO

-- Procédures CRUD pour CKGROUPE10

-- Sélectionner tous les membres
CREATE PROCEDURE SPX_CKGROUPE10_SelectAll
AS
BEGIN
    SELECT * FROM CKGROUPE10;
END;
GO

-- Obtenir un membre par CKgroupe10_Id
CREATE PROCEDURE SPX_CKGROUPE10_Get
    @CKgroupe10_Id INT
AS
BEGIN
    SELECT * FROM CKGROUPE10
    WHERE CKgroupe10_Id = @CKgroupe10_Id;
END;
GO

-- Insérer un nouveau membre
CREATE PROCEDURE SPX_CKGROUPE10_Insert
    @CKgroupe10_NomPrenoms VARCHAR(50),
    @CKgroupe10_Date DATETIME,
    @CKgroupe10_Taille DECIMAL(10, 2),
    @categorield VARCHAR(10)
AS
BEGIN
    INSERT INTO CKGROUPE10 (CKgroupe10_NomPrenoms, CKgroupe10_Date, CKgroupe10_Taille, categorield)
    VALUES (@CKgroupe10_NomPrenoms, @CKgroupe10_Date, @CKgroupe10_Taille, @categorield);
END;
GO

-- Mettre à jour un membre
CREATE PROCEDURE SPX_CKGROUPE10_Update
    @CKgroupe10_Id INT,
    @CKgroupe10_NomPrenoms VARCHAR(50),
    @CKgroupe10_Date DATETIME,
    @CKgroupe10_Taille DECIMAL(10, 2),
    @categorield VARCHAR(10)
AS
BEGIN
    UPDATE CKGROUPE10
    SET CKgroupe10_NomPrenoms = @CKgroupe10_NomPrenoms,
        CKgroupe10_Date = @CKgroupe10_Date,
        CKgroupe10_Taille = @CKgroupe10_Taille,
        categorield = @categorield
    WHERE CKgroupe10_Id = @CKgroupe10_Id;
END;
GO

-- Supprimer un membre
CREATE PROCEDURE SPX_CKGROUPE10_Delete
    @CKgroupe10_Id INT
AS
BEGIN
    DELETE FROM CKGROUPE10
    WHERE CKgroupe10_Id = @CKgroupe10_Id;
END;
GO