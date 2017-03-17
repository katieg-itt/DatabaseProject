--INITIAL POST - PARENT POST - INFORMATIVE OR QUESTION POST
CREATE OR REPLACE PROCEDURE InitialPost(postId IN VARCHAR2)
IS 

initialP NUMBER(5) := postId;

BEGIN
    
        UPDATE POST SET parentId = initialP
        WHERE postId = initialP;
 
END;


