CREATE TABLE [dbo].[MessageEntity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserEntityId] [int] NULL,
	[TextField] [nvarchar](30) NULL,
	[LengthField] [int] NULL,
	[LeaveDate] [datetime] NULL,
	[Stars] [smallint] NULL,
	[PaidMessage] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
/****** Object:  Index [ix_USER_ID]    Script Date: 31.10.2018 18:14:02 ******/
CREATE NONCLUSTERED INDEX [ix_USER_ID] ON [dbo].[MessageEntity]
(
	[UserEntityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO
ALTER TABLE [dbo].[MessageEntity]  WITH CHECK ADD FOREIGN KEY([UserEntityId])
REFERENCES [dbo].[UserEntity] ([Id])