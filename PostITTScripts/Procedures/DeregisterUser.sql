SET SERVEROUTPUT ON
CREATE OR REPLACE PROCEDURE DeregisterITTUser(fnam IN  VARCHAR2, snam IN VARCHAR2, pass IN VARCHAR2)
IS


BEGIN
        DELETE 
        FROM ITTUser
        WHERE fnam IN firstname 
              AND snam IN surname 
              AND pass IN password;
        dbms_output.put_line( 'USER : ' || ' ' ||  fnam || ' ' || snam || ' has been deregistered.' );

 exception
  WHEN NO_DATA_FOUND THEN
    dbms_output.put_line('Sorry the user you entered could not be found - Try again'); 
    
END;