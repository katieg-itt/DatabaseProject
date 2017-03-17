CREATE OR REPLACE PROCEDURE media_disabled(pMediaId in NUMBER)
is
begin
  update media set status='d' where mediaId = pMediaId ;
end;


execute media_disabled(5);
































select * from media;