

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindExcludeFolderStoredProcedure
    /// <summary>
    /// This class is used to Find a 'ExcludeFolder' object.
    /// </summary>
    public class FindExcludeFolderStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindExcludeFolderStoredProcedure' object.
        /// </summary>
        public FindExcludeFolderStoredProcedure()
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
                this.ProcedureName = "ExcludeFolder_Find";

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
