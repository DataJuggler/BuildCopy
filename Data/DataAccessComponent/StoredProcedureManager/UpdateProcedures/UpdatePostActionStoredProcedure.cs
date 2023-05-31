

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdatePostActionStoredProcedure
    /// <summary>
    /// This class is used to Update a 'PostAction' object.
    /// </summary>
    public class UpdatePostActionStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdatePostActionStoredProcedure' object.
        /// </summary>
        public UpdatePostActionStoredProcedure()
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
                this.ProcedureName = "PostAction_Update";

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
