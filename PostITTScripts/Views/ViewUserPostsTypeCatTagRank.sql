DROP VIEW ViewUserPostsTypeCatTagRank;

CREATE VIEW ViewUserPostsTypeCatTagRank
AS SELECT P.userId, surname, postText, postType, categoryName, tagName, postRank 
FROM IttUser U, Post P, PostType O, Category C, Tag T, Rank R 
WHERE U.userId = P.userId AND
      P.postId = R.postId AND
      P.postTypeId = O.postTypeId AND
      P.categoryId = C.categoryId AND
      C.categoryId = T.categoryId AND
      P.postId = R.postId;
      
      
SELECT userId, surname, postText, postType, categoryName, tagName, postRank 
FROM ViewUserPostsTypeCatTagRank;