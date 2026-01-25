-- PROCEDURE: Identity.role_update(bigint, character varying, character varying, text)

-- DROP PROCEDURE IF EXISTS "Identity".role_update(bigint, character varying, character varying, text);

CREATE OR REPLACE PROCEDURE "Identity".role_update(
	IN id bigint,
	IN role_name character varying,
	IN normalized_name character varying,
	IN concurrency_stamp text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
	Update "Identity"."Role"
	Set
		RoleName = role_name,
		NormalizedName = normalized_name,
		ConcurrencyStamp = concurrency_stamp
	Where "Id" = id
	AND IsDeleted = FALSE;
	COMMIT;
End;
$BODY$;
ALTER PROCEDURE "Identity".role_update(bigint, character varying, character varying, text)
    OWNER TO "JACMSUser";
