CREATE OR REPLACE PROCEDURE add_media(pMediaTypeId in NUMBER, pURL IN varchar2,pPostID IN NUMBER)
is
begin
  insert into media (mediaId,mediaTypeId,url,postId) values(media_seq.nextval,pMediaTypeId,pURL,pPostID);
end;













execute add_media(5,'documents\blabla.docx',3);
select * from media;
select * from mediaType order by 1;

select * from post;

