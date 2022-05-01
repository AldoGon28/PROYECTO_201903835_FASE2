CREATE TABLE usuario (
    id        INTEGER IDENTITY(1,1) PRIMARY KEY,
    nombre       VARCHAR(50),
    username   VARCHAR(50)  UNIQUE,
    password   VARCHAR(50),
    tipo VARCHAR(50),
    foto    VARCHAR(100)
);

CREATE TABLE playlist (
    id       INTEGER IDENTITY(1,1) PRIMARY KEY,
    nombre      VARCHAR(50),
    fechacreacion      DATE,
    foto      VARCHAR(100),
    usuario_id  INTEGER NOT NULL
);

CREATE TABLE detalle_playlist (
    id        INTEGER IDENTITY(1,1) PRIMARY KEY,
    cancion_id  INTEGER NOT NULL,
    playlist_id  INTEGER NOT NULL
);

CREATE TABLE cancion (
    id    INTEGER IDENTITY(1,1) PRIMARY KEY,
    nombre   VARCHAR(50),
    genero   VARCHAR(50),
    ubicacion   VARCHAR(100),
    artista_id INTEGER
);

CREATE TABLE artista (
    id       INTEGER IDENTITY(1,1) PRIMARY KEY,
    nombre      VARCHAR(50) UNIQUE,
    nacionalidad  INTEGER NOT NULL
);


ALTER TABLE playlist
    ADD CONSTRAINT playlist_usuario_fk FOREIGN KEY ( usuario_id )
        REFERENCES usuario ( id )
            ON DELETE CASCADE;

ALTER TABLE detalle_playlist
    ADD CONSTRAINT detalle_cancion_fk FOREIGN KEY ( cancion_id )
        REFERENCES cancion ( id )
            ON DELETE CASCADE;

ALTER TABLE detalle_playlist
    ADD CONSTRAINT detalle_playlist_fk FOREIGN KEY ( playlist_id )
        REFERENCES playlist ( id )
            ON DELETE CASCADE;

ALTER TABLE cancion
    ADD CONSTRAINT cancion_artista_fk FOREIGN KEY ( artista_id )
        REFERENCES artista ( id )
            ON DELETE CASCADE;

INSERT INTO usuario(nombre,username,password,tipo,foto) VALUES ('Aldo A','Aldo','abc123','Administrador','C:\Users\Usuario\Desktop\PROYECTO_201903835\Imágenes\Usuarios SQL\Aldo.png')
INSERT INTO usuario(nombre,username,password,tipo,foto) VALUES ('Javier J','Javier','abc123','Cliente','C:\Users\Usuario\Desktop\PROYECTO_201903835\Imágenes\Usuarios SQL\Javier.png')
INSERT INTO usuario(nombre,username,password,tipo,foto) VALUES ('Sebastian C','Sebastian','abc123','Administrador','C:\Users\Usuario\Desktop\PROYECTO_201903835\Imágenes\Usuarios SQL\Sebastian.png')
INSERT INTO usuario(nombre,username,password,tipo,foto) VALUES ('AdminA','Admin','abc123','Administrador','C:\Users\Usuario\Desktop\PROYECTO_201903835\Imágenes\Usuarios SQL\admin1.jpeg)

