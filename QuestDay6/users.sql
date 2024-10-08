CREATE TABLE users(
id BIGINT,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
username VARCHAR(25) NOT NULL,
email VARCHAR(100) NOT NULL,
dob DATETIME,
password_hash VARCHAR(250),
about TEXT,
);

AlTER TABLE users
ADD CONSTRAINT PK_user_id PRIMARY KEY(id);

ALTER TABLE users
ADD phone_number VARCHAR(20);

ALTER TABLE users
ADD CONSTRAINT UQ_users_username UNIQUE (username);

ALTER TABLE users
ADD CONSTRAINT UQ_users_email UNIQUE (email);

ALTER TABLE users
ADD CONSTRAINT CHK_users_dob CHECK (dob < GETDATE())

ALTER TABLE users
ADD CONSTRAINT CHK_users_phone CHECK (LEN(phone_number) BETWEEN 7 AND 20)
