USE [TreeStructure]
GO
SET IDENTITY_INSERT [dbo].[Nodes] ON 

INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (88, N'Root', NULL)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (89, N'Dir 1', 88)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (90, N'Dir 1.1', 89)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (91, N'Dir 1.1.1', 90)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (92, N'Dir 1.1.2', 90)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (93, N'Dir 1.3', 89)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (94, N'Dir 2', 88)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (95, N'Dir 3', 88)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (96, N'Dir 4', 88)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (97, N'Dir 4.1', 96)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (98, N'Dir 5', 88)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (99, N'Dir 3.', 95)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (100, N'Dir 3.2', 95)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (101, N'Dir 3.3', 95)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (102, N'Dir 3.4', 95)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (103, N'Dir 3.5', 95)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (104, N'Dir 2.1', 94)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (105, N'Dir 2.2', 94)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (106, N'Dir 2.3', 94)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (107, N'Dir 2.4', 94)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (108, N'Dir 1.2', 89)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (110, N'Dir 2.1.1', 104)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (111, N'Dir 1.1.1.1', 91)
INSERT [dbo].[Nodes] ([Id], [Name], [ParentID]) VALUES (122, N'Dir 1.2.1', 108)
SET IDENTITY_INSERT [dbo].[Nodes] OFF
GO
