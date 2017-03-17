CREATE OR REPLACE TRIGGER SWEARWORDS 
BEFORE INSERT 
ON Post  
FOR EACH ROW
DECLARE
     text VARCHAR2(50);
BEGIN
     text := lower(:new.postText);
     IF REGEXP_LIKE('(duck|suck|balls)',text) THEN
      raise_application_error(-20030,'No swear words thanks' || ' ' ||
                          'Your score has been decremented as a penalty. ||
                          Your new score is: ' || ' ' ||
                           decrementScore(:new.postid));
      
  END IF;
END;

--This runs with decrementScore in functions folder