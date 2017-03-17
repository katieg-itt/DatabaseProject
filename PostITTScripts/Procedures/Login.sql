CREATE OR REPLACE PROCEDURE login(v_email VARCHAR2,v_password VARCHAR2)
AS
  fnam   VARCHAR2(20);
  snam   VARCHAR2(20);
  emails VARCHAR2(30);
  pass   VARCHAR2(30);
BEGIN
  SELECT firstname, surname, email, password
  INTO fnam,snam,emails,pass
  FROM ITTUser
  WHERE email = v_email
  AND password = v_password;
  DBMS_OUTPUT.PUT_LINE('Welcome ' || fnam || ' ' || snam || ' , to PostITT');

EXCEPTION
WHEN NO_DATA_FOUND THEN
  dbms_output.put_line('Sorry invalid email/password');
END;