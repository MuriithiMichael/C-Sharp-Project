IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[PatientDetails]')) 
   ALTER TABLE [dbo].[PatientDetails] 
   ENABLE  CHANGE_TRACKING
GO
