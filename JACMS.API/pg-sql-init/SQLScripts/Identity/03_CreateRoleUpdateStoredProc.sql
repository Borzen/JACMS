-- PROCEDURE: Identity.role_update(bigint, character varying, character varying, text)

-- DROP PROCEDURE IF EXISTS "Identity".role_update(bigint, character varying, character varying, text);

CREATE OR REPLACE PROCEDURE "Identity".role_update(
	IN "@Id" bigint,
	IN "@RoleName" character varying,
	IN "@NormalizedName" character varying,
	IN "@ConcurrencyStamp" text)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
	Update "Identity"."Role"
	Set
		RoleName = "@RoleName",
		NormalizedName = "@NormalizedName",
		ConcurrencyStamp = "@ConcurrencyStamp"
	Where "Id" = "@Id"
	AND IsDeleted = FALSE;
	COMMIT;
End;
$BODY$;
ALTER PROCEDURE "Identity".role_update(bigint, character varying, character varying, text)
    OWNER TO "JACMSUser";
