-- PROCEDURE: Identity.user_create(character varying, character varying, character varying, character varying, boolean, text, text, text, text, boolean, boolean, timestamp with time zone, boolean, integer)

DROP PROCEDURE IF EXISTS "Identity".user_create(character varying, character varying, character varying, character varying, boolean, text, text, text, text, boolean, boolean, timestamp with time zone, boolean, integer);

CREATE OR REPLACE PROCEDURE "Identity".user_create(
	IN user_name character varying,
	IN normalized_user_name character varying,
	IN email character varying,
	IN normalized_email character varying,
	IN email_confirmed boolean,
	IN password_hash text,
	IN security_stamp text,
	IN concurrency_stamp text,
	IN phone_number text,
	IN phone_number_confirmed boolean,
	IN two_factor_enabled boolean,
	IN lockout_end timestamp with time zone,
	IN lockout_enabled boolean,
	IN access_failed_count integer,
	OUT new_user_id BIGINT)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN

	INSERT INTO "Identity"."User"
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
		user_name, 
		normalized_user_name, 
		email,
		normalized_email,
		email_confirmed,
		password_hash,
		security_stamp,
		concurrency_stamp,
		phone_number,
		phone_number_confirmed,
		two_factor_enabled,
		lockout_end,
		lockout_enabled,
		access_failed_count,
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
