USE [Proyecto]
GO
/****** Object:  Table [dbo].[autores]    Script Date: 20/07/2020 11:56:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autores](
	[id_autor] [int] NOT NULL,
	[nombre] [varchar](500) NULL,
 CONSTRAINT [PK_autores] PRIMARY KEY CLUSTERED 
(
	[id_autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estudiantes]    Script Date: 20/07/2020 11:56:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantes](
	[id_estudiante] [int] IDENTITY(1,1) NOT NULL,
	[identificacion] [numeric](20, 0) NOT NULL,
	[nombres] [varchar](100) NULL,
	[apellidos] [varchar](100) NULL,
 CONSTRAINT [PK_estudiantes] PRIMARY KEY CLUSTERED 
(
	[id_estudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estudiantes_revistas_libros]    Script Date: 20/07/2020 11:56:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantes_revistas_libros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Informacion] [int] NOT NULL,
	[id_estudiante] [int] NULL,
 CONSTRAINT [PK_estudiantes_informacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[generos]    Script Date: 20/07/2020 11:56:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[generos](
	[id_genero] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_generos_1] PRIMARY KEY CLUSTERED 
(
	[id_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[libros]    Script Date: 20/07/2020 11:56:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libros](
	[id_Libro] [int] IDENTITY(1,1) NOT NULL,
	[id_autor] [int] NULL,
	[id_genero] [int] NULL,
	[id_Informacion] [int] NULL,
 CONSTRAINT [PK_libros_1] PRIMARY KEY CLUSTERED 
(
	[id_Libro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[revistas]    Script Date: 20/07/2020 11:56:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[revistas](
	[id_revista] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo] [int] NULL,
	[id_Informacion] [int] NULL,
 CONSTRAINT [PK_revistas_1] PRIMARY KEY CLUSTERED 
(
	[id_revista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[revistas_libros]    Script Date: 20/07/2020 11:56:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[revistas_libros](
	[id_Informacion] [int] IDENTITY(1,1) NOT NULL,
	[numero_paginas] [int] NULL,
	[fecha_publicacion] [date] NULL,
	[descripcion_general] [varchar](500) NULL,
	[editorial] [varchar](200) NULL,
	[nombre] [varchar](100) NULL,
 CONSTRAINT [PK_informacion] PRIMARY KEY CLUSTERED 
(
	[id_Informacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_revistas]    Script Date: 20/07/2020 11:56:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_revistas](
	[id_tipo] [int] NOT NULL,
	[nombre_tipo] [varchar](50) NULL,
 CONSTRAINT [PK_tipo_revistas] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[autores] ([id_autor], [nombre]) VALUES (1, N'Mario Mendoza')
SET IDENTITY_INSERT [dbo].[estudiantes] ON 

INSERT [dbo].[estudiantes] ([id_estudiante], [identificacion], [nombres], [apellidos]) VALUES (1, CAST(12300123 AS Numeric(20, 0)), N'José', N'Blanco Álvarez')
SET IDENTITY_INSERT [dbo].[estudiantes] OFF
SET IDENTITY_INSERT [dbo].[estudiantes_revistas_libros] ON 

INSERT [dbo].[estudiantes_revistas_libros] ([id], [id_Informacion], [id_estudiante]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[estudiantes_revistas_libros] OFF
INSERT [dbo].[generos] ([id_genero], [nombre]) VALUES (1, N'Romance contemporáneo')
SET IDENTITY_INSERT [dbo].[libros] ON 

INSERT [dbo].[libros] ([id_Libro], [id_autor], [id_genero], [id_Informacion]) VALUES (1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[libros] OFF
SET IDENTITY_INSERT [dbo].[revistas] ON 

INSERT [dbo].[revistas] ([id_revista], [id_tipo], [id_Informacion]) VALUES (1, 1, 2)
SET IDENTITY_INSERT [dbo].[revistas] OFF
SET IDENTITY_INSERT [dbo].[revistas_libros] ON 

INSERT [dbo].[revistas_libros] ([id_Informacion], [numero_paginas], [fecha_publicacion], [descripcion_general], [editorial], [nombre]) VALUES (1, 172, CAST(N'1992-01-01' AS Date), N'La ciudad de los umbrales es una novela del escritor colombiano Mario Mendoza que ha sido catalogada como descarnadamente descriptiva, la novela le confiere al lector una habilidad de interpretación', N'Editorial Seix Barral', N'La ciudad de los umbrales')
INSERT [dbo].[revistas_libros] ([id_Informacion], [numero_paginas], [fecha_publicacion], [descripcion_general], [editorial], [nombre]) VALUES (2, 50, CAST(N'2020-07-20' AS Date), N'Revista enfocada a la actualidad automovilística', N'El Tiempo', N'Revista Motor')
SET IDENTITY_INSERT [dbo].[revistas_libros] OFF
INSERT [dbo].[tipo_revistas] ([id_tipo], [nombre_tipo]) VALUES (1, N'Automovilístico')
ALTER TABLE [dbo].[estudiantes_revistas_libros]  WITH CHECK ADD  CONSTRAINT [FK_estudiantes_informacion_estudiantes] FOREIGN KEY([id_estudiante])
REFERENCES [dbo].[estudiantes] ([id_estudiante])
GO
ALTER TABLE [dbo].[estudiantes_revistas_libros] CHECK CONSTRAINT [FK_estudiantes_informacion_estudiantes]
GO
ALTER TABLE [dbo].[estudiantes_revistas_libros]  WITH CHECK ADD  CONSTRAINT [FK_estudiantes_informacion_informacion] FOREIGN KEY([id_Informacion])
REFERENCES [dbo].[revistas_libros] ([id_Informacion])
GO
ALTER TABLE [dbo].[estudiantes_revistas_libros] CHECK CONSTRAINT [FK_estudiantes_informacion_informacion]
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_autores] FOREIGN KEY([id_autor])
REFERENCES [dbo].[autores] ([id_autor])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_autores]
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_generos1] FOREIGN KEY([id_genero])
REFERENCES [dbo].[generos] ([id_genero])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_generos1]
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_revistas_libros] FOREIGN KEY([id_Informacion])
REFERENCES [dbo].[revistas_libros] ([id_Informacion])
GO
ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_revistas_libros]
GO
ALTER TABLE [dbo].[revistas]  WITH CHECK ADD  CONSTRAINT [FK_revistas_revistas_libros] FOREIGN KEY([id_Informacion])
REFERENCES [dbo].[revistas_libros] ([id_Informacion])
GO
ALTER TABLE [dbo].[revistas] CHECK CONSTRAINT [FK_revistas_revistas_libros]
GO
ALTER TABLE [dbo].[revistas]  WITH CHECK ADD  CONSTRAINT [FK_revistas_tipo_revistas] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipo_revistas] ([id_tipo])
GO
ALTER TABLE [dbo].[revistas] CHECK CONSTRAINT [FK_revistas_tipo_revistas]
GO
