CREATE TABLE public."Rotas"
(
    "Id" integer NOT NULL,
    "UfOrigem" text COLLATE pg_catalog."default" NOT NULL,
    "UfDestino" text COLLATE pg_catalog."default" NOT NULL,
    "Distancia" double precision NOT NULL,
    "Preco" double precision,
    CONSTRAINT "Rotas_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Rotas"
    OWNER to postgres;
	
	-- Table: public."Login"

-- DROP TABLE public."Login";

CREATE TABLE public."Login"
(
    "Id" integer NOT NULL,
    "Usuario" text COLLATE pg_catalog."default" NOT NULL,
    "Senha" text COLLATE pg_catalog."default",
    CONSTRAINT "Login_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Login"
    OWNER to postgres;
	
	-- Table: public."PedidoFrete"

-- DROP TABLE public."PedidoFrete";

CREATE TABLE public."PedidoFrete"
(
    "Id" integer NOT NULL,
    "UfOrigem" text COLLATE pg_catalog."default",
    "UfDestino" text COLLATE pg_catalog."default",
    "Status" integer,
    CONSTRAINT "PedidoFrete_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."PedidoFrete"
    OWNER to postgres;