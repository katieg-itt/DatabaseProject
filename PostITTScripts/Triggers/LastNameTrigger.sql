CREATE OR REPLACE TRIGGER userIttSurnameCheck
BEFORE INSERT OR UPDATE ON IttUser
FOR EACH ROW

	DECLARE 
	 surname VARCHAR(20);
BEGIN
	surname := :NEW.surname;

IF (NOT(regexp_like(surname, '[a-zA-Z '']+$')))
THEN
	RAISE_APPLICATION_ERROR(-3000,('Surname name can only contain letters'));
END IF;
END;