DROP DATABASE blockbuster;

CREATE DATABASE IF NOT EXISTS blockbuster;

USE blockbuster;

-- Creación de usuario y otorgamiento de permisos
-- Creación de usuario y otorgamiento de permisos
-- Creación de usuario y otorgamiento de permisos

CREATE USER IF NOT EXISTS 'blockbusterappuser'@'localhost' IDENTIFIED BY 'blockbusterapppass';
GRANT INSERT, DELETE, UPDATE, EXECUTE,SELECT ON blockbuster.* TO 'blockbusterappuser'@'localhost';

-- Tablas
-- Tablas
-- Tablas

CREATE TABLE IF NOT EXISTS client(

	id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	name VARCHAR(50) NOT NULL,
	lastname VARCHAR(50) NOT NULL, 
	email VARCHAR(45) UNIQUE,
	phone_number VARCHAR(20) ,
	index lastname_idx (lastname)

);

CREATE TABLE IF NOT EXISTS category(

	id INT AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(45) UNIQUE,
	description VARCHAR(45),
	index category_name_idx (name)

);

CREATE TABLE IF NOT EXISTS movie(

	id INT AUTO_INCREMENT PRIMARY KEY,
	title VARCHAR(100) NOT NULL UNIQUE,
	release_date DATETIME,
	category_id INT,
	units_available int,
    index fk_movie_category_idx (category_id),
	index movie_title_idx (title),
	foreign key (category_id) REFERENCES category(id)
);

CREATE TABLE IF NOT EXISTS review(

	id INT AUTO_INCREMENT PRIMARY KEY,
	rating DECIMAL(2),
	review_text VARCHAR(100),
	created_on DATETIME,
	client_id INT,
	movie_id INT,
	index fk_review_client_idx(client_id),
	index f_review_movie_idx(movie_id),
	FOREIGN KEY(client_id) REFERENCES client(id),
	FOREIGN KEY(movie_id) REFERENCES movie(id)
    
);

CREATE TABLE IF NOT EXISTS rentals(

	id INT AUTO_INCREMENT PRIMARY KEY,
	rental_date DATETIME,
	client_id INT,
	movie_id INT,
	index fk_rentals_client_idx ( client_id),
	index fk_rentals_movie_idx (movie_id),
	FOREIGN KEY (movie_id) REFERENCES movie(id),
	FOREIGN KEY (client_id) REFERENCES client(id)

);

CREATE TABLE IF NOT EXISTS blockbuster_log (

	id INT AUTO_INCREMENT PRIMARY KEY,
	table_name VARCHAR(45) NOT NULL,
	created_on DATETIME NOT NULL,
	entry_text VARCHAR(45) NOT NULL

);

-- Pruebas
-- Pruebas
-- Pruebas

INSERT INTO client (name,lastname,email,phone_number) VALUES('MARTÍN','FLORES','cflores@itcr.ac.cr','12345678');
INSERT INTO category (name,description) VALUES('ACTION','MOVIES INCLUDING WARLIKE CONFLICTS');
INSERT INTO movie (title,release_date,category_id,units_available) VALUES('ROBOCOP','2014-12-11',1,5);
INSERT INTO rentals (rental_date,client_id,movie_id) VALUES('2021-01-02',1,1);

-- Triggers
-- Triggers
-- Triggers

DELIMITER //

	CREATE TRIGGER rentals_AFTER_UPDATE AFTER UPDATE ON rentals
	FOR EACH ROW BEGIN INSERT INTO blockbuster_log (table_name,created_on,entry_text) VALUES('rentals',current_date(),concat('Rental ',NEW.id,' updated')); 
	END;//

DELIMITER ;

DELIMITER //

	CREATE TRIGGER reviews_AFTER_UPDATE AFTER UPDATE ON review
	FOR EACH ROW BEGIN INSERT INTO blockbuster_log (table_name,created_on,entry_text) VALUES('Review',current_date(),concat('Review ',NEW.id,' updated')); 
	END;//
  
DELIMITER ;

DELIMITER //

	CREATE TRIGGER rentals_AFTER_INSERT AFTER INSERT ON rentals
	FOR EACH ROW BEGIN INSERT INTO blockbuster_log (table_name,created_on,entry_text) VALUES('rentals',current_date(),concat('New rental for client ',NEW.client_id,' and movie ',NEW.movie_id)); 
	END;//

DELIMITER ;

DELIMITER //

	CREATE TRIGGER review_AFTER_INSERT AFTER INSERT ON review
	FOR EACH ROW BEGIN INSERT INTO blockbuster_log (table_name,created_on,entry_text) VALUE('Review',current_date(),concat('New review by client ',NEW.client_id,' for movie ',NEW.movie_id)); 
	END;//

