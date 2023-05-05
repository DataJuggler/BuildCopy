

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

    #region class ExcludeFolderManager
    /// <summary>
    /// This class is used to manage a 'ExcludeFolder' object.
    /// </summary>
    public class ExcludeFolderManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ExcludeFolderManager' object.
        /// </summary>
        public ExcludeFolderManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteExcludeFolder()
            /// <summary>
            /// This method deletes a 'ExcludeFolder' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteExcludeFolder(DeleteExcludeFolderStoredProcedure deleteExcludeFolderProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteExcludeFolderProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllExcludeFolders()
            /// <summary>
            /// This method fetches a  'List<ExcludeFolder>' object.
            /// This method uses the 'ExcludeFolders_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<ExcludeFolder>'</returns>
            /// </summary>
            public List<ExcludeFolder> FetchAllExcludeFolders(FetchAllExcludeFoldersStoredProcedure fetchAllExcludeFoldersProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<ExcludeFolder> excludeFolderCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allExcludeFoldersDataSet = this.DataHelper.LoadDataSet(fetchAllExcludeFoldersProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allExcludeFoldersDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allExcludeFoldersDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            excludeFolderCollection = ExcludeFolderReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return excludeFolderCollection;
            }
            #endregion

            #region FindExcludeFolder()
            /// <summary>
            /// This method finds a  'ExcludeFolder' object.
            /// This method uses the 'ExcludeFolder_Find' procedure.
            /// </summary>
            /// <returns>A 'ExcludeFolder' object.</returns>
            /// </summary>
            public ExcludeFolder FindExcludeFolder(FindExcludeFolderStoredProcedure findExcludeFolderProc, DataConnector databaseConnector)
            {
                // Initial Value
                ExcludeFolder excludeFolder = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet excludeFolderDataSet = this.DataHelper.LoadDataSet(findExcludeFolderProc, databaseConnector);

                    // Verify DataSet Exists
                    if(excludeFolderDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(excludeFolderDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load ExcludeFolder
                            excludeFolder = ExcludeFolderReader.Load(row);
                        }
                    }
                }

                // return value
                return excludeFolder;
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

            #region InsertExcludeFolder()
            /// <summary>
            /// This method inserts a 'ExcludeFolder' object.
            /// This method uses the 'ExcludeFolder_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertExcludeFolder(InsertExcludeFolderStoredProcedure insertExcludeFolderProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertExcludeFolderProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateExcludeFolder()
            /// <summary>
            /// This method updates a 'ExcludeFolder'.
            /// This method uses the 'ExcludeFolder_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateExcludeFolder(UpdateExcludeFolderStoredProcedure updateExcludeFolderProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateExcludeFolderProc, databaseConnector);
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
