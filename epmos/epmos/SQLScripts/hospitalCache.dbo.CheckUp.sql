IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[CheckUp]')) 
   ALTER TABLE [dbo].[CheckUp] 
   ENABLE  CHANGE_TRACKING
GO
