IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[CheckUp]')) 
   ALTER TABLE [dbo].[CheckUp] 
   DISABLE  CHANGE_TRACKING
GO
