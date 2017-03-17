-- VIEW USERS AND THEIR POSTS

DROP VIEW ViewUserPosts;

CREATE VIEW ViewUserPosts
AS SELECT P.userId, firstName, surname, postText
FROM IttUser U, Post P
WHERE U.userId = P.userId;
      
      
SELECT userId, firstName, surname, postText
FROM ViewUserPosts;


