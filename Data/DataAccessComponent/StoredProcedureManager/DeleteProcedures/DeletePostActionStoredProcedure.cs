

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeletePostActionStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'PostAction' object.
    /// </summary>
    public class DeletePostActionStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeletePostActionStoredProcedure' object.
        /// </summary>
        public DeletePostActionStoredProcedure()
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
                this.ProcedureName = "PostAction_Delete";

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
