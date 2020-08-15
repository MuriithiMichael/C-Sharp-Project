IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Login]')) 
   ALTER TABLE [dbo].[Login] 
   DISABLE  CHANGE_TRACKING
GO
