-- PROCEDURE: Identity.role_delete(bigint)

-- DROP PROCEDURE IF EXISTS "Identity".role_delete(bigint);

CREATE OR REPLACE PROCEDURE "Identity".role_delete(
	IN id bigint)
LANGUAGE 'plpgsql'
AS $BODY$
	DECLARE nameGUID text = upper(uuidv4());
BEGIN 
	
	DELETE FROM "Identity"."UserRole" ur where ur."RoleId" = id;

	UPDATE "Identity"."RoleClaim" rc
	set
		rc."IsDeleted" = TRUE,
		rc."UpdateDate" = NOW()
	where
		rc."RoleId" = id and rc."IsDeleted" = 0;

	Update "Identity"."Role" as r
	set r."IsDeleted" = TRUE,
		r."UpdateDate" = NOW(),
		r."Name" = r."Name" || nameGUID,
		r."NormalizedName" = r."NormalizedName" || nameGUID
	where
		r."Id" = id and r."IsDeleted" = FALSE;
END;
$BODY$;
ALTER PROCEDURE "Identity".role_delete(bigint)
    OWNER TO "JACMSUser";

