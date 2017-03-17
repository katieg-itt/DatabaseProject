CREATE OR REPLACE PROCEDURE media_approved(pMediaId in NUMBER)
is
begin
  update media set status='a' where mediaId = pMediaId ;
end;


execute media_approved(5);





























select * from media;