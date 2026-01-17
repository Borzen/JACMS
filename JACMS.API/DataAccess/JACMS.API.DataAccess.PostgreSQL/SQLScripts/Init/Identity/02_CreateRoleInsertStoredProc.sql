-- PROCEDURE: Identity.role_create(character varying, character varying, text)

-- DROP PROCEDURE IF EXISTS "Identity".role_create(character varying, character varying, text);

CREATE OR REPLACE PROCEDURE "Identity".role_create(
	IN rolename character varying,
	IN normalizedname character varying,
	IN concurrencystamp text,
	OUT new_role_id bigint)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
	INSERT INTO "Identity"."Role"
	(
		"Name",
		"NormalizedName",
		"ConcurrencyStamp",
		"IsDeleted",
		"CreationDate",
		"UpdateDate"
	)
	VALUES 
	(
		RoleName,
		NormalizedName,
		ConcurrencyStamp,
		0,
		NOW(),
		NOW()
	)
	RETURNING "Id" into new_role_id;
	COMMIT;
End;
$BODY$;
ALTER PROCEDURE "Identity".role_create(character varying, character varying, text)
    OWNER TO "JACMSUser";
