

#region using statements

using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Project
    [Serializable]
    public partial class Project
    {

        #region Private Variables
        private List<ExcludeFolder> excludeFolders;
        #endregion

        #region Constructor
        public Project()
        {
            // Create a new collection of 'ExcludeFolder' objects.
            ExcludeFolders = new List<ExcludeFolder>();
        }
        #endregion

        #region Methods

            #region Clone()
            public Project Clone()
            {
                // Create New Object
                Project newProject = (Project) this.MemberwiseClone();

                // Return Cloned Object
                return newProject;
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

        #region ExcludeFolders
        /// <summary>
        /// This property gets or sets the value for 'ExcludeFolders'.
        /// </summary>
        public List<ExcludeFolder> ExcludeFolders
        {
            get { return excludeFolders; }
            set { excludeFolders = value; }
        }
        #endregion
            
        #region HasExcludeFolders
        /// <summary>
        /// This property returns true if this object has an 'ExcludeFolders'.
        /// </summary>
        public bool HasExcludeFolders
        {
            get
            {
                // initial value
                bool hasExcludeFolders = (this.ExcludeFolders != null);
                    
                // return value
                return hasExcludeFolders;
            }
        }
        #endregion
            
        #endregion

    }
    #endregion

}
