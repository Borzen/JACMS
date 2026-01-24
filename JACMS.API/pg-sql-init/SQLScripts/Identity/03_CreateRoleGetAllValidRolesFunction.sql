-- FUNCTION: Identity.role_get_all_valid_roles()

-- DROP FUNCTION IF EXISTS "Identity".role_get_all_valid_roles();

CREATE OR REPLACE FUNCTION "Identity".role_get_all_valid_roles(
	)
    RETURNS SETOF "Identity"."Role" 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
BEGIN
	RETURN QUERY 
	SELECT * from "Identity"."Role" r where r."IsDeleted" = FALSE;
END
$BODY$;

ALTER FUNCTION "Identity".role_get_all_valid_roles()
    OWNER TO "JACMSUser";

