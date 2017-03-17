--INDEX FOR USERS SCORE

DROP INDEX userIndex;

CREATE INDEX userIndex
  ON IttUser (surname, score);
  
SELECT surname, score
FROM IttUser;


--INDEX FOR POSTS

DROP INDEX postIndex;

CREATE INDEX postIndex
  ON Post (postText, postDate, userId, categoryId);
   
SELECT postText, postDate, userId, categoryId
FROM Post;


--INDEX FOR RANK

DROP INDEX rankIndex;

CREATE INDEX rankIndex
  ON Rank (rankId, postRank, userId, postId);
   
SELECT userId, SUM(postRank) AS postRankTotal
FROM Rank
GROUP BY userId
ORDER BY postRankTotal DESC;

/*
SELECT SUM(postId) AS postTotal
    FROM Post
    GROUP BY userId
    ORDER BY postTotal DESC;
*/    

--COMBINE THESE IF/WHEN YOU CAN    
--INDEX FOR CATEGORIES

DROP INDEX categoryIndex;

CREATE INDEX categoryIndex
  ON Category (categoryId, categoryName);
  
SELECT categoryId, categoryName
FROM Category;


--INDEX FOR TAGS

DROP INDEX tagIndex;

CREATE INDEX tagIndex
  ON Category (tagId, tagName, categoryId);
  
SELECT tagId, tagName, categoryId
FROM Category;


