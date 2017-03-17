CREATE OR REPLACE FUNCTION search_by_category_name(pCategoryName IN VARCHAR2)
RETURN sys_refcursor IS

  returnResult sys_refcursor;
BEGIN
  OPEN returnResult FOR
  SELECT USERID ,SURNAME ,POSTTEXT ,POSTTYPE ,CATEGORYNAME ,TAGNAME ,POSTRANK  
  FROM VIEWUSERPOSTSTYPECATTAGRANK 
  WHERE UPPER(categoryName) = UPPER(pCategoryName);
  
  RETURN returnResult;
END;
show errors;

select search_by_category_name('Computing')from dual;







