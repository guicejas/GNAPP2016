--CREATE DATABASE SistemaCocheraBDTest

--USE SistemaCocheraBDTest

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Vehiculos'
CREATE TABLE [dbo].[Vehiculos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [DuplicadoNro] nchar(1)  NOT NULL,
    [Patente] nchar(3)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [FechaHoraEntrada] datetime  NOT NULL,
    [FechaHoraSalida] datetime  NULL,
    [Precio] decimal(10,2)  NULL,
    [NroTicket] int  NOT NULL,
    [Telefono] nvarchar(max)  NULL,
    [Clase_id] int  NOT NULL,
    [Caja_Id] int  NULL
);
GO

-- Creating table 'Clases'
CREATE TABLE [dbo].[Clases] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NULL,
    [PrecioHora] decimal(10,2)  NOT NULL,
    [PrecioMediaEstadia] decimal(10,2)  NOT NULL,
    [PrecioEstadia] decimal(10,2)  NOT NULL,
    [TiempoCambioEstadia] int  NULL,
    [MinutosTolerancia] int  NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Cajas'
CREATE TABLE [dbo].[Cajas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Total] decimal(10,2)  NOT NULL,
    [FechaHoraApertura] datetime  NULL,
    [FechaHoraCierre] datetime  NULL,
    [NroCaja] int  NULL
);
GO

-- Creating table 'Sistemas'
CREATE TABLE [dbo].[Sistemas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [password] nvarchar(8)  NOT NULL,
    [NombreImpresora] nvarchar(max)  NOT NULL,
    [NumeracionTickets] int  NULL,
    [NumeracionCajas] int  NULL,
    [CheckSiempreTOP] bit  NOT NULL,
    [CheckSiempreMaximizado] bit  NOT NULL,
    [CheckCodigoCerrar] bit  NOT NULL,
    [CodigoCierre] nvarchar(8)  NOT NULL,
    [passwordWeb] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Impresiones'
CREATE TABLE [dbo].[Impresiones] (
    [Codigo] int  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Encabezado1] nvarchar(50)  NULL,
    [Encabezado2] nvarchar(50)  NULL,
    [Encabezado3] nvarchar(50)  NULL,
    [Encabezado4] nvarchar(50)  NULL,
    [Encabezado5] nvarchar(50)  NULL,
    [Pie1] nvarchar(50)  NULL,
    [Pie2] nvarchar(50)  NULL,
    [Pie3] nvarchar(50)  NULL,
    [Pie4] nvarchar(50)  NULL,
    [Pie5] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Descuentos'
CREATE TABLE [dbo].[Descuentos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Monto] decimal(10,2)  NOT NULL,
    [Caja_Id] int  NOT NULL
);
GO

-- Creating table 'Mensuales'
CREATE TABLE [dbo].[Mensuales] (
    [id] int IDENTITY(1,1) NOT NULL,
    [NombreApellido] nvarchar(max)  NULL,
    [Vehiculo] nvarchar(max)  NULL,
    [Patente] nvarchar(max)  NULL,
    [Domicilio] nvarchar(max)  NULL,
    [Telefono] nvarchar(max)  NULL,
    [RazonSocial] nvarchar(max)  NULL,
    [DomicilioFiscal] nvarchar(max)  NULL,
    [CUIL] nvarchar(max)  NULL,
    [TipoFactura] nvarchar(max)  NULL,
    [Codigo] int  NOT NULL,
    [Activo] bit  NOT NULL,
    [PrecioSugerido] decimal(10,2)  NULL,
    [TipoMensual] nvarchar(max)  NULL,
    [FechaAlta] datetime  NOT NULL,
    [FechaBaja] datetime  NULL,
    [Observaciones] nvarchar(max)  NULL
);
GO

-- Creating table 'PagoMensuales'
CREATE TABLE [dbo].[PagoMensuales] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Monto] decimal(10,2)  NOT NULL,
    [MesSaldado] int  NULL,
    [Caja_Id] int  NULL,
    [Mensual_id] int  NOT NULL
);
GO

-- Creating table 'Recordatorios'
CREATE TABLE [dbo].[Recordatorios] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Mensaje] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [PK_Vehiculos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Clases'
ALTER TABLE [dbo].[Clases]
ADD CONSTRAINT [PK_Clases]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'Cajas'
ALTER TABLE [dbo].[Cajas]
ADD CONSTRAINT [PK_Cajas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'Sistemas'
ALTER TABLE [dbo].[Sistemas]
ADD CONSTRAINT [PK_Sistemas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Codigo] in table 'Impresiones'
ALTER TABLE [dbo].[Impresiones]
ADD CONSTRAINT [PK_Impresiones]
    PRIMARY KEY CLUSTERED ([Codigo] ASC);
GO

-- Creating primary key on [id] in table 'Descuentos'
ALTER TABLE [dbo].[Descuentos]
ADD CONSTRAINT [PK_Descuentos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Mensuales'
ALTER TABLE [dbo].[Mensuales]
ADD CONSTRAINT [PK_Mensuales]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'PagoMensuales'
ALTER TABLE [dbo].[PagoMensuales]
ADD CONSTRAINT [PK_PagoMensuales]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Recordatorios'
ALTER TABLE [dbo].[Recordatorios]
ADD CONSTRAINT [PK_Recordatorios]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Clase_id] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_VehiculoClase]
    FOREIGN KEY ([Clase_id])
    REFERENCES [dbo].[Clases]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VehiculoClase'
CREATE INDEX [IX_FK_VehiculoClase]
ON [dbo].[Vehiculos]
    ([Clase_id]);
GO

-- Creating foreign key on [Caja_Id] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_VehiculoCaja]
    FOREIGN KEY ([Caja_Id])
    REFERENCES [dbo].[Cajas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VehiculoCaja'
CREATE INDEX [IX_FK_VehiculoCaja]
ON [dbo].[Vehiculos]
    ([Caja_Id]);
GO

-- Creating foreign key on [Caja_Id] in table 'Descuentos'
ALTER TABLE [dbo].[Descuentos]
ADD CONSTRAINT [FK_DescuentoCaja]
    FOREIGN KEY ([Caja_Id])
    REFERENCES [dbo].[Cajas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DescuentoCaja'
CREATE INDEX [IX_FK_DescuentoCaja]
ON [dbo].[Descuentos]
    ([Caja_Id]);
GO

-- Creating foreign key on [Caja_Id] in table 'PagoMensuales'
ALTER TABLE [dbo].[PagoMensuales]
ADD CONSTRAINT [FK_CajaPagoMensual]
    FOREIGN KEY ([Caja_Id])
    REFERENCES [dbo].[Cajas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CajaPagoMensual'
CREATE INDEX [IX_FK_CajaPagoMensual]
ON [dbo].[PagoMensuales]
    ([Caja_Id]);
GO

-- Creating foreign key on [Mensual_id] in table 'PagoMensuales'
ALTER TABLE [dbo].[PagoMensuales]
ADD CONSTRAINT [FK_MensualPagoMensual]
    FOREIGN KEY ([Mensual_id])
    REFERENCES [dbo].[Mensuales]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MensualPagoMensual'
CREATE INDEX [IX_FK_MensualPagoMensual]
ON [dbo].[PagoMensuales]
    ([Mensual_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------