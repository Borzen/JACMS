-- FUNCTION: Identity.user_get_all_valid_users_by_id(bigint)

-- DROP FUNCTION IF EXISTS "Identity".user_get_all_valid_users_by_id(bigint);

CREATE OR REPLACE FUNCTION "Identity".user_get_all_valid_users_by_id(
	id bigint)
    RETURNS SETOF "Identity"."User" 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
BEGIN
	RETURN QUERY 
	SELECT * from "Identity"."User" u where u."Id" = id and u."IsDeleted" = FALSE;
END
$BODY$;

ALTER FUNCTION "Identity".user_get_all_valid_users_by_id(bigint)
    OWNER TO "JACMSUser";

