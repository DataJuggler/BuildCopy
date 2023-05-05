

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class ExcludeFolderController
    /// <summary>
    /// This class controls a(n) 'ExcludeFolder' object.
    /// </summary>
    public class ExcludeFolderController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'ExcludeFolderController' object.
        /// </summary>
        public ExcludeFolderController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateExcludeFolderParameter
            /// <summary>
            /// This method creates the parameter for a 'ExcludeFolder' data operation.
            /// </summary>
            /// <param name='excludefolder'>The 'ExcludeFolder' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateExcludeFolderParameter(ExcludeFolder excludeFolder)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = excludeFolder;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(ExcludeFolder tempExcludeFolder)
            /// <summary>
            /// Deletes a 'ExcludeFolder' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'ExcludeFolder_Delete'.
            /// </summary>
            /// <param name='excludefolder'>The 'ExcludeFolder' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(ExcludeFolder tempExcludeFolder)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteExcludeFolder";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempexcludeFolder exists before attemptintg to delete
                    if(tempExcludeFolder != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteExcludeFolderMethod = this.AppController.DataBridge.DataOperations.ExcludeFolderMethods.DeleteExcludeFolder;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateExcludeFolderParameter(tempExcludeFolder);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteExcludeFolderMethod, parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Test For True
                            if (returnObject.Boolean.Value == NullableBooleanEnum.True)
                            {
                                // Set Deleted To True
                                deleted = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAll(ExcludeFolder tempExcludeFolder)
            /// <summary>
            /// This method fetches a collection of 'ExcludeFolder' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'ExcludeFolder_FetchAll'.</summary>
            /// <param name='tempExcludeFolder'>A temporary ExcludeFolder for passing values.</param>
            /// <returns>A collection of 'ExcludeFolder' objects.</returns>
            public List<ExcludeFolder> FetchAll(ExcludeFolder tempExcludeFolder)
            {
                // Initial value
                List<ExcludeFolder> excludeFolderList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.ExcludeFolderMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateExcludeFolderParameter(tempExcludeFolder);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<ExcludeFolder> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        excludeFolderList = (List<ExcludeFolder>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return excludeFolderList;
            }
            #endregion

            #region Find(ExcludeFolder tempExcludeFolder)
            /// <summary>
            /// Finds a 'ExcludeFolder' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'ExcludeFolder_Find'</param>
            /// </summary>
            /// <param name='tempExcludeFolder'>A temporary ExcludeFolder for passing values.</param>
            /// <returns>A 'ExcludeFolder' object if found else a null 'ExcludeFolder'.</returns>
            public ExcludeFolder Find(ExcludeFolder tempExcludeFolder)
            {
                // Initial values
                ExcludeFolder excludeFolder = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempExcludeFolder != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.ExcludeFolderMethods.FindExcludeFolder;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateExcludeFolderParameter(tempExcludeFolder);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as ExcludeFolder != null))
                        {
                            // Get ReturnObject
                            excludeFolder = (ExcludeFolder) returnObject.ObjectValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return excludeFolder;
            }
            #endregion

            #region Insert(ExcludeFolder excludeFolder)
            /// <summary>
            /// Insert a 'ExcludeFolder' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'ExcludeFolder_Insert'.</param>
            /// </summary>
            /// <param name='excludeFolder'>The 'ExcludeFolder' object to insert.</param>
            /// <returns>The id (int) of the new  'ExcludeFolder' object that was inserted.</returns>
            public int Insert(ExcludeFolder excludeFolder)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If ExcludeFolderexists
                    if(excludeFolder != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.ExcludeFolderMethods.InsertExcludeFolder;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateExcludeFolderParameter(excludeFolder);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, insertMethod , parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Set return value
                            newIdentity = returnObject.IntegerValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region Save(ref ExcludeFolder excludeFolder)
            /// <summary>
            /// Saves a 'ExcludeFolder' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='excludeFolder'>The 'ExcludeFolder' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref ExcludeFolder excludeFolder)
            {
                // Initial value
                bool saved = false;

                // If the excludeFolder exists.
                if(excludeFolder != null)
                {
                    // Is this a new ExcludeFolder
                    if(excludeFolder.IsNew)
                    {
                        // Insert new ExcludeFolder
                        int newIdentity = this.Insert(excludeFolder);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            excludeFolder.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update ExcludeFolder
                        saved = this.Update(excludeFolder);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(ExcludeFolder excludeFolder)
            /// <summary>
            /// This method Updates a 'ExcludeFolder' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'ExcludeFolder_Update'.</param>
            /// </summary>
            /// <param name='excludeFolder'>The 'ExcludeFolder' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(ExcludeFolder excludeFolder)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(excludeFolder != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.ExcludeFolderMethods.UpdateExcludeFolder;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateExcludeFolderParameter(excludeFolder);
                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, updateMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.Boolean != null) && (returnObject.Boolean.Value == NullableBooleanEnum.True))
                        {
                            // Set saved to true
                            saved = true;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
