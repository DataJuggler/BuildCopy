

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindPostActionStoredProcedure
    /// <summary>
    /// This class is used to Find a 'PostAction' object.
    /// </summary>
    public class FindPostActionStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindPostActionStoredProcedure' object.
        /// </summary>
        public FindPostActionStoredProcedure()
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
                this.ProcedureName = "PostAction_Find";

                // Set tableName
                this.TableName = "PostAction";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
