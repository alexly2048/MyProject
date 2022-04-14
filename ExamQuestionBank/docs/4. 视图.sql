-- 1. QUESTION_SUBJECT_ANSWER
IF(OBJECT_ID('V_QUESTIONS') IS NOT NULL)
DROP VIEW V_QUESTIONS;
GO
CREATE VIEW V_QUESTIONS
AS
    SELECT S.ID AS SUBJECT_ID,
           S.SUBJECT_GUID,
           S.SUBJECT_TYPE,
           S.COURSE_CODE,
           S.DIFFICULTY_LEVEL,
           S.IS_ENABLE,
           C.COURSE_NAME,
           S.GRADE_CODE,
           G.GRADE_NAME,
           D.ID AS DESCRPITION_ID,
           D.DESCRIPTION,
           Q.ID AS QUESTION_ID,
           Q.QUESTION_TYPE,
           Q.QUESTION_GUID,
           Q.QUESTION_CONTENT,
           Q.SCORE,
           A.ID AS ANSWER_ID,
           A.ANSWER_CONTENT FROM T_SUBJECT AS S 
           LEFT JOIN T_COURSE AS C ON S.COURSE_CODE=C.COURSE_CODE
           LEFT JOIN T_GRADE AS G ON S.GRADE_CODE = G.GRADE_CODE
           LEFT JOIN T_QUESTION AS Q ON S.SUBJECT_GUID=Q.SUBJECT_GUID
        LEFT JOIN T_ANSWER AS A ON A.QUESTION_GUID = Q.QUESTION_GUID
        LEFT JOIN T_SUBJECT_DESCRIPTION AS D ON S.SUBJECT_GUID=D.SUBJECT_GUID;
GO       
-- 2. V_EXAM_BANK
IF(OBJECT_ID('V_EXAM_BANK') IS NOT NULL)
DROP VIEW V_EXAM_BANK;
GO
CREATE VIEW V_EXAM_BANK
AS
    SELECT E.ID AS DISPLAY_ID,
           E.IS_ENABLE,
           E.COURSE_CODE,
		   C.COURSE_NAME,
		   E.GRADE_CODE,
		   G.GRADE_NAME,
		   E.EXAM_GUID,
		   E.SUBJECT_TYPE,
		   E.VERY_EASY,
		   E.EASY,
		   E.COMMON,
		   E.DIFFICULTY,
		   E.VERY_DIFFICULTY
	FROM T_EXAM_BANK AS E
		LEFT JOIN T_COURSE AS C ON E.COURSE_CODE = C.COURSE_CODE
		LEFT JOIN T_GRADE AS G ON E.GRADE_CODE = G.GRADE_CODE;
GO     
-- 3. V_USER_EXAM
IF(OBJECT_ID('V_USER_EXAM') IS NOT NULL)
DROP VIEW V_USER_EXAM;
GO
CREATE VIEW V_USER_EXAM
AS
    SELECT DISTINCT UE.ID,
           UE.USER_EXAM_GUID,
		   UE.USER_ID,
		   U.USERNAME AS USER_NAME,
		   UE.EXAM_GUID,
		   EB.GRADE_CODE,
		   EB.GRADE_NAME,
		   EB.COURSE_CODE,
		   EB.COURSE_NAME,
		   UE.IS_ENABLE,
		   UE.IS_COMPLETE,
		   UE.CREATE_DATE,
		   UE.COMPLETE_DATE					 
			FROM T_USER_EXAM AS UE
				INNER JOIN USERS AS U ON UE.USER_ID = U.USERID
				INNER JOIN V_EXAM_BANK AS EB ON UE.EXAM_GUID = EB.EXAM_GUID;
				
    
    