CREATE OR REPLACE PROCEDURE LoadAFileProcedure
   ( dir_name   VARCHAR2,
     url  VARCHAR2
   )
 IS
  l_bfile   BFILE;
  l_clob    CLOB;
BEGIN
   l_bfile := BFILENAME('C:\test','text.txt');
   IF (dbms_lob.fileexists(l_bfile) = 1) THEN
      dbms_output.put_line('File Exists');
      INSERT INTO Media (MediaId,url)
        VALUES (Media_seq.NEXTVAL,
               EMPTY_CLOB()
      ) RETURN url INTO l_clob;
      L_BFILE := bfilename('C:\test', 'text.txt');
      dbms_lob.fileopen( l_bfile, dbms_lob.FILE_READONLY );
      dbms_lob.loadfromfile( l_clob, l_bfile, dbms_lob.getlength(l_bfile) );
      dbms_lob.fileclose( l_bfile );
      COMMIT;
   ELSE 
     dbms_output.put_line('File does not exist');
   END IF;   
END;