DELIMITER ;

DELIMITER //

	CREATE TRIGGER rentals_AFTER_DELETE AFTER DELETE ON rentals
	FOR EACH ROW BEGIN INSERT INTO blockbuster_log (table_name,created_on,entry_text) VALUES('rentals',current_date(),concat('Deleted rental for client ',OLD.client_id,' and movie ',OLD.movie_id)); 
	END;//

DELIMITER ;

DELIMITER //

	CREATE TRIGGER review_AFTER_DELETE AFTER DELETE ON review
	FOR EACH ROW BEGIN INSERT INTO blockbuster_log (table_name,created_on,entry_text) VALUE('Review',current_date(),concat('Deleted review of client ',OLD.client_id,' for movie ',OLD.movie_id)); 
	END;//

DELIMITER ;

-- Procedimientos
-- Procedimientos
-- Procedimientos

DROP PROCEDURE IF EXISTS create_movie;

DELIMITER //

CREATE PROCEDURE create_movie(

    IN p_title VARCHAR(100),
    IN p_release_date DATETIME,
    IN p_category_id INT,
    IN p_units_available INT,
    OUT p_new_movie_id INT
    
)
BEGIN

	IF EXISTS (SELECT id FROM category WHERE id = p_category_id)
		THEN INSERT INTO movie (title, release_date, category_id, units_available) VALUES(p_title,p_release_date, p_category_id,p_units_available);
        SELECT last_insert_id() INTO p_new_movie_id;
	ELSE
		SET p_new_movie_id =-1;
	END IF;
    
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS update_movie;

DELIMITER //
CREATE PROCEDURE update_movie(

    IN p_id INT,
    IN p_title VARCHAR(100),
    IN p_release_date DATETIME,
    IN p_category_id INT,
    IN p_units_available INT,
    OUT p_new_movie_id INT
    
)
BEGIN

	IF EXISTS (SELECT id FROM movie WHERE id = p_id)
		THEN UPDATE movie SET title = p_title, release_date = p_release_date, category_id = p_category_id, units_available = p_units_available WHERE id = p_id;
        SELECT 1 INTO p_new_movie_id;
	ELSE
		SET p_new_movie_id =-1;
	END IF;
    
END//

DELIMITER ;


DROP PROCEDURE IF EXISTS delete_movie;

DELIMITER //

CREATE PROCEDURE delete_movie(

    IN p_id INT,
    OUT procedure_completed INT
    
)
BEGIN

	IF NOT EXISTS(SELECT movie_id FROM rentals WHERE movie_id = p_id) THEN
		IF EXISTS (SELECT id FROM movie WHERE id = p_id)
			THEN DELETE FROM movie WHERE id = p_id;
				SELECT 1 INTO procedure_completed;
		ELSE
			SET procedure_completed =-1;
		END IF;
	ELSE
		SET procedure_completed =-1;
	END IF;
    
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS create_category;

DELIMITER //

CREATE PROCEDURE create_category(

    IN p_name VARCHAR(45),
    IN p_description VARCHAR(45),
    OUT p_new_category_id INT
    
)
BEGIN

	IF NOT EXISTS (SELECT NAME FROM category WHERE NAME = p_name)
		THEN INSERT INTO category (name,description) VALUES (p_name,p_description);
        SELECT last_insert_id() INTO p_new_category_id;
	ELSE
		SET p_new_category_id =-1;
	END IF;
    
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS update_category;

DELIMITER //

CREATE PROCEDURE update_category(

    IN p_id INT,
    IN p_name VARCHAR(45),
    IN p_description VARCHAR(45),
    OUT process_status INT
    
)
BEGIN

	IF EXISTS (SELECT id FROM category WHERE id = p_id) 
		THEN UPDATE category SET name = p_name, description = p_description WHERE id = p_id;
        SELECT 1 INTO process_status;
	ELSE 
		SET process_status =-1;
	END IF;
    
END//

DELIMITER;

DROP PROCEDURE IF EXISTS delete_category;

DELIMITER //

CREATE PROCEDURE delete_category(

    IN p_id INT,
    OUT procedure_completed INT
    
)
BEGIN

	IF NOT EXISTS(SELECT categcategoryory_id FROM movie WHERE category_id = p_id)
		THEN DELETE FROM category WHERE id = p_id;
		SELECT 1 INTO procedure_completed;
	ELSE
		SET procedure_completed =-1;
	END IF;
    
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS create_client;

DELIMITER //

