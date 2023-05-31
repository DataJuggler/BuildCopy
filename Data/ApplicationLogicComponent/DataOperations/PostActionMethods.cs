

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

    #region class PostActionMethods
    /// <summary>
    /// This class contains methods for modifying a 'PostAction' object.
    /// </summary>
    public class PostActionMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'PostActionMethods' object.
        /// </summary>
        public PostActionMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeletePostAction(PostAction)
            /// <summary>
            /// This method deletes a 'PostAction' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'PostAction' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeletePostAction(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeletePostActionStoredProcedure deletePostActionProc = null;

                    // verify the first parameters is a(n) 'PostAction'.
                    if (parameters[0].ObjectValue as PostAction != null)
                    {
                        // Create PostAction
                        PostAction postAction = (PostAction) parameters[0].ObjectValue;

                        // verify postAction exists
                        if(postAction != null)
                        {
                            // Now create deletePostActionProc from PostActionWriter
                            // The DataWriter converts the 'PostAction'
                            // to the SqlParameter[] array needed to delete a 'PostAction'.
                            deletePostActionProc = PostActionWriter.CreateDeletePostActionStoredProcedure(postAction);
                        }
                    }

                    // Verify deletePostActionProc exists
                    if(deletePostActionProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.PostActionManager.DeletePostAction(deletePostActionProc, dataConnector);

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
            /// This method fetches all 'PostAction' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'PostAction' to delete.
            /// <returns>A PolymorphicObject object with all  'PostActions' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<PostAction> postActionListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllPostActionsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get PostActionParameter
                    // Declare Parameter
                    PostAction paramPostAction = null;

                    // verify the first parameters is a(n) 'PostAction'.
                    if (parameters[0].ObjectValue as PostAction != null)
                    {
                        // Get PostActionParameter
                        paramPostAction = (PostAction) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllPostActionsProc from PostActionWriter
                    fetchAllProc = PostActionWriter.CreateFetchAllPostActionsStoredProcedure(paramPostAction);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    postActionListCollection = this.DataManager.PostActionManager.FetchAllPostActions(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(postActionListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = postActionListCollection;
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

            #region FindPostAction(PostAction)
            /// <summary>
            /// This method finds a 'PostAction' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'PostAction' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindPostAction(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                PostAction postAction = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindPostActionStoredProcedure findPostActionProc = null;

                    // verify the first parameters is a 'PostAction'.
                    if (parameters[0].ObjectValue as PostAction != null)
                    {
                        // Get PostActionParameter
                        PostAction paramPostAction = (PostAction) parameters[0].ObjectValue;

                        // verify paramPostAction exists
                        if(paramPostAction != null)
                        {
                            // Now create findPostActionProc from PostActionWriter
                            // The DataWriter converts the 'PostAction'
                            // to the SqlParameter[] array needed to find a 'PostAction'.
                            findPostActionProc = PostActionWriter.CreateFindPostActionStoredProcedure(paramPostAction);
                        }

                        // Verify findPostActionProc exists
                        if(findPostActionProc != null)
                        {
                            // Execute Find Stored Procedure
                            postAction = this.DataManager.PostActionManager.FindPostAction(findPostActionProc, dataConnector);

                            // if dataObject exists
                            if(postAction != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = postAction;
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

            #region InsertPostAction (PostAction)
            /// <summary>
            /// This method inserts a 'PostAction' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'PostAction' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertPostAction(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                PostAction postAction = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertPostActionStoredProcedure insertPostActionProc = null;

                    // verify the first parameters is a(n) 'PostAction'.
                    if (parameters[0].ObjectValue as PostAction != null)
                    {
                        // Create PostAction Parameter
                        postAction = (PostAction) parameters[0].ObjectValue;

                        // verify postAction exists
                        if(postAction != null)
                        {
                            // Now create insertPostActionProc from PostActionWriter
                            // The DataWriter converts the 'PostAction'
                            // to the SqlParameter[] array needed to insert a 'PostAction'.
                            insertPostActionProc = PostActionWriter.CreateInsertPostActionStoredProcedure(postAction);
                        }

                        // Verify insertPostActionProc exists
                        if(insertPostActionProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.PostActionManager.InsertPostAction(insertPostActionProc, dataConnector);
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

            #region UpdatePostAction (PostAction)
            /// <summary>
            /// This method updates a 'PostAction' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'PostAction' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdatePostAction(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                PostAction postAction = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdatePostActionStoredProcedure updatePostActionProc = null;

                    // verify the first parameters is a(n) 'PostAction'.
                    if (parameters[0].ObjectValue as PostAction != null)
                    {
                        // Create PostAction Parameter
                        postAction = (PostAction) parameters[0].ObjectValue;

                        // verify postAction exists
                        if(postAction != null)
                        {
                            // Now create updatePostActionProc from PostActionWriter
                            // The DataWriter converts the 'PostAction'
                            // to the SqlParameter[] array needed to update a 'PostAction'.
                            updatePostActionProc = PostActionWriter.CreateUpdatePostActionStoredProcedure(postAction);
                        }

                        // Verify updatePostActionProc exists
                        if(updatePostActionProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.PostActionManager.UpdatePostAction(updatePostActionProc, dataConnector);

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
