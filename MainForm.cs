

#region using statements

using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.Win.Controls.Enumerations;
using DataJuggler.UltimateHelper;
using ObjectLibrary.BusinessObjects;
using DataGateway;
using ApplicationLogicComponent.Connection;

#endregion

namespace BuildCopy
{

    #region class MainForm
    /// <summary>
    /// This class is the MainForm for this application.
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {

        #region Private Variables
        private EditModeEnum editMode;
        private bool excludeFolderEditMode;
        private Project selectedProject;
        private ExcludeFolder selectedExcludedFolder;
        private List<Project> projects;
        private Gateway gateway;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

        #region AddButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'AddButton' is clicked.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of a 'Project' object.
            SelectedProject = new Project();

            // Show the DetailsPanel
            UIEnable();

            // Update the UI
            DisplaySelectedProject();

            // Start in the name control
            NameControl.SetFocusToTextBox();

            // Set to Add
            EditMode = EditModeEnum.Add;
        }
        #endregion

        #region AddExcludedFolderButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'AddExcludedFolderButton' is clicked.
        /// </summary>
        private void AddExcludedFolderButton_Click(object sender, EventArgs e)
        {
            // Set the SelectedProject
            if (HasSelectedProject)
            {
                // This shows the ExcludedFolderControl which allows user to select a folder
                excludeFolderEditMode = true;

                // Set the SelectedExcludeFolder
                SelectedExcludedFolder = new ExcludeFolder();

                // Add this item
                SelectedProject.ExcludeFolders.Add(SelectedExcludedFolder);

                // Show the ExcludedFolderControl
                UIEnable();
            }
        }
        #endregion

        #region CancelSaveButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'CancelSaveButton' is clicked.
        /// </summary>
        private void CancelSaveButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region CopyButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'CopyButton' is clicked.
        /// </summary>
        private void CopyButton_Click(object sender, EventArgs e)
        {
            // if the value for HasSelectedProject is true
            if (HasSelectedProject)
            {
                // get the directory
                DirectoryInfo info = new DirectoryInfo(SelectedProject.Path);

                // get the folders
                DirectoryInfo[] directories = info.GetDirectories();

                // Setup the Graph
                Graph.Maximum = directories.Length;
                Graph.Value = 0;
                Graph.Visible = true;
                StatusLabel.Text = "Copying directories, please wait";
                StatusLabel.Visible = true;

                // Copy Files
                CopyFilesRecursively(SelectedProject.Path, SelectedProject.OutputPath);
            }
        }
        #endregion

