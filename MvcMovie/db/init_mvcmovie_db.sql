CREATE TABLE movie
(
  id serial PRIMARY KEY,
  genre varchar(255),
  price numeric(8,2) NOT NULL,
  releasedate timestamp NOT NULL,
  title varchar(255)
);
