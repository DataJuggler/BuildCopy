Use [BuildCopy]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ExcludeFolder_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Insert a new ExcludeFolder
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ExcludeFolder_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ExcludeFolder_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ExcludeFolder_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ExcludeFolder_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ExcludeFolder_Insert >>>'

    End

GO

Create PROCEDURE ExcludeFolder_Insert

    -- Add the parameters for the stored procedure here
    @FullPath nvarchar(255),
    @Name nvarchar(50),
    @ProjectId int,
    @SkipContent bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ExcludeFolder]
    ([FullPath],[Name],[ProjectId],[SkipContent])

    -- Begin Values List
    Values(@FullPath, @Name, @ProjectId, @SkipContent)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ExcludeFolder_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Update an existing ExcludeFolder
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ExcludeFolder_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ExcludeFolder_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ExcludeFolder_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ExcludeFolder_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ExcludeFolder_Update >>>'

    End

GO

Create PROCEDURE ExcludeFolder_Update

    -- Add the parameters for the stored procedure here
    @FullPath nvarchar(255),
    @Id int,
    @Name nvarchar(50),
    @ProjectId int,
    @SkipContent bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [ExcludeFolder]

    -- Update Each field
    Set [FullPath] = @FullPath,
    [Name] = @Name,
    [ProjectId] = @ProjectId,
    [SkipContent] = @SkipContent

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ExcludeFolder_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Find an existing ExcludeFolder
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ExcludeFolder_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ExcludeFolder_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ExcludeFolder_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ExcludeFolder_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ExcludeFolder_Find >>>'

    End

GO

Create PROCEDURE ExcludeFolder_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [FullPath],[Id],[Name],[ProjectId],[SkipContent]

    -- From tableName
    From [ExcludeFolder]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ExcludeFolder_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Delete an existing ExcludeFolder
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ExcludeFolder_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ExcludeFolder_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ExcludeFolder_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ExcludeFolder_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ExcludeFolder_Delete >>>'

    End

GO

Create PROCEDURE ExcludeFolder_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [ExcludeFolder]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ExcludeFolder_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Returns all ExcludeFolder objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ExcludeFolder_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ExcludeFolder_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ExcludeFolder_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ExcludeFolder_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ExcludeFolder_FetchAll >>>'

    End

GO

Create PROCEDURE ExcludeFolder_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [FullPath],[Id],[Name],[ProjectId],[SkipContent]

    -- From tableName
    From [ExcludeFolder]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: PostAction_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Insert a new PostAction
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('PostAction_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure PostAction_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.PostAction_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure PostAction_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure PostAction_Insert >>>'

    End

GO

Create PROCEDURE PostAction_Insert

    -- Add the parameters for the stored procedure here
    @DestinationPath nvarchar(255),
    @ProjectId int,
    @SourcePath nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [PostAction]
    ([DestinationPath],[ProjectId],[SourcePath])

    -- Begin Values List
    Values(@DestinationPath, @ProjectId, @SourcePath)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: PostAction_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Update an existing PostAction
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('PostAction_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure PostAction_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.PostAction_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure PostAction_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure PostAction_Update >>>'

    End

GO

Create PROCEDURE PostAction_Update

    -- Add the parameters for the stored procedure here
    @DestinationPath nvarchar(255),
    @Id int,
    @ProjectId int,
    @SourcePath nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [PostAction]

    -- Update Each field
    Set [DestinationPath] = @DestinationPath,
    [ProjectId] = @ProjectId,
    [SourcePath] = @SourcePath

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: PostAction_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Find an existing PostAction
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('PostAction_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure PostAction_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.PostAction_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure PostAction_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure PostAction_Find >>>'

    End

GO

Create PROCEDURE PostAction_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DestinationPath],[Id],[ProjectId],[SourcePath]

    -- From tableName
    From [PostAction]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: PostAction_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Delete an existing PostAction
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('PostAction_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure PostAction_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.PostAction_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure PostAction_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure PostAction_Delete >>>'

    End

GO

Create PROCEDURE PostAction_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [PostAction]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: PostAction_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Returns all PostAction objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('PostAction_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure PostAction_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.PostAction_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure PostAction_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure PostAction_FetchAll >>>'

    End

GO

Create PROCEDURE PostAction_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DestinationPath],[Id],[ProjectId],[SourcePath]

    -- From tableName
    From [PostAction]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Insert a new Project
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_Insert >>>'

    End

GO

Create PROCEDURE Project_Insert

    -- Add the parameters for the stored procedure here
    @Name nvarchar(50),
    @OutputPath nvarchar(255),
    @Path nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Project]
    ([Name],[OutputPath],[Path])

    -- Begin Values List
    Values(@Name, @OutputPath, @Path)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Update an existing Project
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_Update >>>'

    End

GO

Create PROCEDURE Project_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(50),
    @OutputPath nvarchar(255),
    @Path nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Project]

    -- Update Each field
    Set [Name] = @Name,
    [OutputPath] = @OutputPath,
    [Path] = @Path

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Find an existing Project
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_Find >>>'

    End

GO

Create PROCEDURE Project_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[OutputPath],[Path]

    -- From tableName
    From [Project]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Delete an existing Project
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_Delete >>>'

    End

GO

Create PROCEDURE Project_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Project]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Returns all Project objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_FetchAll >>>'

    End

GO

Create PROCEDURE Project_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[OutputPath],[Path]

    -- From tableName
    From [Project]

END

-- Begin Custom Methods


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ExcludeFolder_FetchAllForProjectId
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/31/2023
-- Description:    Returns all ExcludeFolder objects for the ProjectId given.
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ExcludeFolder_FetchAllForProjectId'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ExcludeFolder_FetchAllForProjectId

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ExcludeFolder_FetchAllForProjectId') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ExcludeFolder_FetchAllForProjectId >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ExcludeFolder_FetchAllForProjectId >>>'

    End

GO

Create PROCEDURE ExcludeFolder_FetchAllForProjectId

    -- Create @ProjectId Paramater
    @ProjectId int


AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [FullPath],[Id],[Name],[ProjectId],[SkipContent]

    -- From tableName
    From [ExcludeFolder]

    -- Load Matching Records
    Where [ProjectId] = @ProjectId

END


-- End Custom Methods

-- Thank you for using DataTier.Net.