CREATE PROCEDURE create_client(
    
    IN p_name VARCHAR(50),
    IN p_lastname VARCHAR(50),
    IN p_email VARCHAR(45),
    IN p_phone_number VARCHAR(20),
    OUT p_new_client_id INT

)
BEGIN
	
	INSERT INTO client (name, lastname, email, phone_number) VALUES (p_name, p_lastname, p_email, p_phone_number);
	SELECT last_insert_id() INTO p_new_client_id;
	
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS update_client;

DELIMITER //

CREATE PROCEDURE update_client(

    IN p_id INT,
    IN p_name VARCHAR(50),
    IN p_lastname VARCHAR(50),
    IN p_email VARCHAR(45),
    IN p_phone_number VARCHAR(20),
    OUT p_procedure_status INT
    
)
BEGIN

	IF EXISTS (SELECT id FROM client WHERE id = p_id)
		THEN UPDATE client SET name = p_name, lastname = p_lastname, email = p_email,phone_number = p_phone_number WHERE id = p_id;
        SELECT 1 INTO p_procedure_status;
	ELSE
		SET p_procedure_status =-1;
	
    END IF;
    
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS read_client;

DELIMITER //

CREATE PROCEDURE read_client(

    IN p_id INT,
    OUT p_name VARCHAR(50),
    OUT p_lastname VARCHAR(50),
    OUT p_email VARCHAR(45),
    OUT p_phone_number VARCHAR(20),
    OUT p_procedure_status INT

)
BEGIN

	IF EXISTS (SELECT id FROM client WHERE id = p_id)
		THEN SELECT name,lastname, email, phone_number INTO p_name,p_lastname,p_email,p_phone_number FROM client WHERE id=p_id;
        SELECT 1 INTO p_procedure_status;
	ELSE
		SET p_procedure_status =-1;
	END IF;

END//

DELIMITER ;


DROP PROCEDURE IF EXISTS delete_client;

DELIMITER //

CREATE PROCEDURE delete_client(

    IN p_id INT,
    OUT procedure_completed INT 

)
BEGIN

	IF EXISTS(SELECT id FROM client WHERE id = p_id)
		THEN IF NOT EXISTS (SELECT client_id FROM rentals WHERE client_id = p_id)
			THEN IF NOT EXISTS(SELECT client_id FROM review WHERE client_id = p_id)
				THEN DELETE FROM movie WHERE id = p_id;
					SELECT 1 INTO procedure_completed;
			ELSE
				SET procedure_completed=1;
			END IF;
		ELSE
			SET procedure_completed =-1;
		END IF;
	ELSE
		SET procedure_completed =-1;
	END IF;
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS create_rental;

DELIMITER //

CREATE PROCEDURE create_rental(

    IN p_client_id INT,
    IN p_movie_id INT,
    IN p_rental_date DATETIME,
    OUT p_new_rental INT

)
BEGIN

	IF EXISTS(SELECT id FROM client WHERE id = p_client_id)
		THEN IF EXISTS(SELECT id FROM movie WHERE id = p_movie_id)
			THEN INSERT INTO rentals(rental_date,client_id,movie_id) VALUES(p_rental_date,p_client_id,p_movie_id);
            SELECT last_insert_id() INTO p_new_rental;
        ELSE
			SET p_new_rental =-1;
        END IF;
    ELSE
		SET p_new_rental =-1;
	END IF;

END//

DELIMITER ;

DROP PROCEDURE IF EXISTS read_rental;

DELIMITER //

CREATE PROCEDURE read_rental(

    IN p_id INT,
    OUT p_rental_date DATETIME,
    OUT p_client_id INT,
    OUT p_movie_id INT,
    OUT p_procedure_status INT

)
BEGIN

	IF EXISTS(SELECT id FROM rentals WHERE id = p_id)
		THEN SELECT rental_date, client_id, movie_id INTO p_rental_date,p_client_id,p_movie_id FROM rentals WHERE id=p_id;
        SELECT 1 INTO p_procedure_status;
	ELSE
		SET p_procedure_status =-1;
	END IF;

END//

DELIMITER ;


DROP PROCEDURE IF EXISTS update_rental;

DELIMITER //

CREATE PROCEDURE update_rental(
    
    IN p_id INT,
    IN p_rental_date DATETIME,
    IN p_client_id INT,
    IN p_movie_id INT,
    OUT p_procedure_status INT

)
BEGIN

	IF EXISTS(SELECT id FROM rentals WHERE id = p_id)
		THEN IF EXISTS(SELECT id FROM movie WHERE id=p_movie_id)
			THEN IF EXISTS(SELECT id FROM client WHERE id=p_client_id) THEN
				UPDATE rentals SET rental_date = p_rental_date, client_id= p_client_id, movie_id = p_movie_id WHERE id = p_id;
				SELECT 1 INTO p_procedure_status;
            ELSE
				SET p_procedure_status =-1;
		END IF;
        ELSE
			SET p_procedure_status =-1;
		END IF;
	ELSE
		SET p_procedure_status =-1;
	END IF;
    
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS read_category;

