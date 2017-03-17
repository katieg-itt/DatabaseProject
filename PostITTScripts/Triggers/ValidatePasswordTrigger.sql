CREATE OR REPLACE TRIGGER validatePassword1 
BEFORE INSERT 
ON ITTUser 
FOR EACH ROW 

BEGIN 
    IF NOT REGEXP_LIKE(:new.password, '^.*[0-9]', 'c')
      AND NOT REGEXP_LIKE(:new.password, '^[a-zA-Z][a-zA-Z0-9]{5,}$', 'c') 
      THEN raise_application_error(-20000,'Error with inserting the password - 
                                          please ensure your password 
                                          has a number, is mixed case (a-z)(A-Z) 
                                          and is at least 5 letters long');
    END IF;
END;
/*
^.*[0-9] ensures there is at least one digit
The ^ anchor asserts that we are at the beginning of the string
[a-zA-Z] matches the initial letter
[a-zA-Z0-9]{5,} matches 7 or more chars (ensuring 8 or more total) that are either ASCII letters or digits
The $ anchor asserts that we are at the end of the string
Reference http://stackoverflow.com/questions/24817736/i-need-a-regular-expression-for-password-in-pl-sql-using-regexp-like
*/