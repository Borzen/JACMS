-- PROCEDURE: Identity.user_create(character varying, character varying, character varying, character varying, boolean, text, text, text, text, boolean, boolean, timestamp with time zone, boolean, integer)

DROP PROCEDURE IF EXISTS "Identity".user_create(character varying, character varying, character varying, character varying, boolean, text, text, text, text, boolean, boolean, timestamp with time zone, boolean, integer);

CREATE OR REPLACE PROCEDURE "Identity".user_create(
	IN username character varying,
	IN normalizedusername character varying,
	IN email character varying,
	IN normalizedemail character varying,
	IN emailconfirmed boolean,
	IN passwordhash text,
	IN securitystamp text,
	IN concurrencystamp text,
	IN phonenumber text,
	IN phonenumberconfirmed boolean,
	IN twofactorenabled boolean,
	IN lockoutend timestamp with time zone,
	IN lockoutenabled boolean,
	IN accessfailedcount integer,
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
		UserName, 
		NormalizedUserName, 
		Email,
		NormalizedEmail,
		EmailConfirmed,
		PasswordHash,
		SecurityStamp,
		ConcurrencyStamp,
		PhoneNumber,
		PhoneNumberConfirmed,
		TwoFactorEnabled,
		LockoutEnd,
		LockoutEnabled,
		AccessFailedCount,
		0,
		NOW(),
		NOW()
	)
	RETURNING "Id" INTO new_user_id;
	COMMIT;
End;
$BODY$;
ALTER PROCEDURE "Identity".user_create(character varying, character varying, character varying, character varying, boolean, text, text, text, text, boolean, boolean, timestamp with time zone, boolean, integer)
    OWNER TO "JACMSUser";
