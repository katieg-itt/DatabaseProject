CREATE OR REPLACE PROCEDURE InformativePost
IS
pTDesc VARCHAR2(20) := 'Informative';

BEGIN
        
        INSERT INTO PostType(postTypeId,postType)
        VALUES(PostType_seq.NEXTVAL,pTDesc);
END;