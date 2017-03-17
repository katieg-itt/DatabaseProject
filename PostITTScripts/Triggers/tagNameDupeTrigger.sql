CREATE OR REPLACE TRIGGER TAGTRIGGER 
BEFORE INSERT 
ON Tag
FOR EACH ROW
DECLARE 
    CURSOR tagCursor IS
      SELECT tagName
      FROM tag
      WHERE tagName = :new.tagName;
      tName VARCHAR2(20) := :new.tagname;   
BEGIN
     OPEN tagCursor;
       LOOP
          FETCH tagCursor INTO tName;
              IF tagcursor%found THEN
              RAISE_APPLICATION_ERROR(-25000,tName || ' already exists');
              END IF;
          EXIT WHEN tagcursor%found;
       END LOOP;
     CLOSE tagCursor;    
END;
