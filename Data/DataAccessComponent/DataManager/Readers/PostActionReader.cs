

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class PostActionReader
    /// <summary>
    /// This class loads a single 'PostAction' object or a list of type <PostAction>.
    /// </summary>
    public class PostActionReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'PostAction' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'PostAction' DataObject.</returns>
            public static PostAction Load(DataRow dataRow)
            {
                // Initial Value
                PostAction postAction = new PostAction();

                // Create field Integers
                int destinationPathfield = 0;
                int idfield = 1;
                int projectIdfield = 2;
                int sourcePathfield = 3;

                try
                {
                    // Load Each field
                    postAction.DestinationPath = DataHelper.ParseString(dataRow.ItemArray[destinationPathfield]);
                    postAction.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    postAction.ProjectId = DataHelper.ParseInteger(dataRow.ItemArray[projectIdfield], 0);
                    postAction.SourcePath = DataHelper.ParseString(dataRow.ItemArray[sourcePathfield]);
                }
                catch
                {
                }

                // return value
                return postAction;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'PostAction' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A PostAction Collection.</returns>
            public static List<PostAction> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<PostAction> postActions = new List<PostAction>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'PostAction' from rows
                        PostAction postAction = Load(row);

                        // Add this object to collection
                        postActions.Add(postAction);
                    }
                }
                catch
                {
                }

                // return value
                return postActions;
            }
            #endregion

        #endregion

    }
    #endregion

}
