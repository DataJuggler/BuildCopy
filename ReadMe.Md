﻿# Build Copy

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

BuildCopy will copy the files from a Visual Studio project (folder) to an output folder. In this case, the output folder is ProjectTemplates\Working\Templates. BuildCopy also allows you to set ignore folders, so I do not copy the .vs, .git, .bin, .obj, .templateconfig and a few others.

Here is a video showing you how to setup this project, build the data tier for Blazor Gallery, and build your own DataTier.Net projects.

How To Create A Nuget Package For A Blazor Site
https://youtu.be/K5WbNKUPDGs

# Want To Help Contribute to this project?
Volunteer to take the instructions from the video and write them out as step by step. Bonus with images and screen shots.

If you think this project is worth the price, please leave a star and / or subscribe to my YouTube channel: https://youtube.com/DataJuggler

Thanks
