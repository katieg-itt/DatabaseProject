CREATE OR REPLACE TRIGGER profilePicTrigger
BEFORE INSERT OR UPDATE ON IttUser
FOR EACH ROW
	DECLARE
	   profilePic BLOB;
	BEGIN
	   profilePic := (:NEW.profilePic);

	IF dbms_lob.getlength (profilePic) > 1048576
    THEN
      raise_application_error(-30010,'Profile Picture must be under 1MB');
	END IF;
END;