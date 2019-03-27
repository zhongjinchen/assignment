CREATE TABLE [dbo].[TProblme] (
    [Id]              INT         IDENTITY (2, 2) NOT NULL,
    [Title]           NCHAR (100) NOT NULL,
    [Content]         NCHAR (500) NOT NULL,
    [NeedRemoteHelp]  BIT         DEFAULT ((1)) NULL,
    [Reward]          INT         DEFAULT ((10)) NOT NULL,
    [PublishDateTime] NCHAR (20)  NOT NULL,
    [Reply]           NCHAR (10)  NULL,
    [Summarize]       NCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [AK_Content] UNIQUE NONCLUSTERED ([Content] ASC),
    CONSTRAINT [CK_Reward] CHECK ([Reward] < (20))
);

