CREATE OR REPLACE PROCEDURE createCategory(catDesc IN VARCHAR2)
IS

BEGIN
Dbms_Output.Put(catDesc || ' category was created');
INSERT INTO Category(categoryId,categoryName)
VALUES(Category_seq.NEXTVAL,catDesc);


END;