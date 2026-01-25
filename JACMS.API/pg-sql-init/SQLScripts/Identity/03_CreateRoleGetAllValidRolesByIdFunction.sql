-- FUNCTION: Identity.role_get_all_valid_roles_by_id(bigint)

-- DROP FUNCTION IF EXISTS "Identity".role_get_all_valid_roles_by_id(bigint);

CREATE OR REPLACE FUNCTION "Identity".role_get_all_valid_roles_by_id(
	id bigint)
    RETURNS SETOF "Identity"."Role" 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
BEGIN
	RETURN QUERY 
	SELECT * from "Identity"."Role" r where r."Id" = id AND r."IsDeleted" = FALSE;
END
$BODY$;

ALTER FUNCTION "Identity".role_get_all_valid_roles_by_id(bigint)
    OWNER TO "JACMSUser";

