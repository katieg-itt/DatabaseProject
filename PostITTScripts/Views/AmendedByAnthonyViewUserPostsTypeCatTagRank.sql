DROP VIEW ViewUserPostsTypeCatTagRank;

CREATE VIEW ViewUserPostsTypeCatTagRank
AS SELECT u.userId, u.surname, p.postText, pt.postType, c.categoryName, t.tagName, r.postRank
FROM post p
   join ittuser u on u.userid = p.userId
   left join rank r on r.postId = p.postId
   left join postType pt on p.postTypeId = pt.postTypeId
   left join category c on c.categoryId = p.categoryId
   left join tag t on t.categoryId = c.categoryId;
      
SELECT userId, surname, postText, postType, categoryName, tagName, postRank 
FROM ViewUserPostsTypeCatTagRank;