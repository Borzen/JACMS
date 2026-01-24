-- PROCEDURE: Identity.userrole_create(bigint, bigint)

-- DROP PROCEDURE IF EXISTS "Identity".userrole_create(bigint, bigint);

CREATE OR REPLACE PROCEDURE "Identity".userrole_create(
	IN "@UserId" bigint,
	IN "@RoleId" bigint)
LANGUAGE 'plpgsql'
AS $BODY$
BEGIN
	INSERT INTO "Identity"."UserRole"
	(
		"UserId",
		"RoleId"
	)
	VALUES 
	(
		"@UserId",
		"@RoleId"
	);
	COMMIT;
End;
$BODY$;
ALTER PROCEDURE "Identity".userrole_create(bigint, bigint)
    OWNER TO "JACMSUser";
