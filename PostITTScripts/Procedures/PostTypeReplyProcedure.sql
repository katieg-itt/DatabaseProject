CREATE OR REPLACE PROCEDURE ReplyPost
IS
pTDesc VARCHAR2(20) := 'Reply';

BEGIN
        INSERT INTO PostType(postTypeId,postType)
        VALUES(PostType_seq.NEXTVAL,pTDesc);
END;