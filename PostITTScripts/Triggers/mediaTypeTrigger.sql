CREATE OR REPLACE TRIGGER MEDIATYPEDESCTRIGGER 
BEFORE INSERT 
ON MEDIATYPE 
FOR EACH ROW

DECLARE
  MediaTypeDesc VARCHAR2(20);
  

BEGIN
MediaTypeDesc := lower(:new.MediaTypeDesc);
      IF NOT REGEXP_LIKE('^(?:[\w]\:|\\)(\\[a-z_\-\s0-9\.]+)+\.(docx|doc|pdf|java|html|txt|htm|jpg|jpeg|png|gif)$',MediaTypeDesc) THEN
        RAISE_APPLICATION_ERROR(-20090,'The file type you entered was invalid sorry... The suppported 
        formats are:' || '' || 'Images - .jpg, .jpeg, .png, .gif' || '' ||
        'Documents - .docx, .doc, .pdf, .java, .html, .txt, .htm');
    END IF;
END;
