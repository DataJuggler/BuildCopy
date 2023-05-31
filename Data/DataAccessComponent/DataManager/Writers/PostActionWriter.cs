
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

    #region class PostActionWriter
    /// <summary>
    /// This class is used for converting a 'PostAction' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class PostActionWriter : PostActionWriterBase
    {

        #region Static Methods

            #region CreateFetchAllPostActionsStoredProcedure(PostAction postAction)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllPostActionsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'PostAction_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllPostActionsStoredProcedure' object.</returns>
            public static new FetchAllPostActionsStoredProcedure CreateFetchAllPostActionsStoredProcedure(PostAction postAction)
            {
                // Initial value
                FetchAllPostActionsStoredProcedure fetchAllPostActionsStoredProcedure = new FetchAllPostActionsStoredProcedure();

                // if the postAction object exists
                if (postAction != null)
                {
                    // if LoadByProjectId is true
                    if (postAction.LoadByProjectId)
                    {
                        // Change the procedure name
                        fetchAllPostActionsStoredProcedure.ProcedureName = "PostAction_FetchAllForProjectId";
                        
                        // Create the @ProjectId parameter
                        fetchAllPostActionsStoredProcedure.Parameters = SqlParameterHelper.CreateSqlParameters("@ProjectId", postAction.ProjectId);
                    }
                }
                
                // return value
                return fetchAllPostActionsStoredProcedure;
            }
            #endregion
            
        #endregion

    }
    #endregion

}
