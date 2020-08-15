IF NOT EXISTS (SELECT * FROM sys.change_tracking_tables WHERE object_id = OBJECT_ID(N'[dbo].[Appointment]')) 
   ALTER TABLE [dbo].[Appointment] 
   ENABLE  CHANGE_TRACKING
GO
