CREATE OR REPLACE PROCEDURE AnswerPost
IS
pTDesc VARCHAR2(20) := 'Answer';

BEGIN
        
        INSERT INTO PostType(postTypeId,postType)
        VALUES(PostType_seq.NEXTVAL,pTDesc);
END;