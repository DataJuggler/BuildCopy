

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertExcludeFolderStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'ExcludeFolder' object.
    /// </summary>
    public class InsertExcludeFolderStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertExcludeFolderStoredProcedure' object.
        /// </summary>
        public InsertExcludeFolderStoredProcedure()
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
                this.ProcedureName = "ExcludeFolder_Insert";

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
