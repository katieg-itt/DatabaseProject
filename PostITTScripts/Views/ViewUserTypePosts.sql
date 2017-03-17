DROP VIEW ViewUserTypePosts;

CREATE VIEW ViewUserTypePosts
AS SELECT P.userId, typeDescription, firstName, surname, postText
FROM IttUser U, UserType T, Post P
WHERE U.userTypeId = T.userTypeId AND
      U.userId = P.userId;
      
      
SELECT userId, firstName, surname, typeDescription, postText
FROM ViewUserTypePosts;


