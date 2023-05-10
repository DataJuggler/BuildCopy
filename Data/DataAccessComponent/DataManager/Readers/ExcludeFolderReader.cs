

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class ExcludeFolderReader
    /// <summary>
    /// This class loads a single 'ExcludeFolder' object or a list of type <ExcludeFolder>.
    /// </summary>
    public class ExcludeFolderReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'ExcludeFolder' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'ExcludeFolder' DataObject.</returns>
            public static ExcludeFolder Load(DataRow dataRow)
            {
                // Initial Value
                ExcludeFolder excludeFolder = new ExcludeFolder();

                // Create field Integers
                int fullPathfield = 0;
                int idfield = 1;
                int namefield = 2;
                int projectIdfield = 3;
                int skipContentfield = 4;

                try
                {
                    // Load Each field
                    excludeFolder.FullPath = DataHelper.ParseString(dataRow.ItemArray[fullPathfield]);
                    excludeFolder.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    excludeFolder.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    excludeFolder.ProjectId = DataHelper.ParseInteger(dataRow.ItemArray[projectIdfield], 0);
                    excludeFolder.SkipContent = DataHelper.ParseBoolean(dataRow.ItemArray[skipContentfield], false);
                }
                catch
                {
                }

                // return value
                return excludeFolder;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'ExcludeFolder' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A ExcludeFolder Collection.</returns>
            public static List<ExcludeFolder> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<ExcludeFolder> excludeFolders = new List<ExcludeFolder>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'ExcludeFolder' from rows
                        ExcludeFolder excludeFolder = Load(row);

                        // Add this object to collection
                        excludeFolders.Add(excludeFolder);
                    }
                }
                catch
                {
                }

                // return value
                return excludeFolders;
            }
            #endregion

        #endregion

    }
    #endregion

}
