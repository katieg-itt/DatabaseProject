--Procedure to post a post
--UserId and catId will be passed in as a parameter from page

CREATE OR REPLACE PROCEDURE insertPost(pText VARCHAR2, uId NUMBER, pTypeId NUMBER, catId NUMBER)
AS

BEGIN
     
     INSERT INTO Post (postId, postDate, postText, userId, postTypeId, categoryId) 
     VALUES (Post_seq.NEXTVAL, SYSDATE, pText, uId, pTypeId, catId);
     
     InitialPost(Post_seq.CURRVAL);
     
END;