DELIMITER //

CREATE PROCEDURE read_category(
    
    IN p_id INT,
    OUT p_name VARCHAR(45),
    OUT p_description VARCHAR(45),
    OUT p_procedure_status INT
    
)
BEGIN

	IF EXISTS(SELECT id FROM category WHERE id = p_id) THEN
		SELECT name, description INTO p_name,p_description FROM category WHERE id=p_id;
        SELECT 1 INTO p_procedure_status;
	ELSE
		SET p_procedure_status =-1;
	END IF;
    
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS delete_rental;

DELIMITER //

CREATE PROCEDURE delete_rental(

    IN p_id INT,
    OUT procedure_completed INT

)
BEGIN

	IF EXISTS(SELECT id FROM rentals WHERE id = p_id)
			THEN DELETE FROM rentals WHERE id = p_id;
			SELECT 1 INTO procedure_completed;
	ELSE
		SET procedure_completed =-1;
	END IF;
    
END//

DELIMITER ;

DROP PROCEDURE IF EXISTS create_review;

DELIMITER //

CREATE PROCEDURE create_review(

    IN p_client_id INT,
    IN p_movie_id INT,
    IN p_created_on DATETIME,
    IN p_rating DECIMAL(2),
    IN p_review_text VARCHAR(100),
    OUT p_new_review INT

)
BEGIN

	IF EXISTS(SELECT id FROM cliente WHERE id = p_client_id)
		THEN IF EXISTS(SELECT id FROM movie WHERE id = p_movie_id)
			THEN INSERT INTO review (rating,review_text,created_on,client_id,movie_id) VALUES (p_rating,p_review_text,p_created_on,p_client_id,p_movie_id);
            SELECT last_insert_id() INTO p_new_review;
        ELSE
			SET p_new_review =-1;
        END IF;
    ELSE
		SET p_new_review =-1;
	END IF;

END//

DELIMITER ;

DROP PROCEDURE IF EXISTS delete_review;

DELIMITER //

CREATE PROCEDURE delete_review(

    IN p_id INT,
    OUT procedure_completed INT
    
)
BEGIN

	IF EXISTS(SELECT id FROM review WHERE id = p_id)
			THEN DELETE FROM review WHERE id = p_id;
			SELECT 1 INTO procedure_completed;
	ELSE
		SET procedure_completed =-1;
	END IF;

END//

DELIMITER ;

DROP PROCEDURE IF EXISTS read_review;

DELIMITER //

CREATE PROCEDURE read_review(

    IN p_id INT,
    OUT p_rating DECIMAL(2),
    OUT p_client_id INT,
    OUT p_movie_id INT,
    OUT p_review_text VARCHAR(100),
    OUT p_created_on DATE,
    OUT p_procedure_status INT
    
)
BEGIN

	IF EXISTS(SELECT id FROM review WHERE id = p_id)
		THEN SELECT rating,client_id,movie_id,review_text,created_on INTO p_rating,p_client_id,p_movie_id,p_review_text,p_created_on FROM review WHERE id=p_id;
        SELECT 1 INTO p_procedure_status;
	ELSE
		SET p_procedure_status =-1;
	END IF;

END//

DELIMITER ;


DROP PROCEDURE IF EXISTS update_review;

DELIMITER //

CREATE PROCEDURE update_review(

    IN p_id INT,
    IN p_rating DECIMAL(2),
    IN p_client_id INT,
    IN p_movie_id INT,
    IN p_review_text VARCHAR(100),
    IN p_created_on DATE,
    OUT p_procedure_status INT
    
)
BEGIN

	IF EXISTS(SELECT id FROM review WHERE id = p_id)
		THEN IF EXISTS(SELECT id FROM movie WHERE id=p_movie_id)
			THEN IF EXISTS(SELECT id FROM client WHERE id=p_client_id)
				THEN UPDATE review SET rating = p_rating, client_id= p_client_id, movie_id = p_movie_id, created_on = p_created_on,review_text = p_review_text WHERE id = p_id;
				SELECT 1 INTO p_procedure_status;
            ELSE
				SET p_procedure_status =-1;
			END IF;
        ELSE
			SET p_procedure_status =-1;
		END IF;
	ELSE
		SET p_procedure_status =-1;
	END IF;

END//

DELIMITER ;