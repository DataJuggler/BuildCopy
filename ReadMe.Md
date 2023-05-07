# Build Copy

To run this app you will need SQL Server or SQL Server Express
1. In SQL Server Management Studio, create a database named BuildCopy.
2. Execute BuildCopyDatabase.sql located in the SQL folder of this project
3. Create a connectionstring to the above database and copy to your clipboard *
4. Create an environment variable named BuildCopyConnString and paste in the 
    connectionstring from step 3.

* DataTier.Net comes with a ConnectionStringBuilder app, located in the Tools folder.
https://github.com/DataJuggler/DataTier.Net

There is also a release version of DataTier.Net, that installs ConnectionStringBuilder as a stand alone app.

This project is used when I create Nuget packagtes for Blazor projects, so I can copy all the code I want to
the templates directory.

Video coming soon.