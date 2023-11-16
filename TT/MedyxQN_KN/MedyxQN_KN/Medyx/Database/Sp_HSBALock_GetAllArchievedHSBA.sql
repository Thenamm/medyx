 
 If Exists (select * from Sys.objects where object_id=OBJECT_ID(N'Sp_HSBALock_GetAllArchievedHSBA'))
	Begin
	drop procedure Sp_HSBALock_GetAllArchievedHSBA
	End
	Go
Create PROC [dbo].[Sp_HSBALock_GetAllArchievedHSBA]
(    
		@MaBAQL nvarchar(20)
)
AS
BEGIN
	set @MaBAQL=@MaBAQL+'%'
	-- GET Total of records
 

	-- GET records
SELECT ba.mabaQL,bal.*	
	FROM [HSBALock]	bal left join BenhAN ba on bal.MaHSBA=ba.MaBA
	where ba.mabaQL like @MaBAQL

 

	/*
		CAST('23:59' AS TIME)
		WHERE CAST(UpdateDate AS TIME)
	*/
END

/*
	declare @p4 int
set @p4=1
exec dbo.Sp_HSBALock_GetAllArchievedHSBA @IsLocked=1,@PageNo=1,@RecordsPerPage=15,@NumOfRecords=@p4 output
select @p4
*/			
	
