-- FUNCTION: Identity.user_get_all_valid_users_by_normalized_name(character varying)

-- DROP FUNCTION IF EXISTS "Identity".user_get_all_valid_users_by_normalized_name(character varying);

CREATE OR REPLACE FUNCTION "Identity".user_get_all_valid_users_by_normalized_name(
	normalized_name character varying)
    RETURNS SETOF "Identity"."User" 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
BEGIN
	RETURN QUERY 
	SELECT * from "Identity"."User" u where u."NormalizedUserName" = normalized_name and u."IsDeleted" = FALSE;
END
$BODY$;

ALTER FUNCTION "Identity".user_get_all_valid_users_by_normalized_name(character varying)
    OWNER TO "JACMSUser";

