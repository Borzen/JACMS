-- PROCEDURE: Identity.role_create(character varying, character varying, text)

-- DROP PROCEDURE IF EXISTS "Identity".role_create(character varying, character varying, text);

CREATE OR REPLACE PROCEDURE "Identity".role_create(
	IN role_name character varying,
	IN normalized_name character varying,
	IN concurrency_stamp text,
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
		role_name,
		normalized_name,
		concurrency_stamp,
		FALSE,
		NOW(),
		NOW()
	)
	RETURNING "Id" into new_role_id;
	COMMIT;
End;
$BODY$;
ALTER PROCEDURE "Identity".role_create(character varying, character varying, text)
    OWNER TO "JACMSUser";
