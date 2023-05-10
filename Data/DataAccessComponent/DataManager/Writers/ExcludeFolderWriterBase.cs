

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

    #region class ExcludeFolderWriterBase
    /// <summary>
    /// This class is used for converting a 'ExcludeFolder' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class ExcludeFolderWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='excludeFolder'>The 'ExcludeFolder' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(ExcludeFolder excludeFolder)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (excludeFolder != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", excludeFolder.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteExcludeFolder'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ExcludeFolder_Delete'.
            /// </summary>
            /// <param name="excludeFolder">The 'ExcludeFolder' to Delete.</param>
            /// <returns>An instance of a 'DeleteExcludeFolderStoredProcedure' object.</returns>
            public static DeleteExcludeFolderStoredProcedure CreateDeleteExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            {
                // Initial Value
                DeleteExcludeFolderStoredProcedure deleteExcludeFolderStoredProcedure = new DeleteExcludeFolderStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteExcludeFolderStoredProcedure.Parameters = CreatePrimaryKeyParameter(excludeFolder);

                // return value
                return deleteExcludeFolderStoredProcedure;
            }
            #endregion

            #region CreateFindExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindExcludeFolderStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ExcludeFolder_Find'.
            /// </summary>
            /// <param name="excludeFolder">The 'ExcludeFolder' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindExcludeFolderStoredProcedure CreateFindExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            {
                // Initial Value
                FindExcludeFolderStoredProcedure findExcludeFolderStoredProcedure = null;

                // verify excludeFolder exists
                if(excludeFolder != null)
                {
                    // Instanciate findExcludeFolderStoredProcedure
                    findExcludeFolderStoredProcedure = new FindExcludeFolderStoredProcedure();

                    // Now create parameters for this procedure
                    findExcludeFolderStoredProcedure.Parameters = CreatePrimaryKeyParameter(excludeFolder);
                }

                // return value
                return findExcludeFolderStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new excludeFolder.
            /// </summary>
            /// <param name="excludeFolder">The 'ExcludeFolder' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(ExcludeFolder excludeFolder)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify excludeFolderexists
                if(excludeFolder != null)
                {
                    // Create [FullPath] parameter
                    param = new SqlParameter("@FullPath", excludeFolder.FullPath);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", excludeFolder.Name);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [ProjectId] parameter
                    param = new SqlParameter("@ProjectId", excludeFolder.ProjectId);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [SkipContent] parameter
                    param = new SqlParameter("@SkipContent", excludeFolder.SkipContent);

                    // set parameters[3]
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertExcludeFolderStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ExcludeFolder_Insert'.
            /// </summary>
            /// <param name="excludeFolder"The 'ExcludeFolder' object to insert</param>
            /// <returns>An instance of a 'InsertExcludeFolderStoredProcedure' object.</returns>
            public static InsertExcludeFolderStoredProcedure CreateInsertExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            {
                // Initial Value
                InsertExcludeFolderStoredProcedure insertExcludeFolderStoredProcedure = null;

                // verify excludeFolder exists
                if(excludeFolder != null)
                {
                    // Instanciate insertExcludeFolderStoredProcedure
                    insertExcludeFolderStoredProcedure = new InsertExcludeFolderStoredProcedure();

                    // Now create parameters for this procedure
                    insertExcludeFolderStoredProcedure.Parameters = CreateInsertParameters(excludeFolder);
                }

                // return value
                return insertExcludeFolderStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing excludeFolder.
            /// </summary>
            /// <param name="excludeFolder">The 'ExcludeFolder' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(ExcludeFolder excludeFolder)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[5];
                SqlParameter param = null;

                // verify excludeFolderexists
                if(excludeFolder != null)
                {
                    // Create parameter for [FullPath]
                    param = new SqlParameter("@FullPath", excludeFolder.FullPath);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", excludeFolder.Name);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [ProjectId]
                    param = new SqlParameter("@ProjectId", excludeFolder.ProjectId);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [SkipContent]
                    param = new SqlParameter("@SkipContent", excludeFolder.SkipContent);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", excludeFolder.Id);
                    parameters[4] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateExcludeFolderStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ExcludeFolder_Update'.
            /// </summary>
            /// <param name="excludeFolder"The 'ExcludeFolder' object to update</param>
            /// <returns>An instance of a 'UpdateExcludeFolderStoredProcedure</returns>
            public static UpdateExcludeFolderStoredProcedure CreateUpdateExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            {
                // Initial Value
                UpdateExcludeFolderStoredProcedure updateExcludeFolderStoredProcedure = null;

                // verify excludeFolder exists
                if(excludeFolder != null)
                {
                    // Instanciate updateExcludeFolderStoredProcedure
                    updateExcludeFolderStoredProcedure = new UpdateExcludeFolderStoredProcedure();

                    // Now create parameters for this procedure
                    updateExcludeFolderStoredProcedure.Parameters = CreateUpdateParameters(excludeFolder);
                }

                // return value
                return updateExcludeFolderStoredProcedure;
            }
            #endregion

            #region CreateFetchAllExcludeFoldersStoredProcedure(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllExcludeFoldersStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ExcludeFolder_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllExcludeFoldersStoredProcedure' object.</returns>
            public static FetchAllExcludeFoldersStoredProcedure CreateFetchAllExcludeFoldersStoredProcedure(ExcludeFolder excludeFolder)
            {
                // Initial value
                FetchAllExcludeFoldersStoredProcedure fetchAllExcludeFoldersStoredProcedure = new FetchAllExcludeFoldersStoredProcedure();

                // return value
                return fetchAllExcludeFoldersStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
