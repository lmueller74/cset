USE [CSETWeb]
GO
/****** Object:  Table [dbo].[FINDING_CONTACT]    Script Date: 11/14/2018 3:57:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FINDING_CONTACT](
	[Finding_Id] [int] NOT NULL,
	[Assessment_Contact_Id] [int] NOT NULL,
	[IgnoreThis] [int] NULL,
	[Id] [uniqueidentifier] NULL,
 CONSTRAINT [PK_FINDING_CONTACT_1] PRIMARY KEY CLUSTERED 
(
	[Finding_Id] ASC,
	[Assessment_Contact_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FINDING_CONTACT]  WITH CHECK ADD  CONSTRAINT [FK_FINDING_CONTACT_ASSESSMENT_CONTACTS] FOREIGN KEY([Assessment_Contact_Id])
REFERENCES [dbo].[ASSESSMENT_CONTACTS] ([Assessment_Contact_Id])
GO
ALTER TABLE [dbo].[FINDING_CONTACT] CHECK CONSTRAINT [FK_FINDING_CONTACT_ASSESSMENT_CONTACTS]
GO
ALTER TABLE [dbo].[FINDING_CONTACT]  WITH CHECK ADD  CONSTRAINT [FK_FINDING_CONTACT_USER_DETAIL_INFORMATION] FOREIGN KEY([Id])
REFERENCES [dbo].[USER_DETAIL_INFORMATION] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[FINDING_CONTACT] CHECK CONSTRAINT [FK_FINDING_CONTACT_USER_DETAIL_INFORMATION]
GO
ALTER TABLE [dbo].[FINDING_CONTACT]  WITH CHECK ADD  CONSTRAINT [FK_FINDING_INDIVIDUAL_FINDING1] FOREIGN KEY([Finding_Id])
REFERENCES [dbo].[FINDING] ([Finding_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FINDING_CONTACT] CHECK CONSTRAINT [FK_FINDING_INDIVIDUAL_FINDING1]
GO
