insert into Cajas VALUES ( 0, Getdate(), null, 1)

insert into Sistemas VALUES ( '0', '-', 0,0,1,1,1,'1','1')

insert into Clases VALUES ('9', 'Estadias', 0,0,0,0,0,1)
insert into Clases VALUES ('1', 'Autos', 25,90,120,3,0,1)
insert into Clases VALUES ('2', 'Chatas', 30,100,140,3,0,1)

insert into Impresiones VALUES (1,'PRUEBA', '','','','','','','','','','')
insert into Impresiones VALUES (2,'PRUEBA', '','','','','','','','','','')
insert into Impresiones VALUES (3,'PRUEBA', '','','','','','','','','','')
insert into Impresiones VALUES (4,'PRUEBA', '','','','','','','','','','')

insert into Mensuales VALUES ('Galizia Roberto', 'Ford Fiesta','AAA-123','Ov Lagos 123','4351111','Salchicas Robert','Callao 222','20-25124856-4','A',1,1,1500,'24Hs',GETDATE(),'','')
insert into Mensuales VALUES ('Lara Veronica', 'Chevrolet Spark','BBB-479','Ov Lagos 123','4351111','Garcia Marcelo','Callao 222','20-85474256-4','A',2,1,950,'Diurno',GETDATE(),'','')
insert into Mensuales VALUES ('Pepe Mujica', '','BBB-479','Ov Lagos 123','4351111','','','','A',3,1,650,'',GETDATE(),'','')



/*** NEW ****/

insert into Cajas VALUES ( 0, Getdate(), null, 1)

