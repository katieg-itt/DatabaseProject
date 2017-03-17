create or replace PROCEDURE LoadABlobProcedure 
( 
  src_name VARCHAR2,
  dest_name VARCHAR2,
  profilePic BLOB
) IS
  src_bfile   BFILE;
  dest_file    BLOB;
BEGIN
   src_bfile := BFILENAME('C:\test','pic.jpg');
   IF (dbms_lob.fileexists(src_bfile) = 1) THEN
      dbms_output.put_line('File Exists');
      INSERT INTO IttUser (userId, profilePic)
        VALUES (IttUser_seq.NEXTVAL,                 
               EMPTY_BLOB()
      ) RETURN profilePic INTO dest_file;
      Src_BFILE := bfilename('C:\test', 'pic.jpg');
      dbms_lob.fileopen( src_bfile, dbms_lob.FILE_READONLY );
      dbms_lob.loadfromfile( dest_file, src_bfile, dbms_lob.getlength(src_bfile) );
      dbms_lob.fileclose( src_bfile );
      COMMIT;
   ELSE 
     dbms_output.put_line('File does not exist');
   END IF;   
END;