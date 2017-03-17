CREATE OR REPLACE PROCEDURE createUserType
IS
  tDesc VARCHAR2(20);

BEGIN
    tDesc := 'U';
    INSERT INTO UserType(userTypeId, typeDescription)
VALUES(UserType_seq.NEXTVAL,tDesc);

END;

    

