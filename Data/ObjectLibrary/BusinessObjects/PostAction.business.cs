
#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion

namespace ObjectLibrary.BusinessObjects
{

    #region class PostAction
    [Serializable]
    public partial class PostAction
    {

        #region Private Variables
        private bool loadByProjectId;
        #endregion

        #region Constructor
        public PostAction()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public PostAction Clone()
            {
                // Create New Object
                PostAction newPostAction = (PostAction) this.MemberwiseClone();

                // Return Cloned Object
                return newPostAction;
            }
            #endregion

        #endregion

        #region Properties

            #region LoadByProjectId
            /// <summary>
            /// This property gets or sets the value for 'LoadByProjectId'.
            /// </summary>
            public bool LoadByProjectId
            {
                get { return loadByProjectId; }
                set { loadByProjectId = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
