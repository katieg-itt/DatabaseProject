--TRIGGER TO VALIDATE THE EMAIL

CREATE OR REPLACE TRIGGER validateEmail 
BEFORE INSERT 
ON ITTUser 
FOR EACH ROW 

BEGIN 
    IF NOT REGEXP_LIKE(:new.email, '[a-zA-Z0-9._%-]+@[a-zA-Z0-9._%-]+\.[a-zA-Z]{2,4}')
            THEN raise_application_error(-20000,'Error email not in correct format - 
                                          please re-enter');
    END IF;
END;
