

#region using statements

using DataAccessComponent.DataManager.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager
{

    #region class PostActionManager
    /// <summary>
    /// This class is used to manage a 'PostAction' object.
    /// </summary>
    public class PostActionManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'PostActionManager' object.
        /// </summary>
        public PostActionManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeletePostAction()
            /// <summary>
            /// This method deletes a 'PostAction' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeletePostAction(DeletePostActionStoredProcedure deletePostActionProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deletePostActionProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllPostActions()
            /// <summary>
            /// This method fetches a  'List<PostAction>' object.
            /// This method uses the 'PostActions_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<PostAction>'</returns>
            /// </summary>
            public List<PostAction> FetchAllPostActions(FetchAllPostActionsStoredProcedure fetchAllPostActionsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<PostAction> postActionCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allPostActionsDataSet = this.DataHelper.LoadDataSet(fetchAllPostActionsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allPostActionsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allPostActionsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            postActionCollection = PostActionReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return postActionCollection;
            }
            #endregion

            #region FindPostAction()
            /// <summary>
            /// This method finds a  'PostAction' object.
            /// This method uses the 'PostAction_Find' procedure.
            /// </summary>
            /// <returns>A 'PostAction' object.</returns>
            /// </summary>
            public PostAction FindPostAction(FindPostActionStoredProcedure findPostActionProc, DataConnector databaseConnector)
            {
                // Initial Value
                PostAction postAction = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet postActionDataSet = this.DataHelper.LoadDataSet(findPostActionProc, databaseConnector);

                    // Verify DataSet Exists
                    if(postActionDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(postActionDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load PostAction
                            postAction = PostActionReader.Load(row);
                        }
                    }
                }

                // return value
                return postAction;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perorm Initialization For This Object
            /// </summary>
            private void Init()
            {
                // Create DataHelper object
                this.DataHelper = new DataHelper();
            }
            #endregion

            #region InsertPostAction()
            /// <summary>
            /// This method inserts a 'PostAction' object.
            /// This method uses the 'PostAction_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertPostAction(InsertPostActionStoredProcedure insertPostActionProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertPostActionProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdatePostAction()
            /// <summary>
            /// This method updates a 'PostAction'.
            /// This method uses the 'PostAction_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdatePostAction(UpdatePostActionStoredProcedure updatePostActionProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updatePostActionProc, databaseConnector);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region DataHelper
            /// <summary>
            /// This object uses the Microsoft Data
            /// Application Block to execute stored
            /// procedures.
            /// </summary>
            internal DataHelper DataHelper
            {
                get { return dataHelper; }
                set { dataHelper = value; }
            }
            #endregion

            #region DataManager
            /// <summary>
            /// A reference to this objects parent.
            /// </summary>
            internal DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
