CREATE OR REPLACE FUNCTION search_by_user(pUserName IN VARCHAR2)
RETURN sys_refcursor IS

  returnResult sys_refcursor;
BEGIN
  OPEN returnResult FOR
  SELECT USERID ,SURNAME ,POSTTEXT ,POSTTYPE ,CATEGORYNAME ,TAGNAME ,POSTRANK  
  FROM VIEWUSERPOSTSTYPECATTAGRANK 
  WHERE UPPER(SURNAME) like UPPER(pUserName) || '%';
  
  RETURN returnResult;
END;
show errors;

select search_by_user('Sayers')from dual;
select * from VIEWUSERPOSTSTYPECATTAGRANK;