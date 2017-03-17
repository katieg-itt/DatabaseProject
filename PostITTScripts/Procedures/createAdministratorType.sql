CREATE OR REPLACE PROCEDURE createAdministrator
IS
  tDesc VARCHAR2(20);

BEGIN
    tDesc := 'A';
    INSERT INTO UserType(userTypeId, typeDescription)
VALUES(UserType_seq.NEXTVAL,tDesc);


END;