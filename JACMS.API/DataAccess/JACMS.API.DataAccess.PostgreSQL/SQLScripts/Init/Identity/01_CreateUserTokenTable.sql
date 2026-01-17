-- Table: Identity.UserToken

-- DROP TABLE IF EXISTS "Identity"."UserToken";

CREATE TABLE IF NOT EXISTS "Identity"."UserToken"
(
    "UserId" bigint NOT NULL,
    "LoginProvider" character varying(128) COLLATE pg_catalog."default" NOT NULL,
    "Name" character varying(128) COLLATE pg_catalog."default" NOT NULL,
    "Value" text COLLATE pg_catalog."default",
    CONSTRAINT "PK_UserToken" PRIMARY KEY ("UserId", "LoginProvider", "Name"),
    CONSTRAINT "FK_UserToken_User" FOREIGN KEY ("UserId")
        REFERENCES "Identity"."User" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS "Identity"."UserToken"
    OWNER to "JACMSUser";