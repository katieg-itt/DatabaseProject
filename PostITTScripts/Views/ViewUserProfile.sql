--VIEW USER PROFILE
CREATE OR REPLACE VIEW ViewUserProfile
AS SELECT userId, firstName, surname, email, score, profilePic
FROM IttUser;
           
SELECT userId, firstName, surname, email, score, profilePic
FROM ViewUserProfile;
