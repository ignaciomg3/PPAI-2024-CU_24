CREATE TABLE "Pais" (
    "id_Pais" INTEGER PRIMARY KEY AUTOINCREMENT,
    "nombre" TEXT NOT NULL UNIQUE
);

CREATE TABLE "Provincia" (
    "id_Provincia" INTEGER PRIMARY KEY AUTOINCREMENT,
    "nombre" TEXT NOT NULL UNIQUE,
    "id_Pais" INTEGER NOT NULL,
    FOREIGN KEY("id_Pais") REFERENCES "Pais"("id_Pais")
);

CREATE TABLE "RegionVitivinicola" (
    "id_Region" INTEGER PRIMARY KEY AUTOINCREMENT,
    "nombre" TEXT NOT NULL UNIQUE,
    "id_Provincia" INTEGER NOT NULL,
    FOREIGN KEY("id_Provincia") REFERENCES "Provincia"("id_Provincia")
);

CREATE TABLE "Bodega" (
    "id_Bodega" INTEGER PRIMARY KEY AUTOINCREMENT,
    "nombre" TEXT NOT NULL UNIQUE,
    "id_Region" INTEGER NOT NULL,
    FOREIGN KEY("id_Region") REFERENCES "RegionVitivinicola"("id_Region")
);

CREATE TABLE "Reseña" (
    "id_Resena" INTEGER PRIMARY KEY AUTOINCREMENT,
    "esPremium" BOOLEAN NOT NULL,
    "fechaResena" DATE NOT NULL,
    "puntaje" INTEGER NOT NULL,
    "id_Vino" INTEGER NOT NULL,
    FOREIGN KEY("id_Vino") REFERENCES "Vino"("id_Vino")
);

CREATE TABLE "Vino" (
    "id_Vino" INTEGER PRIMARY KEY AUTOINCREMENT,
    "nombre" TEXT NOT NULL UNIQUE,
    "precio" DECIMAL(10, 2) NOT NULL,
    "id_Bodega" INTEGER NOT NULL,
    FOREIGN KEY("id_Bodega") REFERENCES "Bodega"("id_Bodega")
);

CREATE TABLE "Varietal" (
    "id_Varietal" INTEGER PRIMARY KEY AUTOINCREMENT,
    "descripcion" TEXT NOT NULL UNIQUE
);

CREATE TABLE "VinoPorVarietal" (
    "id_Vino" INTEGER NOT NULL,
    "id_Varietal" INTEGER NOT NULL,
    PRIMARY KEY("id_Vino", "id_Varietal"),
    FOREIGN KEY("id_Vino") REFERENCES "Vino"("id_Vino"),
    FOREIGN KEY("id_Varietal") REFERENCES "Varietal"("id_Varietal")
);

CREATE TABLE "Usuario" (
    "id_Usuario" INTEGER PRIMARY KEY AUTOINCREMENT,
    "nombre" TEXT NOT NULL UNIQUE,
    "contrasena" TEXT NOT NULL
);

CREATE TABLE "Perfil" (
    "id_Perfil" INTEGER PRIMARY KEY AUTOINCREMENT,
    "descripcion" TEXT NOT NULL,
    "id_Usuario" INTEGER NOT NULL,
    FOREIGN KEY("id_Usuario") REFERENCES "Usuario"("id_Usuario")
);


-- Insertar datos en la tabla Pais
INSERT INTO "Pais" ("nombre") VALUES ('Argentina');
INSERT INTO "Pais" ("nombre") VALUES ('Chile');

-- Insertar datos en la tabla Provincia
INSERT INTO "Provincia" ("nombre", "id_Pais") VALUES ('Mendoza', 1);
INSERT INTO "Provincia" ("nombre", "id_Pais") VALUES ('San Juan', 1);
INSERT INTO "Provincia" ("nombre", "id_Pais") VALUES ('Valparaíso', 2);

-- Insertar datos en la tabla RegionVitivinicola
INSERT INTO "RegionVitivinicola" ("nombre", "id_Provincia") VALUES ('Valle de Uco', 1);
INSERT INTO "RegionVitivinicola" ("nombre", "id_Provincia") VALUES ('Maipú', 1);
INSERT INTO "RegionVitivinicola" ("nombre", "id_Provincia") VALUES ('Aconcagua', 3);

-- Insertar datos en la tabla Bodega
INSERT INTO "Bodega" ("nombre", "id_Region") VALUES ('Bodega Norton', 1);
INSERT INTO "Bodega" ("nombre", "id_Region") VALUES ('Bodega Catena Zapata', 2);
INSERT INTO "Bodega" ("nombre", "id_Region") VALUES ('Bodega Casa Blanca', 3);

-- Insertar datos en la tabla Vino
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Malbec Reserva', 1200.00, 1);
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Cabernet Sauvignon', 1500.00, 2);
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Sauvignon Blanc', 1800.00, 3);

-- Insertar datos en la tabla Varietal
INSERT INTO "Varietal" ("descripcion") VALUES ('Malbec');
INSERT INTO "Varietal" ("descripcion") VALUES ('Cabernet Sauvignon');
INSERT INTO "Varietal" ("descripcion") VALUES ('Sauvignon Blanc');

-- Insertar datos en la tabla VinoPorVarietal
INSERT INTO "VinoPorVarietal" ("id_Vino", "id_Varietal") VALUES (1, 1);
INSERT INTO "VinoPorVarietal" ("id_Vino", "id_Varietal") VALUES (2, 2);
INSERT INTO "VinoPorVarietal" ("id_Vino", "id_Varietal") VALUES (3, 3);

-- Insertar datos en la tabla Usuario
INSERT INTO "Usuario" ("nombre", "contrasena") VALUES ('JuanPerez', 'password123');
INSERT INTO "Usuario" ("nombre", "contrasena") VALUES ('MariaGomez', 'securepass');

-- Insertar datos en la tabla Perfil
INSERT INTO "Perfil" ("descripcion", "id_Usuario") VALUES ('Administrador', 1);
INSERT INTO "Perfil" ("descripcion", "id_Usuario") VALUES ('Sommelier', 2);

-- Insertar datos en la tabla Reseña
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (1, '2024-11-01', 90, 1);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (0, '2024-11-02', 85, 2);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (1, '2024-11-03', 88, 3);

-- Insertar más datos en la tabla Vino
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Chardonnay Reserva', 1300.00, 1);
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Merlot Gran Reserva', 1600.00, 2);
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Pinot Noir', 1900.00, 3);
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Tempranillo Especial', 1400.00, 1);
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Syrah Clásico', 1250.00, 2);
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Torrontés Dulce', 1100.00, 3);
INSERT INTO "Vino" ("nombre", "precio", "id_Bodega") VALUES ('Bonarda Tradicional', 1450.00, 1);

-- Insertar más datos en la tabla Reseña
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (0, '2024-11-04', 89, 4);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (1, '2024-11-05', 92, 5);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (0, '2024-11-06', 87, 6);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (1, '2024-11-07', 91, 7);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (0, '2024-11-08', 84, 1);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (1, '2024-11-09', 86, 2);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (0, '2024-11-10', 90, 3);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (1, '2024-11-11', 88, 4);
INSERT INTO "Reseña" ("esPremium", "fechaResena", "puntaje", "id_Vino") VALUES (0, '2024-11-12', 85, 5);


