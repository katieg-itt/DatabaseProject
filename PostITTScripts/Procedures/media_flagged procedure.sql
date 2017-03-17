CREATE OR REPLACE PROCEDURE media_flagged(pMediaId in NUMBER)
is
begin
  update media set status='f' where mediaId = pMediaId ;
end;


execute media_flagged(5);





























select * from media;

