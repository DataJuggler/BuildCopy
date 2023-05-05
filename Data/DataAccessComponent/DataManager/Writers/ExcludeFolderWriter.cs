
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

    #region class ExcludeFolderWriter
    /// <summary>
    /// This class is used for converting a 'ExcludeFolder' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class ExcludeFolderWriter : ExcludeFolderWriterBase
    {

        #region Static Methods

            #region CreateDeleteExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteExcludeFolder'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'ExcludeFolder_Delete'.
            /// </summary>
            /// <param name="excludeFolder">The 'ExcludeFolder' to Delete.</param>
            /// <returns>An instance of a 'DeleteExcludeFolderStoredProcedure' object.</returns>
            public static new DeleteExcludeFolderStoredProcedure CreateDeleteExcludeFolderStoredProcedure(ExcludeFolder excludeFolder)
            {
                // Initial Value
                DeleteExcludeFolderStoredProcedure deleteExcludeFolderStoredProcedure = new DeleteExcludeFolderStoredProcedure();

                // if excludeFolder.DeleteByProjectId is true
                if (excludeFolder.DeleteByProjectId)
                {
                        // Change the procedure name
                        deleteExcludeFolderStoredProcedure.ProcedureName = "ExcludeFolder_DeleteByProjectId";
                        
                        // Create the @ProjectId parameter
                        deleteExcludeFolderStoredProcedure.Parameters = SqlParameterHelper.CreateSqlParameters("@ProjectId", excludeFolder.ProjectId);
                }
                else
                {
                    // Now Create Parameters For The DeleteProc
                    deleteExcludeFolderStoredProcedure.Parameters = CreatePrimaryKeyParameter(excludeFolder);
                }

                // return value
                return deleteExcludeFolderStoredProcedure;
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
            public static new FetchAllExcludeFoldersStoredProcedure CreateFetchAllExcludeFoldersStoredProcedure(ExcludeFolder excludeFolder)
            {
                // Initial value
                FetchAllExcludeFoldersStoredProcedure fetchAllExcludeFoldersStoredProcedure = new FetchAllExcludeFoldersStoredProcedure();

                // if the excludeFolder object exists
                if (excludeFolder != null)
                {
                    // if LoadByProjectId is true
                    if (excludeFolder.LoadByProjectId)
                    {
                        // Change the procedure name
                        fetchAllExcludeFoldersStoredProcedure.ProcedureName = "ExcludeFolder_FetchAllForProjectId";
                        
                        // Create the @ProjectId parameter
                        fetchAllExcludeFoldersStoredProcedure.Parameters = SqlParameterHelper.CreateSqlParameters("@ProjectId", excludeFolder.ProjectId);
                    }
                }
                
                // return value
                return fetchAllExcludeFoldersStoredProcedure;
            }
            #endregion
            
        #endregion

    }
    #endregion

}
