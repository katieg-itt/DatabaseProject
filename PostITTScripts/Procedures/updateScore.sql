  -- number of  posts X the sum of all his post ranks 
CREATE OR REPLACE PROCEDURE updateScore(uId IN NUMBER)
IS 
    numPosts NUMBER(5);
    postRanks NUMBER(5);
    sc NUMBER(5);   
BEGIN
     SELECT COUNT(*)
     INTO numPosts
     FROM IttUser u, Post p
     WHERE uId = u.userid AND
          uId = p.userid;
     
     SELECT SUM(postRank)
     INTO postRanks
     FROM Rank r, ITTUser u
          WHERE uId = r.userid;
          
     SELECT score
     INTO sc
     FROM ITTUser u
    WHERE uId = u.userid;
     
     IF sc = 1 THEN
         UPDATE ITTUser u
         SET score = 2
        WHERE uId = u.userid;  
     END IF;   
     
     UPDATE ITTUser u
         SET score = (postRanks*numPosts)
         WHERE uId = u.userid;
END;
