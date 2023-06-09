

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class DataOperationsManager
    /// <summary>
    /// This class manages DataOperations for this project.
    /// </summary>
    public class DataOperationsManager
    {

        #region Private Variables
        private DataManager dataManager;
        private SystemMethods systemMethods;
        private ExcludeFolderMethods excludefolderMethods;
        private PostActionMethods postactionMethods;
        private ProjectMethods projectMethods;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'DataOperationsManager' object.
        /// </summary>
        public DataOperationsManager(DataManager dataManagerArg)
        {
            // Save Arguments
            this.DataManager = dataManagerArg;

            // Create Child DataOperationMethods
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Create Child DataOperationMethods
            /// </summary>
            private void Init()
            {
                // Create Child DataOperatonMethods
                this.SystemMethods = new SystemMethods();
                this.ExcludeFolderMethods = new ExcludeFolderMethods(this.DataManager);
                this.PostActionMethods = new PostActionMethods(this.DataManager);
                this.ProjectMethods = new ProjectMethods(this.DataManager);
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager
            public DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

            #region SystemMethods
            public SystemMethods SystemMethods
            {
                get { return systemMethods; }
                set { systemMethods = value; }
            }
            #endregion

            #region ExcludeFolderMethods
            public ExcludeFolderMethods ExcludeFolderMethods
            {
                get { return excludefolderMethods; }
                set { excludefolderMethods = value; }
            }
            #endregion

            #region PostActionMethods
            public PostActionMethods PostActionMethods
            {
                get { return postactionMethods; }
                set { postactionMethods = value; }
            }
            #endregion

            #region ProjectMethods
            public ProjectMethods ProjectMethods
            {
                get { return projectMethods; }
                set { projectMethods = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
