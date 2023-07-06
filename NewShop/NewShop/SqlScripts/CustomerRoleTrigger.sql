CREATE OR REPLACE FUNCTION add_user_role_on_create()
  RETURNS TRIGGER 
  LANGUAGE PLPGSQL
  AS
$$
BEGIN
	INSERT INTO "AspNetUserRoles" ("UserId", "RoleId")
	VALUES (NEW."Id", 'cus');
	
	RETURN NULL;
END;
$$

------ ЗАПУСКАТЬ ОТДЕЛЬНО ВЕРХНЕЕ И НИЖНЕЕ ВЫРАЖЕНИЕ!!!-----------

CREATE OR REPLACE TRIGGER add_user_cutomer_role_after_insert
  AFTER INSERT
  ON "AspNetUsers"
  FOR EACH ROW
  EXECUTE PROCEDURE add_user_role_on_create();