-- Table: Identity.UserLogin

-- DROP TABLE IF EXISTS "Identity"."UserLogin";

CREATE TABLE IF NOT EXISTS "Identity"."UserLogin"
(
    "LoginProvider" character varying(128) COLLATE pg_catalog."default" NOT NULL,
    "ProviderKey" character varying(125) COLLATE pg_catalog."default" NOT NULL,
    "UserId" bigint NOT NULL,
    "IsDeleted" boolean NOT NULL,
    "CreationDate" timestamp without time zone NOT NULL,
    "UpdateDate" timestamp without time zone NOT NULL,
    CONSTRAINT "PK_UserLogin" PRIMARY KEY ("LoginProvider", "ProviderKey"),
    CONSTRAINT "FK_UserLogin_User" FOREIGN KEY ("UserId")
        REFERENCES "Identity"."User" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS "Identity"."UserLogin"
    OWNER to "JACMSUser";