GO
/****** Object:  Table [dbo].[Sistemas]    Script Date: 02/02/2016 13:06:10 ******/
SET IDENTITY_INSERT [dbo].[Sistemas] ON
INSERT [dbo].[Sistemas] ([id], [password], [NombreImpresora], [NumeracionTickets], [NumeracionCajas], [CheckSiempreTOP], [CheckSiempreMaximizado], [CheckCodigoCerrar], [CodigoCierre], [passwordWeb]) VALUES (1, N'0', N'EPSON TM-T88V Receipt', 1649, 156, 1, 1, 1, N'1', N'1')
SET IDENTITY_INSERT [dbo].[Sistemas] OFF
/****** Object:  Table [dbo].[Impresiones]    Script Date: 02/02/2016 13:06:10 ******/
INSERT [dbo].[Impresiones] ([Codigo], [Descripcion], [Encabezado1], [Encabezado2], [Encabezado3], [Encabezado4], [Encabezado5], [Pie1], [Pie2], [Pie3], [Pie4], [Pie5]) VALUES (1, N'Ticket Entrada', N'GARAGE NADIA', N'BALCARCE 440. ROSARIO', N'TEL: (0341) 153-374371', N'', N'', N'HORARIO VERANO:', N'LU-VIER: 07 A 23 HRS.', N'SABADOS: 07 A 14 Y 20.30 A 09 HRS.', N'DOMINGOS CERRADO A PARTIR DE 09:00 HRS', N'REABRIMOS LUNES 07:00 HRS')
INSERT [dbo].[Impresiones] ([Codigo], [Descripcion], [Encabezado1], [Encabezado2], [Encabezado3], [Encabezado4], [Encabezado5], [Pie1], [Pie2], [Pie3], [Pie4], [Pie5]) VALUES (2, N'Ticket Clase 9', N'GARAGE NADIA', N'BALCARCE 440. ROSARIO', N'TEL: (0341) 153-374371', N'', N'', N'HORARIO VERANO', N'LU-VIER: 07 A 23 HRS.', N'SABADOS: 07 A 14 Y 20.30 A 09 HRS.', N'DOMINGOS CERRADO A PARTIR DE 09:00 HRS', N'REABRIMOS LUNES 07:00 HRS')
INSERT [dbo].[Impresiones] ([Codigo], [Descripcion], [Encabezado1], [Encabezado2], [Encabezado3], [Encabezado4], [Encabezado5], [Pie1], [Pie2], [Pie3], [Pie4], [Pie5]) VALUES (3, N'Ticket Salida', N'GARAGE NADIA', N'BALCARCE 440. ROSARIO', N'TEL: (0341) 153-374371', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[Impresiones] ([Codigo], [Descripcion], [Encabezado1], [Encabezado2], [Encabezado3], [Encabezado4], [Encabezado5], [Pie1], [Pie2], [Pie3], [Pie4], [Pie5]) VALUES (4, N'Ticket Clase 9 Duplicado', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'')
/****** Object:  Table [dbo].[Clases]    Script Date: 02/02/2016 13:06:10 ******/
SET IDENTITY_INSERT [dbo].[Clases] ON
INSERT [dbo].[Clases] ([id], [Codigo], [Descripcion], [PrecioHora], [PrecioMediaEstadia], [PrecioEstadia], [TiempoCambioEstadia], [MinutosTolerancia], [Activo]) VALUES (1, N'9', N'Estadias', CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, 0, 1)
INSERT [dbo].[Clases] ([id], [Codigo], [Descripcion], [PrecioHora], [PrecioMediaEstadia], [PrecioEstadia], [TiempoCambioEstadia], [MinutosTolerancia], [Activo]) VALUES (2, N'1', N'AUTOS', CAST(32.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), CAST(140.00 AS Decimal(10, 2)), 4, 0, 1)
INSERT [dbo].[Clases] ([id], [Codigo], [Descripcion], [PrecioHora], [PrecioMediaEstadia], [PrecioEstadia], [TiempoCambioEstadia], [MinutosTolerancia], [Activo]) VALUES (3, N'2', N'CHATAS', CAST(36.00 AS Decimal(10, 2)), CAST(130.00 AS Decimal(10, 2)), CAST(150.00 AS Decimal(10, 2)), 4, 0, 1)
INSERT [dbo].[Clases] ([id], [Codigo], [Descripcion], [PrecioHora], [PrecioMediaEstadia], [PrecioEstadia], [TiempoCambioEstadia], [MinutosTolerancia], [Activo]) VALUES (4, N'3', N'MEDICOS', CAST(28.00 AS Decimal(10, 2)), CAST(130.00 AS Decimal(10, 2)), CAST(150.00 AS Decimal(10, 2)), 5, 0, 1)
INSERT [dbo].[Clases] ([id], [Codigo], [Descripcion], [PrecioHora], [PrecioMediaEstadia], [PrecioEstadia], [TiempoCambioEstadia], [MinutosTolerancia], [Activo]) VALUES (5, N'5', N'MOTOS', CAST(16.00 AS Decimal(10, 2)), CAST(70.00 AS Decimal(10, 2)), CAST(80.00 AS Decimal(10, 2)), 5, 0, 1)
SET IDENTITY_INSERT [dbo].[Clases] OFF


/*** MENSUALES NEW ***/


INSERT Mensuales VALUES ('LARA MARIA EUGENIA', 'TOYOTA COROLLA', 'IKZ 179', 'BALCARCE 447 1ER PISO', '4265162 155010253', 'LARA MARIA EUGENIA', 'BALCARCE 447 1ER PISO', '27-18485160-7', 'B', 1, 1, CAST(1800.00 AS Decimal(10, 2)), '24HS', CAST(0x00008A8400000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('EJERCITO DE SALVACION', 'RENAULT KANGOO', 'OUD 696', 'URQUIZA 2142', '4256739 153129532', '', '', '', 'B', 2, 0, CAST(950.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000927A00000000 AS DateTime), CAST(0x0000A59E00000000 AS DateTime), '')
INSERT Mensuales VALUES ('GALIZIA CRISTINA', 'RENAULT MEGANE', 'GAZ 447', 'OROÑO 419 PB B', '4254512 156956830 4264135 156134757 155853990', 'GALIZIA CRISTINA', 'OROÑO 419 PB B', '27-13509393-4', 'A', 3, 1, CAST(1800.00 AS Decimal(10, 2)), '24HS', CAST(0x000094B300000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('LARA VERONICA', 'CHEVROLET SPARK', 'PFR 215', 'BALCARCE 447 PB', '4265026/7', 'GARCIA MARCELO', 'BROWN 2126 PISO 2', '20-18487809-8', 'A', 4, 1, CAST(1150.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000959200000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('CIRCULO OFICIALES DE POLICIA DE LA PROV DE SANTA FE', 'RENAULT FLUENCE', 'KLC 777', 'URQUIZA 2152/54', '4254580', '', '', '', 'B', 5, 1, CAST(0.00 AS Decimal(10, 2)), '24S', CAST(0x0000961300000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('BERTOLI MARIANO', 'FIAT IDEA', 'HNC 245', 'TUCUMAN 2150 DTO 4', '156825026 155113551 4499178', '', '', '', 'B', 6, 1, CAST(1800.00 AS Decimal(10, 2)), '24HS', CAST(0x00009B0A00000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('JOAQUIN ANDRES', 'PEUGEOT 207', 'KAA 916', 'OROÑO 480 P12 DPTO C', '153741448', '', '', '', 'B', 7, 1, CAST(1100.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x00009EF700000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('AINSE MARIA DE LOS ANGELES', 'RENAULT SANDERO ', 'LKH 424', 'OROÑO 355', '156555604 4255052', 'COCINEROS ARGENTINOS SA', 'OROÑO 355 ROSARIO', '30-69480562-7', 'B', 8, 1, CAST(1150.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000A05300000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('MORGENSTERN MARCELA', 'RENAULT SANDERO ', 'MLB 159', 'BALCARCE 368', '155106873', 'MORGENSTERN MARCELA', 'BALCARCE 368', '23-17648994-4', 'A', 9, 1, CAST(1150.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000A05300000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('SIRI FEDERICO', 'VOLKSWAGEN SAVEIRO', 'NRX 964', 'TUCUMAN 2020 PISO7', '153022450', 'TRANS DATOS SA', 'CORDOBA 1452 PISO 11 ROSARIO', '30-67495522-3', 'A', 10, 0, CAST(900.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x0000A0BF00000000 AS DateTime), CAST(0x0000A59E00000000 AS DateTime), '')
INSERT Mensuales VALUES ('SINDICATO DEL VESTIDO', 'PEUGEOT 308', 'OHG 653', 'OROÑO 465', '4256726 4254599 156416016 153785411 (Alejandro)', '', '', '', 'B', 11, 1, CAST(2300.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000A17700000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), 'PEUGEOT 307  -GXW 727-')
INSERT Mensuales VALUES ('BELMONTE MARIANO', 'PEUGEOT 207', 'KGC 806', 'OROÑO 480 2DO A', '11 156 2147271', 'CAR SECURITY', 'SAN LORENZO 3887 OLIVOS ', '30-69874417-7', 'B', 12, 1, CAST(1100.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x0000A1B400000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), 'CHEVROLET AGILE -NKK 221- | VOLKSWAGEN SAVEIRO  -??? 901-')
INSERT Mensuales VALUES ('BAHIT CECILIA', 'RENAULT CLIO', 'MYA 681', 'NEWBERI 9041', '156920445', 'GRUPO ARGENTINO COLABORATIVO EN INVESTIGACION CLINICA SRL', 'AVENIDA CORRIENTES 753 1ER PISO  BUENOS AIRES', '30-71442897-3', 'A', 13, 1, CAST(1150.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000A22D00000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), 'HONDA CRV -??? 689-')
INSERT Mensuales VALUES ('RIGATUSO ADRIAN', 'BMW ', 'NEE 811', 'OROÑO 405', '156465636 4474646 156465634 (marisa)', 'RIGATUSO ADRIAN', 'OROÑO 405', '20-20812558-4', 'A', 14, 1, CAST(2600.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000A29700000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), 'RANGE ROVER -NLE 935-  |  HONDA CRV -GRW 981- | VOLVO S40 -GNX 711-')
INSERT Mensuales VALUES ('REVELANT GILDA', 'PEUGEOT 207', 'OPA 258', 'BALCARCE 473 1RO C', '4256799 03465-15416080', '', '', '', 'B', 15, 1, CAST(870.00 AS Decimal(10, 2)), '24HS', CAST(0x0000A2A600000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('SALINAS SILVINA', 'PEUGEOT 208', 'NCA 644', 'OROÑO 480 5TO C', '153579005 156829983 (trabajo)', 'FRESENIUS KABI SA', 'AVENIDA CABILDO 2677 CABA', '30-6929719-3', 'A', 17, 0, CAST(1500.00 AS Decimal(10, 2)), '24HS', CAST(0x0000A33E00000000 AS DateTime), CAST(0x0000A59E00000000 AS DateTime), '')
INSERT Mensuales VALUES ('TULLIANI MARIA ANGELICA', 'RENAULT DUSTER', 'LMP 191', 'URQUIZA 2153 2DO A', '0341-155630316', 'AGROPECUARIA DON DOMINGO', 'BELGRANO 738 WHEELWRIGHT SANTA FE', '30-68950633-6', 'A', 16, 1, CAST(1800.00 AS Decimal(10, 2)), '24HS', CAST(0x0000A2A600000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('LOPEZ PABLO ANDRES', 'CORSA CLASSIC ', 'JGO 324', 'BALCARCE 456 1RO B', '156375284', '', '', '', 'B', 18, 1, CAST(1300.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x0000A3B600000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('MAISONNAVE GASTO', 'FORD FIESTA', 'OKY 002', 'BALCARCE 571 PISO 1 DEPTO 1', '155327698', 'MAISONNAVE GASTON ORLANDO', 'TUCUMAN 1291 ROSARIO', '20-30685682-1', 'A', 19, 1, CAST(1800.00 AS Decimal(10, 2)), '24HS', CAST(0x0000A41B00000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('DAMONTE ANIBAL', 'AUDI A4', 'MBC 757', 'MAIPU 534 - MEDICO ICR', '155005144', 'DAMONTE ANIBAL', 'MAIPU 534 ROSARIO', '20-14888546-0', 'A', 20, 1, CAST(1150.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000A45600000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('AYALA SERGIO', 'CHEVROLET BLAZER', 'BEH 557', 'MORENO 511', '156237373 4495668', '', '', '', 'B', 21, 1, CAST(1200.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x0000A47600000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('D ANGELO NOELIA', 'MOTO MOTOMEL S2', 'KXW 438', 'BALCARCE 456 9NO  B', '156928649', '', '', '', 'B', 22, 1, CAST(300.00 AS Decimal(10, 2)), '24HS', CAST(0x0000A4C000000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('FURLAN MARIA CRISTINA', 'FORD FOCUS', 'KQG 452', 'SALVAT 1155', '153389644', 'CASTAGNO FABIO', 'SALVAT 1155 ROSARIO', '20-17412512-1', 'A', 23, 0, CAST(950.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000A50600000000 AS DateTime), CAST(0x0000A59E00000000 AS DateTime), '')
INSERT Mensuales VALUES ('POSTMA CAROLINA', 'MOTO GUERRERO G110', 'GCQ 993', 'GARCIA DEL COSIO 967 BIS', '155794719', '', '', '', 'B', 24, 1, CAST(360.00 AS Decimal(10, 2)), 'DIURNO', CAST(0x0000A54400000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('TRUCCO ALEJANDRO', 'FIAT PUNTO', 'JGT 753', 'BALCARCE 423 PISO 2', '152274123', '', '', '', 'B', 25, 1, CAST(1300.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x0000A56100000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('RENIERO DAVID', 'VOLKSWAGEN AMAROK', 'ORC 345', 'ORONO 480 3RO C', '3425957457', 'MINISTERIO DE SEGURIDAD', '1RA JUNTA 2823 SANTA FE', '30-99901844-7', 'B', 26, 1, CAST(1100.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x0000A58E00000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('SCIAMMARO PABLO', 'HONDA 250', 'DNA 250', 'TUCUMAN 2161 DTO 1', '153407641', '', '', '', 'B', 27, 1, CAST(600.00 AS Decimal(10, 2)), '24HS', CAST(0x0000A59900000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('MORENO ESTEBA', 'FORD F100', 'BUO 751', 'BALCARCE 481', '155150453', '', '', '', 'B', 28, 1, CAST(1200.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x0000A59A00000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')
INSERT Mensuales VALUES ('MASCIMO DAVID', 'PEUGEOT 308', 'MZV 308', 'BALCARCE 311 5A', '155497557', 'JOSE LUIS MASCIMO', 'ENTRE RIOS 3081 ROSARIO', '20-04692647-2', 'A', 29, 1, CAST(1100.00 AS Decimal(10, 2)), 'NOCTURNO', CAST(0x0000A59B00000000 AS DateTime), CAST(0x0000000000000000 AS DateTime), '')

