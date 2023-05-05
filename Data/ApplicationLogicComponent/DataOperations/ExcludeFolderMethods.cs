

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

    #region class ExcludeFolderMethods
    /// <summary>
    /// This class contains methods for modifying a 'ExcludeFolder' object.
    /// </summary>
    public class ExcludeFolderMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ExcludeFolderMethods' object.
        /// </summary>
        public ExcludeFolderMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteExcludeFolder(ExcludeFolder)
            /// <summary>
            /// This method deletes a 'ExcludeFolder' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ExcludeFolder' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteExcludeFolder(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteExcludeFolderStoredProcedure deleteExcludeFolderProc = null;

                    // verify the first parameters is a(n) 'ExcludeFolder'.
                    if (parameters[0].ObjectValue as ExcludeFolder != null)
                    {
                        // Create ExcludeFolder
                        ExcludeFolder excludeFolder = (ExcludeFolder) parameters[0].ObjectValue;

                        // verify excludeFolder exists
                        if(excludeFolder != null)
                        {
                            // Now create deleteExcludeFolderProc from ExcludeFolderWriter
                            // The DataWriter converts the 'ExcludeFolder'
                            // to the SqlParameter[] array needed to delete a 'ExcludeFolder'.
                            deleteExcludeFolderProc = ExcludeFolderWriter.CreateDeleteExcludeFolderStoredProcedure(excludeFolder);
                        }
                    }

                    // Verify deleteExcludeFolderProc exists
                    if(deleteExcludeFolderProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.ExcludeFolderManager.DeleteExcludeFolder(deleteExcludeFolderProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'ExcludeFolder' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ExcludeFolder' to delete.
            /// <returns>A PolymorphicObject object with all  'ExcludeFolders' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<ExcludeFolder> excludeFolderListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllExcludeFoldersStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get ExcludeFolderParameter
                    // Declare Parameter
                    ExcludeFolder paramExcludeFolder = null;

                    // verify the first parameters is a(n) 'ExcludeFolder'.
                    if (parameters[0].ObjectValue as ExcludeFolder != null)
                    {
                        // Get ExcludeFolderParameter
                        paramExcludeFolder = (ExcludeFolder) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllExcludeFoldersProc from ExcludeFolderWriter
                    fetchAllProc = ExcludeFolderWriter.CreateFetchAllExcludeFoldersStoredProcedure(paramExcludeFolder);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    excludeFolderListCollection = this.DataManager.ExcludeFolderManager.FetchAllExcludeFolders(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(excludeFolderListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = excludeFolderListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FindExcludeFolder(ExcludeFolder)
            /// <summary>
            /// This method finds a 'ExcludeFolder' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ExcludeFolder' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindExcludeFolder(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ExcludeFolder excludeFolder = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindExcludeFolderStoredProcedure findExcludeFolderProc = null;

                    // verify the first parameters is a 'ExcludeFolder'.
                    if (parameters[0].ObjectValue as ExcludeFolder != null)
                    {
                        // Get ExcludeFolderParameter
                        ExcludeFolder paramExcludeFolder = (ExcludeFolder) parameters[0].ObjectValue;

                        // verify paramExcludeFolder exists
                        if(paramExcludeFolder != null)
                        {
                            // Now create findExcludeFolderProc from ExcludeFolderWriter
                            // The DataWriter converts the 'ExcludeFolder'
                            // to the SqlParameter[] array needed to find a 'ExcludeFolder'.
                            findExcludeFolderProc = ExcludeFolderWriter.CreateFindExcludeFolderStoredProcedure(paramExcludeFolder);
                        }

                        // Verify findExcludeFolderProc exists
                        if(findExcludeFolderProc != null)
                        {
                            // Execute Find Stored Procedure
                            excludeFolder = this.DataManager.ExcludeFolderManager.FindExcludeFolder(findExcludeFolderProc, dataConnector);

                            // if dataObject exists
                            if(excludeFolder != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = excludeFolder;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertExcludeFolder (ExcludeFolder)
            /// <summary>
            /// This method inserts a 'ExcludeFolder' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ExcludeFolder' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertExcludeFolder(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ExcludeFolder excludeFolder = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertExcludeFolderStoredProcedure insertExcludeFolderProc = null;

                    // verify the first parameters is a(n) 'ExcludeFolder'.
                    if (parameters[0].ObjectValue as ExcludeFolder != null)
                    {
                        // Create ExcludeFolder Parameter
                        excludeFolder = (ExcludeFolder) parameters[0].ObjectValue;

                        // verify excludeFolder exists
                        if(excludeFolder != null)
                        {
                            // Now create insertExcludeFolderProc from ExcludeFolderWriter
                            // The DataWriter converts the 'ExcludeFolder'
                            // to the SqlParameter[] array needed to insert a 'ExcludeFolder'.
                            insertExcludeFolderProc = ExcludeFolderWriter.CreateInsertExcludeFolderStoredProcedure(excludeFolder);
                        }

                        // Verify insertExcludeFolderProc exists
                        if(insertExcludeFolderProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.ExcludeFolderManager.InsertExcludeFolder(insertExcludeFolderProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateExcludeFolder (ExcludeFolder)
            /// <summary>
            /// This method updates a 'ExcludeFolder' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'ExcludeFolder' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateExcludeFolder(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                ExcludeFolder excludeFolder = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateExcludeFolderStoredProcedure updateExcludeFolderProc = null;

                    // verify the first parameters is a(n) 'ExcludeFolder'.
                    if (parameters[0].ObjectValue as ExcludeFolder != null)
                    {
                        // Create ExcludeFolder Parameter
                        excludeFolder = (ExcludeFolder) parameters[0].ObjectValue;

                        // verify excludeFolder exists
                        if(excludeFolder != null)
                        {
                            // Now create updateExcludeFolderProc from ExcludeFolderWriter
                            // The DataWriter converts the 'ExcludeFolder'
                            // to the SqlParameter[] array needed to update a 'ExcludeFolder'.
                            updateExcludeFolderProc = ExcludeFolderWriter.CreateUpdateExcludeFolderStoredProcedure(excludeFolder);
                        }

                        // Verify updateExcludeFolderProc exists
                        if(updateExcludeFolderProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.ExcludeFolderManager.UpdateExcludeFolder(updateExcludeFolderProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
                }

                // return value
                return returnObject;
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

        #endregion

    }
    #endregion

}
