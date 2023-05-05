

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class ProjectWriterBase
    /// <summary>
    /// This class is used for converting a 'Project' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class ProjectWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Project project)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='project'>The 'Project' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Project project)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (project != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", project.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteProjectStoredProcedure(Project project)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteProject'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Project_Delete'.
            /// </summary>
            /// <param name="project">The 'Project' to Delete.</param>
            /// <returns>An instance of a 'DeleteProjectStoredProcedure' object.</returns>
            public static DeleteProjectStoredProcedure CreateDeleteProjectStoredProcedure(Project project)
            {
                // Initial Value
                DeleteProjectStoredProcedure deleteProjectStoredProcedure = new DeleteProjectStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteProjectStoredProcedure.Parameters = CreatePrimaryKeyParameter(project);

                // return value
                return deleteProjectStoredProcedure;
            }
            #endregion

            #region CreateFindProjectStoredProcedure(Project project)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Project_Find'.
            /// </summary>
            /// <param name="project">The 'Project' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindProjectStoredProcedure CreateFindProjectStoredProcedure(Project project)
            {
                // Initial Value
                FindProjectStoredProcedure findProjectStoredProcedure = null;

                // verify project exists
                if(project != null)
                {
                    // Instanciate findProjectStoredProcedure
                    findProjectStoredProcedure = new FindProjectStoredProcedure();

                    // Now create parameters for this procedure
                    findProjectStoredProcedure.Parameters = CreatePrimaryKeyParameter(project);
                }

                // return value
                return findProjectStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Project project)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new project.
            /// </summary>
            /// <param name="project">The 'Project' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Project project)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify projectexists
                if(project != null)
                {
                    // Create [Name] parameter
                    param = new SqlParameter("@Name", project.Name);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [OutputPath] parameter
                    param = new SqlParameter("@OutputPath", project.OutputPath);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Path] parameter
                    param = new SqlParameter("@Path", project.Path);

                    // set parameters[2]
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertProjectStoredProcedure(Project project)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Project_Insert'.
            /// </summary>
            /// <param name="project"The 'Project' object to insert</param>
            /// <returns>An instance of a 'InsertProjectStoredProcedure' object.</returns>
            public static InsertProjectStoredProcedure CreateInsertProjectStoredProcedure(Project project)
            {
                // Initial Value
                InsertProjectStoredProcedure insertProjectStoredProcedure = null;

                // verify project exists
                if(project != null)
                {
                    // Instanciate insertProjectStoredProcedure
                    insertProjectStoredProcedure = new InsertProjectStoredProcedure();

                    // Now create parameters for this procedure
                    insertProjectStoredProcedure.Parameters = CreateInsertParameters(project);
                }

                // return value
                return insertProjectStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Project project)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing project.
            /// </summary>
            /// <param name="project">The 'Project' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Project project)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify projectexists
                if(project != null)
                {
                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", project.Name);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [OutputPath]
                    param = new SqlParameter("@OutputPath", project.OutputPath);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Path]
                    param = new SqlParameter("@Path", project.Path);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", project.Id);
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateProjectStoredProcedure(Project project)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Project_Update'.
            /// </summary>
            /// <param name="project"The 'Project' object to update</param>
            /// <returns>An instance of a 'UpdateProjectStoredProcedure</returns>
            public static UpdateProjectStoredProcedure CreateUpdateProjectStoredProcedure(Project project)
            {
                // Initial Value
                UpdateProjectStoredProcedure updateProjectStoredProcedure = null;

                // verify project exists
                if(project != null)
                {
                    // Instanciate updateProjectStoredProcedure
                    updateProjectStoredProcedure = new UpdateProjectStoredProcedure();

                    // Now create parameters for this procedure
                    updateProjectStoredProcedure.Parameters = CreateUpdateParameters(project);
                }

                // return value
                return updateProjectStoredProcedure;
            }
            #endregion

            #region CreateFetchAllProjectsStoredProcedure(Project project)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllProjectsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Project_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllProjectsStoredProcedure' object.</returns>
            public static FetchAllProjectsStoredProcedure CreateFetchAllProjectsStoredProcedure(Project project)
            {
                // Initial value
                FetchAllProjectsStoredProcedure fetchAllProjectsStoredProcedure = new FetchAllProjectsStoredProcedure();

                // return value
                return fetchAllProjectsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
