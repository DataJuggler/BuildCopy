
#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion

namespace ObjectLibrary.BusinessObjects
{

    #region class ExcludeFolder
    [Serializable]
    public partial class ExcludeFolder
    {

        #region Private Variables
        private bool loadByProjectId;
        private bool deleteByProjectId;
        #endregion

        #region Constructor
        public ExcludeFolder()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public ExcludeFolder Clone()
            {
                // Create New Object
                ExcludeFolder newExcludeFolder = (ExcludeFolder) this.MemberwiseClone();

                // Return Cloned Object
                return newExcludeFolder;
            }
            #endregion

            #region ToString()
            /// <summary>
            /// method returns the String
            /// </summary>
            public override string ToString()
            {
                // return value
                return Name;
            }
            #endregion

        #endregion

        #region Properties

            #region DeleteByProjectId
            /// <summary>
            /// This property gets or sets the value for 'DeleteByProjectId'.
            /// </summary>
            public bool DeleteByProjectId
            {
                get { return deleteByProjectId; }
                set { deleteByProjectId = value; }
            }
            #endregion

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
