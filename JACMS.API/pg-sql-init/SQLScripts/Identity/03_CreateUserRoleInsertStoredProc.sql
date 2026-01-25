-- PROCEDURE: Identity.userrole_create(bigint, bigint)

-- DROP PROCEDURE IF EXISTS "Identity".userrole_create(bigint, bigint);

CREATE OR REPLACE PROCEDURE "Identity".userrole_create(
	IN user_id bigint,
	IN role_id bigint)
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
		user_id,
		role_id
	);
	COMMIT;
End;
$BODY$;
ALTER PROCEDURE "Identity".userrole_create(bigint, bigint)
    OWNER TO "JACMSUser";
