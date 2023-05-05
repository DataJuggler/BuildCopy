

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateExcludeFolderStoredProcedure
    /// <summary>
    /// This class is used to Update a 'ExcludeFolder' object.
    /// </summary>
    public class UpdateExcludeFolderStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateExcludeFolderStoredProcedure' object.
        /// </summary>
        public UpdateExcludeFolderStoredProcedure()
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
                this.ProcedureName = "ExcludeFolder_Update";

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
