﻿CREATE TABLE users
(
    id SERIAL PRIMARY KEY,
    email VARCHAR(255) NOT NULL UNIQUE,
    alias VARCHAR(30) NOT NULL
);