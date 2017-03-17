--VIEW USERS
CREATE OR REPLACE VIEW ViewUser
AS SELECT userId, firstName, surname
FROM IttUser;
           
SELECT userId, firstName, surname
FROM ViewUser;

--VIEW POSTS
CREATE OR REPLACE VIEW ViewPosts
AS SELECT postId, postText, userId
FROM Post;
           
SELECT postId, postText, userId
FROM ViewPosts;

 


