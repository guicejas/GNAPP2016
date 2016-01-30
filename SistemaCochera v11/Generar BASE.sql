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
    [Clase_id] int  NOT NULL,
    [Caja_Id] int  NULL
);


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


-- Creating table 'Cajas'
CREATE TABLE [dbo].[Cajas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Total] decimal(10,2)  NOT NULL,
    [FechaHoraApertura] datetime  NULL,
    [FechaHoraCierre] datetime  NULL,
    [NroCaja] int  NULL
);


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
    [CodigoCierre] nvarchar(8)  NOT NULL
);


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


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [PK_Vehiculos]
    PRIMARY KEY CLUSTERED ([id] ASC);


-- Creating primary key on [id] in table 'Clases'
ALTER TABLE [dbo].[Clases]
ADD CONSTRAINT [PK_Clases]
    PRIMARY KEY CLUSTERED ([id] ASC);


-- Creating primary key on [Id] in table 'Cajas'
ALTER TABLE [dbo].[Cajas]
ADD CONSTRAINT [PK_Cajas]
    PRIMARY KEY CLUSTERED ([Id] ASC);


-- Creating primary key on [id] in table 'Sistemas'
ALTER TABLE [dbo].[Sistemas]
ADD CONSTRAINT [PK_Sistemas]
    PRIMARY KEY CLUSTERED ([id] ASC);


-- Creating primary key on [Codigo] in table 'Impresiones'
ALTER TABLE [dbo].[Impresiones]
ADD CONSTRAINT [PK_Impresiones]
    PRIMARY KEY CLUSTERED ([Codigo] ASC);


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


-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------