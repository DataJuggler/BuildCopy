

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteExcludeFolderStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'ExcludeFolder' object.
    /// </summary>
    public class DeleteExcludeFolderStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteExcludeFolderStoredProcedure' object.
        /// </summary>
        public DeleteExcludeFolderStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "ExcludeFolder_Delete";

                // Set tableName
                this.TableName = "ExcludeFolder";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
