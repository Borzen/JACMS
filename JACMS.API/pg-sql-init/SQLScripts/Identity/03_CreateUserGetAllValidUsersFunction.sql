-- FUNCTION: Identity.user_get_all_valid_users()

-- DROP FUNCTION IF EXISTS "Identity".user_get_all_valid_users();

CREATE OR REPLACE FUNCTION "Identity".user_get_all_valid_users(
	)
    RETURNS SETOF "Identity"."User" 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
BEGIN
	RETURN QUERY 
	SELECT * from "Identity"."User" u where u."IsDeleted" = FALSE;
END
$BODY$;

ALTER FUNCTION "Identity".user_get_all_valid_users()
    OWNER TO "JACMSUser";

