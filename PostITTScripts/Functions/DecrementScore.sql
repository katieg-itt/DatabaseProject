 
SET serveroutput ON
CREATE OR REPLACE FUNCTION decrementScore(pstID IN NUMBER)
RETURN NUMBER
AS
  p_id NUMBER(5);
  rnk NUMBER(5) := 0;
BEGIN
  SELECT pstID, r.postRank
  INTO p_id, rnk
  FROM Rank r, Post p
  WHERE p_id = p.postid AND
  p.postid = r.postid;
 
 rnk := rnk -1;
  
  RETURN rnk;
END;