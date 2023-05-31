

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertPostActionStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'PostAction' object.
    /// </summary>
    public class InsertPostActionStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertPostActionStoredProcedure' object.
        /// </summary>
        public InsertPostActionStoredProcedure()
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
                this.ProcedureName = "PostAction_Insert";

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
