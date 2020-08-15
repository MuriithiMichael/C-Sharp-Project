IF EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[PatientHistory]')) 
   ALTER TABLE [dbo].[PatientHistory] 
   DISABLE  CHANGE_TRACKING
GO
