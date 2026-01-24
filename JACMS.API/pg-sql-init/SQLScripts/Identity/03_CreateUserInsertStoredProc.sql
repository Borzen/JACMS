-- PROCEDURE: Identity.user_create(character varying, character varying, character varying, character varying, boolean, text, text, text, text, boolean, boolean, timestamp with time zone, boolean, integer)

DROP PROCEDURE IF EXISTS "Identity".user_create(character varying, character varying, character varying, character varying, boolean, text, text, text, text, boolean, boolean, timestamp with time zone, boolean, integer);

CREATE OR REPLACE PROCEDURE "Identity".user_create(
	IN "@UserName" character varying,
	IN "@NormalizedUserName" character varying,
	IN "@Email" character varying,
	IN "@NormalizedEmail" character varying,
	IN "@EmailConfirmed" boolean,
	IN "@PasswordHash" text,
	IN "@SecurityStamp" text,
	IN "@ConcurrencyStamp" text,
	IN "@PhoneNumber" text,
	IN "@PhoneNumberConfirmed" boolean,
	IN "@TwoFactorEnabled" boolean,
	IN "@LockoutEnd" timestamp with time zone,
	IN "@LockoutEnabled" boolean,
	IN "@AccessFailedCount" integer,
	OUT new_user_id BIGINT)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN

	INSERT INTO "User"
	(
		"UserName",
		"NormalizedUserName",
		"Email",
		"NormalizedEmail",
		"EmailConfirmed",
		"PasswordHash",
		"SecurityStamp",
		"ConcurrencyStamp",
		"PhoneNumber",
		"PhoneNumberConfirmed",
		"TwoFactorEnabled",
		"LockoutEnd",
		"LockoutEnabled",
		"AccessFailedCount",
		"IsDeleted",
		"CreationDate",
		"UpdateDate"
	)
	VALUES 
	(
		"@UserName", 
		"@NormalizedUserName", 
		"@Email",
		"@NormalizedEmail",
		"@EmailConfirmed",
		"@PasswordHash",
		"@SecurityStamp",
		"@ConcurrencyStamp",
		"@PhoneNumber",
		"@PhoneNumberConfirmed",
		"@TwoFactorEnabled",
		"@LockoutEnd",
		"@LockoutEnabled",
		"@AccessFailedCount",
		FALSE,
		NOW(),
		NOW()
	)
	RETURNING "Id" INTO new_user_id;
	COMMIT;
End;
$BODY$;
ALTER PROCEDURE "Identity".user_create(character varying, character varying, character varying, character varying, boolean, text, text, text, text, boolean, boolean, timestamp with time zone, boolean, integer)
    OWNER TO "JACMSUser";
