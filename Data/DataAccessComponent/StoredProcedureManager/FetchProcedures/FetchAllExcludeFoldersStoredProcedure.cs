

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllExcludeFoldersStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'ExcludeFolder' objects.
    /// </summary>
    public class FetchAllExcludeFoldersStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllExcludeFoldersStoredProcedure' object.
        /// </summary>
        public FetchAllExcludeFoldersStoredProcedure()
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
                this.ProcedureName = "ExcludeFolder_FetchAll";

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