        #region DeleteButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'DeleteButton' is clicked.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // if the value for HasSelectedProject is true
            if (HasSelectedProject)
            {
                // to do: Perform Delete

                // Reload
                LoadAndDisplayProjects();
            }
        }
        #endregion

        #region DeleteExcludedFolderButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'DeleteExcludedFolderButton' is clicked.
        /// </summary>
        private void DeleteExcludedFolderButton_Click(object sender, EventArgs e)
        {
            // if the value for HasSelectedExcludedFolder is true
            if (HasSelectedExcludedFolder)
            {
                // perform the delete
                bool deleted = Gateway.DeleteExcludeFolder(SelectedExcludedFolder.Id);

                // if the value for deleted is true
                if (deleted)
                {
                    // reload
                    SelectedProject.ExcludeFolders = Gateway.LoadExcludeFoldersForProjectId(SelectedProject.Id);

                    // redisplay
                    DisplayExcludeFolders();

                    // destory
                    SelectedExcludedFolder = null;

                    // Enable or disable controls
                    UIEnable();
                }
            }
        }
        #endregion

        #region EditButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'EditButton' is clicked.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Switch to Edit
            EditMode = EditModeEnum.Edit;

            // Update the UI
            DisplaySelectedProject();

            // Start in the name control
            NameControl.SetFocusToTextBox();

            // Enable Controls
            UIEnable();
        }
        #endregion

        #region ExcludedFoldersListBox_SelectedIndexChanged(object sender, EventArgs e)
        /// <summary>
        /// event is fired when a selection is made in the 'ExcludedFoldersListBox_'.
        /// </summary>
        private void ExcludedFoldersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the SelectedExcludedFolder
            SelectedExcludedFolder = ExcludedFoldersListBox.SelectedItem as ExcludeFolder;

            // Enable
            UIEnable();
        }
        #endregion

        #region OnTextChanged(Control sender, string text)
        /// <summary>
        /// event is fired when On Text Changed
        /// </summary>
        public void OnTextChanged(Control sender, string text)
        {
            // if the selected project exists            
            if ((HasSelectedProject) && (TextHelper.Exists(text)))
            {
                // if the NameControl
                if (sender.Name == NameControl.Name)
                {
                    // set the value
                    SelectedProject.Name = NameControl.Text;
                }
                else if (sender.Name == PathControl.Name)
                {
                    // set the value
                    SelectedProject.Path = PathControl.Text;
                }
                else if (sender.Name == OutputFolderControl.Name)
                {
                    // Set the value
                    SelectedProject.OutputPath = OutputFolderControl.Text;
                }
                // if the ExclludedFolder control
                if ((sender.Name == ExcludeFolderControl.Name) && (SelectedProject.HasExcludeFolders))
                {
                    // if the SelectedProject.ExcludedFolders collection exists
                    if ((ExcludeFolderEditMode) && (HasSelectedExcludedFolder))
                    {
                        // Create the info
                        DirectoryInfo info = new DirectoryInfo(text);

                        // Set the value
                        SelectedExcludedFolder.Name = info.Name;

                        // Set the FullName
                        selectedExcludedFolder.FullPath = info.FullName;

                        // redisplay
                        DisplayExcludeFolders();

                        // Erase
                        ExcludeFolderControl.Text = "";

                        // exit edit mode
                        ExcludeFolderEditMode = false;
                    }
                }
            }

            // Enable or disable controls
            UIEnable();
        }
        #endregion

        #region ProjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        /// <summary>
        /// event is fired when a selection is made in the 'ProjectsListBox_'.
        /// </summary>
        private void ProjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // to do: Cast the selected item as a Project once it exists
            SelectedProject = ProjectsListBox.SelectedItem as Project;

            // if the value for HasSelectedProject is true
            if (HasSelectedProject)
            {
                // Load the ExcludedFolder
                SelectedProject.ExcludeFolders = Gateway.LoadExcludeFoldersForProjectId(SelectedProject.Id);
            }

            // Display the selected project
            DisplaySelectedProject();
        }
        #endregion

        #region SaveButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'SaveButton' is clicked.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // if the value for HasSelectedProject is true
            if (HasSelectedProject)
            {
                // Save the project
                bool saved = Gateway.SaveProject(ref selectedProject);

                // if the value for saved is true
                if (saved)
                {
                    // perform the delete
                    Gateway.DeleteExcludeFolderByProjectId(SelectedProject.Id);

                    // Save the ExcludedFolders
                    if (SelectedProject.HasExcludeFolders)
                    {
                        // loop
                        foreach (ExcludeFolder folder in SelectedProject.ExcludeFolders)
                        {
                            // erase
                            folder.UpdateIdentity(0);

                            // perform the save
                            folder.ProjectId = SelectedProject.Id;

                            // make a copy
                            ExcludeFolder clone = folder.Clone();

                            // perform the save
                            saved = gateway.SaveExcludeFolder(ref clone);
                        }

                        // reload
                        SelectedProject.ExcludeFolders = Gateway.LoadExcludeFoldersForProjectId(SelectedProject.Id);
                    }

                    // reload
                    LoadAndDisplayProjects(SelectedProject.Name);
                }
            }
        }
        #endregion

        #endregion

        #region Methods

        #region CopyFilesRecursively()
        /// <summary>
        /// Copy Files Recursively
        /// </summary>
        public void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            // local
            bool skip = false;

            // if SelectedProject exists
            if (HasSelectedProject)
            {
                // if already exist
                if (!Directory.Exists(targetPath))
                {
                    // Create directory
                    Directory.CreateDirectory(targetPath);
                }

                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    // reset
                    skip = false;

                    // if there are one or more ExcludeFolders
                    if (ListHelper.HasOneOrMoreItems(SelectedProject.ExcludeFolders))
                    {
                        // iterate
                        foreach (ExcludeFolder folder in SelectedProject.ExcludeFolders)
                        {
                            if (dirPath.Contains(folder.FullPath))
                            {
                                // set to true
                                skip = true;

                                // break out of the loop
                                break;
                            }
                        }
                    }

                    // if not a skipped folder
                    if (!skip)
                    {
                        // get the new folder path
                        string newPath = dirPath.Replace(sourcePath, targetPath);

                        // if the old directory exists
                        if (Directory.Exists(newPath))
                        {
                            // Perform delete
                            Directory.Delete(newPath, true);
                        }

                        // Create the directory
                        Directory.CreateDirectory(newPath);
                    }

                    // if in range
                    if (Graph.Value < Graph.Maximum)
                    {
                        // increment
                        Graph.Value++;
                    }
                }

                // reset Graph for files
                string[] files = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);

                // reset
                Graph.Value = 0;
                Graph.Maximum = files.Length;
                StatusLabel.Text = "Copying files, please wait.";

                // Copy all the files & Replaces any files with the same name
                foreach (string newPath in files)
                {
                    // reset
                    skip = false;

                    // Create a new instance of a 'FileInfo' object.
                    FileInfo fileInfo = new FileInfo(newPath);

                    // if there are one or more ExcludeFolders
                    if (ListHelper.HasOneOrMoreItems(SelectedProject.ExcludeFolders))
                    {
                        // iterate
                        foreach (ExcludeFolder folder in SelectedProject.ExcludeFolders)
                        {
                            // if the DirectoryName for this file is in the excluded, then skip
                            if (fileInfo.Directory.FullName.Contains(folder.FullPath))
                            {
                                // set to true
                                skip = true;

                                // break out of the loop
                                break;
                            }
                        }
                    }

                    // if not skip
                    if (!skip)
                    {
                        // copy the file
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                    }

                    // if in range
                    if (Graph.Value < Graph.Maximum)
                    {
                        // increment
                        Graph.Value++;
                    }
                }
            }

            // Set to Finished
            StatusLabel.Text = "Done";

            // Hide
            Graph.Visible = false;
        }
        #endregion

        #region DisplayExcludeFolders(ExcludeFolder selectedExcludeFolder = null)
        /// <summary>
        /// Display Exclude Folders
        /// </summary>
        public void DisplayExcludeFolders(ExcludeFolder selectedExcludeFolder = null)
        {
            // clear the list            
            ExcludedFoldersListBox.Items.Clear();

            // locals
            int index = -1;
            int tempIndex = -1;

            // if the value for HasSelectedProject is true
            if ((HasSelectedProject) && (SelectedProject.HasExcludeFolders))
            {
                // loop through
                foreach (ExcludeFolder excludeFolder in SelectedProject.ExcludeFolders)
                {
                    // Increment the value for tempIndex
                    tempIndex++;

                    if (NullHelper.Exists(selectedExcludedFolder))
                    {
                        // if the ids match
                        if (excludeFolder.Id == selectedExcludedFolder.Id)
                        {
                            // set the selected idnex
                            index = tempIndex;
                        }
                    }

                    // Add this item
                    ExcludedFoldersListBox.Items.Add(excludeFolder);
                }

                // Set the value
                ExcludedFoldersListBox.SelectedIndex = index;
            }
        }
        #endregion

        #region DisplayProjects(string selectedProjectName = "")
        /// <summary>
        /// Display Projects
        /// </summary>
        public void DisplayProjects(string selectedProjectName = "")
        {
            // Clear the list            
            ProjectsListBox.Items.Clear();

            // local
            int index = -1;
            int selectedIndex = -1;

            // if the value for HasProjects is true
            if (HasProjects)
            {
                // Iterate the collection of object objects
                foreach (Project project in Projects)
                {
                    // Increment the value for index
                    index++;

                    // to do: Make sure Project overrides ToString() to return the Name of the Project.

                    // Add this object
                    ProjectsListBox.Items.Add(project);

                    // if this is the selected item
                    // to do: Switch this to Project.Name
                    string projectName = project.ToString();

                    // if this is the SelectedProject
                    if (TextHelper.IsEqual(selectedProjectName, projectName))
                    {
                        // reload
                        project.ExcludeFolders = Gateway.LoadExcludeFoldersForProjectId(project.Id);

                        // Set the selectedIndex
                        selectedIndex = index;
                    }
                }

                // Set the SelectedIndex
                ProjectsListBox.SelectedIndex = selectedIndex;
            }
        }
        #endregion

        #region DisplaySelectedProject()
        /// <summary>
        /// Display Selected Project
        /// </summary>
        public void DisplaySelectedProject()
        {
            // locals
            string name = "";
            string path = "";
            string outputPath = "";

            // to do: Set the values from the SelectedProject once it exists
            if (HasSelectedProject)
            {
                // set the values
                name = SelectedProject.Name;
                path = SelectedProject.Path;
                outputPath = SelectedProject.OutputPath;
            }

            // Set the name
            NameControl.Text = name;
            PathControl.Text = path;
            OutputFolderControl.Text = outputPath;

            // load the list box
            DisplayExcludeFolders();
        }
        #endregion

        #region Init()
        /// <summary>
        ///  This method performs initializations for this object.
        /// </summary>
        public void Init()
        {
            // Setup the listener
            NameControl.OnTextChangedListener = this;
            PathControl.OnTextChangedListener = this;
            OutputFolderControl.OnTextChangedListener = this;
            ExcludeFolderControl.OnTextChangedListener = this;

            // Create a new instance of a 'Gateway' object.
            Gateway = new Gateway(Connection.Name);

            // Load and Display the projects
            LoadAndDisplayProjects();

            // Enable or disable controls
            UIEnable();
        }
        #endregion

        #region LoadAndDisplayProjects(string selectedProjectName = "")
        /// <summary>
        /// Load And Display Projects
        /// </summary>
        public void LoadAndDisplayProjects(string selectedProjectName = "")
        {
            // Load the projects
            Projects = LoadProjects();

            // Display the list
            DisplayProjects(selectedProjectName);
        }
        #endregion

        #region LoadProjects()
        /// <summary>
        /// returns a list of Projects
        /// </summary>
        public List<Project> LoadProjects()
        {
            // initial value
            List<Project> projects = Gateway.LoadProjects();

            // return value
            return projects;
        }
        #endregion

        #region UIEnable()
        /// <summary>
        /// UI Enable
        /// </summary>
        public void UIEnable()
        {
            // Only show if ExcludeFolderEditMode is true
            ExcludeFolderControl.Visible = ExcludeFolderEditMode;
            DetailsPanel.Visible = HasSelectedProject;
            EditButton.Enabled = HasSelectedProject;
            DeleteButton.Enabled = HasSelectedProject;
            DeleteExcludedFolderButton.Enabled = HasSelectedExcludedFolder;
        }
        #endregion

        #endregion

        #region Properties

        #region EditMode
        /// <summary>
        /// This property gets or sets the value for 'EditMode'.
        /// </summary>
        public EditModeEnum EditMode
        {
            get { return editMode; }
            set { editMode = value; }
        }
        #endregion

        #region ExcludeFolderEditMode
        /// <summary>
        /// This property gets or sets the value for 'ExcludeFolderEditMode'.
        /// </summary>
        public bool ExcludeFolderEditMode
        {
            get { return excludeFolderEditMode; }
            set { excludeFolderEditMode = value; }
        }
        #endregion

        #region Gateway
        /// <summary>
        /// This property gets or sets the value for 'Gateway'.
        /// </summary>
        public Gateway Gateway
        {
            get { return gateway; }
            set { gateway = value; }
        }
        #endregion

        #region HasGateway
        /// <summary>
        /// This property returns true if this object has a 'Gateway'.
        /// </summary>
        public bool HasGateway
        {
            get
            {
                // initial value
                bool hasGateway = (this.Gateway != null);

                // return value
                return hasGateway;
            }
        }
        #endregion

        #region HasProjects
        /// <summary>
        /// This property returns true if this object has a 'Projects'.
        /// </summary>
        public bool HasProjects
        {
            get
            {
                // initial value
                bool hasProjects = (this.Projects != null);

                // return value
                return hasProjects;
            }
        }
        #endregion

        #region HasSelectedExcludedFolder
        /// <summary>
        /// This property returns true if this object has a 'SelectedExcludedFolder'.
        /// </summary>
        public bool HasSelectedExcludedFolder
        {
            get
            {
                // initial value
                bool hasSelectedExcludedFolder = (this.SelectedExcludedFolder != null);

                // return value
                return hasSelectedExcludedFolder;
            }
        }
        #endregion

        #region HasSelectedProject
        /// <summary>
        /// This property returns true if this object has a 'SelectedProject'.
        /// </summary>
        public bool HasSelectedProject
        {
            get
            {
                // initial value
                bool hasSelectedProject = (this.SelectedProject != null);

                // return value
                return hasSelectedProject;
            }
        }
        #endregion

        #region Projects
        /// <summary>
        /// This property gets or sets the value for 'Projects'.
        /// </summary>
        public List<Project> Projects
        {
            get { return projects; }
            set { projects = value; }
        }
        #endregion

        #region SelectedExcludedFolder
        /// <summary>
        /// This property gets or sets the value for 'SelectedExcludedFolder'.
        /// </summary>
        public ExcludeFolder SelectedExcludedFolder
        {
            get { return selectedExcludedFolder; }
            set { selectedExcludedFolder = value; }
        }
        #endregion

        #region SelectedProject
        /// <summary>
        /// This property gets or sets the value for 'SelectedProject'.
        /// </summary>
        public Project SelectedProject
        {
            get { return selectedProject; }
            set { selectedProject = value; }
        }
        #endregion

        #endregion

    }
    #endregion

}
