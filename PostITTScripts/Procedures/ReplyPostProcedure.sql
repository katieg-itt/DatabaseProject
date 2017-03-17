--REPLY POST - Takes the parents post Id and insert it into the childs parent Id
--Might need store procedure to select parent Id on posting reply (later)
SET SERVEROUTPUT ON
CREATE OR REPLACE PROCEDURE replyPostProc(childPostId IN NUMBER, parentPostId IN NUMBER)
IS
 
BEGIN
  UPDATE Post SET parentId = parentPostId
  WHERE postId = childPostId;
 
END;
