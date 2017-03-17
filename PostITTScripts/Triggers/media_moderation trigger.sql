Create or replace trigger media_moderation
before insert on media
For each row

Begin
	:new.status := 'p';
End;


execute add_media(5,'documents\blabla.docx',3);





















select * from media;
select * from mediaType order by 1;

select * from post;
