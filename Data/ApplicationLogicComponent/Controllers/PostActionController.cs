

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

    #region class PostActionController
    /// <summary>
    /// This class controls a(n) 'PostAction' object.
    /// </summary>
    public class PostActionController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'PostActionController' object.
        /// </summary>
        public PostActionController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreatePostActionParameter
            /// <summary>
            /// This method creates the parameter for a 'PostAction' data operation.
            /// </summary>
            /// <param name='postaction'>The 'PostAction' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreatePostActionParameter(PostAction postAction)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = postAction;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(PostAction tempPostAction)
            /// <summary>
            /// Deletes a 'PostAction' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'PostAction_Delete'.
            /// </summary>
            /// <param name='postaction'>The 'PostAction' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(PostAction tempPostAction)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeletePostAction";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify temppostAction exists before attemptintg to delete
                    if(tempPostAction != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deletePostActionMethod = this.AppController.DataBridge.DataOperations.PostActionMethods.DeletePostAction;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreatePostActionParameter(tempPostAction);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deletePostActionMethod, parameters);

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

            #region FetchAll(PostAction tempPostAction)
            /// <summary>
            /// This method fetches a collection of 'PostAction' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'PostAction_FetchAll'.</summary>
            /// <param name='tempPostAction'>A temporary PostAction for passing values.</param>
            /// <returns>A collection of 'PostAction' objects.</returns>
            public List<PostAction> FetchAll(PostAction tempPostAction)
            {
                // Initial value
                List<PostAction> postActionList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.PostActionMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreatePostActionParameter(tempPostAction);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<PostAction> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        postActionList = (List<PostAction>) returnObject.ObjectValue;
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
                return postActionList;
            }
            #endregion

            #region Find(PostAction tempPostAction)
            /// <summary>
            /// Finds a 'PostAction' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'PostAction_Find'</param>
            /// </summary>
            /// <param name='tempPostAction'>A temporary PostAction for passing values.</param>
            /// <returns>A 'PostAction' object if found else a null 'PostAction'.</returns>
            public PostAction Find(PostAction tempPostAction)
            {
                // Initial values
                PostAction postAction = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempPostAction != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.PostActionMethods.FindPostAction;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreatePostActionParameter(tempPostAction);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as PostAction != null))
                        {
                            // Get ReturnObject
                            postAction = (PostAction) returnObject.ObjectValue;
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
                return postAction;
            }
            #endregion

            #region Insert(PostAction postAction)
            /// <summary>
            /// Insert a 'PostAction' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'PostAction_Insert'.</param>
            /// </summary>
            /// <param name='postAction'>The 'PostAction' object to insert.</param>
            /// <returns>The id (int) of the new  'PostAction' object that was inserted.</returns>
            public int Insert(PostAction postAction)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If PostActionexists
                    if(postAction != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.PostActionMethods.InsertPostAction;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreatePostActionParameter(postAction);

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

            #region Save(ref PostAction postAction)
            /// <summary>
            /// Saves a 'PostAction' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='postAction'>The 'PostAction' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref PostAction postAction)
            {
                // Initial value
                bool saved = false;

                // If the postAction exists.
                if(postAction != null)
                {
                    // Is this a new PostAction
                    if(postAction.IsNew)
                    {
                        // Insert new PostAction
                        int newIdentity = this.Insert(postAction);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            postAction.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update PostAction
                        saved = this.Update(postAction);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(PostAction postAction)
            /// <summary>
            /// This method Updates a 'PostAction' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'PostAction_Update'.</param>
            /// </summary>
            /// <param name='postAction'>The 'PostAction' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(PostAction postAction)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(postAction != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.PostActionMethods.UpdatePostAction;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreatePostActionParameter(postAction);
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
