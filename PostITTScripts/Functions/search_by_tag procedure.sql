CREATE OR REPLACE FUNCTION search_by_tag(pTagName IN VARCHAR2)
RETURN sys_refcursor IS

  returnResult sys_refcursor;
BEGIN
  OPEN returnResult FOR
  SELECT USERID ,SURNAME ,POSTTEXT ,POSTTYPE ,CATEGORYNAME ,TAGNAME ,POSTRANK  
  FROM VIEWUSERPOSTSTYPECATTAGRANK 
  WHERE UPPER(TAGNAME) = UPPER(pTagName);
  
  RETURN returnResult;
END;
show errors;

select search_by_tag('Java')from dual;
select * from VIEWUSERPOSTSTYPECATTAGRANK;
select * from post















   
    
  
