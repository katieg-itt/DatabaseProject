CREATE OR REPLACE PROCEDURE createTag(tagDesc IN VARCHAR2, catid IN NUMBER)
IS
  cName VARCHAR(20);

BEGIN
        SELECT categoryName
        INTO cName
        FROM Category
        WHERE categoryId = catid;
        Dbms_Output.Put(tagDesc || ' tag was created in the ' || cName || ' category');
        INSERT INTO Tag(tagId, tagName, categoryId)
        VALUES(Tag_seq.NEXTVAL,tagDesc,catid); --Testing computing category
    
EXCEPTION WHEN NO_DATA_FOUND THEN
    DBMS_OUTPUT.PUT_LINE('Error creating the tag');

END;