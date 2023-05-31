

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class PostActionWriterBase
    /// <summary>
    /// This class is used for converting a 'PostAction' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class PostActionWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(PostAction postAction)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='postAction'>The 'PostAction' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(PostAction postAction)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (postAction != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", postAction.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeletePostActionStoredProcedure(PostAction postAction)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeletePostAction'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'PostAction_Delete'.
            /// </summary>
            /// <param name="postAction">The 'PostAction' to Delete.</param>
            /// <returns>An instance of a 'DeletePostActionStoredProcedure' object.</returns>
            public static DeletePostActionStoredProcedure CreateDeletePostActionStoredProcedure(PostAction postAction)
            {
                // Initial Value
                DeletePostActionStoredProcedure deletePostActionStoredProcedure = new DeletePostActionStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deletePostActionStoredProcedure.Parameters = CreatePrimaryKeyParameter(postAction);

                // return value
                return deletePostActionStoredProcedure;
            }
            #endregion

            #region CreateFindPostActionStoredProcedure(PostAction postAction)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindPostActionStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'PostAction_Find'.
            /// </summary>
            /// <param name="postAction">The 'PostAction' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindPostActionStoredProcedure CreateFindPostActionStoredProcedure(PostAction postAction)
            {
                // Initial Value
                FindPostActionStoredProcedure findPostActionStoredProcedure = null;

                // verify postAction exists
                if(postAction != null)
                {
                    // Instanciate findPostActionStoredProcedure
                    findPostActionStoredProcedure = new FindPostActionStoredProcedure();

                    // Now create parameters for this procedure
                    findPostActionStoredProcedure.Parameters = CreatePrimaryKeyParameter(postAction);
                }

                // return value
                return findPostActionStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(PostAction postAction)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new postAction.
            /// </summary>
            /// <param name="postAction">The 'PostAction' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(PostAction postAction)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify postActionexists
                if(postAction != null)
                {
                    // Create [DestinationPath] parameter
                    param = new SqlParameter("@DestinationPath", postAction.DestinationPath);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [ProjectId] parameter
                    param = new SqlParameter("@ProjectId", postAction.ProjectId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [SourcePath] parameter
                    param = new SqlParameter("@SourcePath", postAction.SourcePath);

                    // set parameters[2]
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertPostActionStoredProcedure(PostAction postAction)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertPostActionStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'PostAction_Insert'.
            /// </summary>
            /// <param name="postAction"The 'PostAction' object to insert</param>
            /// <returns>An instance of a 'InsertPostActionStoredProcedure' object.</returns>
            public static InsertPostActionStoredProcedure CreateInsertPostActionStoredProcedure(PostAction postAction)
            {
                // Initial Value
                InsertPostActionStoredProcedure insertPostActionStoredProcedure = null;

                // verify postAction exists
                if(postAction != null)
                {
                    // Instanciate insertPostActionStoredProcedure
                    insertPostActionStoredProcedure = new InsertPostActionStoredProcedure();

                    // Now create parameters for this procedure
                    insertPostActionStoredProcedure.Parameters = CreateInsertParameters(postAction);
                }

                // return value
                return insertPostActionStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(PostAction postAction)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing postAction.
            /// </summary>
            /// <param name="postAction">The 'PostAction' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(PostAction postAction)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify postActionexists
                if(postAction != null)
                {
                    // Create parameter for [DestinationPath]
                    param = new SqlParameter("@DestinationPath", postAction.DestinationPath);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [ProjectId]
                    param = new SqlParameter("@ProjectId", postAction.ProjectId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [SourcePath]
                    param = new SqlParameter("@SourcePath", postAction.SourcePath);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", postAction.Id);
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdatePostActionStoredProcedure(PostAction postAction)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdatePostActionStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'PostAction_Update'.
            /// </summary>
            /// <param name="postAction"The 'PostAction' object to update</param>
            /// <returns>An instance of a 'UpdatePostActionStoredProcedure</returns>
            public static UpdatePostActionStoredProcedure CreateUpdatePostActionStoredProcedure(PostAction postAction)
            {
                // Initial Value
                UpdatePostActionStoredProcedure updatePostActionStoredProcedure = null;

                // verify postAction exists
                if(postAction != null)
                {
                    // Instanciate updatePostActionStoredProcedure
                    updatePostActionStoredProcedure = new UpdatePostActionStoredProcedure();

                    // Now create parameters for this procedure
                    updatePostActionStoredProcedure.Parameters = CreateUpdateParameters(postAction);
                }

                // return value
                return updatePostActionStoredProcedure;
            }
            #endregion

            #region CreateFetchAllPostActionsStoredProcedure(PostAction postAction)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllPostActionsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'PostAction_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllPostActionsStoredProcedure' object.</returns>
            public static FetchAllPostActionsStoredProcedure CreateFetchAllPostActionsStoredProcedure(PostAction postAction)
            {
                // Initial value
                FetchAllPostActionsStoredProcedure fetchAllPostActionsStoredProcedure = new FetchAllPostActionsStoredProcedure();

                // return value
                return fetchAllPostActionsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
