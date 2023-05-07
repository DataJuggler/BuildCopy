

#region using statements


#endregion

namespace BuildCopy
{

    #region class MainForm
    /// <summary>
    /// This class is the designer for MainForm.
    /// </summary>
    partial class MainForm
    {

        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.Button DeleteButton;
        private DataJuggler.Win.Controls.Button EditButton;
        private DataJuggler.Win.Controls.Button AddButton;
        private ListBox ProjectsListBox;
        private Label ListLabel;
        private Label TitleLabel;
        #endregion

        #region Methods

        #region Dispose(bool disposing)
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region InitializeComponent()
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DeleteButton = new DataJuggler.Win.Controls.Button();
            EditButton = new DataJuggler.Win.Controls.Button();
            AddButton = new DataJuggler.Win.Controls.Button();
            ProjectsListBox = new ListBox();
            ListLabel = new Label();
            TitleLabel = new Label();
            DetailsPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            StatusLabel = new Label();
            Graph = new ProgressBar();
            CopyButton = new DataJuggler.Win.Controls.Button();
            ExcludeFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            DeleteExcludedFolderButton = new DataJuggler.Win.Controls.Button();
            AddExcludedFolderButton = new DataJuggler.Win.Controls.Button();
            ExcludedFoldersLabel = new Label();
            ExcludedFoldersListBox = new ListBox();
            OutputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            PathControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            CancelSaveButton = new DataJuggler.Win.Controls.Button();
            SaveButton = new DataJuggler.Win.Controls.Button();
            NameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            DetailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Transparent;
            DeleteButton.ButtonText = "Delete";
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.LemonChiffon;
            DeleteButton.Location = new Point(250, 582);
            DeleteButton.Margin = new Padding(4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(107, 44);
            DeleteButton.TabIndex = 12;
            DeleteButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Transparent;
            EditButton.ButtonText = "Edit";
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.LemonChiffon;
            EditButton.Location = new Point(132, 583);
            EditButton.Margin = new Padding(5, 4, 5, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(107, 44);
            EditButton.TabIndex = 11;
            EditButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Transparent;
            AddButton.ButtonText = "Add";
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.LemonChiffon;
            AddButton.Location = new Point(14, 582);
            AddButton.Margin = new Padding(5, 4, 5, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(107, 44);
            AddButton.TabIndex = 10;
            AddButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            AddButton.Click += AddButton_Click;
            // 
            // ProjectsListBox
            // 
            ProjectsListBox.FormattingEnabled = true;
            ProjectsListBox.ItemHeight = 15;
            ProjectsListBox.Location = new Point(12, 41);
            ProjectsListBox.Name = "ProjectsListBox";
            ProjectsListBox.Size = new Size(346, 529);
            ProjectsListBox.TabIndex = 9;
            ProjectsListBox.SelectedIndexChanged += ProjectsListBox_SelectedIndexChanged;
            // 
            // ListLabel
            // 
            ListLabel.AutoSize = true;
            ListLabel.BackColor = Color.Transparent;
            ListLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ListLabel.ForeColor = Color.LemonChiffon;
            ListLabel.Location = new Point(15, -30);
            ListLabel.Name = "ListLabel";
            ListLabel.Size = new Size(58, 18);
            ListLabel.TabIndex = 8;
            ListLabel.Text = "Ideas";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.LemonChiffon;
            TitleLabel.Location = new Point(12, 18);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(81, 18);
            TitleLabel.TabIndex = 14;
            TitleLabel.Text = "Projects";
            // 
            // DetailsPanel
            // 
            DetailsPanel.BackColor = Color.Transparent;
            DetailsPanel.Controls.Add(StatusLabel);
            DetailsPanel.Controls.Add(Graph);
            DetailsPanel.Controls.Add(CopyButton);
            DetailsPanel.Controls.Add(ExcludeFolderControl);
            DetailsPanel.Controls.Add(DeleteExcludedFolderButton);
            DetailsPanel.Controls.Add(AddExcludedFolderButton);
            DetailsPanel.Controls.Add(ExcludedFoldersLabel);
            DetailsPanel.Controls.Add(ExcludedFoldersListBox);
            DetailsPanel.Controls.Add(OutputFolderControl);
            DetailsPanel.Controls.Add(PathControl);
            DetailsPanel.Controls.Add(CancelSaveButton);
            DetailsPanel.Controls.Add(SaveButton);
            DetailsPanel.Controls.Add(NameControl);
            DetailsPanel.Dock = DockStyle.Right;
            DetailsPanel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DetailsPanel.Location = new Point(377, 0);
            DetailsPanel.Name = "DetailsPanel";
            DetailsPanel.Size = new Size(665, 648);
            DetailsPanel.TabIndex = 15;
            DetailsPanel.Visible = false;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(28, 502);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(612, 23);
            StatusLabel.TabIndex = 23;
            StatusLabel.Visible = false;
            // 
            // Graph
            // 
            Graph.Location = new Point(28, 534);
            Graph.Name = "Graph";
            Graph.Size = new Size(612, 23);
            Graph.TabIndex = 22;
            Graph.Visible = false;
            // 
            // CopyButton
            // 
            CopyButton.BackColor = Color.Transparent;
            CopyButton.ButtonText = "Copy";
            CopyButton.FlatStyle = FlatStyle.Flat;
            CopyButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CopyButton.ForeColor = Color.LemonChiffon;
            CopyButton.Location = new Point(28, 582);
            CopyButton.Margin = new Padding(6, 5, 6, 5);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(107, 44);
            CopyButton.TabIndex = 21;
            CopyButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            CopyButton.Click += CopyButton_Click;
            // 
            // ExcludeFolderControl
            // 
            ExcludeFolderControl.BackColor = Color.Transparent;
            ExcludeFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            ExcludeFolderControl.ButtonColor = Color.LemonChiffon;
            ExcludeFolderControl.ButtonImage = (Image)resources.GetObject("ExcludeFolderControl.ButtonImage");
            ExcludeFolderControl.ButtonWidth = 48;
            ExcludeFolderControl.DarkMode = false;
            ExcludeFolderControl.DisabledLabelColor = Color.Empty;
            ExcludeFolderControl.Editable = true;
            ExcludeFolderControl.EnabledLabelColor = Color.Empty;
            ExcludeFolderControl.Filter = null;
            ExcludeFolderControl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExcludeFolderControl.HideBrowseButton = false;
            ExcludeFolderControl.LabelBottomMargin = 0;
            ExcludeFolderControl.LabelColor = Color.LemonChiffon;
            ExcludeFolderControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExcludeFolderControl.LabelText = "Exclude:";
            ExcludeFolderControl.LabelTopMargin = 0;
            ExcludeFolderControl.LabelWidth = 120;
            ExcludeFolderControl.Location = new Point(29, 449);
            ExcludeFolderControl.Name = "ExcludeFolderControl";
            ExcludeFolderControl.OnTextChangedListener = null;
            ExcludeFolderControl.OpenCallback = null;
            ExcludeFolderControl.ScrollBars = ScrollBars.None;
            ExcludeFolderControl.SelectedPath = null;
            ExcludeFolderControl.Size = new Size(611, 32);
            ExcludeFolderControl.StartPath = null;
            ExcludeFolderControl.TabIndex = 20;
            ExcludeFolderControl.TextBoxBottomMargin = 0;
            ExcludeFolderControl.TextBoxDisabledColor = Color.Empty;
            ExcludeFolderControl.TextBoxEditableColor = Color.Empty;
            ExcludeFolderControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExcludeFolderControl.TextBoxTopMargin = 0;
            ExcludeFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            ExcludeFolderControl.Visible = false;
            // 
            // DeleteExcludedFolderButton
            // 
            DeleteExcludedFolderButton.BackColor = Color.Transparent;
            DeleteExcludedFolderButton.ButtonText = "Delete";
            DeleteExcludedFolderButton.FlatStyle = FlatStyle.Flat;
            DeleteExcludedFolderButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteExcludedFolderButton.ForeColor = Color.LemonChiffon;
            DeleteExcludedFolderButton.Location = new Point(366, 386);
            DeleteExcludedFolderButton.Margin = new Padding(4);
            DeleteExcludedFolderButton.Name = "DeleteExcludedFolderButton";
            DeleteExcludedFolderButton.Size = new Size(107, 44);
            DeleteExcludedFolderButton.TabIndex = 19;
            DeleteExcludedFolderButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            DeleteExcludedFolderButton.Click += DeleteExcludedFolderButton_Click;
            // 
            // AddExcludedFolderButton
            // 
            AddExcludedFolderButton.BackColor = Color.Transparent;
            AddExcludedFolderButton.ButtonText = "Add";
            AddExcludedFolderButton.FlatStyle = FlatStyle.Flat;
            AddExcludedFolderButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddExcludedFolderButton.ForeColor = Color.LemonChiffon;
            AddExcludedFolderButton.Location = new Point(237, 386);
            AddExcludedFolderButton.Margin = new Padding(4);
            AddExcludedFolderButton.Name = "AddExcludedFolderButton";
            AddExcludedFolderButton.Size = new Size(107, 44);
            AddExcludedFolderButton.TabIndex = 17;
            AddExcludedFolderButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            AddExcludedFolderButton.Click += AddExcludedFolderButton_Click;
            // 
            // ExcludedFoldersLabel
            // 
            ExcludedFoldersLabel.AutoSize = true;
            ExcludedFoldersLabel.BackColor = Color.Transparent;
            ExcludedFoldersLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExcludedFoldersLabel.ForeColor = Color.LemonChiffon;
            ExcludedFoldersLabel.Location = new Point(67, 195);
            ExcludedFoldersLabel.Name = "ExcludedFoldersLabel";
            ExcludedFoldersLabel.Size = new Size(156, 18);
            ExcludedFoldersLabel.TabIndex = 16;
            ExcludedFoldersLabel.Text = "Excluded Folders";
            // 
            // ExcludedFoldersListBox
            // 
            ExcludedFoldersListBox.FormattingEnabled = true;
            ExcludedFoldersListBox.ItemHeight = 18;
            ExcludedFoldersListBox.Location = new Point(67, 218);
            ExcludedFoldersListBox.Name = "ExcludedFoldersListBox";
            ExcludedFoldersListBox.Size = new Size(573, 148);
            ExcludedFoldersListBox.TabIndex = 15;
            // 
            // OutputFolderControl
            // 
            OutputFolderControl.BackColor = Color.Transparent;
            OutputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            OutputFolderControl.ButtonColor = Color.LemonChiffon;
            OutputFolderControl.ButtonImage = (Image)resources.GetObject("OutputFolderControl.ButtonImage");
            OutputFolderControl.ButtonWidth = 48;
            OutputFolderControl.DarkMode = false;
            OutputFolderControl.DisabledLabelColor = Color.Empty;
            OutputFolderControl.Editable = true;
            OutputFolderControl.EnabledLabelColor = Color.Empty;
            OutputFolderControl.Filter = null;
            OutputFolderControl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputFolderControl.HideBrowseButton = false;
            OutputFolderControl.LabelBottomMargin = 0;
            OutputFolderControl.LabelColor = Color.LemonChiffon;
            OutputFolderControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OutputFolderControl.LabelText = "Output:";
            OutputFolderControl.LabelTopMargin = 0;
            OutputFolderControl.LabelWidth = 120;
            OutputFolderControl.Location = new Point(29, 136);
            OutputFolderControl.Name = "OutputFolderControl";
            OutputFolderControl.OnTextChangedListener = null;
            OutputFolderControl.OpenCallback = null;
            OutputFolderControl.ScrollBars = ScrollBars.None;
            OutputFolderControl.SelectedPath = null;
            OutputFolderControl.Size = new Size(611, 32);
            OutputFolderControl.StartPath = null;
            OutputFolderControl.TabIndex = 12;
            OutputFolderControl.TextBoxBottomMargin = 0;
            OutputFolderControl.TextBoxDisabledColor = Color.Empty;
            OutputFolderControl.TextBoxEditableColor = Color.Empty;
            OutputFolderControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputFolderControl.TextBoxTopMargin = 0;
            OutputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // PathControl
            // 
            PathControl.BackColor = Color.Transparent;
            PathControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            PathControl.ButtonColor = Color.LemonChiffon;
            PathControl.ButtonImage = (Image)resources.GetObject("PathControl.ButtonImage");
            PathControl.ButtonWidth = 48;
            PathControl.DarkMode = false;
            PathControl.DisabledLabelColor = Color.Empty;
            PathControl.Editable = true;
            PathControl.EnabledLabelColor = Color.Empty;
            PathControl.Filter = null;
            PathControl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PathControl.HideBrowseButton = false;
            PathControl.LabelBottomMargin = 0;
            PathControl.LabelColor = Color.LemonChiffon;
            PathControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PathControl.LabelText = "Path:";
            PathControl.LabelTopMargin = 0;
            PathControl.LabelWidth = 120;
            PathControl.Location = new Point(29, 77);
            PathControl.Name = "PathControl";
            PathControl.OnTextChangedListener = null;
            PathControl.OpenCallback = null;
            PathControl.ScrollBars = ScrollBars.None;
            PathControl.SelectedPath = null;
            PathControl.Size = new Size(611, 32);
            PathControl.StartPath = null;
            PathControl.TabIndex = 11;
            PathControl.TextBoxBottomMargin = 0;
            PathControl.TextBoxDisabledColor = Color.Empty;
            PathControl.TextBoxEditableColor = Color.Empty;
            PathControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PathControl.TextBoxTopMargin = 0;
            PathControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CancelSaveButton
            // 
            CancelSaveButton.BackColor = Color.Transparent;
            CancelSaveButton.ButtonText = "Cancel";
            CancelSaveButton.FlatStyle = FlatStyle.Flat;
            CancelSaveButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelSaveButton.ForeColor = Color.LemonChiffon;
            CancelSaveButton.Location = new Point(533, 591);
            CancelSaveButton.Margin = new Padding(4);
            CancelSaveButton.Name = "CancelSaveButton";
            CancelSaveButton.Size = new Size(107, 44);
            CancelSaveButton.TabIndex = 10;
            CancelSaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            CancelSaveButton.Click += CancelSaveButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Transparent;
            SaveButton.ButtonText = "Save";
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.LemonChiffon;
            SaveButton.Location = new Point(410, 591);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(107, 44);
            SaveButton.TabIndex = 9;
            SaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            SaveButton.Click += SaveButton_Click;
            // 
            // NameControl
            // 
            NameControl.BackColor = Color.Transparent;
            NameControl.BottomMargin = 0;
            NameControl.Editable = true;
            NameControl.Encrypted = false;
            NameControl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NameControl.Inititialized = true;
            NameControl.LabelBottomMargin = 0;
            NameControl.LabelColor = Color.LemonChiffon;
            NameControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NameControl.LabelText = "Name:";
            NameControl.LabelTopMargin = 0;
            NameControl.LabelWidth = 120;
            NameControl.Location = new Point(29, 18);
            NameControl.MultiLine = false;
            NameControl.Name = "NameControl";
            NameControl.OnTextChangedListener = null;
            NameControl.PasswordMode = false;
            NameControl.ScrollBars = ScrollBars.None;
            NameControl.Size = new Size(611, 32);
            NameControl.TabIndex = 7;
            NameControl.TextBoxBottomMargin = 0;
            NameControl.TextBoxDisabledColor = Color.LightGray;
            NameControl.TextBoxEditableColor = Color.White;
            NameControl.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameControl.TextBoxTopMargin = 0;
            NameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BlackImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1042, 648);
            Controls.Add(DetailsPanel);
            Controls.Add(TitleLabel);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(ProjectsListBox);
            Controls.Add(ListLabel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Build Copy 1.0.0";
            DetailsPanel.ResumeLayout(false);
            DetailsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        #endregion

        private DataJuggler.Win.Controls.Objects.PanelExtender DetailsPanel;
        private Label StatusLabel;
        private ProgressBar Graph;
        private DataJuggler.Win.Controls.Button CopyButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl ExcludeFolderControl;
        private DataJuggler.Win.Controls.Button DeleteExcludedFolderButton;
        private DataJuggler.Win.Controls.Button AddExcludedFolderButton;
        private Label ExcludedFoldersLabel;
        private ListBox ExcludedFoldersListBox;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputFolderControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl PathControl;
        private DataJuggler.Win.Controls.Button CancelSaveButton;
        private DataJuggler.Win.Controls.Button SaveButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl NameControl;
    }
    #endregion

}
