-- Table: Identity.UserRole

-- DROP TABLE IF EXISTS "Identity"."UserRole";

CREATE TABLE IF NOT EXISTS "Identity"."UserRole"
(
    "UserId" bigint NOT NULL,
    "RoleId" bigint NOT NULL,
    CONSTRAINT "PK_UserRole" PRIMARY KEY ("UserId", "RoleId"),
    CONSTRAINT "FK_UserRole_Role" FOREIGN KEY ("RoleId")
        REFERENCES "Identity"."Role" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT "FK_UserRole_User" FOREIGN KEY ("UserId")
        REFERENCES "Identity"."User" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS "Identity"."UserRole"
    OWNER to "JACMSUser";