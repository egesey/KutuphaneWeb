
DROP DATABASE IF EXISTS LibaryDB;
-- 2. Yeniden oluştur ve kullan
CREATE DATABASE LibaryDB;
USE LibaryDB;


CREATE TABLE Book (
    BId INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Author VARCHAR(100),
    Year INT
);

CREATE TABLE ReadenBooks (
    RId INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100)
);

CREATE TABLE Rating (
    RaId INT PRIMARY KEY AUTO_INCREMENT,
    Ratings FLOAT,
    Name VARCHAR(100)
);

INSERT INTO Book (Name, Author, Year) VALUES ('Suç ve Ceza', 'Dostoyevski', 1866);
INSERT INTO Book (Name, Author, Year) VALUES ('Sefiller', 'Victor Hugo', 1862);
INSERT INTO Book (Name, Author, Year) VALUES ('Kürk Mantolu Madonna', 'Sabahattin Ali', 1943);
INSERT INTO Book (Name, Author, Year) VALUES ('1984', 'George Orwell', 1949);
INSERT INTO Book (Name, Author, Year) VALUES ('Hayvan Çiftliği', 'George Orwell', 1945);
INSERT INTO Book (Name, Author, Year) VALUES ('İnce Mehmed', 'Yaşar Kemal', 1955);
INSERT INTO Book (Name, Author, Year) VALUES ('Beyaz Gemi', 'Cengiz Aytmatov', 1970);
INSERT INTO Book (Name, Author, Year) VALUES ('Yabancı', 'Albert Camus', 1942);
INSERT INTO Book (Name, Author, Year) VALUES ('Tutunamayanlar', 'Oğuz Atay', 1972);
INSERT INTO Book (Name, Author, Year) VALUES ('Çalıkuşu', 'Reşat Nuri Güntekin', 1922);
INSERT INTO Book (Name, Author, Year) VALUES ('Simyacı', 'Paulo Coelho', 1988);
INSERT INTO Book (Name, Author, Year) VALUES ('Savaş ve Barış', 'Lev Tolstoy', 1869);
INSERT INTO Book (Name, Author, Year) VALUES ('Bülbülü Öldürmek', 'Harper Lee', 1960);
INSERT INTO Book (Name, Author, Year) VALUES ('Don Kişot', 'Miguel de Cervantes', 1605);
INSERT INTO Book (Name, Author, Year) VALUES ('Uçurtma Avcısı', 'Khaled Hosseini', 2003);

INSERT INTO ReadenBooks (Name) VALUES ('Yabancı');
INSERT INTO ReadenBooks (Name) VALUES ('Simyacı');
INSERT INTO ReadenBooks (Name) VALUES ('Don Kişot');
INSERT INTO ReadenBooks (Name) VALUES ('Savaş Ve Barış');
INSERT INTO ReadenBooks (Name) VALUES ('Sefiller');
INSERT INTO ReadenBooks (Name) VALUES ('Beyaz Gemi');

INSERT INTO Rating (Name, Ratings) VALUES ('Suç ve Ceza', 8.7);
INSERT INTO Rating (Name, Ratings) VALUES ('Sefiller', 7.2);
INSERT INTO Rating (Name, Ratings) VALUES ('Kürk Mantolu Madonna', 6.5);
INSERT INTO Rating (Name, Ratings) VALUES ('1984', 8.9);
INSERT INTO Rating (Name, Ratings) VALUES ('Hayvan Çiftliği', 7.8);
INSERT INTO Rating (Name, Ratings) VALUES ('İnce Mehmed', 6.1);
INSERT INTO Rating (Name, Ratings) VALUES ('Beyaz Gemi', 5.3);
INSERT INTO Rating (Name, Ratings) VALUES ('Yabancı', 7.1);
INSERT INTO Rating (Name, Ratings) VALUES ('Tutunamayanlar', 8.2);
INSERT INTO Rating (Name, Ratings) VALUES ('Çalıkuşu', 6.9);
INSERT INTO Rating (Name, Ratings) VALUES ('Simyacı', 5.7);
INSERT INTO Rating (Name, Ratings) VALUES ('Savaş ve Barış', 9.0);
INSERT INTO Rating (Name, Ratings) VALUES ('Bülbülü Öldürmek', 8.4);
INSERT INTO Rating (Name, Ratings) VALUES ('Don Kişot', 6.8);
INSERT INTO Rating (Name, Ratings) VALUES ('Uçurtma Avcısı', 7.6);




SELECT * FROM Book;
SELECT * FROM ReadenBooks;
SELECT * FROM Rating;