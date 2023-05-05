

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class ProjectReader
    /// <summary>
    /// This class loads a single 'Project' object or a list of type <Project>.
    /// </summary>
    public class ProjectReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Project' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Project' DataObject.</returns>
            public static Project Load(DataRow dataRow)
            {
                // Initial Value
                Project project = new Project();

                // Create field Integers
                int idfield = 0;
                int namefield = 1;
                int outputPathfield = 2;
                int pathfield = 3;

                try
                {
                    // Load Each field
                    project.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    project.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    project.OutputPath = DataHelper.ParseString(dataRow.ItemArray[outputPathfield]);
                    project.Path = DataHelper.ParseString(dataRow.ItemArray[pathfield]);
                }
                catch
                {
                }

                // return value
                return project;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Project' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Project Collection.</returns>
            public static List<Project> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Project> projects = new List<Project>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Project' from rows
                        Project project = Load(row);

                        // Add this object to collection
                        projects.Add(project);
                    }
                }
                catch
                {
                }

                // return value
                return projects;
            }
            #endregion

        #endregion

    }
    #endregion

}
