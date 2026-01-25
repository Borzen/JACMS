-- FUNCTION: Identity.role_get_all_valid_roles_by_name(character varying)

-- DROP FUNCTION IF EXISTS "Identity".role_get_all_valid_roles_by_name(character varying);

CREATE OR REPLACE FUNCTION "Identity".role_get_all_valid_roles_by_name(
	name character varying)
    RETURNS SETOF "Identity"."Role" 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$

BEGIN
	RETURN QUERY 
	SELECT * from "Identity"."Role" r where r."Name" = name AND r."IsDeleted" = FALSE;
END
$BODY$;

ALTER FUNCTION "Identity".role_get_all_valid_roles_by_name(character varying)
    OWNER TO "JACMSUser";

