

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllPostActionsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'PostAction' objects.
    /// </summary>
    public class FetchAllPostActionsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllPostActionsStoredProcedure' object.
        /// </summary>
        public FetchAllPostActionsStoredProcedure()
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
                this.ProcedureName = "PostAction_FetchAll";

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
