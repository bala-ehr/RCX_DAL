using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data;
using System.Data.SqlClient;
using RC_X.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Configuration;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ConnectionParameters;
using static RC_X.rtm_services;
using System.Net.Mail;
using System.Text;

namespace RC_X
{
    #region classes

    #region IV&V classes

    public class GeneralInfo
    {
        public String GeneralInfoID { get; set; }
        public String StateName { get; set; }
        public String ProjectName { get; set; }
        public String ProgramName { get; set; }
        public String StatePrimaryPOC { get; set; }
        public String StatePrimaryPOCEmail { get; set; }
        public String SubmitterName { get; set; }
        public String SubmitterRole { get; set; }
        public String SubmitterEmail { get; set; }
        public String SubmitterPhone { get; set; }
        public String ConsultDate { get; set; }
        public String RFPReleaseDate { get; set; }
        public String OnBoardDate { get; set; }
        public String NextProgressDate { get; set; }
        public String ProgressReportDate { get; set; }

        public String ExecutiveSummary { get; set; }

    }
    public class LifeCycleStatus
    {
        public String LifeCycleStatusID { get; set; }
        public String Module { get; set; }
        public String ProjectName { get; set; }
        public String Project { get; set; }
        public String Status { get; set; }
        public String IAPDApprovalDate { get; set; }
        public String R1Date { get; set; }
        public String R2Date { get; set; }
        public String LiveDate { get; set; }
        public String R3Date { get; set; }
        public String DevelopmentStartDate { get; set; }

    }

    public class IVVRisks
    {
        public String RisksID { get; set; }
        public String UniqueID { get; set; }
        public String Title { get; set; }
        public String Probability { get; set; }
        public String Impact { get; set; }
        public String ResolutionDate { get; set; }
        public Boolean Status { get; set; }
        public String Description { get; set; }

    }
    public class IVVRecommendations
    {
        public String RecommendationID { get; set; }
        public String RecommendationId { get; set; }
        public String Recommendation { get; set; }
        public Boolean Resolved { get; set; }
        public String RecommendationDate { get; set; }
        public String Comments { get; set; }

    }
    #endregion


    public class EmailTemplatePlaceholders
    {
        public String Placeholder { get; set; }
        public String Replacement { get; set; }
    }

    public class GapGoal
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public String Type { get; set; }
        public String ProjectId { get; set; }
        public String Description { get; set; }
        public Boolean Open { get; set; }
        public String OpenDate { get; set; }
        public String CloseDate { get; set; }
    }
    public class ProjectTasks
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public String ProjectId { get; set; }
        public String Description { get; set; }
        public String StartDate { get; set; }
        public String EstimatedEndDate { get; set; }
        public String TargetDate1 { get; set; }
        public String TargetDate2 { get; set; }
        public String TargetDate3 { get; set; }
        public String Status { get; set; }
        public String ActualEndDate { get; set; }
        public String CMSreviewDate { get; set; }
        public String CMStextReview { get; set; }
        public Boolean Roadmap { get; set; }
    }
    public class RoadmapXref
    {
        public String Id { get; set; }
        public String RoadmapId { get; set; }
        public String GapGoalId { get; set; }
        public bool Open { get; set; }
        public String Title { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }
    }

    public class ProjectManagement
    {
        public String Id { get; set; }
        public String Type { get; set; }
        public String Area { get; set; }
        public String Title { get; set; }
        public String UniqueID { get; set; }
        public String Description { get; set; }
        public String Solution { get; set; }
        public String Priority { get; set; }
        public String Status { get; set; }
        public String Home { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }
    public class EnterpriseInfo
    {
        public String DBconnectionString { get; set; }
        public String EnterpriseName { get; set; }
    }
    public class Artifact
    {
        public Guid ArtifactID { get; set; }
        public String ProjectID { get; set; }
        public String Title { get; set; }
        public String Type { get; set; }
        public String Home { get; set; }
        public String filename { get; set; }
        public String filestoragename { get; set; }
        public String Description { get; set; }
        public String filetext { get; set; }
        public String DateUploaded { get; set; }
        public String UploadedBy { get; set; }
        public String ChangedBy { get; set; }
        public String UploadedByName { get; set; }
        public String ChangedByName { get; set; }
        public Boolean Deleted { get; set; }
    }
    public class Attachment
    {
        public String AttachmentID { get; set; }
        public String ProjectID { get; set; }
        public String ArtifactID { get; set; }
        public String ItemID { get; set; }
        public String PageReference { get; set; }
        public String ArtifactTitle { get; set; }
        public DateTime DateAttached { get; set; }
        public String ArtifactType { get; set; }
        public String ArtifactHome { get; set; }
        public String filename { get; set; }
        public String filestoragename { get; set; }

    }
    public class AttachmentList : List<Attachment>
    {
        //        public DataTable GetAttachTable()
        //        {
        //            ***CHANGE THIS TO A Stored procedure with INSERT WHERE NOT EXISTS
        //            First, load all the current attachments in the database into a datatable.It will be used to check for dulicates before attaching


        //           DataTable tableAttached = new DataTable();
        //            string constr = System.Web.HttpContext.Current.Session["userConnString"].ToString();
        //            using (SqlConnection con = new SqlConnection(constr))
        //            {
        //                using (SqlCommand cmd = new SqlCommand("rcsp_attachments_getall"))
        //                {
        //                    cmd.Connection = con;
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //                    {
        //                        sda.Fill(tableAttached);
        //                    }
        //                }
        //                Now check for duplicates in the current attachments by looping through the AttachmentList class. Delete from list any that already exist
        //                foreach (var item in this.ToList())
        //                {
        //                    DataRow[] DuplicateRows = tableAttached.Select("att_artifact = '" + item.ArtifactID + "' AND att_itemid = '" + item.ItemID + "' AND att_projectid = '" + item.ProjectID + "'");
        //                    if (DuplicateRows.Count() > 0)
        //                    {
        //                        this.Remove(item);
        //    }
        //}

        //Now create a datatable to be returned by the function, then add all the items left in this list to the table

        //DataTable table = new DataTable();

        //table.Columns.Add("att_artifact", typeof(String));
        //table.Columns.Add("att_itemid", typeof(String));
        //table.Columns.Add("att_projectid", typeof(String));
        //table.Columns.Add("att_pageref", typeof(String));

        //                foreach (var item in this)
        //                {
        //    table.Rows.Add(item.ArtifactID, item.ItemID, item.ProjectID, item.PageReference);
        //}
        //                return table;
        //}
        //        }
    }
    public class ReositoryAttachments
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        
    }
    
    public class ScoreStandards
    {
        public String ScoreId { get; set; }
        public String ProjectID { get; set; }
        public String StandardID { get; set; }
        public String CardID { get; set; }
        public String ItemID { get; set; }
        public int ScoreCol1 { get; set; }
        public int ScoreCol2 { get; set; }
        public int ScoreCol3 { get; set; }
        public int ScoreCol4 { get; set; }
        public int ScoreCol5 { get; set; }
        public String Measure1 { get; set; }
        public String Measure2 { get; set; }
        public String Measure3 { get; set; }
        public String Measure4 { get; set; }
        public String Measure5 { get; set; }
    }
    public class ScoreStandardsList : List<ScoreStandards>
    {
        public DataTable GetStandardsTable()
        {
            //Now create a datatable to be returned by the function, then add all the items left in this list to the table
            DataTable table = new DataTable();
            table.Columns.Add("score_id", typeof(String));
            table.Columns.Add("score_itemid", typeof(String));
            table.Columns.Add("score_projectid", typeof(String));
            table.Columns.Add("card_id", typeof(String));
            table.Columns.Add("score_standard", typeof(String));
            table.Columns.Add("score_col1", typeof(int));
            table.Columns.Add("score_col2", typeof(int));
            table.Columns.Add("score_col3", typeof(int));
            table.Columns.Add("score_col4", typeof(int));
            table.Columns.Add("score_col5", typeof(int));
            table.Columns.Add("score_colmeasure1", typeof(String));
            table.Columns.Add("score_colmeasure2", typeof(String));
            table.Columns.Add("score_colmeasure3", typeof(String));
            table.Columns.Add("score_colmeasure4", typeof(String));
            table.Columns.Add("score_colmeasure5", typeof(String));


            foreach (var item in this)
            {
                table.Rows.Add(item.ScoreId, item.ItemID, item.ProjectID, item.CardID, item.StandardID, item.ScoreCol1,item.ScoreCol2,item.ScoreCol3,item.ScoreCol4,item.ScoreCol5,item.Measure1,item.Measure2,item.Measure3,item.Measure4,item.Measure5);
            }
            return table;
        }

    }
    public class Scorecard
    {
        public String CardId { get; set; }
        public String CardName { get; set; }
        public String CardDescription { get; set; }
        public Boolean MeasuredEnabled { get; set; }
        public String MeasureDescription { get; set; }
        public String CardCol1 { get; set; }
        public String CardCol2 { get; set; }
        public String CardCol3 { get; set; }
        public String CardCol4 { get; set; }
        public String CardCol5 { get; set; }
        public Boolean EnabledCol1 { get; set; }
        public Boolean EnabledCol2 { get; set; }
        public Boolean EnabledCol3 { get; set; }
        public Boolean EnabledCol4 { get; set; }
        public Boolean EnabledCol5 { get; set; }
        public String Measure1 { get; set; }
        public String Measure2 { get; set; }
        public String Measure3 { get; set; }
        public String Measure4 { get; set; }
        public String Measure5 { get; set; }
    }
    public class Scores
    {
        public String CardId { get; set; }
        public String StandardId { get; set; }
        public String StandardName { get; set; }
        public String Quality { get; set; }
        public String ItemId { get; set; }
        public String ScoreId { get; set; }
        public int ScoreCol1 { get; set; }
        public int ScoreCol2 { get; set; }
        public int ScoreCol3 { get; set; }
        public int ScoreCol4 { get; set; }
        public int ScoreCol5 { get; set; }
        public String Measure1 { get; set; }
        public String Measure2 { get; set; }
        public String Measure3 { get; set; }
        public String Measure4 { get; set; }
        public String Measure5 { get; set; }
        
    }
    public class AssessmentResponse
    {
        public Guid ResponseID { get; set; }
        public Guid ItemKey { get; set; }
        public Guid ProjectID { get; set; }
        public Guid MilestoneID { get; set; }
        public String Response { get; set; }
        public String Assesment { get; set; }
        public String MilestoneName { get; set; }
    }
    public class ScoreDescription
    {
        public Guid DescriptionId { get; set; }
        public Guid ItemKey { get; set; }
        public Guid ProjectID { get; set; }
        public Guid CardId { get; set; }
        public String Description { get; set; }

    }
    //public class AssessmentResponseList : List<AssessmentResponse>
    //{
    //    public DataTable AssessmentResponseDataTable()
    //    {
    //        //Now create a datatable to be returned by the function, then add all the items left in this list to the table
    //        DataTable table = new DataTable();
    //        table.Columns.Add("res_id", typeof(String));
    //        table.Columns.Add("res_projectID", typeof(String));
    //        table.Columns.Add("res_itemID", typeof(String));
    //        table.Columns.Add("res_response", typeof(String));
    //        table.Columns.Add("usrole_roleID", typeof(String));
    //        table.Columns.Add("usrole_roleID", typeof(String));

    //        foreach (var item in this)
    //        {
    //            table.Rows.Add(item.Id, item.ProjectID, item.UserID, item.RoleID);
    //        }
    //        return table;
    //    }
    //}

    public class Workflow
    {
        public Guid Id { get; set; }
        public Guid ItemKey { get; set; }
        public Guid ProjectID { get; set; }
        public String Status { get; set; }
        public int StatusValue { get; set; }
        public String Comments { get; set; }
        public String Worker { get; set; }
        public Guid WorkerID { get; set; }
        public String Manager { get; set; }
        public Guid ManagerID { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StatusDate { get; set; }
    }
    public class MultiAssignWorkflow
    {
        public String ID { get; set; }
        public String Identifier { get; set; }
        public String Name { get; set; }
       


    }

    public class ResponseEvaluation
    {
        public Guid EvaluationID { get; set; }
        public Guid CriteriaID { get; set; }
        public Guid ItemID { get; set; }
        public String ReviwerBy { get; set; }
        public DateTime ReviwerDate { get; set; }
        public String ReviwerAssessment { get; set; }
        public String ReviwerComments { get; set; }
    }

    // enterprise RTM & Assessment Model Class
    public class RtmChecklist
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class RtmProjectChecklist
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Boolean IsActive { get; set; }
    }
    public class RtmObjectives
    {
        public string Id { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string ChecklistTitle { get; set; }
        public string ChecklistType { get; set; }

    }
    public class RtmCriteria
    {
        public string Id { get; set; }
        public string ChecklistTitle { get; set; }
        public string ChecklistType { get; set; }
        public string ObjectiveUniqueId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Criteria { get; set; }
        public int Order { get; set; }
        public string Complaince { get; set; }
        public string Source { get; set; }
        public Boolean Critical { get; set; }
    }
    public class BusinessArea
    {
        public string Id { get; set; }
        public string UniqueID { get; set; }
        public string AreaTitle { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }

    }
    public class BusinessCategory
    {
        public string Id { get; set; }
        public string AreaID { get; set; }
        public string AreaTitle { get; set; }
        public string UniqueID { get; set; }
        public string CategoryTitle { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }

    }
    public class BusinessProcess
    {
        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string AreaTitle { get; set; }
        public string CategoryTitle { get; set; }
        public string UniqueID { get; set; }
        public string ProcessTitle { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class FrontMatter
    {
        public String FrontMatterID { get; set; }
        public Guid ProjectID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; } 
    }

    public class ScoreStandardValues
    {
        public string Id { get; set; }
        public string StandardId { get; set; }
        public string Standard { get; set; }
        public int ValueScore { get; set; }
        public string ValueScoreText { get; set; }
        public string ValueMeasures { get; set; }
    }

    public class EnterpriseAPD
    {
        public string Id { get; set; }
        public string APDtype { get; set; }
        public string APDNumber { get; set; }
        public string APDName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }

    // model classes for Componets

    public class Componets
    {
        public string ComponentId { get; set; }
        public string ComponentName { get; set; }
        public string ComponentType { get; set; }
        public string ComponentMode { get; set; }
        public string ComponentTest { get; set; }
        public string ComponentLocation { get; set; }
        public string SerialNumber { get; set; }
        public String StartDate { get; set; }
        public String EndDate { get; set; }
        public string Notes { get; set; }
    }
    #endregion

    #region securityclasses
    public class RolePermissions
    {
        public String PermissionName { get; set; }
        public String Description { get; set; }
        public String RoleID { get; set; }
        public String Code { get; set; }
    }
    public class RolePermissionsList : List<RolePermissions>
    {
        public DataTable GetRolePermissionsTable()
        {
            //Now create a datatable to be returned by the function, then add all the items left in this list to the table
            DataTable table = new DataTable();
            table.Columns.Add("perm_name", typeof(String));
            table.Columns.Add("perm_description", typeof(String));
            table.Columns.Add("perm_roleID", typeof(String));
            table.Columns.Add("perm_code", typeof(String));


            foreach (var item in this)
            {
                table.Rows.Add(item.PermissionName, item.Description, item.RoleID, item.Code);
            }
            return table;
        }

    }
    public class ProjectRole
    {
        public String RoleAssignmentID { get; set; }
        public String UserID { get; set; }
        public String Email { get; set; }
        public String RoleName { get; set; }
        public String RoleID { get; set; }
        public String ProjectID { get; set; }
        public String ProjectName { get; set; }

    }
    public class ProjectRoleList : List<ProjectRole>
    {
        public DataTable RoleAssignmentDataTable()
        {
            //Now create a datatable to be returned by the function, then add all the items left in this list to the table
            DataTable table = new DataTable();
            table.Columns.Add("usrole_id", typeof(String));
            table.Columns.Add("usrole_user", typeof(String));
            table.Columns.Add("usrole_roleID", typeof(String));
            table.Columns.Add("usrole_projectID", typeof(String));
            table.Columns.Add("usrole_user", typeof(String));
            table.Columns.Add("usrole_roleID", typeof(String));

            foreach (var item in this)
            {
                table.Rows.Add(item.ProjectID, item.UserID, item.RoleID);
            }
            return table;
        }
    }
    public class RCuser
    {
        public String UserID { get; set; }
        public String Email { get; set; }
        public String ProjectID { get; set; }
        public Boolean EmailConfirmed { get; set; }
        public String PhoneNumber { get; set; }
        public String DefaultProject { get; set; }

    }
    public class RCuserList : List<RCuser>
    {
        public DataTable GetUserTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(String));
            table.Columns.Add("Email", typeof(String));
            table.Columns.Add("project", typeof(String));
            table.Columns.Add("EmailConfirmed", typeof(String));
            table.Columns.Add("PhoneNumber", typeof(String));
            foreach (var item in this)
            {
                table.Rows.Add(item.UserID, item.Email, item.ProjectID, item.EmailConfirmed, item.PhoneNumber);
            }
            return table;
        }
    }
    public class ProjectUserRole
    {
        public Guid Id { get; set; }
        public Guid ProjectID { get; set; }
        public Guid UserID { get; set; }
        public Guid RoleID { get; set; }
    }
    public class ProjectUserRoleList : List<ProjectUserRole>
    {
        public DataTable RoleAssignmentDataTable()
        {
            //Now create a datatable to be returned by the function, then add all the items left in this list to the table
            DataTable table = new DataTable();
            table.Columns.Add("usrole_id", typeof(String));
            table.Columns.Add("usrole_projectID", typeof(String));
            table.Columns.Add("usrole_user", typeof(String));
            table.Columns.Add("usrole_roleID", typeof(String));

            foreach (var item in this)
            {
                table.Rows.Add(item.Id, item.ProjectID, item.UserID, item.RoleID);
            }
            return table;
        }
    }
    public class ActivePermission
    {
        public String PermissionCode { get; set; }
        public Boolean Authorized { get; set; }
    }

    public class RtmPlanningProjectDetails
    {
        public string CriteriaId { get; set; }
        public string ProjectName { get; set; }
        public bool IsActive { get; set; }
    }

    public class KeyValueObject
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class UserStatistics
    {
        public string UserStatisticsID { get; set; }
        public string UserName { get; set; }
        public string ProjectName { get; set; }
        public string EventName { get; set; }
        public String EventTime { get; set; }
        public string Notes { get; set; }
        public string IPAddress { get; set; }

    }

    #endregion
    public class rc_services
    {
        #region Roadmap
        public static List<GapGoal> GetGapGoals()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<GapGoal> GapGoalData = new List<GapGoal>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            // newly added code using DAL functionalities..
            List<string> paramDict = new List<string>(2);
            paramDict.Add("rcsp_roadmap_gapgoal_get"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@gap_projectID;" + System.Web.HttpContext.Current.Session["projectID"].ToString() + ";string"); //order of params - paramname;paramvalue;typeofparam
            List<string> outputVars = new List<string>();
            outputVars.Add("gap_id");
            outputVars.Add("gap_title");
            outputVars.Add("gap_type");
            outputVars.Add("gap_projectID");
            outputVars.Add("gap_desc");
            outputVars.Add("gap_open");
            outputVars.Add("gap_opendate");
            outputVars.Add("gap_closedate");
            List<controls.ReaderOutputs> outs = controls.DAL_RCServices.ExecuteReader(connectionString, paramDict, 8, outputVars);

            foreach (var item in outs)
            {
                GapGoalData.Add(new GapGoal
                {
                    Id =item.out1.ToString(),
                    Title = item.out2.ToString(),
                    Type = item.out3.ToString(),
                    ProjectId = item.out4.ToString(),
                    Description = item.out5.ToString(),
                    //Open = (bool)item.out6.ToString(), // need to do the convertion properly. 
                    OpenDate = item.out7.ToString() == "" ? "" : Convert.ToDateTime(item.out7.ToString()).ToShortDateString(), // == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["bp_opendate"]),
                    CloseDate = item.out8.ToString() == "" ? "" : Convert.ToDateTime(item.out8.ToString()).ToShortDateString()

                });
            }
            // older existing code
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_roadmap_gapgoal_get", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@gap_projectID", System.Web.HttpContext.Current.Session["projectID"].ToString());
            //                //command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);
            //                //command.Parameters.AddWithValue("@gapgoal", GapOrGoal);

            //                connection.Open();
            //                reader = command.ExecuteReader();

            //                while (reader.Read())
            //                {

            //                    GapGoalData.Add(new GapGoal
            //                    {
            //                        Id = reader["gap_id"].ToString(),
            //                        Title = reader["gap_title"].ToString(),
            //                        Type = reader["gap_type"].ToString(), 
            //                        ProjectId = reader["gap_projectID"].ToString(),
            //                        Description = reader["gap_desc"].ToString(),
            //                        Open = (bool)reader["gap_open"],
            //                        OpenDate = reader["gap_opendate"].ToString() == "" ? "" : Convert.ToDateTime(reader["gap_opendate"].ToString()).ToShortDateString(), // == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["bp_opendate"]),
            //                        CloseDate = reader["gap_closedate"].ToString() == "" ? "" : Convert.ToDateTime(reader["gap_closedate"].ToString()).ToShortDateString()

            //                    });

            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return GapGoalData;


        }
        public static string NewGapGoal(GapGoal InsertGapGoal)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var CurrentProjectId = System.Web.HttpContext.Current.Session["projectID"].ToString();
            // newly code added using DAL
            string returnVal = string.Empty;
            List<string> paramDict = new List<string>(8);
            paramDict.Add("rcsp_roadmap_gapgoal_insert"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@gap_title; " + InsertGapGoal.Title + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@gap_type;" + InsertGapGoal.Type + ";string");
            paramDict.Add("@gap_projectID;" + CurrentProjectId + ";string");
            paramDict.Add("@gap_desc;"+ InsertGapGoal.Description == null ? "" : InsertGapGoal.Description +";string");
            paramDict.Add("@gap_open;"+ InsertGapGoal.Open+";string");
            if (InsertGapGoal.OpenDate == null) { paramDict.Add("@gap_opendate;"+ DBNull.Value + ";DBNull"); } else { paramDict.Add("@gap_opendate;"+ InsertGapGoal.OpenDate); }
            if (InsertGapGoal.CloseDate == null) { paramDict.Add("@gap_closedate;"+ DBNull.Value+ ";DBNull"); } else { paramDict.Add("@gap_closedate;"+ InsertGapGoal.CloseDate); }


            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "Sucessfully Added";
            else
                returnVal = "error";

            // following is older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_roadmap_gapgoal_insert", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@gap_title", InsertGapGoal.Title);
            //                command.Parameters.AddWithValue("@gap_type", InsertGapGoal.Type);
            //                command.Parameters.AddWithValue("@gap_projectID", CurrentProjectId);
            //                command.Parameters.AddWithValue("@gap_desc", InsertGapGoal.Description == null ? "" : InsertGapGoal.Description);
            //                command.Parameters.AddWithValue("@gap_open", InsertGapGoal.Open);
            //                if (InsertGapGoal.OpenDate == null) { command.Parameters.AddWithValue("@gap_opendate", DBNull.Value); } else { command.Parameters.AddWithValue("@gap_opendate", InsertGapGoal.OpenDate); }
            //                if (InsertGapGoal.CloseDate == null) { command.Parameters.AddWithValue("@gap_closedate", DBNull.Value); } else { command.Parameters.AddWithValue("@gap_closedate", InsertGapGoal.CloseDate); }
            //                connection.Open();
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                return ex.Message;
            //            }
            //            finally
            //            {
            //                connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return returnVal;
        }
        public static string EditGapGoal(GapGoal UpdateGapGoal)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var CurrentProjectId = System.Web.HttpContext.Current.Session["projectID"].ToString();

            // newly code added using DAL
            string returnVal = string.Empty;
            List<string> paramDict = new List<string>(7);
            paramDict.Add("rcsp_roadmap_gapgoal_update"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@gap_id; " + UpdateGapGoal.Id + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@gap_title;" + UpdateGapGoal.Title + ";string");
            paramDict.Add("@gap_desc;" + UpdateGapGoal.Description + ";string");
            paramDict.Add("@gap_open;" + UpdateGapGoal.Open + ";string");
            if (UpdateGapGoal.OpenDate == null) { paramDict.Add("@gap_opendate;" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@gap_opendate;" + UpdateGapGoal.OpenDate); }
            if (UpdateGapGoal.CloseDate == null) { paramDict.Add("@gap_closedate;" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@gap_closedate;" + UpdateGapGoal.CloseDate); }


            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "Sucessfully Update";
            else
                returnVal = "error";

            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_roadmap_gapgoal_update", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@gap_id", UpdateGapGoal.Id);
            //                command.Parameters.AddWithValue("@gap_title", UpdateGapGoal.Title);
            //                command.Parameters.AddWithValue("@gap_desc", UpdateGapGoal.Description);
            //                command.Parameters.AddWithValue("@gap_open", UpdateGapGoal.Open);
            //                if (UpdateGapGoal.OpenDate == null) { command.Parameters.AddWithValue("@gap_opendate", DBNull.Value); } else { command.Parameters.AddWithValue("@gap_opendate", UpdateGapGoal.OpenDate); }
            //                if (UpdateGapGoal.CloseDate == null) { command.Parameters.AddWithValue("@gap_closedate", DBNull.Value); } else { command.Parameters.AddWithValue("@gap_closedate", UpdateGapGoal.CloseDate); }

            //                connection.Open();
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                return ex.Message;
            //            }
            //            finally
            //            {
            //                connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return returnVal;
        }
        public static string DeleteGapGoal(String GapGoalID)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            // newly code added using DAL
            string returnVal = string.Empty;
            List<string> paramDict = new List<string>(2);
            paramDict.Add("rcsp_roadmap_gapgoal_delete"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@gap_id; " + GapGoalID + ";string"); //order of params - paramname;paramvalue;typeofparam
           

            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "Sucessfully Deleted";
            else
                returnVal = "error";

            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_roadmap_gapgoal_delete", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@gap_id", GapGoalID);
            //                connection.Open();
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                return ex.Message;
            //            }
            //            finally
            //            {
            //                connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return returnVal;
        }

        public static List<ProjectTasks> GetProjectTasks(bool deliverablescreen)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<ProjectTasks> ProjectTasksData = new List<ProjectTasks>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            // newly added code using DAL functionalities
            List<string> paramDict = new List<string>(2);
            paramDict.Add("sp_rc_project_GetAllTasks"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@rm_projectID;" + System.Web.HttpContext.Current.Session["projectID"].ToString()+";"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@rm_deliverable;"+ deliverablescreen+";");
            List<string> outputVars = new List<string>();
            outputVars.Add("rm_id");
            outputVars.Add("rm_title");
            outputVars.Add("rm_projectID");
            outputVars.Add("rm_desc");
            outputVars.Add("rm_startdate");
            outputVars.Add("rm_estimatedend");
            outputVars.Add("rm_targetdate1");
            outputVars.Add("rm_targetdate2");
            outputVars.Add("rm_targetdate3");
            outputVars.Add("rm_actualend");
            outputVars.Add("rm_cmsreviewdate");
            outputVars.Add("rm_cmsreviewtext");
            outputVars.Add("rm_status");
            outputVars.Add("rm_isvisible");
            List<controls.ReaderOutputs> outs = controls.DAL_RCServices.ExecuteReader(connectionString, paramDict, 14, outputVars);
            foreach (var item in outs)
            {
                ProjectTasksData.Add(new ProjectTasks
                {
                    Id = item.out1.ToString(),
                    Title = item.out2.ToString(),
                    ProjectId = item.out3.ToString(),
                    Description = item.out4.ToString(),
                    StartDate = item.out5.ToString() == "" ? "" : Convert.ToDateTime(item.out5.ToString()).ToShortDateString(), // == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["bp_opendate"]),
                    EstimatedEndDate = item.out6.ToString() == "" ? "" : Convert.ToDateTime(item.out6.ToString()).ToShortDateString(),
                    TargetDate1 = item.out7.ToString() == "" ? "" : Convert.ToDateTime(item.out7.ToString()).ToShortDateString(),
                    TargetDate2 = item.out8.ToString() == "" ? "" : Convert.ToDateTime(item.out8.ToString()).ToShortDateString(),
                    TargetDate3 = item.out9.ToString() == "" ? "" : Convert.ToDateTime(item.out9.ToString()).ToShortDateString(),
                    ActualEndDate = item.out10.ToString() == "" ? "" : Convert.ToDateTime(item.out10.ToString()).ToShortDateString(), // == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["bp_opendate"]),
                    CMSreviewDate = item.out11.ToString() == "" ? "" : Convert.ToDateTime(item.out11.ToString()).ToShortDateString(),
                    CMStextReview = item.out12.ToString(),
                    Status = item.out13.ToString(),
                    // Roadmap = item.out14 == DBNull.Value ? false : Convert.ToBoolean(item.out14) });  // need to fix the compile errors
                });
            }
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("sp_rc_project_GetAllTasks", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@rm_projectID", System.Web.HttpContext.Current.Session["projectID"].ToString());
            //                command.Parameters.AddWithValue("@rm_deliverable", deliverablescreen);
            //                //command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);

            //                connection.Open();
            //                reader = command.ExecuteReader();

            //                while (reader.Read())
            //                {

            //                    ProjectTasksData.Add(new ProjectTasks
            //                    {
            //                        Id = reader["rm_id"].ToString(),
            //                        Title = reader["rm_title"].ToString(),
                                   
            //                        ProjectId = reader["rm_projectID"].ToString(),
            //                        Description = reader["rm_desc"].ToString(),
            //                        StartDate = reader["rm_startdate"].ToString() == "" ? "" : Convert.ToDateTime(reader["rm_startdate"].ToString()).ToShortDateString(), // == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["bp_opendate"]),
            //                        EstimatedEndDate = reader["rm_estimatedend"].ToString() == "" ? "" : Convert.ToDateTime(reader["rm_estimatedend"].ToString()).ToShortDateString(),
            //                        TargetDate1 = reader["rm_targetdate1"].ToString() == "" ? "" : Convert.ToDateTime(reader["rm_targetdate1"].ToString()).ToShortDateString(),
            //                        TargetDate2 = reader["rm_targetdate2"].ToString() == "" ? "" : Convert.ToDateTime(reader["rm_targetdate2"].ToString()).ToShortDateString(),
            //                        TargetDate3 = reader["rm_targetdate3"].ToString() == "" ? "" : Convert.ToDateTime(reader["rm_targetdate3"].ToString()).ToShortDateString(),
            //                        ActualEndDate = reader["rm_actualend"].ToString() == "" ? "" : Convert.ToDateTime(reader["rm_actualend"].ToString()).ToShortDateString(), // == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["bp_opendate"]),
            //                        CMSreviewDate = reader["rm_cmsreviewdate"].ToString() == "" ? "" : Convert.ToDateTime(reader["rm_cmsreviewdate"].ToString()).ToShortDateString(),
            //                        CMStextReview = reader["rm_cmsreviewtext"].ToString(),
            //                        Status = reader["rm_status"].ToString(),
                                   
            //                        Roadmap = reader["rm_isvisible"] == DBNull.Value ? false : Convert.ToBoolean(reader["rm_isvisible"])


            //                    });

            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return ProjectTasksData;


        }
        public static string NewProjectTasks(ProjectTasks InsertProject)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var CurrentProjectId = System.Web.HttpContext.Current.Session["projectID"].ToString();
            //Added new code using DAL functionalities..
            string returnVal = string.Empty;
            List<string> paramDict = new List<string>(14);
            paramDict.Add("sp_rc_project_InsertNewTasks"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@rm_title;" + InsertProject.Title + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@rm_projectID;" + CurrentProjectId + ";string");
            paramDict.Add("@rm_desc;" + InsertProject.Description == null ? "" : InsertProject.Description + ";string");
            paramDict.Add("@rm_cmsreviewtext;"+ InsertProject.CMStextReview == null ? "" : InsertProject.CMStextReview + ";string");
            if (InsertProject.StartDate == null) { paramDict.Add("@rm_startdate;"+ DBNull.Value+ ";DBNull"); } else { paramDict.Add("@rm_startdate;"+ InsertProject.StartDate+";string"); }
            if (InsertProject.EstimatedEndDate == null) { paramDict.Add("@rm_estimatedend;"+ DBNull.Value+ ";DBNull"); } else { paramDict.Add("@rm_estimatedend;"+ InsertProject.EstimatedEndDate+";string"); }
            if (InsertProject.TargetDate1 == null) { paramDict.Add("@rm_targetdate1;"+ DBNull.Value+ ";DBNull"); } else { paramDict.Add("@rm_targetdate1;"+ InsertProject.TargetDate1+";string"); }
            if (InsertProject.TargetDate2 == null) { paramDict.Add("@rm_targetdate2;"+ DBNull.Value+ ";DBNull"); } else { paramDict.Add("@rm_targetdate2;"+ InsertProject.TargetDate2+";string"); }
            if (InsertProject.TargetDate3 == null) { paramDict.Add("@rm_targetdate3;"+ DBNull.Value+ ";DBNull"); } else { paramDict.Add("@rm_targetdate3;"+ InsertProject.TargetDate3+";string"); }
            paramDict.Add("@rm_status;"+ InsertProject.Status+";string");
            if (InsertProject.ActualEndDate == null) { paramDict.Add("@rm_actualend;"+ DBNull.Value+ ";DBNull"); } else { paramDict.Add("@rm_actualend;"+ InsertProject.ActualEndDate+";string"); }
            if (InsertProject.CMSreviewDate == null) { paramDict.Add("@rm_cmsreviewdate"+ DBNull.Value+ ";DBNull"); } else { paramDict.Add("@rm_cmsreviewdate;"+ InsertProject.CMSreviewDate+";string"); }
            paramDict.Add("@rm_isvisible;"+ InsertProject.Roadmap+";");

            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "Sucessfully Added";
            else
                returnVal = "error";


            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("sp_rc_project_InsertNewTasks", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@rm_title", InsertProject.Title);
            //                command.Parameters.AddWithValue("@rm_projectID", CurrentProjectId);
            //                command.Parameters.AddWithValue("@rm_desc", InsertProject.Description == null ? "" : InsertProject.Description);
            //                command.Parameters.AddWithValue("@rm_cmsreviewtext", InsertProject.CMStextReview == null ? "" : InsertProject.CMStextReview);
                           
            //                if (InsertProject.StartDate == null) { command.Parameters.AddWithValue("@rm_startdate", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_startdate", InsertProject.StartDate); }
            //                if (InsertProject.EstimatedEndDate == null) { command.Parameters.AddWithValue("@rm_estimatedend", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_estimatedend", InsertProject.EstimatedEndDate); }
            //                if (InsertProject.TargetDate1 == null) { command.Parameters.AddWithValue("@rm_targetdate1", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_targetdate1", InsertProject.TargetDate1); }
            //                if (InsertProject.TargetDate2 == null) { command.Parameters.AddWithValue("@rm_targetdate2", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_targetdate2", InsertProject.TargetDate2); }
            //                if (InsertProject.TargetDate3 == null) { command.Parameters.AddWithValue("@rm_targetdate3", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_targetdate3", InsertProject.TargetDate3); }
            //                command.Parameters.AddWithValue("@rm_status", InsertProject.Status);
            //                if (InsertProject.ActualEndDate == null) { command.Parameters.AddWithValue("@rm_actualend", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_actualend", InsertProject.ActualEndDate); }
            //                if (InsertProject.CMSreviewDate == null) { command.Parameters.AddWithValue("@rm_cmsreviewdate", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_cmsreviewdate", InsertProject.CMSreviewDate); }
                            
            //                command.Parameters.AddWithValue("@rm_isvisible", InsertProject.Roadmap);

            //                connection.Open();
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                return ex.Message;
            //            }
            //            finally
            //            {
            //                connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return returnVal;
        }
        public static string EditProjectTasks(ProjectTasks UpdateRoadmapProject)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var CurrentProjectId = System.Web.HttpContext.Current.Session["projectID"].ToString();
            //Added new code using DAL functionalities..
            string returnVal = string.Empty;
            List<string> paramDict = new List<string>(14);
            paramDict.Add("sp_rc_Project_updateTasks"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@rm_id;" + UpdateRoadmapProject.Id + ";string");
            paramDict.Add("@rm_title;" + UpdateRoadmapProject.Title + ";string"); //order of params - paramname;paramvalue;typeofparam
            
            paramDict.Add("@rm_desc;" + UpdateRoadmapProject.Description == null ? "" : UpdateRoadmapProject.Description + ";string");
            paramDict.Add("@rm_cmsreviewtext;" + UpdateRoadmapProject.CMStextReview == null ? "" : UpdateRoadmapProject.CMStextReview + ";string");
            if (UpdateRoadmapProject.StartDate == null) { paramDict.Add("@rm_startdate;" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@rm_startdate;" + UpdateRoadmapProject.StartDate + ";string"); }
            if (UpdateRoadmapProject.EstimatedEndDate == null) { paramDict.Add("@rm_estimatedend;" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@rm_estimatedend;" + UpdateRoadmapProject.EstimatedEndDate + ";string"); }
            if (UpdateRoadmapProject.TargetDate1 == null) { paramDict.Add("@rm_targetdate1;" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@rm_targetdate1;" + UpdateRoadmapProject.TargetDate1 + ";string"); }
            if (UpdateRoadmapProject.TargetDate2 == null) { paramDict.Add("@rm_targetdate2;" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@rm_targetdate2;" + UpdateRoadmapProject.TargetDate2 + ";string"); }
            if (UpdateRoadmapProject.TargetDate3 == null) { paramDict.Add("@rm_targetdate3;" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@rm_targetdate3;" + UpdateRoadmapProject.TargetDate3 + ";string"); }
            paramDict.Add("@rm_status;" + UpdateRoadmapProject.Status + ";string");
            if (UpdateRoadmapProject.ActualEndDate == null) { paramDict.Add("@rm_actualend;" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@rm_actualend;" + UpdateRoadmapProject.ActualEndDate + ";string"); }
            if (UpdateRoadmapProject.CMSreviewDate == null) { paramDict.Add("@rm_cmsreviewdate" + DBNull.Value + ";DBNull"); } else { paramDict.Add("@rm_cmsreviewdate;" + UpdateRoadmapProject.CMSreviewDate + ";string"); }
            paramDict.Add("@rm_isvisible;" + UpdateRoadmapProject.Roadmap + ";");

            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "Sucessfully Update";
            else
                returnVal = "error";

            // following is the older code

            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("sp_rc_Project_updateTasks", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@rm_id", UpdateRoadmapProject.Id);
            //                command.Parameters.AddWithValue("@rm_title", UpdateRoadmapProject.Title);
            //                command.Parameters.AddWithValue("@rm_desc", UpdateRoadmapProject.Description == null ? "" : UpdateRoadmapProject.Description);
            //                command.Parameters.AddWithValue("@rm_cmsreviewtext", UpdateRoadmapProject.CMStextReview == null ? "" : UpdateRoadmapProject.CMStextReview);
            //                if (UpdateRoadmapProject.StartDate == null) { command.Parameters.AddWithValue("@rm_startdate", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_startdate", UpdateRoadmapProject.StartDate); }
            //                if (UpdateRoadmapProject.EstimatedEndDate == null) { command.Parameters.AddWithValue("@rm_estimatedend", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_estimatedend", UpdateRoadmapProject.EstimatedEndDate); }
            //                if (UpdateRoadmapProject.TargetDate1 == null) { command.Parameters.AddWithValue("@rm_targetdate1", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_targetdate1", UpdateRoadmapProject.TargetDate1); }
            //                if (UpdateRoadmapProject.TargetDate2 == null) { command.Parameters.AddWithValue("@rm_targetdate2", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_targetdate2", UpdateRoadmapProject.TargetDate2); }
            //                if (UpdateRoadmapProject.TargetDate3 == null) { command.Parameters.AddWithValue("@rm_targetdate3", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_targetdate3", UpdateRoadmapProject.TargetDate3); }
            //                command.Parameters.AddWithValue("@rm_status", UpdateRoadmapProject.Status);
            //                if (UpdateRoadmapProject.ActualEndDate == null) { command.Parameters.AddWithValue("@rm_actualend", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_actualend", UpdateRoadmapProject.ActualEndDate); }
            //                if (UpdateRoadmapProject.CMSreviewDate == null) { command.Parameters.AddWithValue("@rm_cmsreviewdate", DBNull.Value); } else { command.Parameters.AddWithValue("@rm_cmsreviewdate", UpdateRoadmapProject.CMSreviewDate); }
                            
            //                command.Parameters.AddWithValue("@rm_isvisible", UpdateRoadmapProject.Roadmap);

            //                connection.Open();
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                return ex.Message;
            //            }
            //            finally
            //            {
            //                connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return returnVal;
        }
        public static string DeleteProjectTasks(String ProjectTaskID)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            //Added new code using DAL functionalities..
            string returnVal = string.Empty;
            List<string> paramDict = new List<string>(2);
            paramDict.Add("sp_rc_Project_deleteTasks"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@rm_id;" + ProjectTaskID + ";string");
           
            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "Sucessfully Deleted";
            else
                returnVal = "error";
            // following is the older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("sp_rc_Project_deleteTasks", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@rm_id", ProjectTaskID);
            //                connection.Open();
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                return ex.Message;
            //            }
            //            finally
            //            {
            //                connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return returnVal;
        }

        public static List<RoadmapXref> GetRoadmapAttachments(String RoadmapProjectId)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<RoadmapXref> RoadmMapReferences = new List<RoadmapXref>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            // Added new code using DAL functionalities..
            List<string> paramDict = new List<string>(2);
            paramDict.Add("rcsp_roadmap_xref_get"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@rm_id;" + RoadmapProjectId + ";string"); //order of params - paramname;paramvalue;typeofparam
            List<string> outputVars = new List<string>();
            outputVars.Add("rmxref_id");
            outputVars.Add("rm_id");
            outputVars.Add("gap_id");
            outputVars.Add("gap_open");
            outputVars.Add("gap_title");
            outputVars.Add("gap_type");
            outputVars.Add("gap_desc");
            List<controls.ReaderOutputs> outs = controls.DAL_RCServices.ExecuteReader(connectionString, paramDict, 7, outputVars);

            foreach (var item in outs)
            {
                RoadmMapReferences.Add(new RoadmapXref
                {
                    Id = item.out1.ToString(),
                    RoadmapId = item.out2.ToString(),
                    GapGoalId = item.out3.ToString(),
                    //Open = (bool)item.out4,  // need to modify the compilation error.
                    Title = item.out5.ToString(),
                    Type = item.out6.ToString(),
                    Description = item.out7.ToString()
                });
            }

            // following are the older code
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_roadmap_xref_get", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@rm_id", RoadmapProjectId);

            //                connection.Open();
            //                reader = command.ExecuteReader();

            //                while (reader.Read())
            //                {

            //                    RoadmMapReferences.Add(new RoadmapXref
            //                    {
            //                        Id = reader["rmxref_id"].ToString(),
            //                        RoadmapId = reader["rm_id"].ToString(),
            //                        GapGoalId = reader["gap_id"].ToString(),
            //                        Open = (bool)reader["gap_open"],
            //                        Title = reader["gap_title"].ToString(),
            //                        Type = reader["gap_type"].ToString(),
            //                        Description = reader["gap_desc"].ToString()
            //                    });

            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return RoadmMapReferences;
        }
        //  need to debug the written logic functionality..
        public static void InsertAssociatedGapsandGoals(string TaskID, List<string> GapandGoals)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            // Newly added code using DAL functionalities..
            
            string returnVal = string.Empty;
            foreach (var GapandGaol in GapandGoals)
            {
                List<string> paramDict = new List<string>(3);
                paramDict.Add("sp_rc_insertAssociatedGapsandGoals"); // First item as Stored procedure name if exist else set it as null
                paramDict.Add("@tasksId;" + TaskID + ";string");
                paramDict.Add("@gapId;" + GapandGaol + ";string");
                int status = controls.DAL_RCServices.ExecuteNonQuery_Transaction(connectionString, paramDict);
                if (status > 0)
                    returnVal = "";
                else
                    break;
            }
            

            // Following are older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        SqlTransaction transaction = connection.BeginTransaction();
            //        foreach (var GapandGaol in GapandGoals)
            //        {
            //            using (SqlCommand command = new SqlCommand("sp_rc_insertAssociatedGapsandGoals", connection, transaction))
            //            {
            //                try
            //                {
            //                    command.CommandType = CommandType.StoredProcedure;
            //                    command.Parameters.AddWithValue("@tasksId", TaskID);
            //                    command.Parameters.AddWithValue("@gapId", GapandGaol);

            //                    int count = command.ExecuteNonQuery();

            //                }
            //                catch (Exception ex)
            //                {
            //                }
            //            }
            //        }
            //        transaction.Commit();
            //        connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //TODO: log exception
            //}
        }
        #endregion

        #region Responses
        // need to check the functionality test..
        public static List<AssessmentResponse>  GetResponse(Guid ItemKey, String MilestoneID = "")
        {
            List<AssessmentResponse> Response = new List<AssessmentResponse>();
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            Guid ProjectID = Guid.Parse(System.Web.HttpContext.Current.Session["projectID"].ToString());
            SqlDataReader reader = null;
            // newly added using DAL functionalities..
            List<string> paramDict = new List<string>(4);
            paramDict.Add("rcsp_response_get"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@res_projectID;" + ProjectID + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@res_itemID;" + ItemKey + ";Guid");
            if (MilestoneID == "" || MilestoneID == null)
            {
                paramDict.Add("@res_milestoneID;"+ DBNull.Value+ ";DBNull");
            }
            else
            {
                paramDict.Add("@res_milestoneID;"+ Guid.Parse(MilestoneID)+";Guid");
            }
            List<string> outputVars = new List<string>();
            outputVars.Add("res_id");
            outputVars.Add("res_response");
            outputVars.Add("mil_name");
            outputVars.Add("mil_id");
            outputVars.Add("res_assessment");
            List<controls.ReaderOutputs> outs = controls.DAL_RCServices.ExecuteReader(connectionString, paramDict, 5, outputVars);

            foreach (var item in outs)
            {
                AssessmentResponse response = new AssessmentResponse();
                response.ResponseID = Guid.Parse(item.out1.ToString());
                response.ItemKey = ItemKey; // Guid.Parse(reader["res_projectID"].ToString());
                response.ProjectID = ProjectID;
                response.Response = item.out2.ToString();


                if (MilestoneID == null || MilestoneID == "")
                {


                    response.MilestoneName = item.out3.ToString();
                    response.MilestoneID = Guid.Parse(item.out4.ToString());
                }
                else
                {
                    response.Assesment = item.out5.ToString();
                    response.MilestoneID = Guid.Parse(MilestoneID.ToString());
                }
                Response.Add(response);
            }
            // following is older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_response_get", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@res_projectID", ProjectID);
            //                command.Parameters.AddWithValue("@res_itemID", ItemKey);
            //                if (MilestoneID == "" || MilestoneID == null)
            //                {
            //                    command.Parameters.AddWithValue("@res_milestoneID", DBNull.Value);
            //                }
            //                else
            //                {
            //                    command.Parameters.AddWithValue("@res_milestoneID", Guid.Parse(MilestoneID));
            //                }
            //                //command.Parameters.AddWithValue("@res_milestoneID", MilestoneID);
            //                connection.Open();
            //                reader = command.ExecuteReader();
            //                while (reader.Read())
            //                {
            //                    AssessmentResponse response = new AssessmentResponse();
            //                     response.ResponseID = Guid.Parse(reader["res_id"].ToString());
            //                    response.ItemKey = ItemKey; // Guid.Parse(reader["res_projectID"].ToString());
            //                    response.ProjectID = ProjectID;
            //                    response.Response = reader["res_response"].ToString();
                                
                               
            //                    if (MilestoneID == null || MilestoneID == "")
            //                    {
                                    

            //                        response.MilestoneName = reader["mil_name"].ToString();
            //                        response.MilestoneID = Guid.Parse(reader["mil_id"].ToString());
            //                    }
            //                    else
            //                    {
            //                        response.Assesment = reader["res_assessment"].ToString();
            //                        response.MilestoneID = Guid.Parse(MilestoneID.ToString());
            //                    }
            //                    Response.Add(response);
            //                }
                            
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return Response;
        }


        public static string InsertNewResponse(AssessmentResponse NewResponse)
        {
            
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            Guid ProjectID = Guid.Parse(System.Web.HttpContext.Current.Session["projectID"].ToString());

            string returnVal = string.Empty;
            // newly code added using DAL
            List<string> paramDict = new List<string>(5);
            paramDict.Add("rcsp_response_new"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@res_projectID;" + ProjectID + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@res_itemID;" + NewResponse.ItemKey + ";string");
            paramDict.Add("@res_response;" + NewResponse.Response + ";string");
            if (NewResponse.Assesment == "" || NewResponse.Assesment == null) { paramDict.Add("@res_assessment;null;DBNull"); }
            else { paramDict.Add("@res_assessment;"+ NewResponse.Assesment+ ";string"); }
            if (NewResponse.MilestoneID.ToString() == "" || NewResponse.MilestoneID == null) { paramDict.Add("@res_milestoneID;null;DBNull"); }
            else { paramDict.Add("@res_milestoneID;"+ Guid.Parse(NewResponse.MilestoneID.ToString()) + ";string"); }
            
            
            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "";
            else
                returnVal = "error";

            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_response_new", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@res_projectID", ProjectID);
            //                command.Parameters.AddWithValue("@res_itemID", NewResponse.ItemKey);
            //                command.Parameters.AddWithValue("@res_response", NewResponse.Response);
            //                if (NewResponse.Assesment == "" || NewResponse.Assesment == null) { command.Parameters.AddWithValue("@res_assessment", DBNull.Value); }
            //                else { command.Parameters.AddWithValue("@res_assessment", NewResponse.Assesment); }
            //                if (NewResponse.MilestoneID.ToString() == "" || NewResponse.MilestoneID == null) { command.Parameters.AddWithValue("@res_milestoneID", DBNull.Value); }
            //                else { command.Parameters.AddWithValue("@res_milestoneID", Guid.Parse(NewResponse.MilestoneID.ToString())); }

            //                connection.Open();
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                return ex.Message;
            //            }
            //            finally
            //            {
            //                connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message;
            //}
            return returnVal;
        }

        public static string SaveResponse(AssessmentResponse UpdateResponse)
        {
            string xresult = "";
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            Guid ProjectID = Guid.Parse(System.Web.HttpContext.Current.Session["projectID"].ToString());
            SqlDataReader reader = null;
            // Newly added code using DAL functionalities..
            List<string> paramDict = new List<string>(6);
            paramDict.Add("rcsp_response_update"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@res_id;" + UpdateResponse.ResponseID + ";Guid"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@res_response;" + UpdateResponse.Response + ";string");
            if (UpdateResponse.Assesment == "" || UpdateResponse.Assesment == null) { paramDict.Add("@res_assessment;"+ DBNull.Value+ ";DBNull"); }
            else { paramDict.Add("@res_assessment;"+ UpdateResponse.Assesment + ";string"); }
            if (UpdateResponse.MilestoneID.ToString() == "" || UpdateResponse.MilestoneID.ToString() == null) { paramDict.Add("@res_milestoneID;"+ DBNull.Value+ ";DBNull"); }
            else { paramDict.Add("@res_milestoneID;"+ Guid.Parse(UpdateResponse.MilestoneID.ToString())+";Guid"); }
            if (UpdateResponse.MilestoneName.ToString() == "" || UpdateResponse.MilestoneName.ToString() == null) { paramDict.Add("@res_milestoneName;"+ DBNull.Value + ";DBNull"); }
            else { paramDict.Add("@res_milestoneName;"+ Guid.Parse(UpdateResponse.MilestoneName.ToString()) + ";Guid"); }


            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                xresult = "";
            else
                xresult = "error";
            // Following is the older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_response_update", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@res_id", UpdateResponse.ResponseID);
            //                command.Parameters.AddWithValue("@res_response", UpdateResponse.Response);
            //                if (UpdateResponse.Assesment == "" || UpdateResponse.Assesment == null) { command.Parameters.AddWithValue("@res_assessment", DBNull.Value); }
            //                else { command.Parameters.AddWithValue("@res_assessment", UpdateResponse.Assesment); }
            //                if (UpdateResponse.MilestoneID.ToString() == "" || UpdateResponse.MilestoneID.ToString() == null) { command.Parameters.AddWithValue("@res_milestoneID", DBNull.Value); }
            //                else { command.Parameters.AddWithValue("@res_milestoneID", Guid.Parse(UpdateResponse.MilestoneID.ToString())); }
            //                if (UpdateResponse.MilestoneName.ToString() == "" || UpdateResponse.MilestoneName.ToString() == null) { command.Parameters.AddWithValue("@res_milestoneName", DBNull.Value); }
            //                else { command.Parameters.AddWithValue("@res_milestoneName", Guid.Parse(UpdateResponse.MilestoneName.ToString())); }

            //                connection.Open();
            //                xresult = Convert.ToString(command.ExecuteNonQuery());
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return xresult;
        }
        #endregion

        #region Evaluation

        public static DataTable GetEvaluation(string xKey, string user = null)
        {

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
           
            DataSet ds = new DataSet();
            // Newly added code using DAL functionalities..
            List<string> paramDict = new List<string>(3);
            paramDict.Add("sp_rtm_getEvaluation"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@eval_itemid;" + xKey + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@user;" + user + ";string");
            ds = controls.DAL_RCServices.ExecuteAdapter_SP_dataset(connectionString, paramDict);

            // Following are the older code
            //try

            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("sp_rtm_getEvaluation", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@eval_itemid", xKey);
            //                command.Parameters.AddWithValue("@user", user);
            //                using (var sa = new SqlDataAdapter(command))
            //                {
            //                    sa.Fill(ds);
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                if (connection.State == ConnectionState.Open)
            //                    connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}

            return ds.Tables.Count > 0 ? ds.Tables[0] : null;

        }

        public static void InsertNewEvaluation(ResponseEvaluation evaluations)
        {
            string returnVal = string.Empty;
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var CurrentProjectID = System.Web.HttpContext.Current.Session["projectID"].ToString();
            // Newly added code using DAL functionalities..
            List<string> paramDict = new List<string>(5);
            paramDict.Add("sp_rtm_insertEvaluation"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@eval_projectID;" + CurrentProjectID + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@eval_itemID;" + evaluations.ItemID + ";Guid");
            paramDict.Add("@eval_reviewer_assessments;" + evaluations.ReviwerAssessment + ";string");
            paramDict.Add("@eval_description;" + evaluations.ReviwerComments + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@eval_date;" + evaluations.ReviwerDate + ";DateTime");
            paramDict.Add("@eval_by;" + evaluations.ReviwerBy + ";string");

            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "";
            else
                returnVal = "error";
            // Following are the older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        using (SqlCommand command = new SqlCommand("sp_rtm_insertEvaluation", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@eval_projectID", CurrentProjectID);
            //                command.Parameters.AddWithValue("@eval_itemID", evaluations.ItemID);
            //                command.Parameters.AddWithValue("@eval_reviewer_assessments", evaluations.ReviwerAssessment);
            //                command.Parameters.AddWithValue("@eval_description", evaluations.ReviwerComments);
            //                command.Parameters.AddWithValue("@eval_date", evaluations.ReviwerDate);
            //                command.Parameters.AddWithValue("@eval_by", evaluations.ReviwerBy);
            //                command.ExecuteNonQuery();

            //            }
            //            catch (Exception ex)
            //            {
            //                //TODO: log exception;
            //                connection.Close();
            //            }
            //        }
            //        if (connection.State == ConnectionState.Open)
            //            connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //TODO: log exception
            //}
        }

        #endregion

        #region Scorecard

        public static String SaveCardAsMatrix(String card_id, List<rtm_services.UniversalAssessmentItem> items)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("id");
            dataTable.Columns.Add("RC_ID");
            dataTable.Columns.Add("RC_NAME");
            dataTable.Columns.Add("RC_TYPE");
            foreach (rtm_services.UniversalAssessmentItem x in items)
            {
                dataTable.Rows.Add(x.Id, x.UniqueID, x.Name, x.Type);
            }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            // Newly added code using DAL functionalities..
            string returnVal = string.Empty;
            List<string> paramDict = new List<string>(3);
            paramDict.Add("rcsp_scorecard_matrixupdate"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@card_id;" + Guid.Parse(card_id) + ";Guid"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@Items;" + dataTable + ";Structured");


            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "";
            else
                returnVal = "error";
            // Following is the older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionS tring))
            //    {
            //        connection.Open();
            //        using (SqlCommand command = new SqlCommand("rcsp_scorecard_matrixupdate", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@card_id", Guid.Parse(card_id));
            //                command.Parameters.Add("@Items", SqlDbType.Structured).Value = dataTable;
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                //TODO: log exception;
            //                connection.Close();
            //            }
            //        }
            //        if (connection.State == ConnectionState.Open)
            //            connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //TODO: log exception
            //}

            return returnVal;
        }
        public static string FillScorecard()
        {
            //First, query database to get a list of standards associated with this scorecard. They will be needed to fill the StandardsList for the store procedure
            ScoreStandardsList xStandards = new ScoreStandardsList();
            //SqlDataSource sqlStandard = new SqlDataSource();
            //sqlStandard.ConnectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            //sqlStandard.SelectCommand = "SELECT rc_scorecards.card_id, rc_scorecards_standards.stan_id FROM rc_scorecards INNER JOIN rc_scorecards_standards ON rc_scorecards.card_id = rc_scorecards_standards.stan_card WHERE (rc_scorecards.card_id = @card_id)";
            //sqlStandard.SelectParameters.Clear();
            //sqlStandard.SelectParameters.Add("card_id", card_id);

            SqlConnection RepCon = new SqlConnection(System.Web.HttpContext.Current.Session["userConnString"].ToString());
            SqlCommand sqlCmdGet = new SqlCommand("rcsp_scorecards_getall", RepCon);
            SqlDataReader CardsReader = null;
            try
            {
                RepCon.Open();
                sqlCmdGet.CommandType = CommandType.StoredProcedure;  
                //sqlCmdGet.ExecuteNonQuery();
                
                CardsReader = sqlCmdGet.ExecuteReader();
        
                while (CardsReader.Read())
                {
                    xStandards.Add(new ScoreStandards
                    {
                        StandardID = CardsReader["stan_id"].ToString(),
                        CardID = CardsReader["card_id"].ToString(),
                        ItemID = CardsReader["matrix_itemkey"].ToString()
                    });
                }
            }

            catch (Exception ex)
            {
                return "error: " + ex.Message;

            }
            finally
            {
                //RepCon.Close();

            }

            //select and loop through to build a datable that can be used as a query parameter
            ScoreStandardsList AllStandards = new ScoreStandardsList();

            DataTable tableStandard = new DataTable();
            List<DropdownItem> ProjectsList = common_services.GetProjects();

            foreach (DropdownItem Project in ProjectsList)
            {
                foreach (ScoreStandards row in xStandards)
                {
                    AllStandards.Add(new ScoreStandards() { ProjectID = Project.Id, ItemID = row.ItemID, CardID = row.CardID, StandardID = row.StandardID });
                }
            }
            RepCon.Close();
            RepCon.Open();
            SqlCommand sqlCmd = new SqlCommand("rcsp_scorecard_fill", RepCon);
            try
            {
            
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@Items", SqlDbType.Structured).Value = AllStandards.GetStandardsTable();
               
                sqlCmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                return "error: " + ex.Message;

            }
            finally
            {
                RepCon.Close();

            }
            return "score rows successfully";




        }
        public static string SaveScoreDescription(string card_id, string score_itemid, string score_projectid, string scoreDescription)
        {
            string xresult = "";
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            SqlDataReader reader = null;
            // Newly added code using DAL functionalities..
            List<string> paramDict = new List<string>(5);
            paramDict.Add("rc_sp_newscoredescription"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@des_cardId;" + card_id + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@des_itemkey;" + score_itemid + ";string");
            paramDict.Add("@des_projectId;" + score_projectid + ";string");
            paramDict.Add("@des_description;" + scoreDescription + ";string");

            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                xresult = "";
            else
                xresult = "error";


            // Following is the older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rc_sp_newscoredescription", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@des_cardId", card_id);
            //                command.Parameters.AddWithValue("@des_itemkey", score_itemid);
            //                command.Parameters.AddWithValue("@des_projectId", score_projectid);
            //                command.Parameters.AddWithValue("@des_description", scoreDescription);

            //                connection.Open();
            //                xresult = Convert.ToString(command.ExecuteNonQuery());
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return xresult;
        }
        public static List<Scorecard> GetScorecards(String ItemID)
        {
            List<Scorecard> ScorecardsTable = new List<Scorecard>();
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            SqlDataReader reader = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_scorecard_get", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@matrix_itemkey", SqlDbType.UniqueIdentifier).Value = Guid.Parse(ItemID);
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                bool Col1 = false;
                                bool Col2 = false;
                                bool Col3 = false;
                                bool Col4 = false;
                                bool Col5 = false;
                                bool Measures = false;
                                if (reader["card_colenabled1"].ToString() != "") { Col1 = (bool)reader["card_colenabled1"]; } else { Col1 = false; }
                                if (reader["card_colenabled2"].ToString() != "") { Col2 = (bool)reader["card_colenabled2"]; } else { Col2 = false; }
                                if (reader["card_colenabled3"].ToString() != "") { Col3 = (bool)reader["card_colenabled3"]; } else { Col3 = false; }
                                if (reader["card_colenabled4"].ToString() != "") { Col4 = (bool)reader["card_colenabled4"]; } else { Col4 = false; }
                                if (reader["card_colenabled5"].ToString() != "") { Col5 = (bool)reader["card_colenabled5"]; } else { Col5 = false; }
                                if (reader["card_measure"].ToString() != "") { Measures = (bool)reader["card_measure"]; } else { Measures = false; }
                                ScorecardsTable.Add(new Scorecard
                                {
                                    CardId = reader["card_id"].ToString(),
                                    CardName = reader["card_name"].ToString(),
                                    CardDescription = reader["card_desc"].ToString(),
                                    MeasuredEnabled = Measures,
                                    MeasureDescription = reader["card_measure_notes"].ToString(),
                                    CardCol1 = reader["card_col1"].ToString(),
                                    CardCol2 = reader["card_col2"].ToString(),
                                    CardCol3 = reader["card_col3"].ToString(),
                                    CardCol4 = reader["card_col4"].ToString(),
                                    CardCol5 = reader["card_col5"].ToString(),
                                    EnabledCol1 = Col1,
                                    EnabledCol2 = Col2,
                                    EnabledCol3 = Col3,
                                    EnabledCol4 = Col4,
                                    EnabledCol5 = Col5,
                                    Measure1 = reader["card_measure1"].ToString(),
                                    Measure2 = reader["card_measure2"].ToString(),
                                    Measure3 = reader["card_measure3"].ToString(),
                                    Measure4 = reader["card_measure4"].ToString(),
                                    Measure5 = reader["card_measure5"].ToString(),

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ScorecardsTable;
        }
        public static List<Scores> GetScores(String projectID, String ItemID, String CardID)
        {
            List<Scores> ScoreTable = new List<Scores>();

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_scorecard_scores_get", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@score_itemid", SqlDbType.UniqueIdentifier).Value = Guid.Parse(ItemID);
                            command.Parameters.Add("@score_projectid", SqlDbType.UniqueIdentifier).Value = Guid.Parse(projectID);
                            command.Parameters.Add("@card_id", SqlDbType.UniqueIdentifier).Value = Guid.Parse(CardID);
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                ScoreTable.Add(new Scores
                                {
                                    CardId = reader["card_id"].ToString(),
                                    StandardId = reader["stan_id"].ToString(),
                                    StandardName = reader["stan_standard"].ToString(),
                                    Quality = reader["stan_capabilityquality"].ToString(),
                                    ItemId = reader["score_itemid"].ToString(),
                                    ScoreId = reader["score_id"].ToString(),
                                    ScoreCol1 = (int)reader["score_col1"],
                                    ScoreCol2 = (int)reader["score_col2"],
                                    ScoreCol3 = (int)reader["score_col3"],
                                    ScoreCol4 = (int)reader["score_col4"],
                                    ScoreCol5 = (int)reader["score_col5"],
                                    Measure1 = reader["score_colmeasure1"].ToString(),
                                    Measure2 = reader["score_colmeasure2"].ToString(),
                                    Measure3 = reader["score_colmeasure3"].ToString(),
                                    Measure4 = reader["score_colmeasure4"].ToString(),
                                    Measure5 = reader["score_colmeasure5"].ToString(),

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return ScoreTable;
        }
        public static string SaveScores(ScoreStandardsList NewScores)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            // Added new code using DAL functionalities..
            string returnVal = string.Empty;
            List<string> paramDict = new List<string>(2);
            paramDict.Add("rcsp_scorecard_scores_save"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@Items;" + NewScores.GetStandardsTable() + ";Structured"); //order of params - paramname;paramvalue;typeofparam
            

            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "";
            else
                returnVal = "error";

            // Following is the older code..
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();
            //        SqlCommand command;
            //        try
            //        {
            //            command = new SqlCommand("rcsp_scorecard_scores_save", connection);
            //            command.CommandType = CommandType.StoredProcedure;
            //            command.Parameters.Add("@Items", SqlDbType.Structured).Value = NewScores.GetStandardsTable();
            //            var result = command.ExecuteNonQuery();

            //        }
            //        catch (Exception ex)
            //        {
            //            //TODO: log exception;
            //            connection.Close();
            //        }

            //        if (connection.State == ConnectionState.Open)
            //            connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //TODO: log exception
            //}
            return returnVal;
        }

        #endregion

        #region Security
        // Find all controls in page, to check if they are SqlDataSources and check their connection strings
        public static void FindAllDataSources(ref Page CurrentPage)
        {
            Control PageControl;
            foreach (Control ctrl in CurrentPage.Controls)
            {
                PageControl = ctrl;
                FindChildControls(ref PageControl);
            }
        }
        //FUnction to check each child control for SqlDataSource
        public static void FindChildControls(ref Control CurrentControl)
        {
            SqlDataSource DataControl;
            //If control is SqlDatasource, then change connection string.
            if (CurrentControl is SqlDataSource)
            {
                DataControl = (SqlDataSource)CurrentControl;
                DataControl.ConnectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
                CurrentControl = DataControl;
            }

            //REcursive call to find all chldren control, to also check if they are SqlDataSources
            Control ChildControl;
            foreach (Control SubControl in CurrentControl.Controls)
            {
                ChildControl = SubControl;
                FindChildControls(ref ChildControl);
            }
        }
        public static bool CheckPermission(string Permission)
        {

            List<ActivePermission> CurrentPermissions = (List<ActivePermission>)HttpContext.Current.Session["ActivePermissions"];
            ActivePermission CurrentRequest = CurrentPermissions.Find(x => x.PermissionCode.ToUpper() == Permission.ToUpper());

            if (CurrentRequest == null) { return false; }
            return CurrentRequest.Authorized;


        }
        public static List<ActivePermission> GetActivePermissions()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<ActivePermission> PermissionTables = new List<ActivePermission>();
            List<ActivePermission> EnterprisePermissions = new List<ActivePermission>();
            List<ActivePermission> ProjectPermissions = new List<ActivePermission>();

            SqlDataReader EnterpriseReader = null;
            SqlDataReader ProjectReader = null;


            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_security_get_permissions_enterprise", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@entrole_user", HttpContext.Current.Session["UserID"]);

                            connection.Open();

                            EnterpriseReader = command.ExecuteReader();

                            while (EnterpriseReader.Read())
                            {
                                EnterprisePermissions.Add(new ActivePermission
                                {
                                    PermissionCode = EnterpriseReader["perm_code"].ToString(),
                                    Authorized = (bool)EnterpriseReader["perm_authorized"]
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            EnterpriseReader.Close();
                        }
                    }
                }

                using (SqlConnection Projectconnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand Projectcommand = new SqlCommand("rcsp_security_get_permissions_project", Projectconnection))
                    {
                        try
                        {
                            Projectcommand.CommandType = CommandType.StoredProcedure;
                            Projectcommand.Parameters.AddWithValue("@usrole_user", HttpContext.Current.Session["UserID"]);
                            Projectcommand.Parameters.AddWithValue("@usrole_projectID", HttpContext.Current.Session["projectID"]);

                            Projectconnection.Open();

                            ProjectReader = Projectcommand.ExecuteReader();

                            while (ProjectReader.Read())
                            {
                                ProjectPermissions.Add(new ActivePermission
                                {
                                    PermissionCode = ProjectReader["perm_code"].ToString(),
                                    Authorized = (bool)ProjectReader["perm_authorized"]
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            ProjectReader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }


            //Add always clear pages, so user is not blocked at global page name security check
            List<ActivePermission> AlwaysClear = new List<ActivePermission>();
            AlwaysClear.Add(new ActivePermission() { PermissionCode = "Login", Authorized = true });
            AlwaysClear.Add(new ActivePermission() { PermissionCode = "ForgotPassword", Authorized = true });
            AlwaysClear.Add(new ActivePermission() { PermissionCode = "userhome", Authorized = true });
            AlwaysClear.Add(new ActivePermission() { PermissionCode = "unauthorized", Authorized = true });
            AlwaysClear.Add(new ActivePermission() { PermissionCode = "Confirm", Authorized = true });
            AlwaysClear.Add(new ActivePermission() { PermissionCode = "ResetPasswordConfirmation", Authorized = true });
            AlwaysClear.Add(new ActivePermission() { PermissionCode = "ResetPassword", Authorized = true });

            PermissionTables.AddRange(EnterprisePermissions);
            PermissionTables.AddRange(ProjectPermissions);
            PermissionTables.AddRange(AlwaysClear);

            //if (Permission == "Login" || Permission == "ForgotPassword" || Permission == "userhome" || Permission == "unauthorized" || Permission == "Confirm" || Permission == "ResetPasswordConfirmation" || Permission == "ResetPassword")
            HttpContext.Current.Session.Add("ActivePermissions", PermissionTables);
            return PermissionTables;
        }
        public static string FillEnterpriseUserRoles()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            RCuserList existingusers = GetUsers();
            DataTable Users = existingusers.GetUserTable();
            ProjectUserRoleList newroles = new ProjectUserRoleList();
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();


            foreach (var item in existingusers)
            {
                newroles.Add(new ProjectUserRole
                {
                    Id = Guid.Empty,
                    UserID = Guid.Parse(item.UserID.ToString()),
                    RoleID = Guid.Empty
                });
            }
            DataTable FillRoles = newroles.RoleAssignmentDataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_security_fillentuserroles", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Items", SqlDbType.Structured).Value = FillRoles;
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return "";
        }
        public static string FillProjectUserRoles() //string projectID
        {
            RCuserList existingusers = GetUsers();
            DataTable Users = existingusers.GetUserTable();
            ProjectUserRoleList newroles = new ProjectUserRoleList();
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            List<DropdownItem> ExistingProjects = common_services.GetProjects();

            foreach (var xProject in ExistingProjects)
            {
                foreach (var item in existingusers)
                {
                    newroles.Add(new ProjectUserRole
                    {
                        Id = Guid.Empty,
                        UserID = Guid.Parse(item.UserID.ToString()),
                        //RoleID = Guid.Empty,
                        ProjectID = Guid.Parse(xProject.Id)
                    });
                }
            }



            DataTable FillRoles = newroles.RoleAssignmentDataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_security_fillprojectuserroles", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Items", SqlDbType.Structured).Value = FillRoles;
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return "";

        }

        public static string UpdateProjectUserRoles(ProjectUserRoleList NewRoles)
        {
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            DataTable RolesTable = NewRoles.RoleAssignmentDataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_security_alterprojectrole", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Items", SqlDbType.Structured).Value = RolesTable;
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return "1";
        }
        //public static string UpdateEnterpriseUserRoles(ProjectUserRoleList NewRoles)
        //{
        //    if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
        //    string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
        //    DataTable RolesTable = NewRoles.RoleAssignmentDataTable();

        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            using (SqlCommand command = new SqlCommand("rcsp_security_updateenterpriserole", connection))
        //            {
        //                try
        //                {
        //                    command.CommandType = CommandType.StoredProcedure;
        //                    command.Parameters.Add("@Items", SqlDbType.Structured).Value = RolesTable;
        //                    connection.Open();
        //                    command.ExecuteNonQuery();
        //                }
        //                catch (Exception ex)
        //                {
        //                    return ex.Message;
        //                }
        //                finally
        //                {
        //                    connection.Close();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // return rtmList;
        //    }

        //    return "1";
        //}
        public static string FillProjectRolePermissions(Guid perm_roleID)
        {
            // Get all Permission Definitions from procedure rcsp_security_getdefinitions, which takes the RoleID to fill in a column with the role ID, 
            //making the returned datatable have the right format (user defined table type 'RolePermissionsTable').
            //Then take the returned data table and use it as a parameter for a stored procedure which fills out any missing records (rcsp_security_fillrolepermissions)
            DataTable tableDefinitions = new DataTable();
            using (var con = new SqlConnection(System.Web.HttpContext.Current.Session["userConnString"].ToString()))
            using (var cmd = new SqlCommand("rcsp_security_getdefinitions_project", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@RoleID", SqlDbType.UniqueIdentifier).Value = perm_roleID;
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(tableDefinitions);


                SqlCommand cmdFillRoles = new SqlCommand("rcsp_security_fillrolepermissions", con);
                cmdFillRoles.CommandType = CommandType.StoredProcedure;
                cmdFillRoles.Parameters.Add("@Items", SqlDbType.Structured).Value = tableDefinitions;

                try
                {
                    con.Open();
                    cmdFillRoles.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return "error: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }


            }

            //Use the returned datatable as an input parameter for the 



            return "project role definitions filled successfully";




        }
        public static string FillEnterpriseRolePermissions(Guid perm_roleID)
        {
            // Get all Permission Definitions from procedure rcsp_security_getdefinitions, which takes the RoleID to fill in a column with the role ID, 
            //making the returned datatable have the right format (user defined table type 'RolePermissionsTable').
            //Then take the returned data table and use it as a parameter for a stored procedure which fills out any missing records (rcsp_security_fillrolepermissions)
            DataTable tableDefinitions = new DataTable();
            using (var con = new SqlConnection(System.Web.HttpContext.Current.Session["userConnString"].ToString()))
            using (var cmd = new SqlCommand("rcsp_security_getdefinitions_enterprise", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@RoleID", SqlDbType.UniqueIdentifier).Value = perm_roleID;
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(tableDefinitions);


                SqlCommand cmdFillRoles = new SqlCommand("rcsp_security_fillrolepermissions", con);
                cmdFillRoles.CommandType = CommandType.StoredProcedure;
                cmdFillRoles.Parameters.Add("@Items", SqlDbType.Structured).Value = tableDefinitions;

                try
                {
                    con.Open();
                    cmdFillRoles.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return "error: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }


            }

            //Use the returned datatable as an input parameter for the 



            return "score rows successfully";




        }
        public static RCuserList GetUsers()
        {
            if (System.Web.HttpContext.Current.Session["enterpriseID"] == null) { common_services.RefreshSession(); }

            RCuserList Users = new RCuserList();
            var connectionString = common_services.BuildConnString("rcxidentity", true); // System.Configuration.ConfigurationManager.ConnectionStrings["RCXidentity"].ConnectionString;
            //SqlDataReader reader = null;

            // new code by using new DAL functionalities..
            List<string> paramDict = new List<string>(2);
            paramDict.Add("rcsp_security_getusers"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@enterprise;" + System.Web.HttpContext.Current.Session["enterpriseID"].ToString().ToUpper() + ";SqlDbType.UniqueIdentifier"); //order of params - paramname;paramvalue;typeofparam
            List<string> outputVars = new List<string>();
            outputVars.Add("Id");
            outputVars.Add("Email");
            outputVars.Add("project");
            outputVars.Add("EmailConfirmed");
            outputVars.Add("PhoneNumber");
            List<controls.ReaderOutputs> outs = controls.DAL_RCServices.ExecuteReader(connectionString, paramDict, 5, outputVars);
            
            foreach (var item in outs)
            {
                Users.Add(new RCuser
                {
                    UserID = item.out1.ToString(),
                    Email = item.out2.ToString(),
                    ProjectID = item.out3.ToString(),
                    EmailConfirmed = Convert.ToBoolean(item.out4.ToString()),  //  need to parse it as true or false..
                    PhoneNumber = item.out5.ToString()
                });
            }
            // older code 

            //try

            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_security_getusers", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.Add("@enterprise", SqlDbType.UniqueIdentifier).Value = Guid.Parse(System.Web.HttpContext.Current.Session["enterpriseID"].ToString().ToUpper());

            //                connection.Open();
            //                reader = command.ExecuteReader();
            //                var xSchema = reader.GetSchemaTable();
            //                while (reader.Read())
            //                {
            //                    Users.Add(new RCuser
            //                    {
            //                        UserID = reader["Id"].ToString(),
            //                        Email = reader["Email"].ToString(),
            //                        ProjectID = reader["project"].ToString(),
            //                        EmailConfirmed = Convert.ToBoolean(reader["EmailConfirmed"].ToString()),
            //                        PhoneNumber = reader["PhoneNumber"].ToString()



            //                    });
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return Users;

        }
        public static List<ProjectRole> GetProjectUserRoles(Guid projectID)
        {
            {

                List<ProjectRole> projectRoles = new List<ProjectRole>();
                var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
                SqlDataReader reader = null;

                try

                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand("rcsp_security_getprojectroles", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("@enterprise", SqlDbType.UniqueIdentifier).Value = Guid.Parse(System.Web.HttpContext.Current.Session["enterpriseID"].ToString());

                                command.Parameters.Add("@usrole_projectID", SqlDbType.UniqueIdentifier).Value = projectID;
                                connection.Open();
                                reader = command.ExecuteReader();

                                while (reader.Read())
                                {
                                    projectRoles.Add(new ProjectRole
                                    {
                                        RoleAssignmentID = reader["usrole_id"].ToString(),
                                        UserID = reader["Id"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        RoleName = reader["roles_name"].ToString(),
                                        RoleID = reader["roles_id"].ToString(),
                                        ProjectID = reader["usrole_projectID"].ToString(),
                                        ProjectName = reader["pro_name"].ToString()

                                    });
                                }
                            }
                            catch (Exception ex)
                            {
                                // return rtmList;
                            }
                            finally
                            {
                                reader.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // return rtmList;
                }
                return projectRoles;


            }
        }
        public static List<ProjectRole> GetEnterpriseUserRoles()
        {
            {

                List<ProjectRole> projectRoles = new List<ProjectRole>();
                var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
                SqlDataReader reader = null;

                try

                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand("rcsp_security_enterprise_userroles_get", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("@enterprise", SqlDbType.UniqueIdentifier).Value = Guid.Parse(System.Web.HttpContext.Current.Session["enterpriseID"].ToString());

                                connection.Open();
                                reader = command.ExecuteReader();

                                while (reader.Read())
                                {
                                    projectRoles.Add(new ProjectRole
                                    {
                                        RoleAssignmentID = reader["entrole_id"].ToString(),
                                        UserID = reader["Id"].ToString(),
                                        Email = reader["Email"].ToString(),
                                        RoleName = reader["roles_name"].ToString(),
                                        RoleID = reader["roles_id"].ToString()

                                    });
                                }
                            }
                            catch (Exception ex)
                            {
                                // return rtmList;
                            }
                            finally
                            {
                                reader.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // return rtmList;
                }
                return projectRoles;


            }
        }

        public static List<UserStatistics> GetUserStatistics()
        {

            List<UserStatistics> compList = new List<UserStatistics>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_getUserStatistics", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                compList.Add(new UserStatistics
                                {
                                    UserStatisticsID = reader["UserStatisticsID"].ToString(),
                                    UserName = reader["UserName"] == DBNull.Value ? string.Empty : reader["UserName"].ToString(),
                                    ProjectName = reader["ProjectName"] == DBNull.Value ? string.Empty : reader["ProjectName"].ToString(),
                                    EventName = reader["EventName"] == DBNull.Value ? string.Empty : reader["EventName"].ToString(),
                                    IPAddress = reader["IPAdress"] == DBNull.Value ? string.Empty : reader["IPAdress"].ToString(),
                                    EventTime = reader["EventTime"].ToString() == "" ? "" : Convert.ToDateTime(reader["EventTime"].ToString()).ToString(),
                                    Notes = reader["Notes"] == DBNull.Value ? string.Empty : reader["Notes"].ToString()

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return compList;


        }
        #endregion

        #region RC_Repository

        public static List<Artifact> GetArtifacts(string IncludeEnterprise)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            //Frame an array with proper parameters to send to DAL
            List<string> paramDict = new List<string>(2);
            paramDict.Add("sp_rc_repository_GetAll"); // First item as Stored procedure name if exist else set it as null
            //paramDict.Add("2"); // Send the number of parameter the SP or query takes if nothing then send it as zero(0).
            paramDict.Add("@lib_projectID;" + System.Web.HttpContext.Current.Session["projectID"].ToString() + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@enterprise;" + IncludeEnterprise + ";string");

            DataSet ds1 = controls.DAL_RCServices.ExecuteReader_SP_dataset(connectionString, paramDict);
            
            // older code 
            List<Artifact> Library = new List<Artifact>();
            
            SqlDataReader reader = null;
            //Guid ParseProID;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_repository_GetAll", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@lib_projectID", System.Web.HttpContext.Current.Session["projectID"].ToString());
                            command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);

                            connection.Open();
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                Library.Add(new Artifact
                                {
                                    ArtifactID = Guid.Parse(reader["lib_id"].ToString()),
                                    //ProjectID = (Guid.TryParse(reader["lib_projectID"].ToString(), out ParseProID)) ? Guid.Parse(reader["lib_projectID"].ToString()) : Guid.Empty,
                                    //ProjectID = reader["lib_projectID"].ToString(),
                                    Title = reader["lib_title"].ToString(),
                                    Type = reader["lib_type"].ToString(),
                                    Home = reader["lib_home"].ToString(),
                                    filename = reader["lib_filename"].ToString(),
                                    filestoragename = reader["lib_storagename"].ToString(),
                                    Description = reader["lib_desc"].ToString(),
                                    filetext = reader["lib_textsearch"].ToString(),
                                    DateUploaded = reader["lib_dateuploaded"].ToString(),
                                    UploadedBy = reader["lib_uploadedby"].ToString(),
                                    //ChangedBy = Guid.Parse(reader["lib_changeby"].ToString()),
                                    UploadedByName = reader["lib_uploadedbyname"].ToString(),
                                    //ChangedByName = reader["lib_changedbyname"].ToString(),

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return Library;


        }

        public static String NewArtifact(string lib_projectID, string lib_title, string lib_type, string lib_home, string lib_filename, string lib_storagename, string lib_desc, string lib_textsearch, string lib_uploadedby)
        {
            string result = "";
            string projectID = System.Web.HttpContext.Current.Session["projectID"].ToString();
            SqlConnection RepCon = new SqlConnection(System.Web.HttpContext.Current.Session["userConnString"].ToString());
            SqlCommand sqlCmd = new SqlCommand("rcsp_newartifact", RepCon);
            SqlDataReader sqlDataReader;
            try
            {
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (lib_home == "P")
                    sqlCmd.Parameters.AddWithValue("@lib_projectID", lib_projectID);
                else
                    sqlCmd.Parameters.AddWithValue("@lib_projectID", DBNull.Value);

                sqlCmd.Parameters.AddWithValue("@lib_title", lib_title);
                sqlCmd.Parameters.AddWithValue("@lib_type", lib_type);
                sqlCmd.Parameters.AddWithValue("@lib_home", lib_home);
                sqlCmd.Parameters.AddWithValue("@lib_filename", lib_filename);
                sqlCmd.Parameters.AddWithValue("@lib_storagename", lib_storagename);
                sqlCmd.Parameters.AddWithValue("@lib_desc", lib_desc);
                sqlCmd.Parameters.AddWithValue("@lib_textsearch", lib_textsearch);
                sqlCmd.Parameters.AddWithValue("@lib_uploadedby", lib_uploadedby);

                RepCon.Open();
                sqlDataReader = sqlCmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    result = sqlDataReader["lib_id"].ToString();
                }

            }

            catch (Exception ex)
            {
                return "error: " + ex.Message;

            }
            finally
            {
                RepCon.Close();

            }
            return result;


        }

        public static string UpdateRepository(Artifact artifact)
        {
            
            string projectID = System.Web.HttpContext.Current.Session["projectID"].ToString();
            SqlConnection RepCon = new SqlConnection(System.Web.HttpContext.Current.Session["userConnString"].ToString());
            SqlCommand sqlCmd = new SqlCommand("sp_rc_repository_Update", RepCon);
           
            try
            {
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (artifact.Home == "P")
                    sqlCmd.Parameters.AddWithValue("@lib_projectID", artifact.ProjectID);
                else
                    sqlCmd.Parameters.AddWithValue("@lib_projectID", DBNull.Value);
                sqlCmd.Parameters.AddWithValue("@lib_id", artifact.ArtifactID);
                sqlCmd.Parameters.AddWithValue("@lib_title", artifact.Title);
                sqlCmd.Parameters.AddWithValue("@lib_type", artifact.Type);
                sqlCmd.Parameters.AddWithValue("@lib_home", artifact.Home);
                sqlCmd.Parameters.AddWithValue("@lib_filename", artifact.filename);
                sqlCmd.Parameters.AddWithValue("@lib_storagename", artifact.filestoragename);
                sqlCmd.Parameters.AddWithValue("@lib_desc", artifact.Description);
                sqlCmd.Parameters.AddWithValue("@lib_textsearch", artifact.filetext);
                sqlCmd.Parameters.AddWithValue("@lib_uploadedby", artifact.UploadedBy);
                sqlCmd.Parameters.AddWithValue("@lib_changeby", artifact.ChangedBy);
                sqlCmd.Parameters.AddWithValue("lib_dateuploaded", artifact.DateUploaded);

                RepCon.Open();
                sqlCmd.ExecuteReader();
                

            }

            catch (Exception ex)
            {
                return ex.Message;

            }
            finally
            {
                RepCon.Close();

            }

            return "Sucessfully Update";

        }

        public static void DeleteRepository(String ArtifactID)
        {

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_rc_repository_Delete", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@artifactID", ArtifactID);

                            command.ExecuteNonQuery();


                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

    

        public static List<Artifact> GetRepository(String Home, Boolean Deleted = false)
        {
            List<Artifact> Library = new List<Artifact>();

            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            Guid ProjectID = Guid.Parse(System.Web.HttpContext.Current.Session["projectID"].ToString());
            SqlDataReader reader = null;
          
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_artifacts_get", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@lib_home", Home);
                            command.Parameters.AddWithValue("@lib_deleted", Deleted ? 1 : 0);
                            //if (Home == "E") { command.Parameters.AddWithValue("@lib_projectID", DBNull.Value); }
                            //else { command.Parameters.AddWithValue("@lib_projectID", ProjectID); }
                            command.Parameters.AddWithValue("@lib_projectID", ProjectID);

                            connection.Open();
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                Library.Add(new Artifact
                                {
                                    ArtifactID = Guid.Parse(reader["lib_id"].ToString()),
                                    //ProjectID = (Guid.TryParse(reader["lib_projectID"].ToString(), out ParseProID)) ? Guid.Parse(reader["lib_projectID"].ToString()) : Guid.Empty,
                                    ProjectID = reader["lib_projectID"].ToString(),
                                    Title = reader["lib_title"].ToString(),
                                    Type = reader["lib_type"].ToString(),
                                    Home = reader["lib_home"].ToString(),
                                    filename = reader["lib_filename"].ToString(),
                                    filestoragename = reader["lib_storagename"].ToString(),
                                    Description = reader["lib_desc"].ToString(),
                                    filetext = reader["lib_textsearch"].ToString(),
                                    DateUploaded = reader["lib_dateuploaded"].ToString(),
                                    UploadedBy = reader["lib_uploadedby"].ToString(),
                                    ChangedBy = reader["lib_changeby"].ToString(),
                                    UploadedByName = reader["lib_uploadedbyname"].ToString(),
                                    ChangedByName = reader["lib_changedbyname"].ToString(),
                                    Deleted = (reader["lib_changeby"].ToString() == "0") ? false : true
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return Library;
        }
        public static string AttachArtifact(AttachmentList AttachPoints)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    foreach (Attachment item in AttachPoints)
                    {
                        using (SqlCommand sqlCmd = new SqlCommand("rcsp_attachments_new", connection, transaction))
                        {
                            try
                            {
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                sqlCmd.Parameters.AddWithValue("@att_artifact", item.ArtifactID);
                                sqlCmd.Parameters.AddWithValue("@att_itemid", item.ItemID);
                                if (item.ProjectID == "")
                                    sqlCmd.Parameters.AddWithValue("@att_projectid", DBNull.Value);
                                else
                                    sqlCmd.Parameters.AddWithValue("@att_projectid", item.ProjectID);

                                sqlCmd.Parameters.AddWithValue("@att_pageref", item.PageReference);

                                int count = sqlCmd.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return "Artifact attached successfully";

        }
       
        public static List<Attachment> GetAttachments(Guid ItemID)
        {
            List<Attachment> Attachments = new List<Attachment>();
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            Guid ProjectID = Guid.Parse(System.Web.HttpContext.Current.Session["projectID"].ToString());
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_attachments_get", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@att_projectID", ProjectID);
                            command.Parameters.AddWithValue("@att_itemid", ItemID);
                            connection.Open();
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                Attachments.Add(new Attachment
                                {
                                    AttachmentID = reader["att_id"].ToString(),
                                    ArtifactID = reader["lib_id"].ToString(),
                                    DateAttached = DateTime.Parse(reader["att_date"].ToString()),
                                    ProjectID = reader["att_projectID"].ToString(),
                                    ItemID = reader["att_itemid"].ToString(),
                                    PageReference = reader["att_pageref"].ToString(),
                                    ArtifactTitle = reader["lib_title"].ToString(),
                                    ArtifactType = reader["lib_type"].ToString(),
                                    ArtifactHome = reader["lib_home"].ToString(),
                                    filename = reader["lib_filename"].ToString(),
                                    filestoragename = reader["lib_storagename"].ToString()
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return Attachments;

        }
        public static String DeleteAttachment(Guid AttachmentID)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlTransaction transaction;
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("rcsp_attachments_delete", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@att_id", AttachmentID);
                            int count = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return "";
        }

        public static int CheckExistingFileName(string fileName)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlTransaction transaction;
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_rc_getDuplicateFileName", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@fileName", fileName);
                            using (SqlDataAdapter sa = new SqlDataAdapter(command))
                            {
                                sa.Fill(dt);
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return dt != null ? dt.Rows.Count : -1;
        }


        public static List<ReositoryAttachments> GetRepositoryAttachments(String RepositoryId)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<ReositoryAttachments> RoadmMapReferences = new List<ReositoryAttachments>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_repository_attachments_get", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@artifactID", RepositoryId);

                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {

                                RoadmMapReferences.Add(new ReositoryAttachments
                                {
                                    Id = reader["id"].ToString(),
                                    Title = reader["RC_ID"].ToString(),
                                    Name = reader["RC_NAME"].ToString(),

                                    Type = reader["RC_TYPE"].ToString(), 
                                    
                                });

                            }
                        }
                        catch (Exception ex)
                        {
                            
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
            return RoadmMapReferences;


        }

        public static DataTable GetRepositoryAttachmentsHistory(String RepositoryId)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_repository_attachmentsHistory_get", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@his_artifactID", RepositoryId);
                         
                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;


        }

        #endregion

        #region workflow
        public static List<Workflow> GetWorkflow(Guid ItemID, Guid ProjectID)
        {

            List<Workflow> WorkflowReturn = new List<Workflow>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_workflow_get", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@wf_itemkey", ItemID);
                            command.Parameters.AddWithValue("@wf_projectid", ProjectID);
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                WorkflowReturn.Add(new Workflow
                                {
                                    Id = (Guid)reader["wf_id"],
                                    ItemKey = (Guid)reader["wf_itemkey"],
                                    ProjectID = (Guid)reader["wf_projectid"],
                                    Status = (String)reader["wf_status"],
                                    StatusValue = (int)reader["wf_status_value"],
                                    Comments = (String)reader["wf_comments"],
                                    Worker = (String)reader["Worker"],
                                    WorkerID = (Guid)reader["wf_to"],
                                    Manager = (String)reader["Manager"],
                                    ManagerID = (Guid)reader["wf_from"],
                                    DueDate = (DateTime)reader["wf_duedate"],
                                    StatusDate = (DateTime)reader["wf_statusdate"]
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return WorkflowReturn;


        }
        public static string NewWorkflowStatus(Workflow NewStatus)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            string returnVal = string.Empty;
            // newly code added using DAL
            List<string> paramDict = new List<string>(9);
            paramDict.Add("rcsp_workflow_save"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@wf_itemkey;" + NewStatus.ItemKey + ";string"); //order of params - paramname;paramvalue;typeofparam
            paramDict.Add("@wf_projectid;" + NewStatus.ProjectID + ";string");
            paramDict.Add("@wf_status;"+ NewStatus.Status+";string");
            paramDict.Add("@wf_status_value;"+ NewStatus.StatusValue + ";string");
            paramDict.Add("@wf_comments;"+ NewStatus.Comments+";string");
            paramDict.Add("@wf_to;"+ NewStatus.WorkerID+";string");
            paramDict.Add("@wf_from;"+ NewStatus.ManagerID+";string");
            paramDict.Add("@wf_duedate;"+ NewStatus.DueDate+";string");
            paramDict.Add("@wf_statusdate;"+ NewStatus.StatusDate+";string");
            bool status = controls.DAL_RCServices.ExecuteNonQuery(connectionString, paramDict);
            if (status == true)
                returnVal = "";
            else
                returnVal = "error";
            // older code
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_workflow_save", connection))
            //        {
                        
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@wf_itemkey", NewStatus.ItemKey);
            //                command.Parameters.AddWithValue("@wf_projectid", NewStatus.ProjectID);
            //                command.Parameters.AddWithValue("@wf_status", NewStatus.Status);
            //                command.Parameters.AddWithValue("@wf_status_value", NewStatus.StatusValue);
            //                command.Parameters.AddWithValue("@wf_comments", NewStatus.Comments);
            //                command.Parameters.AddWithValue("@wf_to", NewStatus.WorkerID);
            //                command.Parameters.AddWithValue("@wf_from", NewStatus.ManagerID);
            //                command.Parameters.AddWithValue("@wf_duedate", NewStatus.DueDate);
            //                command.Parameters.AddWithValue("@wf_statusdate", NewStatus.StatusDate);
            //                connection.Open();
            //                command.ExecuteNonQuery();
            //            }
            //            catch (Exception ex)
            //            {
            //                return ex.Message;
            //            }
            //            finally
            //            {
            //                connection.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return returnVal;
        }

        public static string GetItemName(string ItemKey)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            //newly added DAL code..
            string itemName = string.Empty;
            List<string> paramDict = new List<string>(1);
            paramDict.Add("sp_workflow_getItemName"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@itemKey;" + ItemKey + ";string"); //order of params - paramname;paramvalue;typeofparam
            itemName = controls.DAL_RCServices.ExecuteReader_SP_string(connectionString, paramDict);

            // older existing code..
            //SqlDataReader reader = null;
            //string itemName = string.Empty;
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("sp_workflow_getItemName", connection))
            //        {
            //            try
            //            {
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@itemKey", ItemKey);

            //                connection.Open();
            //                reader = command.ExecuteReader();

            //                while (reader.Read())
            //                {
            //                    itemName = reader["ItemName"].ToString();
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return itemName;
        }

        public static string WorkFlowNotificationEmail( Guid WorkerID, string worker, string manager, string projectName, string Status, List<string> items = null, string item = null)
        {
            //StringBuilder builder = new StringBuilder();
            //foreach (var ITEM in items) // Loop through all strings
            //{
            //    builder.Append(ITEM).Append(","); // Append string to StringBuilder
            //}
            string multiItem = string.Join(",", items.ToArray());
            //string multiItem = builder.ToString(); // Get string from StringBuilder
            var notification = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = System.Web.HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            string user = WorkerID.ToString();

            try
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                if (item == "")
                {
                    // Get HTML template, replace call back URL
                    //String InnerMessage = "Please confirm your RCX account by clicking <a href=\"" + callbackUrl + "\">here</a>. <br/> Your temporary password is " + password + "<br/> Please change it after logging in"
                    List<EmailTemplatePlaceholders> MessageParameters = new List<EmailTemplatePlaceholders>();
                    MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{ENTERPRISE}", Replacement = HttpContext.Current.Session["EnterpriseName"].ToString() });
                    MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{SUBJECT}", Replacement = "" });
                    MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{USERNAME}", Replacement = "" });
                    MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{MESSAGE}", Replacement = "Dear  " + worker + ", <br /><br /><br /> Items " + multiItem + " has been assigned to you in ReadyCert with " + Status + " , in " + projectName + " , assigned by  " + manager + " .  <br/><br/> To see this item, sign into your ReadyCert account.<br/>Thank you" });

                    String NewWorkflowMessage = common_services.PrepNotificationEmail(MessageParameters);

                    notification.SendEmail(user, "New work Assigned, need to take action on it in readycert", NewWorkflowMessage);
                }
                else
                {
                    // Get HTML template, replace call back URL
                    //String InnerMessage = "Please confirm your RCX account by clicking <a href=\"" + callbackUrl + "\">here</a>. <br/> Your temporary password is " + password + "<br/> Please change it after logging in"
                    List<EmailTemplatePlaceholders> MessageParameters = new List<EmailTemplatePlaceholders>();
                    MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{ENTERPRISE}", Replacement = HttpContext.Current.Session["EnterpriseName"].ToString() });
                    MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{SUBJECT}", Replacement = "" });
                    MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{USERNAME}", Replacement = "" });
                    MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{MESSAGE}", Replacement = "Dear  " + worker + ", <br /><br /><br /> Items " + item + " has been assigned to you in ReadyCert with " + Status + " , in " + projectName + " , assigned by  " + manager + " .  <br/><br/> To see this item, sign into your ReadyCert account.<br/>Thank you" });

                    String NewWorkflowMessage = common_services.PrepNotificationEmail(MessageParameters);

                    notification.SendEmail(user, "New work Assigned, need to take action on it in readycert", NewWorkflowMessage);
                }

                
            }
            catch (Exception ex)
            {

            }

            return "Mail sent sucessfully";


        }

        public static List<MultiAssignWorkflow> GetWorkflowItem(string Area, string ProjectID)
        {
            List<MultiAssignWorkflow> WorkflowReturn = new List<MultiAssignWorkflow>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_workflow_getitems", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@area", Area);
                            command.Parameters.AddWithValue("@projectId", ProjectID);
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                WorkflowReturn.Add(new MultiAssignWorkflow
                                {
                                    ID = reader["ID"].ToString(),
                                    Identifier = reader["Identifier"].ToString(),
                                    Name = reader["AreaName"].ToString(),
                                   
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return WorkflowReturn;

        }
        public static string NewMultiWorkflowStatus(List<MultiAssignWorkflow> items, Workflow NewStatus)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Identifier");
            dataTable.Columns.Add("Name");
           
            foreach (MultiAssignWorkflow x in items)
            {
                dataTable.Rows.Add(x.ID, x.Identifier, x.Name);
            }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_workflow_multiAssign", connection))
                    {

                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@Items", SqlDbType.Structured).Value = dataTable;
                            command.Parameters.AddWithValue("@wf_projectid", NewStatus.ProjectID);
                            command.Parameters.AddWithValue("@wf_status", NewStatus.Status);
                            command.Parameters.AddWithValue("@wf_status_value", NewStatus.StatusValue);
                            command.Parameters.AddWithValue("@wf_comments", NewStatus.Comments);
                            command.Parameters.AddWithValue("@wf_to", NewStatus.WorkerID);
                            command.Parameters.AddWithValue("@wf_from", NewStatus.ManagerID);
                            command.Parameters.AddWithValue("@wf_duedate", NewStatus.DueDate);
                            command.Parameters.AddWithValue("@wf_statusdate", NewStatus.StatusDate);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "";
        }

        public static DataTable GetMultiAssignWorkflowItems(string UserID,string projectId, string Area)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_workflow_getmultiassignitems", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@area", Area);
                            command.Parameters.AddWithValue("@projectId", projectId);
                            command.Parameters.AddWithValue("@userId", UserID);
                           
                            
                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }
        public static bool DeleteMultiAssignWorkflowItems(string workflowID, string projectId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("rcsp_workflow_dropworkflow", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@wf_id", workflowID);
                            command.Parameters.AddWithValue("@projectId", projectId);
                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }
        
        #endregion

        #region Identity
        //  ROutine for creasting new users
        public static string NewUser(string Email, string UserName, Guid Enterprise, Guid DefaultProject, string PhoneNumber, string ConnString, HttpRequest Request)
        {
            var password = System.Web.Security.Membership.GeneratePassword(8, 2);
            var manager = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = System.Web.HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email, Email = Email, enterprise = Enterprise, connstring = ConnString, project = DefaultProject };
            IdentityResult result = manager.Create(user, password);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                string code = manager.GenerateEmailConfirmationToken(user.Id);
                string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, Convert.ToString(user.Id), Request);

                // Get HTML template, replace call back URL
                //String InnerMessage = "Please confirm your RCX account by clicking <a href=\"" + callbackUrl + "\">here</a>. <br/> Your temporary password is " + password + "<br/> Please change it after logging in"
                List<EmailTemplatePlaceholders> MessageParameters = new List<EmailTemplatePlaceholders>();
                MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{ENTERPRISE}", Replacement = HttpContext.Current.Session["EnterpriseName"].ToString() });
                MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{SUBJECT}", Replacement = "Please confirm your new RCX account" });
                MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{USERNAME}", Replacement = "Your username is: " + Email + "<br/><br/> Your temporary password is " + password + "<br/>" });
                MessageParameters.Add(new EmailTemplatePlaceholders { Placeholder = "{MESSAGE}", Replacement = "Please confirm your RCX account by  <a href =\"" + callbackUrl + "\">clicking here</a>." });

                String NewUserWelcomeMessage = common_services.PrepNotificationEmail(MessageParameters);

                manager.SendEmail(user.Id, "Confirm your RCX account", NewUserWelcomeMessage);

                ////signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                //IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                return "User " + UserName + " created successfully.";
            }
            else
            {
                return result.Errors.FirstOrDefault();
            }
        }

        // New user creation for the newly created enterprise created by Bala
        public static string NewUser_enterprise(string Email, string UserName, Guid Enterprise, Guid DefaultProject, string PhoneNumber, string ConnString)
        {
            try
            {
                //var password = System.Web.Security.Membership.GeneratePassword(8, 2);
                var password = "readyfreddy";
                var manager = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signInManager = System.Web.HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
                var user = new ApplicationUser() { UserName = Email, Email = Email, enterprise = Enterprise, connstring = ConnString, project = DefaultProject, EmailConfirmed=true };
                IdentityResult result = manager.Create(user, password);
                //string user_id = user.Id;
                if (result.Succeeded)
                    return "UserName:" + UserName + ",Password:" + password + ",UserID:" + user.Id;
                else
                    return "";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static string DeleteUser(Guid UserID)
        {
            string UserDeletedResult = "";

            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(UserID.ToString());



            var manager = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //var user = new ApplicationUser() { Id = Convert.ToString(UserID) };
            manager.Delete(user);

            return UserDeletedResult;
        }

        //public static string SendConfirmationEmail (Guid userID, HttpRequest Request)
        //{
        //    var manager = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //    string code = manager.GenerateEmailConfirmationToken(Convert.ToString(userID));
        //    string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, Convert.ToString(userID), Request);
        //    return "sent";
        //    manager.SendEmail(userId, "Confirm your RCX account", "Please confirm your RCX account by clicking <a href=\"" + callbackUrl + "\">here</a>. <br/> Your temporary password is " + password + "<br/> Please change it after logging in");

        //}

        public static string GetUserNameByID(Guid UserID)
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(UserID.ToString());
            var name = user.UserName;
            return name;

        }

        public static string GetUserName()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var name = user.UserName;
            return name;
        }
        public static string GetUserEmail()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var email = user.Email;
            return email;
        }
        public static string GetUserID()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var ID = user.Id;
            return ID;
        }
        public static string GetUserConnString()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var ConnString = user.connstring;
            return ConnString;
        }
        public static string GetUserEnterprise()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var enterprise = user.enterprise;
            return enterprise.ToString();
        }
        public static string GetUserProject()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var project = user.project;
            return project.ToString();
        }
        #endregion

        #region ProjectManagement
        public static List<ProjectManagement> GetPMitems(bool IncludeEnterprise = false)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<ProjectManagement> AllPMs = new List<ProjectManagement>();

            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            //Guid ProjectID = Guid.Parse(System.Web.HttpContext.Current.Session["projectID"].ToString());
            SqlDataReader reader = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_pm_getall", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@pm_projectID", System.Web.HttpContext.Current.Session["projectID"].ToString());
                            command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);
                            connection.Open();
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                AllPMs.Add(new ProjectManagement
                                {
                                    Id = reader["pm_id"].ToString(),
                                    Area = reader["pm_area"].ToString(),
                                    Type = reader["pm_type"].ToString(),
                                    UniqueID = reader["pm_uniqueID"].ToString(),
                                    Title = reader["pm_title"].ToString(),
                                    Description = reader["pm_desc"].ToString(),
                                    Solution = reader["pm_solution"].ToString(),
                                    Priority = reader["pm_priority"].ToString(),
                                    Status = reader["pm_status"].ToString(),
                                    Home = reader["pm_home"].ToString(),
                                    CreatedBy = reader["pm_createdby"].ToString(),
                                    CreatedDate = DateTime.Parse(reader["pm_createddate"].ToString()),

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return AllPMs;
        }
        public static string InsertPMitem(ProjectManagement NewPM)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var CurrentProjectId = System.Web.HttpContext.Current.Session["projectID"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCmd = new SqlCommand("rcsp_pm_insert", connection))
                    {
                        try
                        {
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            sqlCmd.Parameters.AddWithValue("@pm_desc", NewPM.Description);
                            sqlCmd.Parameters.AddWithValue("@pm_solution", NewPM.Solution);
                            sqlCmd.Parameters.AddWithValue("@pm_priority", NewPM.Priority);
                            sqlCmd.Parameters.AddWithValue("@pm_status", NewPM.Status);
                            sqlCmd.Parameters.AddWithValue("@pm_title", NewPM.Title);
                            sqlCmd.Parameters.AddWithValue("@pm_uniqueID", NewPM.UniqueID);
                            sqlCmd.Parameters.AddWithValue("@pm_type", NewPM.Type);
                            sqlCmd.Parameters.AddWithValue("@pm_createdby", NewPM.CreatedBy);
                            sqlCmd.Parameters.AddWithValue("@pm_area", NewPM.Area);
                            sqlCmd.Parameters.AddWithValue("@pm_home", NewPM.Home);
                            sqlCmd.Parameters.AddWithValue("@pm_projectID", CurrentProjectId);
                            connection.Open();
                            sqlCmd.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "Sucessfully Added";

        }
        public static string UpdatePMitem(ProjectManagement EditPM)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var CurrentProjectId = System.Web.HttpContext.Current.Session["projectID"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_pm_update", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@pm_id", EditPM.Id);
                            command.Parameters.AddWithValue("@pm_desc", EditPM.Description);
                            command.Parameters.AddWithValue("@pm_solution", EditPM.Solution);
                            command.Parameters.AddWithValue("@pm_priority", EditPM.Priority);
                            command.Parameters.AddWithValue("@pm_status", EditPM.Status);
                            command.Parameters.AddWithValue("@pm_title", EditPM.Title);
                            command.Parameters.AddWithValue("@pm_uniqueID", EditPM.UniqueID);
                            command.Parameters.AddWithValue("@pm_type", EditPM.Type);
                            command.Parameters.AddWithValue("@pm_area", EditPM.Area);
                            command.Parameters.AddWithValue("@pm_projectID", CurrentProjectId);
                            command.Parameters.AddWithValue("@pm_home", EditPM.Home);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }

                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Update";

        }
        public static void DeletePMitem(String PMid)
        {
            
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("rcsp_pm_delete", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@pm_id", PMid);

                            command.ExecuteNonQuery();


                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
        #endregion

        #region ScoreStandard Values

        public static DataTable GetStandardValues(string standardID)
        {
            List<ScoreStandardValues> categoryList = new List<ScoreStandardValues>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_scoreStandard_getvalues", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@stan_id", standardID);
                            SqlDataAdapter sa = new SqlDataAdapter(command);

                            sa.Fill(ds);

                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;

        }
        public static void InsertNewStandardValues(ScoreStandardValues standard)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command;
                    try
                    {
                        command = new SqlCommand("sp_scoreStandard_newValues", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@value_standard", standard.StandardId);
                        command.Parameters.AddWithValue("@value_score", standard.ValueScore);
                        command.Parameters.AddWithValue("@value_scoretext", standard.ValueScoreText);
                        command.Parameters.AddWithValue("@value_measures", standard.ValueMeasures);
                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        //TODO: log exception;
                        connection.Close();
                    }

                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }
        // Function to called to update value data in the grid 
        public static void UpdateStandardValue(List<ScoreStandardValues> values)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlTransaction transaction;
                    connection.Open();

                    foreach (var value in values)
                    {


                        using (SqlCommand command = new SqlCommand("", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("", value.Id);
                                command.Parameters.AddWithValue("", value.ValueScore);
                                command.Parameters.AddWithValue("", value.ValueScoreText);
                                command.Parameters.AddWithValue("", value.ValueMeasures);

                                int count = command.ExecuteNonQuery();

                                // transaction.Commit();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }
        // Function to called to delete Standard values
        public static bool DeleteCategory(string ValueId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("", ValueId);

                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }



        #endregion

        #region Components
        // function used to get the components from DB to primarary grid to display all the componets
        public static List<Componets> GetComponents()
        {

            List<Componets> compList = new List<Componets>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_getComponets", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);
                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                compList.Add(new Componets
                                {
                                    ComponentId = reader["comp_ID"].ToString(),
                                    ComponentName = reader["comp_name"] == DBNull.Value ? string.Empty : reader["comp_name"].ToString(),
                                    ComponentType = reader["comp_type"] == DBNull.Value ? string.Empty : reader["comp_type"].ToString(),
                                    ComponentMode = reader["comp_mode"] == DBNull.Value ? string.Empty : reader["comp_mode"].ToString(),
                                    ComponentTest = reader["comp_test"] == DBNull.Value ? string.Empty : reader["comp_test"].ToString(),
                                    ComponentLocation = reader["comp_location"] == DBNull.Value ? string.Empty : reader["comp_location"].ToString(),
                                    StartDate = reader["comp_startDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["comp_startDate"].ToString()).ToShortDateString(),
                                    EndDate = reader["comp_endDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["comp_endDate"].ToString()).ToShortDateString(),
                                    // StartDate = reader["comp_startDate"] == DBNull.Value ? DateTime.Now : (reader["comp_startDate"].ToString()),
                                    // EndDate = reader["comp_endDate"] == DBNull.Value ? DateTime.Now : (reader["comp_endDate"]),
                                    Notes = reader["comp_notes"] == DBNull.Value ? string.Empty : reader["comp_notes"].ToString(),
                                    SerialNumber = reader["comp_serialNumber"] == DBNull.Value ? string.Empty : reader["comp_serialNumber"].ToString()

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return compList;


        }
        // function to add new componetns
        public static void InsertNewComponent(Componets components)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_rc_NewComponent", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@comp_name", components.ComponentName);
                            command.Parameters.AddWithValue("@comp_type", components.ComponentType);
                            command.Parameters.AddWithValue("@comp_mode", components.ComponentMode);
                            command.Parameters.AddWithValue("@comp_test", components.ComponentTest);
                            command.Parameters.AddWithValue("@comp_location", components.ComponentLocation);
                            command.Parameters.AddWithValue("@comp_startDate", components.StartDate);
                            if (components.EndDate == null) { command.Parameters.AddWithValue("@comp_endDate", DBNull.Value); } else { command.Parameters.AddWithValue("@comp_endDate", components.EndDate); }
                            //command.Parameters.AddWithValue("@comp_endDate", components.EndDate);
                            command.Parameters.AddWithValue("@comp_notes", components.Notes);
                            command.Parameters.AddWithValue("@comp_serialNumber", components.SerialNumber);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            //TODO: log exception;
                            connection.Close();
                        }
                    }
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }
        // function to update the existing componnets
        public static void UpdateComponentDetails(Componets component)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_rc_updateComponent", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@comp_Id", component.ComponentId);
                            command.Parameters.AddWithValue("@comp_name", component.ComponentName);
                            command.Parameters.AddWithValue("@comp_type", component.ComponentType);
                            command.Parameters.AddWithValue("@comp_mode", component.ComponentMode);
                            command.Parameters.AddWithValue("@comp_test", component.ComponentTest);
                            command.Parameters.AddWithValue("@comp_location", component.ComponentLocation);
                            command.Parameters.AddWithValue("@comp_startDate", component.StartDate);
                            if (component.EndDate == null) { command.Parameters.AddWithValue("@comp_endDate", DBNull.Value); } else { command.Parameters.AddWithValue("@comp_endDate", component.EndDate); }
                            command.Parameters.AddWithValue("@comp_notes", component.Notes);
                            command.Parameters.AddWithValue("@comp_serialNumber", component.SerialNumber);

                            int count = command.ExecuteNonQuery();

                            // transaction.Commit();
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }
        // function to delete the existing components
        public static void DeleteComponent(string ComponentId)
        {


            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_rc_dropComponent", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@comp_Id", ComponentId);

                            command.ExecuteNonQuery();


                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }



        }

        public static DataTable GetEnterpriseLevelProjects(string componentId)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_components_getEnterpriseLevelProjects", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@componentID", componentId);

                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public static DataTable GetProjects(string componentId)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_components_getProjects", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@componentID", componentId);

                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;

        }

        // funtion to add the new projects as attachements for the specified componnent
        public static void InsertComponentProjects(string componentId, List<string> projectIds)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    foreach (var project in projectIds)
                    {
                        using (SqlCommand command = new SqlCommand("sp_rc_insertComponentProject", connection, transaction))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@componentId", componentId);
                                command.Parameters.AddWithValue("@projectId", project);

                                int count = command.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        public static DataTable GetProjectLevelBusinessArea(string componentId)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_components_getProjectLevelBA", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@componentID", componentId);

                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        // funtion to add the new Business Area as attachements for the specified componnent
        public static void InsertComponentProjectArea(string componentId, List<string> Areas)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    foreach (var Area in Areas)
                    {
                        using (SqlCommand command = new SqlCommand("sp_rc_insertComponentProjectArea", connection, transaction))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@componentId", componentId);
                                command.Parameters.AddWithValue("@AreaId", Area);

                                int count = command.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }


        public static DataTable GetProjectLevelBusinessProcesses(string componentId)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_components_getProjectLevelBPM", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@componentID", componentId);

                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }
        // funtion to add the new Business Processes as attachements for the specified componnent
        public static void InsertComponentProjectBPM(string componentId, List<string> Processes)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    foreach (var Process in Processes)
                    {
                        using (SqlCommand command = new SqlCommand("sp_rc_insertComponentProjectProsecesses", connection, transaction))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@componentId", componentId);
                                command.Parameters.AddWithValue("@ProcessesId", Process);

                                int count = command.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        public static DataTable GetProjectLevelRTM(string componentId)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_components_getProjectLevelRTM", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@componentID", componentId);

                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        // funtion to add the new RTM Item (Criteria) as attachements for the specified componnent
        public static void InsertComponentProjectRTMItem(string componentId, List<string> Criterias)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    foreach (var criteria in Criterias)
                    {
                        using (SqlCommand command = new SqlCommand("sp_rc_insertComponentProjectRTMItem", connection, transaction))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@componentId", componentId);
                                command.Parameters.AddWithValue("@RTMId", criteria);

                                int count = command.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        #endregion
    }

    // RTM services at enterprise level
    public class rtm_services
    {
        #region Enterprise RTM

        #region Enterprise RTM Planning

        public static void SavePrePlanProjects(string ProjectName)
        {
            string connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ent_insertPrePlanProject", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@project_name", ProjectName);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
        }

        public static DataTable GetRtmPlanningProjects()
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataTable ds = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ent_rtmPlanningProjects", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds;
        }

        public static void UpdateRTMPlanningDetails(List<RtmPlanningProjectDetails> checklists)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    foreach (var checklist in checklists)
                    {
                        using (SqlCommand command = new SqlCommand("sp_RTMPlannig_newProjectsByChecklist", connection, transaction))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@criteriaId", checklist.CriteriaId);
                                command.Parameters.AddWithValue("@projectName", checklist.ProjectName);
                                command.Parameters.AddWithValue("@isActive", checklist.IsActive);

                                int count = command.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    transaction.Commit();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        #endregion

        #region Checklist

        public static List<RtmChecklist> GetRTMCheckList(string projectId)
        {

            List<RtmChecklist> rtmList = new List<RtmChecklist>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rtm_getChecklist", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ProjectID", projectId);
                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                rtmList.Add(new RtmChecklist
                                {
                                    Id = reader["ChecklistId"].ToString(),
                                    Title = reader["ChecklistTitle"] == DBNull.Value ? string.Empty : reader["ChecklistTitle"].ToString(),
                                    //Description = reader["ch_description"] == DBNull.Value ? string.Empty : reader["ch_description"].ToString()

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return rtmList;


        }

        // Function to called to update checklist data in the grid using bach mode
        public static void UpdateCheckListDetails(string projectId, List<RtmProjectChecklist> checklists)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlTransaction transaction;
                    connection.Open();

                    foreach (var checklist in checklists)
                    {


                        using (SqlCommand command = new SqlCommand("sp_rtm_UpdateChecklist", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("@projectId", projectId);
                                command.Parameters.AddWithValue("@checkListId", checklist.Id);
                                command.Parameters.AddWithValue("@ch_title", checklist.Title);
                                command.Parameters.AddWithValue("@ch_type", checklist.Type);
                                command.Parameters.AddWithValue("@ch_description", checklist.Description);
                                command.Parameters.AddWithValue("@isActive", checklist.IsActive);

                                int count = command.ExecuteNonQuery();

                                // transaction.Commit();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        // Function to called to get checklist data to dispaly in the grid
        public static List<RtmProjectChecklist> GetCheckList(string projectId)
        {

            List<RtmProjectChecklist> rtmList = new List<RtmProjectChecklist>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rtm_getProjectChecklist", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@projectId", projectId);
                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                rtmList.Add(new RtmProjectChecklist
                                {
                                    Id = reader["ch_id"].ToString(),
                                    Title = reader["ch_title"] == DBNull.Value ? string.Empty : reader["ch_title"].ToString(),
                                    Type = reader["ch_type"] == DBNull.Value ? string.Empty : reader["ch_type"].ToString(),
                                    Description = reader["ch_description"] == DBNull.Value ? string.Empty : reader["ch_description"].ToString(),
                                    IsActive = reader["act_isacctive"] == DBNull.Value ? false : Convert.ToBoolean(reader["act_isacctive"])
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return rtmList;


        }

        // Function to called to delete checklist data and associated objective and criteria data using softdelete
        public static bool DeleteCheckList(string checkListId, string projectId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("rcsp_rtm_dropchecklist", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ch_id", checkListId);
                            command.Parameters.AddWithValue("@projectId", projectId);
                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }

        #endregion

        #region Objectives
        // Function to called to get Business Objective data to dispaly in the grid
        public static List<RtmObjectives> GetObjectives()
        {

            List<RtmObjectives> rtmList = new List<RtmObjectives>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rtm_getObjectives", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@projectId", projectId);
                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                rtmList.Add(new RtmObjectives
                                {
                                    Id = reader["bo_id"].ToString(),
                                    UniqueId = reader["bo_unique_id"].ToString(),
                                    Name = reader["bo_name"].ToString(),
                                    ChecklistType = reader["ChecklistType"].ToString(),
                                    ChecklistTitle = reader["ChecklistTitile"].ToString(),

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return rtmList;


        }

        // Function to called to update Objective data in the grid using bach mode
        public static void UpdateObjectivesDetails(List<RtmObjectives> objectives)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlTransaction transaction;
                    foreach (var objective in objectives)
                    {
                        connection.Open();

                        transaction = connection.BeginTransaction();

                        using (SqlCommand command = new SqlCommand("sp_rtm_UpdateObjectives", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Transaction = transaction;

                                command.Parameters.AddWithValue("@bo_Id", objective.Id);
                                command.Parameters.AddWithValue("@uniqueId", objective.UniqueId);
                                command.Parameters.AddWithValue("@name", objective.Name);

                                command.ExecuteNonQuery();


                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                //TODO: log exception
                                transaction.Rollback();
                                connection.Close();
                            }
                        }
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        // Function to called to delete Objective data and associated criteria data using softdelete
        public static bool DeleteObjectives(string objectiveId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("rcsp_rtm_dropObjectives", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@bo_id", objectiveId);

                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }
        #endregion

        #region SRC
        // Function to called to get Source Criteria data to dispaly in the grid
        public static List<RtmCriteria> GetCriteria()
        {

            List<RtmCriteria> rtmList = new List<RtmCriteria>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rtm_getCriteria", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                rtmList.Add(new RtmCriteria
                                {
                                    Id = reader["CriteriaId"].ToString(),
                                    ChecklistType = reader["ChecklistType"].ToString(),
                                    ChecklistTitle = reader["CheckListTitle"].ToString(),
                                    ObjectiveUniqueId = reader["ObjectiveName"].ToString(),
                                    Title = reader["CriteriaTitle"].ToString(),
                                    Name = reader["src_unique_name"].ToString(),
                                    Criteria = reader["Criteria"].ToString(),
                                    Complaince = reader["src_composite_name"].ToString(),
                                    Source = reader["src_source"].ToString(),
                                    Critical = Convert.ToBoolean(reader["IsCritical"])
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return rtmList;


        }

        // Function to called to update Source Criteria data in the grid using bach mode
        public static void UpdateCriteriatDetails(List<RtmCriteria> criterias)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlTransaction transaction;
                    foreach (var criteria in criterias)
                    {
                        connection.Open();

                        transaction = connection.BeginTransaction();

                        using (SqlCommand command = new SqlCommand("sp_rtm_UpdateCriteria", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Transaction = transaction;

                                command.Parameters.AddWithValue("@id", criteria.Id);
                                command.Parameters.AddWithValue("@title", criteria.Title);
                                command.Parameters.AddWithValue("@uniqueName", criteria.Name);
                                command.Parameters.AddWithValue("@criteriaName", criteria.Criteria);
                                command.Parameters.AddWithValue("@source", criteria.Source);
                                command.Parameters.AddWithValue("@IsCritical", criteria.Critical);

                                command.ExecuteNonQuery();


                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                //TODO: log exception
                                transaction.Rollback();
                                connection.Close();
                            }
                        }
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        // Function to called to delete Source Criteria
        public static bool DeleteCriteria(string criteriaId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                // setup connection to connect the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // open connection
                    connection.Open();

                    // setup the command
                    using (SqlCommand command = new SqlCommand("rcsp_rtm_dropCriteria", connection))
                    {
                        try
                        {
                            // define comamnd to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@src_id", criteriaId);

                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }
        #endregion

        #region RTM Mass Load

        // Function to called to Insert Checklist, Business Objective and SRC Data by uploading a Spreadsheet
        public static DataTable UploadExcelData(DataTable table, bool ProjectRTMUploadLoad = false)
        {
            DataSet ds = new DataSet();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                // set up connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // set up command
                    if (ProjectRTMUploadLoad == false)
                    {
                        using (SqlCommand command = new SqlCommand("sp_rtm_insertRtmData", connection))
                        {
                            using (var da = new SqlDataAdapter(command))
                            {
                                try
                                {
                                    // define comamnd type to be stored procedure
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@data", table);

                                    da.Fill(ds);
                                }
                                catch (Exception ex)
                                {
                                    //TODO: log exception

                                    connection.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        using (SqlCommand command = new SqlCommand("sp_rc_rtm_insertProjectRtmMassLoadData", connection))
                        {
                            using (var da = new SqlDataAdapter(command))
                            {
                                try
                                {
                                    // define comamnd type to be stored procedure
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@data", table);

                                    da.Fill(ds);
                                }
                                catch (Exception ex)
                                {
                                    //TODO: log exception

                                    connection.Close();
                                }
                            }
                        }
                    }

                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
        }

        #endregion

        #endregion

        #region Enterprise Assessment
        #region Business Area
        // Function to called to get Area data to dispaly in the grid
        public static List<BusinessArea> GetBusinessArea()
        {

            List<BusinessArea> areaList = new List<BusinessArea>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_assessment_getArea", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                areaList.Add(new BusinessArea
                                {
                                    Id = reader["area_id"].ToString(),
                                    UniqueID = reader["area_identifier"].ToString(),
                                    AreaTitle = reader["area_name"].ToString(),
                                    Description = reader["area_description"].ToString(),
                                    Source = reader["area_source"].ToString(),
                                    Date = DateTime.Parse(reader["area_sourcedate"].ToString())
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return areaList;


        }


        public static void InsertNewBusinessArea(List<BusinessArea> Areas)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command;
                    foreach (var area in Areas)
                    {
                        try
                        {
                            command = new SqlCommand("sp_assessment_insertBusinessArea", connection, transaction);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@area_identifier", area.UniqueID);
                            command.Parameters.AddWithValue("@area_name", area.AreaTitle);
                            command.Parameters.AddWithValue("@area_description", area.Description);
                            command.Parameters.AddWithValue("@area_source", area.Source);
                            command.Parameters.AddWithValue("@area_sourcedate", area.Date);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            //TODO: log exception;
                            transaction.Rollback();
                            connection.Close();
                        }
                    }

                    transaction.Commit();
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        // Function to called to update Area data in the grid using bach mode
        public static void UpdateBusinessArea(List<BusinessArea> areas)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlTransaction transaction;
                    connection.Open();

                    foreach (var Area in areas)
                    {


                        using (SqlCommand command = new SqlCommand("sp_assessment_updateArea", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;


                                command.Parameters.AddWithValue("@id", Area.Id);
                                command.Parameters.AddWithValue("@uniqueId", Area.UniqueID);
                                command.Parameters.AddWithValue("@title", Area.AreaTitle);
                                command.Parameters.AddWithValue("@description", Area.Description);
                                command.Parameters.AddWithValue("@source", Area.Source);
                                command.Parameters.AddWithValue("@date", Area.Date);


                                int count = command.ExecuteNonQuery();

                                // transaction.Commit();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        // Function to called to delete Area data and associated Categories and Processess data using softdelete
        public static bool DeleteArea(string AreaId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_assessment_dropArea", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@area_id", AreaId);

                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }

        #endregion

        #region Business Category

        public static List<BusinessCategory> GetBusinessCategories()
        {

            List<BusinessCategory> categoryList = new List<BusinessCategory>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_assessment_getCategory", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                categoryList.Add(new BusinessCategory
                                {
                                    Id = reader["cat_id"].ToString(),
                                    AreaID = reader["cat_baID"].ToString(),
                                    //AreaTitle = reader["area_name"].ToString(),
                                    UniqueID = reader["cat_identifier"].ToString(),
                                    CategoryTitle = reader["cat_name"].ToString(),
                                    Description = reader["cat_description"].ToString(),
                                    Source = reader["cat_source"].ToString(),
                                    Date = DateTime.Parse(reader["cat_sourcedate"].ToString())
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return categoryList;


        }

        public static void InsertNewBusinessCategory(List<BusinessCategory> Categories)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command;
                    foreach (var category in Categories)
                    {
                        try
                        {
                            command = new SqlCommand("sp_assessment_insertBusinessCategory", connection, transaction);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@cat_baID", category.AreaID);
                            command.Parameters.AddWithValue("@cat_identifier", category.UniqueID);
                            command.Parameters.AddWithValue("@cat_name", category.CategoryTitle);
                            command.Parameters.AddWithValue("@cat_description", category.Description);
                            command.Parameters.AddWithValue("@cat_source", category.Source);
                            command.Parameters.AddWithValue("@cat_sourcedate", category.Date);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            //TODO: log exception;
                            transaction.Rollback();
                            connection.Close();
                        }
                    }

                    transaction.Commit();
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        public static DataTable GetAllBusinessCategories()
        {

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            DataSet ds = new DataSet();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_assessment_getNewCategory", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            using (var sa = new SqlDataAdapter(command))
                            {
                                sa.Fill(ds);
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return ds.Tables.Count > 0 ? ds.Tables[0] : null;

        }


        // Function to called to update Area data in the grid using bach mode
        public static void UpdateBusinessCategory(List<BusinessCategory> categories)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlTransaction transaction;
                    connection.Open();

                    foreach (var Category in categories)
                    {


                        using (SqlCommand command = new SqlCommand("sp_assessment_updateCategory", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;


                                command.Parameters.AddWithValue("@cat_Id", Category.Id);
                                command.Parameters.AddWithValue("@uniqueId", Category.UniqueID);
                                command.Parameters.AddWithValue("@title", Category.CategoryTitle);
                                command.Parameters.AddWithValue("@description", Category.Description);
                                command.Parameters.AddWithValue("@source", Category.Source);
                                command.Parameters.AddWithValue("@date", Category.Date);


                                int count = command.ExecuteNonQuery();

                                // transaction.Commit();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        // Function to called to delete Area data and associated Categories and Processess data using softdelete
        public static bool DeleteCategory(string CategoryId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_assessment_dropCategory", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@cat_id", CategoryId);

                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }

        #endregion

        #region Business Process


        // Function to called to get checklist data to dispaly in the grid
        public static List<BusinessProcess> GetBusinessProcess(string projectId)
        {

            List<BusinessProcess> rtmList = new List<BusinessProcess>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_assessment_getProjectProcesses", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@projectId", projectId);
                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                rtmList.Add(new BusinessProcess
                                {
                                    Id = reader["bp_id"].ToString(),
                                    CategoryId = reader["bp_bcID"].ToString(),
                                    AreaTitle = reader["area_name"] == DBNull.Value ? string.Empty : reader["area_name"].ToString(),
                                    //CategoryTitle = reader["cat_name"] == DBNull.Value ? string.Empty : reader["cat_name"].ToString(),
                                    UniqueID = reader["bp_identifier"] == DBNull.Value ? string.Empty : reader["bp_identifier"].ToString(),
                                    ProcessTitle = reader["bp_name"] == DBNull.Value ? string.Empty : reader["bp_name"].ToString(),
                                    Description = reader["bp_description"] == DBNull.Value ? string.Empty : reader["bp_description"].ToString(),
                                    Source = reader["bp_source"] == DBNull.Value ? string.Empty : reader["bp_source"].ToString(),
                                    Date = reader["bp_sourcedate"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["bp_sourcedate"]),
                                    IsActive = reader["act_isacctive"] == DBNull.Value ? false : Convert.ToBoolean(reader["act_isacctive"])
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return rtmList;


        }

        public static void InsertNewBusinessProcesses(List<BusinessProcess> Processes)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command;
                    foreach (var process in Processes)
                    {
                        try
                        {
                            command = new SqlCommand("sp_assessment_insertBusinessProcesses", connection, transaction);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@bp_bcID", process.CategoryId);
                            command.Parameters.AddWithValue("@bp_identifier", process.UniqueID);
                            command.Parameters.AddWithValue("@bp_name", process.ProcessTitle);
                            command.Parameters.AddWithValue("@bp_description", process.Description);
                            command.Parameters.AddWithValue("@bp_source", process.Source);
                            command.Parameters.AddWithValue("@bp_sourcedate", process.Date);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            //TODO: log exception;
                            transaction.Rollback();
                            connection.Close();
                        }
                    }

                    transaction.Commit();
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        public static void UpdateProcessDetails(string projectId, List<BusinessProcess> processess)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlTransaction transaction;
                    connection.Open();

                    foreach (var process in processess)
                    {


                        using (SqlCommand command = new SqlCommand("sp_assessment_UpdateProcesses", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("@projectId", projectId);
                                command.Parameters.AddWithValue("@processId", process.Id);
                                command.Parameters.AddWithValue("@uniqueId", process.UniqueID);
                                command.Parameters.AddWithValue("@name", process.ProcessTitle);
                                command.Parameters.AddWithValue("@description", process.Description);
                                command.Parameters.AddWithValue("@source", process.Source);
                                command.Parameters.AddWithValue("@sourcedate", process.Date);
                                command.Parameters.AddWithValue("@isActive", process.IsActive);

                                int count = command.ExecuteNonQuery();

                                // transaction.Commit();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }



        // Function to called to delete checklist data and associated objective and criteria data using softdelete
        public static bool DeleteProcess(string processId, string projectId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_assessment_dropProcesses", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@bp_id", processId);
                            command.Parameters.AddWithValue("@projectId", projectId);
                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }

        #endregion

        #region Assessment Mass Load

        // Function to called to Insert Checklist, Business Objective and SRC Data by uploading a Spreadsheet
        public static DataTable UploadAssessmentExcelData(DataTable table, bool ProjectAssessmentploadLoad = false)
        {
            DataSet ds = new DataSet();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                // set up connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // set up command
                    if (ProjectAssessmentploadLoad == false)
                    {
                        using (SqlCommand command = new SqlCommand("sp_rc_assessment_insertBusinessAreaResponses", connection))
                        {
                            using (var da = new SqlDataAdapter(command))
                            {
                                try
                                {
                                    // define comamnd type to be stored procedure
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@data", table);

                                    da.Fill(ds);
                                }
                                catch (Exception ex)
                                {
                                    //TODO: log exception

                                    connection.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        using (SqlCommand command = new SqlCommand("sp_rc_assessment_massUpload _AssessmentItemsAndResponses", connection))
                        {
                            using (var da = new SqlDataAdapter(command))
                            {
                                try
                                {
                                    // define comamnd type to be stored procedure
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@data", table);

                                    da.Fill(ds);
                                }
                                catch (Exception ex)
                                {
                                    //TODO: log exception

                                    connection.Close();
                                }
                            }
                        }
                    }

                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable();
        }

        #endregion

        public class UniversalAssessmentItem
        {
            public String Id { get; set; }
            public String Type { get; set; }
            public String UniqueID { get; set; }
            public String Name { get; set; }

        }
        public static List<UniversalAssessmentItem> GetAllAssessmentItems()
        {
            List<UniversalAssessmentItem> FullAssessment = new List<UniversalAssessmentItem>();

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try
            {// setup conncetion and command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_assessment_GetAllTypes", connection))
                    {
                        try
                        {
                            // define command type to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;

                            // Open connection, execute the command
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                FullAssessment.Add(new UniversalAssessmentItem
                                {
                                    Id = Convert.ToString(reader["id"]),
                                    Name = reader["RC_NAME"].ToString(),
                                    UniqueID = reader["RC_ID"].ToString(),
                                    Type = reader["RC_TYPE"].ToString(),

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return FullAssessment;
        }

        #endregion

        #region Ptoject RTM

        public static DataTable GetProjectResponses(string projectId, string milestoneId,bool CSF = true, bool AssessmentAutorized = false)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            // newly added code
            //Frame an array with proper parameters to send to DAL
            List<string> paramDict = new List<string>(2);
            //paramDict.Add("sp_rtm_getRTMResponses"); // First item as Stored procedure name if exist else set it as null
            //paramDict.Add("2"); // Send the number of parameter the SP or query takes if nothing then send it as zero(0).
            //paramDict.Add("projectId;" + projectId + ";string"); //order of params - paramname;paramvalue;typeofparam
            //paramDict.Add("milestoneId;" + milestoneId + ";string");

            //controls.DAL_SP_ParamDefs.spname = "sp_rtm_getRTMResponses";
            //controls.DAL_SP_ParamDefs.paramCount = 2;
            //controls.DAL_SP_ParamDefs.param1Name = "projectId";
            //controls.DAL_SP_ParamDefs.param1Value = projectId;
            //controls.DAL_SP_ParamDefs.param1Type = "string";
            //controls.DAL_SP_ParamDefs.param1Name = "milestoneId";
            //controls.DAL_SP_ParamDefs.param1Value = milestoneId;
            //controls.DAL_SP_ParamDefs.param1Type = "string";
            //DataSet ds1 = controls.DAL_RCServices.ExecuteAdapter_SP_dataset(connectionString, paramDict);

            // older code

            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            if (CSF == false)
            {
                if (AssessmentAutorized == true)
                {
                    try
                    {
                        //List<string> paramDict = new List<string>(2);
                        paramDict.Add("sp_rtm_getRTMResponses_onlyAssingedItems_NoCSF"); // First item as Stored procedure name if exist else set it as null
                        paramDict.Add("projectId;" + projectId + ";string"); //order of params - paramname;paramvalue;typeofparam
                        paramDict.Add("milestoneId;" + milestoneId + ";string");
                        ds = controls.DAL_RCServices.ExecuteAdapter_SP_dataset(connectionString, paramDict);
                        //using (SqlConnection connection = new SqlConnection(connectionString))
                        //{
                        //    using (SqlCommand command = new SqlCommand("sp_rtm_getRTMResponses_onlyAssingedItems_NoCSF", connection))
                        //    {
                        //        try
                        //        {
                        //            sa = new SqlDataAdapter(command);
                        //            command.CommandType = CommandType.StoredProcedure;
                        //            command.Parameters.AddWithValue("projectId", projectId);
                        //            command.Parameters.AddWithValue("milestoneId", milestoneId);
                        //            sa.Fill(ds);
                        //        }
                        //        catch (Exception ex)
                        //        {
                        //            // return rtmList;
                        //        }
                        //    }
                        //}
                    }
                    catch (Exception ex)
                    {
                        // return rtmList;
                    }
                }
                else
                {
                    try
                    {
                        paramDict.Add("sp_rtm_getRTMResponses_NoCSF"); // First item as Stored procedure name if exist else set it as null
                        paramDict.Add("projectId;" + projectId + ";string"); //order of params - paramname;paramvalue;typeofparam
                        paramDict.Add("milestoneId;" + milestoneId + ";string");
                        ds = controls.DAL_RCServices.ExecuteAdapter_SP_dataset(connectionString, paramDict);

                        //using (SqlConnection connection = new SqlConnection(connectionString))
                        //{
                        //    using (SqlCommand command = new SqlCommand("sp_rtm_getRTMResponses_NoCSF", connection))
                        //    {
                        //        try
                        //        {
                        //            sa = new SqlDataAdapter(command);
                        //            command.CommandType = CommandType.StoredProcedure;
                        //            command.Parameters.AddWithValue("projectId", projectId);
                        //            command.Parameters.AddWithValue("milestoneId", milestoneId);
                        //            sa.Fill(ds);
                        //        }
                        //        catch (Exception ex)
                        //        {
                        //            // return rtmList;
                        //        }
                        //    }
                        //}
                    }
                    catch (Exception ex)
                    {
                        // return rtmList;
                    }
                }
            }
            else
            {
                if (AssessmentAutorized == true)
                {
                    try
                    {
                        paramDict.Add("sp_rtm_getRTMResponses_onlyAssingedItems"); // First item as Stored procedure name if exist else set it as null
                        paramDict.Add("projectId;" + projectId + ";string"); //order of params - paramname;paramvalue;typeofparam
                        paramDict.Add("milestoneId;" + milestoneId + ";string");
                        ds = controls.DAL_RCServices.ExecuteAdapter_SP_dataset(connectionString, paramDict);

                        //using (SqlConnection connection = new SqlConnection(connectionString))
                        //{
                        //    using (SqlCommand command = new SqlCommand("sp_rtm_getRTMResponses_onlyAssingedItems", connection))
                        //    {
                        //        try
                        //        {
                        //            sa = new SqlDataAdapter(command);
                        //            command.CommandType = CommandType.StoredProcedure;
                        //            command.Parameters.AddWithValue("projectId", projectId);
                        //            command.Parameters.AddWithValue("milestoneId", milestoneId);
                        //            sa.Fill(ds);
                        //        }
                        //        catch (Exception ex)
                        //        {
                        //            // return rtmList;
                        //        }
                        //    }
                        //}
                    }
                    catch (Exception ex)
                    {
                        // return rtmList;
                    }
                }
                else
                {
                    try
                    {
                        paramDict.Add("sp_rtm_getRTMResponses"); // First item as Stored procedure name if exist else set it as null
                        paramDict.Add("projectId;" + projectId + ";string"); //order of params - paramname;paramvalue;typeofparam
                        paramDict.Add("milestoneId;" + milestoneId + ";string");
                        ds = controls.DAL_RCServices.ExecuteAdapter_SP_dataset(connectionString, paramDict);

                        //using (SqlConnection connection = new SqlConnection(connectionString))
                        //{
                        //    using (SqlCommand command = new SqlCommand("sp_rtm_getRTMResponses", connection))
                        //    {
                        //        try
                        //        {
                        //            sa = new SqlDataAdapter(command);
                        //            command.CommandType = CommandType.StoredProcedure;
                        //            command.Parameters.AddWithValue("projectId", projectId);
                        //            command.Parameters.AddWithValue("milestoneId", milestoneId);
                        //            sa.Fill(ds);
                        //        }
                        //        catch (Exception ex)
                        //        {
                        //            // return rtmList;
                        //        }
                        //    }
                        //}
                    }
                    catch (Exception ex)
                    {
                        // return rtmList;
                    }
                }
            }
            
            
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        #endregion

        #region Ptoject Assessment

        public static DataTable GetAssessmentArea(string projectId, bool AssessmentAutorized = false)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_assessment_getAssessmentArea", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("projectId", projectId);
                            command.Parameters.AddWithValue("AssessmentAutorized", AssessmentAutorized);
                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public static DataTable GetAssessmentCategory(string projectId, bool AssessmentAutorized = false)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_assessment_getAssessmentCategory", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("projectId", projectId);
                            command.Parameters.AddWithValue("AssessmentAutorized", AssessmentAutorized);
                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public static DataTable GetAssessmentProcesses(string projectId, bool AssessmentAutorized = false)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_assessment_getAssessmentProcesses", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("projectId", projectId);
                            command.Parameters.AddWithValue("AssessmentAutorized", AssessmentAutorized);
                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        #endregion

        #region Front Matter
        public static DataTable GetFrontMatter(string projectId)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataAdapter sa = null;
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_getfrontMatter", connection))
                    {
                        try
                        {
                            sa = new SqlDataAdapter(command);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("projectId", projectId);
                            //command.Parameters.AddWithValue("milestoneId", milestoneId);
                            sa.Fill(ds);
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public static string NewFrontMatter(FrontMatter NewFrontMatter)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_frontmatter_insert", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@name", NewFrontMatter.Name);
                            command.Parameters.AddWithValue("@projectid", NewFrontMatter.ProjectID);

                            command.Parameters.AddWithValue("@description", NewFrontMatter.Description);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "";
        }

        public static string UpdateFrontMatter(FrontMatter EditFrontMatter)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_frontmatter_Update", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@frontmatterid", EditFrontMatter.FrontMatterID);
                            command.Parameters.AddWithValue("@name", EditFrontMatter.Name);
                            command.Parameters.AddWithValue("@description", EditFrontMatter.Description);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "";
        }

        public static string DeleteFrontMatter(FrontMatter DeleteFrontMatter)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_frontmatter_delete", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@frontmatterid", DeleteFrontMatter.FrontMatterID);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "";
        }
        #endregion


        #region Enterprise APD

        // Function to called to get Area data to dispaly in the grid
        public static List<EnterpriseAPD> GetEnterpriseAPD()
        {

            List<EnterpriseAPD> apdList = new List<EnterpriseAPD>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ent_getAPD", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            connection.Open();
                            reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                apdList.Add(new EnterpriseAPD
                                {
                                    Id = reader["apd_id"].ToString(),
                                    APDtype = reader["apd_type"].ToString(),
                                    APDNumber = reader["apd_number"].ToString(),
                                    APDName = reader["apd_Name"].ToString(),
                                    Description = reader["apd_description"].ToString(),
                                    StartDate = DateTime.Parse(reader["apd_startdate"].ToString()),
                                    EndDate = DateTime.Parse(reader["apd_enddate"].ToString())
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return apdList;


        }


        public static void InsertNewEnterpriseAPD(List<EnterpriseAPD> APDs)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command;
                    foreach (var apd in APDs)
                    {
                        try
                        {
                            command = new SqlCommand("sp_ent_newAPD", connection, transaction);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@apdtype", apd.APDtype);
                            command.Parameters.AddWithValue("@apdnumber", apd.APDNumber);
                            command.Parameters.AddWithValue("@apdname", apd.APDName);
                            command.Parameters.AddWithValue("@description", apd.Description);
                            command.Parameters.AddWithValue("@startDate", apd.StartDate);
                            command.Parameters.AddWithValue("@endDate", apd.EndDate);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            //TODO: log exception;
                            transaction.Rollback();
                            connection.Close();
                        }
                    }

                    transaction.Commit();
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        // Function to called to update Area data in the grid using bach mode
        public static void UpdateEnterpriseAPD(List<EnterpriseAPD> apds)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlTransaction transaction;
                    connection.Open();

                    foreach (var apd in apds)
                    {


                        using (SqlCommand command = new SqlCommand("sp_ent_updateAPD", connection))
                        {
                            try
                            {
                                command.CommandType = CommandType.StoredProcedure;


                                //command.Parameters.AddWithValue("@apd_id", apd.Id);
                                command.Parameters.AddWithValue("@apdtype", apd.APDtype);
                                command.Parameters.AddWithValue("@apdnumber", apd.APDNumber);
                                command.Parameters.AddWithValue("@apdname", apd.APDName);
                                command.Parameters.AddWithValue("@description", apd.Description);
                                command.Parameters.AddWithValue("@startDate", apd.StartDate);
                                command.Parameters.AddWithValue("@endDate", apd.EndDate);


                                int count = command.ExecuteNonQuery();

                                // transaction.Commit();
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        // Function to called to delete APD data
        public static bool DeleteAPD(string APDId)
        {
            bool result = true;

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_ent_dropAPD", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@apd_id", APDId);

                            command.ExecuteNonQuery();
                            result = true;

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;


        }

        #endregion
    }
    #region Projects and dropdowns
    // Model calss for the projects dropdown
    public class DropdownItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string MilestoneID { get; set; }
        public string MilestoneName { get; set; }
    }

    public class Projects
    {
        public String ProjectID { get; set; }
        public String ProjectName { get; set; }
        public String ProjectColor { get; set; }
        public String Description { get; set; }
        public String MilestoneName { get; set; }
        public String StartDate { get; set; }
        public String EstimatedEndDate { get; set; }
        public String TargetDate1 { get; set; }
        public String TargetDate2 { get; set; }
        public String TargetDate3 { get; set; }
        public String Status { get; set; }
        public String ActualEndDate { get; set; }
        public String CertificationDate { get; set; }
        public String PMName { get; set; }
        public Boolean Roadmap { get; set; }
    }

    public class Milestone
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MilestoneType { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Boolean IsStatic { get; set; }
    }
    #endregion

    // Calss for the dropdown for the Projects
    public class common_services
    {
        public static string PrepNotificationEmail(List<EmailTemplatePlaceholders> Placeholders)
        {
            string template = System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("~/Content/EmailTemplate/RCXmail.html"));

            //FInd all text placeholders to be inserted into email message
            foreach (EmailTemplatePlaceholders item in Placeholders)
            {
                template = template.Replace(item.Placeholder, item.Replacement);
            }
            return template;
        }

        public static string BuildConnString(string EnterpriseDB, bool IsIdentityDB = false)
        {

            ConnectionStringSettings ConnString = ConfigurationManager.ConnectionStrings["TemplateConnString"];
            string connectString = ConnString.ConnectionString;

            if (null != ConnString)
            {
                // Retrieve the partial connection string.

                // Create a new SqlConnectionStringBuilder based on the
                // partial connection string retrieved from the config file.
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);

                // Supply the additional values.
                builder.DataSource = ConfigurationManager.AppSettings["DataSource"];
                builder.UserID = ConfigurationManager.AppSettings["DataUser"];
                builder.Password = ConfigurationManager.AppSettings["DataPass"];
                if (IsIdentityDB == false) { builder.InitialCatalog = EnterpriseDB; } else { builder.InitialCatalog = ConfigurationManager.AppSettings["IdentityCatalog"]; }

                connectString = builder.ConnectionString;
            }
            return connectString;
        }

        public static void RefreshSession()
        {
            //Now that the user is authenticated, cast the user from ASP.NET Identity to retrieve his default landing project
            var xmanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            //var currentUser = xmanager.FindById(User.Identity.GetUserId());
            var currentUser = xmanager.FindByName(HttpContext.Current.User.Identity.GetUserName());
            if (currentUser == null) { return; }
            // Use the extended user property of 'project' which contains the GUID for the enterprise project and it to session so it can be used when querying data throughout the project
            HttpContext.Current.Session.Add("enterpriseID", currentUser.enterprise);
            HttpContext.Current.Session.Add("UserID", currentUser.Id);
            HttpContext.Current.Session.Add("UserEmail", currentUser.Email);

            //Mode for saying whether user is in Enterprise or Project Mode DEPRECATED
            HttpContext.Current.Session.Add("Mode", "project");

            //Now select query other information about the project and then add them to session variabes so they can be use. Session(projectID) will be used for querying
            //and the other properties pro_name and pro_color will be used to customize the interface to show the use what project he is currently working on
            //First, add the user's connection String to the sqldatasource - also save the connectionstring into session so that it can be declaratively used on SqlDataSources throughout the project

            // Get Enteprise Name and COnnection String
            EnterpriseInfo LoginEnterprise = common_services.GetEnterpriseInfo(currentUser.enterprise);
            HttpContext.Current.Session.Add("userConnString", common_services.BuildConnString(LoginEnterprise.DBconnectionString));
            HttpContext.Current.Session.Add("IdentityConnString", common_services.BuildConnString("rcxidentity", true));
            HttpContext.Current.Session.Add("EnterpriseName", LoginEnterprise.EnterpriseName);

            // Now get the project info from the enterprise database for this client (the client's enterprise DB has the information for each solution)
            DropdownItem NewProject = new DropdownItem();
            NewProject = common_services.GetProjectMilestone(currentUser.project);
            HttpContext.Current.Session.Add("projectName", NewProject.Name);
            HttpContext.Current.Session.Add("projectColor", NewProject.Color);
            HttpContext.Current.Session.Add("projectID", NewProject.Id);
            HttpContext.Current.Session.Add("MilestoneID", NewProject.MilestoneID);
            HttpContext.Current.Session.Add("MilestoneName", NewProject.MilestoneName);

            //Get Active Security Permissions
            HttpContext.Current.Session.Add("ActivePermissions", rc_services.GetActivePermissions());


        }

        public static String SaveXref(String ReferenceID, List<rtm_services.UniversalAssessmentItem> items)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("id");
            dataTable.Columns.Add("RC_ID");
            dataTable.Columns.Add("RC_NAME");
            dataTable.Columns.Add("RC_TYPE");
            foreach (rtm_services.UniversalAssessmentItem x in items)
            {
                dataTable.Rows.Add(x.Id, x.UniqueID, x.Name, x.Type);
            }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("rcsp_xref_update", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@xref_referenceid", Guid.Parse(ReferenceID));
                            command.Parameters.Add("@Items", SqlDbType.Structured).Value = dataTable;
                            int REsults = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            //TODO: log exception;
                            connection.Close();
                        }
                    }
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }

            return "";
        }
        public static List<UniversalAssessmentItem> GetXref(String ReferenceID)
        {
            List<rtm_services.UniversalAssessmentItem> XrefList = new List<rtm_services.UniversalAssessmentItem>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try
            {
                // setup conncetion and command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_xref_select", connection))
                    {
                        try
                        {
                            // define command type to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@xref_referenceid", ReferenceID);
                            // Open connection, execute the command
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                XrefList.Add(new rtm_services.UniversalAssessmentItem
                                {
                                    Id = Convert.ToString(reader["id"]),
                                    Name = reader["RC_NAME"].ToString(),
                                    Type = reader["RC_TYPE"].ToString(),
                                    UniqueID = reader["RC_ID"].ToString(),

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return XrefList;
        }

        //Takes the name of a report and returns an actual report object with datasource corrected to user's enterprise (session variable userConnString)
        public static XtraReport GetSourcedReport(string ReportName, string parameter = null, string Project1 = null, string Project2 = null, HttpRequest request = null)

        {
            XtraReport ReportObject = (XtraReport)Activator.CreateInstance(Type.GetType(ReportName));

            //Take the datasource used by the report, swap its connection string for the one in session variable and feed it back to REport object before loading it
            string UserConnString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            DevExpress.DataAccess.Sql.SqlDataSource ds = (DevExpress.DataAccess.Sql.SqlDataSource)ReportObject.DataSource;
            CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(UserConnString);
            ds.ConnectionParameters = connectionParameters;
            ReportObject.DataSource = ds;

            if (ReportObject.Parameters["ProjectID"] != null) { ReportObject.Parameters["ProjectID"].Value = System.Web.HttpContext.Current.Session["projectID"].ToString(); }
            if (ReportObject.Parameters["ProjectColor"] != null) { ReportObject.Parameters["ProjectColor"].Value = System.Web.HttpContext.Current.Session["projectColor"].ToString(); }
            if (ReportObject.Parameters["ProjectName"] != null) { ReportObject.Parameters["ProjectName"].Value = System.Web.HttpContext.Current.Session["projectName"].ToString(); }
            if (ReportObject.Parameters["EnterpriseName"] != null) { ReportObject.Parameters["EnterpriseName"].Value = System.Web.HttpContext.Current.Session["EnterpriseName"].ToString(); }
            if (ReportObject.Parameters["EnterpriseID"] != null) { ReportObject.Parameters["EnterpriseID"].Value = System.Web.HttpContext.Current.Session["enterpriseID"].ToString(); }
            if (ReportObject.Parameters["MilestoneID"] != null) { ReportObject.Parameters["MilestoneID"].Value = System.Web.HttpContext.Current.Session["MilestoneID"].ToString(); }
            if (ReportObject.Parameters["MilestoneName"] != null) { ReportObject.Parameters["MilestoneName"].Value = System.Web.HttpContext.Current.Session["MilestoneName"].ToString(); }
            if (ReportObject.Parameters["UserEmail"] != null) { ReportObject.Parameters["UserEmail"].Value = System.Web.HttpContext.Current.Session["UserEmail"].ToString(); }
            if (ReportObject.Parameters["UserID"] != null) { ReportObject.Parameters["UserID"].Value = System.Web.HttpContext.Current.Session["UserID"].ToString(); }
            if (ReportObject.Parameters["ChecklistID"] != null) { ReportObject.Parameters["ChecklistID"].Value = parameter.ToString(); }
            if (ReportObject.Parameters["SrtateProject"] != null) { ReportObject.Parameters["SrtateProject"].Value = parameter.ToString(); }
            if (ReportObject.Parameters["ProjectID1"] != null) { ReportObject.Parameters["ProjectID1"].Value = Project1.ToString(); }
            if (ReportObject.Parameters["ProjectID2"] != null) { ReportObject.Parameters["ProjectID2"].Value = Project2.ToString(); }

            //Gets the URL for reports that generate links to the get_repo page for downloading an artifact, like the MECL addendum report

            if (request != null) { 
            if (ReportObject.Parameters["CurrentURL"] != null) { ReportObject.Parameters["CurrentURL"].Value = request.Url.Scheme + System.Uri.SchemeDelimiter + request.Url.Authority; }

            }

            return ReportObject;
        }
        #region Projects
        public static List<Projects> GetEnterpriseProjects()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<Projects> ProjectList = new List<Projects>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                // setup conncetion and command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_ent_projects", connection))
                    {
                        try
                        {
                            // define command type to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;

                            // Open connection, execute the command
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                ProjectList.Add(new Projects
                                {
                                    ProjectID = Convert.ToString(reader["pro_ID"]),
                                    ProjectName = reader["pro_name"] == DBNull.Value ? string.Empty : reader["pro_name"].ToString(),
                                    ProjectColor = reader["pro_color"] == DBNull.Value ? string.Empty : reader["pro_color"].ToString(),
                                    Description = reader["pro_description"] == DBNull.Value ? string.Empty : reader["pro_description"].ToString(),
                                    MilestoneName = reader["MilestoneName"] == DBNull.Value ? string.Empty : reader["MilestoneName"].ToString(),
                                    StartDate = reader["pro_startDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_startDate"].ToString()).ToShortDateString(),
                                    TargetDate1 = reader["pro_targetDate1"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_targetDate1"].ToString()).ToShortDateString(),
                                    TargetDate2 = reader["pro_targetDate2"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_targetDate2"].ToString()).ToShortDateString(),
                                    TargetDate3 = reader["pro_targetDate3"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_targetDate3"].ToString()).ToShortDateString(),
                                    EstimatedEndDate = reader["pro_endDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_endDate"].ToString()).ToShortDateString(),
                                    CertificationDate = reader["pro_certificationDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_certificationDate"].ToString()).ToShortDateString(),
                                    ActualEndDate = reader["pro_actualEndDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_actualEndDate"].ToString()).ToShortDateString(),
                                    Roadmap = reader["pro_roadmap"] == DBNull.Value ? false : (bool)reader["pro_roadmap"],
                                    PMName = reader["pro_projectManager"] == DBNull.Value ? string.Empty : reader["pro_projectManager"].ToString(),
                                    Status = reader["pro_status"] == DBNull.Value ? string.Empty : reader["pro_status"].ToString(),


                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ProjectList;
        }

        public static List<Projects> GetEnterpriseRoadMapProjects()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<Projects> ProjectList = new List<Projects>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                // setup conncetion and command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_ent_roadMapProjects", connection))
                    {
                        try
                        {
                            // define command type to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;

                            // Open connection, execute the command
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                ProjectList.Add(new Projects
                                {
                                    ProjectID = Convert.ToString(reader["pro_ID"]),
                                    ProjectName = reader["pro_name"] == DBNull.Value ? string.Empty : reader["pro_name"].ToString(),
                                    ProjectColor = reader["pro_color"] == DBNull.Value ? string.Empty : reader["pro_color"].ToString(),
                                    Description = reader["pro_description"] == DBNull.Value ? string.Empty : reader["pro_description"].ToString(),
                                    MilestoneName = reader["MilestoneName"] == DBNull.Value ? string.Empty : reader["MilestoneName"].ToString(),
                                    StartDate = reader["pro_startDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_startDate"].ToString()).ToShortDateString(),
                                    TargetDate1 = reader["pro_targetDate1"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_targetDate1"].ToString()).ToShortDateString(),
                                    TargetDate2 = reader["pro_targetDate2"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_targetDate2"].ToString()).ToShortDateString(),
                                    TargetDate3 = reader["pro_targetDate3"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_targetDate3"].ToString()).ToShortDateString(),
                                    EstimatedEndDate = reader["pro_endDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_endDate"].ToString()).ToShortDateString(),
                                    CertificationDate = reader["pro_certificationDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_certificationDate"].ToString()).ToShortDateString(),
                                    ActualEndDate = reader["pro_actualEndDate"].ToString() == "" ? "" : Convert.ToDateTime(reader["pro_actualEndDate"].ToString()).ToShortDateString(),
                                    Roadmap = reader["pro_roadmap"] == DBNull.Value ? false : (bool)reader["pro_roadmap"],
                                    PMName = reader["pro_projectManager"] == DBNull.Value ? string.Empty : reader["pro_projectManager"].ToString(),
                                    Status = reader["pro_status"] == DBNull.Value ? string.Empty : reader["pro_status"].ToString(),


                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return ProjectList;
        }

        public static void InsertNewProject(Projects projects)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_rc_ent_InsertNewProject", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@pro_name", projects.ProjectName);
                            command.Parameters.AddWithValue("@pro_color", projects.ProjectColor);
                            command.Parameters.AddWithValue("@pro_description", projects.Description);
                            command.Parameters.AddWithValue("@mil_name", projects.MilestoneName);
                            command.Parameters.AddWithValue("@pro_startDate", projects.StartDate);
                            command.Parameters.AddWithValue("@pro_endDate", projects.EstimatedEndDate);
                            command.Parameters.AddWithValue("@pro_targetDate1", projects.TargetDate1);
                            command.Parameters.AddWithValue("@pro_targetDate2", projects.TargetDate2);
                            command.Parameters.AddWithValue("@pro_targetDate3", projects.TargetDate3);
                            command.Parameters.AddWithValue("@pro_actualEndDate", projects.ActualEndDate);
                            command.Parameters.AddWithValue("@pro_certificationDate", projects.CertificationDate);
                            command.Parameters.AddWithValue("@pro_projectManager", projects.PMName);
                            command.Parameters.AddWithValue("@pro_roadmap", projects.Roadmap);
                            command.Parameters.AddWithValue("@pro_status", projects.Status);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            //TODO: log exception;
                            connection.Close();
                        }
                    }
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        public static void UpdateProjects(Projects projects)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var user = HttpContext.Current.Session["UserEmail"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_rc_ent_projectUpdate", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@pro_ID", projects.ProjectID);
                            command.Parameters.AddWithValue("@pro_name", projects.ProjectName);
                            command.Parameters.AddWithValue("@pro_color", projects.ProjectColor);
                            command.Parameters.AddWithValue("@pro_description", projects.Description);
                            command.Parameters.AddWithValue("@mil_name", projects.MilestoneName);
                            command.Parameters.AddWithValue("@pro_startDate", projects.StartDate);
                            command.Parameters.AddWithValue("@pro_endDate", projects.EstimatedEndDate);
                            command.Parameters.AddWithValue("@pro_targetDate1", projects.TargetDate1);
                            command.Parameters.AddWithValue("@pro_targetDate2", projects.TargetDate2);
                            command.Parameters.AddWithValue("@pro_targetDate3", projects.TargetDate3);
                            command.Parameters.AddWithValue("@pro_actualEndDate", projects.ActualEndDate);
                            command.Parameters.AddWithValue("@pro_certificationDate", projects.CertificationDate);
                            command.Parameters.AddWithValue("@pro_projectManager", projects.PMName);
                            command.Parameters.AddWithValue("@pro_roadmap", projects.Roadmap);
                            command.Parameters.AddWithValue("@pro_status", projects.Status);
                            command.Parameters.AddWithValue("@user", user);

                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        public static void DeleteProjects(Projects project)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var user = HttpContext.Current.Session["UserEmail"].ToString();
            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_rc_ent_Deleteproject", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@pro_ID", project.ProjectID);
                            command.Parameters.AddWithValue("@user", user);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        // Function to called get the Projects into the dropdown at Enterprise RTM
        public static List<DropdownItem> GetProjects(string project=null)
        {

            List<DropdownItem> dropdownList = new List<DropdownItem>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                // setup conncetion and command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rtm_projects", connection))
                    {
                        try
                        {
                            // define command type to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@projectID", project);
                            // Open connection, execute the command
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                dropdownList.Add(new DropdownItem
                                {
                                    Id = Convert.ToString(reader["pro_ID"]),
                                    Name = reader["pro_name"].ToString(),
                                    Color = reader["pro_color"].ToString(),
                                    Description = reader["pro_description"].ToString(),

                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return dropdownList;

        }

        public static List<DropdownItem> GetMenuProjects(string project)
        {

            List<DropdownItem> dropdownList = new List<DropdownItem>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try

            {
                // setup conncetion and command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_menu_projects_getAll", connection))
                    {
                        try
                        {
                            // define command type to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@project", project);
                            // Open connection, execute the command
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                dropdownList.Add(new DropdownItem
                                {
                                    Id = Convert.ToString(reader["pro_ID"]),
                                    Name = reader["pro_name"].ToString(),
                                    Color = reader["pro_color"].ToString(),
                                    Description = reader["pro_description"].ToString(),

                                });
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dropdownList;

        }

        public static DropdownItem GetProjectMilestone(Guid projectID)
        {

            DropdownItem dropdownList = new DropdownItem();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try
            {
                // setup conncetion and command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_projects_get", connection))
                    {
                        try
                        {
                            // define command type to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("pro_id", projectID);

                            // Open connection, execute the command
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                dropdownList.Id = Convert.ToString(reader["pro_ID"]);
                                dropdownList.Name = reader["pro_name"].ToString();
                                dropdownList.Color = reader["pro_color"].ToString();
                                dropdownList.Description = reader["pro_description"].ToString();
                                dropdownList.MilestoneID = reader["mil_id"].ToString();
                                dropdownList.MilestoneName = reader["mil_name"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return dropdownList;

        }

        public static List<Milestone> GetMilestone()
        {
            List<Milestone> milestoneList = new List<Milestone>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rtm_getMilestones", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@projectId", projectId);
                            connection.Open();
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                milestoneList.Add(new Milestone
                                {
                                    Id = reader["mil_id"].ToString(),
                                    Name = reader["mil_name"].ToString(),
                                    MilestoneType = reader["mil_type"].ToString(),
                                    Description = reader["mil_description"].ToString(),
                                    Date = DateTime.Parse(reader["mil_date"].ToString()),
                                    IsStatic = reader["IsStatic"] == DBNull.Value ? false : Convert.ToBoolean(reader["IsStatic"])
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return milestoneList;
        }

        public static List<Milestone> GetFluidMilestones()
        {
            List<Milestone> milestoneList = new List<Milestone>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_milestones_getfluid", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@projectId", projectId);
                            connection.Open();
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                milestoneList.Add(new Milestone
                                {
                                    Id = reader["mil_id"].ToString(),
                                    Name = reader["mil_name"].ToString(),
                                    Description = reader["mil_description"].ToString(),
                                    Date = DateTime.Parse(reader["mil_date"].ToString()),
                                    IsStatic = reader["IsStatic"] == DBNull.Value ? false : Convert.ToBoolean(reader["IsStatic"])
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return milestoneList;
        }

        public static List<Milestone> GetStaticMilestones()
        {
            List<Milestone> milestoneList = new List<Milestone>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_milestones_getstatic", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@projectId", projectId);
                            connection.Open();
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                milestoneList.Add(new Milestone
                                {
                                    Id = reader["mil_id"].ToString(),
                                    Name = reader["mil_name"].ToString(),
                                    Description = reader["mil_description"].ToString(),
                                    Date = DateTime.Parse(reader["mil_date"].ToString()),
                                    IsStatic = reader["IsStatic"] == DBNull.Value ? false : Convert.ToBoolean(reader["IsStatic"])
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return milestoneList;
        }

        public static void InsertNewMilestone(Milestone milestones)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_rtm_InsertNewMilestone", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@mil_name", milestones.Name);
                            command.Parameters.AddWithValue("@mil_type", milestones.MilestoneType);
                            command.Parameters.AddWithValue("@mil_description", milestones.Description);
                            command.Parameters.AddWithValue("@mil_date", milestones.Date);
                            command.Parameters.AddWithValue("@IsStatic", milestones.IsStatic);
                            command.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            //TODO: log exception;
                            connection.Close();
                        }
                    }
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        public static void UpdateMilestones(Milestone milestone)
        {
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_rtm_UpdateMilestone", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@mil_id", milestone.Id);
                            command.Parameters.AddWithValue("@mil_name", milestone.Name);
                            command.Parameters.AddWithValue("@mil_type", milestone.MilestoneType);
                            command.Parameters.AddWithValue("@mil_description", milestone.Description);
                            command.Parameters.AddWithValue("@mil_date", milestone.Date);
                            command.Parameters.AddWithValue("@isStatic", milestone.IsStatic);

                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: log exception
            }
        }

        public static List<DropdownItem> GetCustomDropDown(string Area)
        {
            
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            // new code by using new DAL functionalities..
            List<string> paramDict = new List<string>(2);
            paramDict.Add("rcsp_valuetypes_get"); // First item as Stored procedure name if exist else set it as null
            paramDict.Add("@type_home;" + Area + ";string"); //order of params - paramname;paramvalue;typeofparam
            List<string> outputVars = new List<string>();
            outputVars.Add("type_id");
            outputVars.Add("type_title");
            outputVars.Add("type_value");
            List<controls.ReaderOutputs> outs = controls.DAL_RCServices.ExecuteReader(connectionString, paramDict,3, outputVars);
            List<DropdownItem> dropdownList = new List<DropdownItem>();
            foreach (var item in outs)
            {
                dropdownList.Add(new DropdownItem
                {
                    Id = Convert.ToString(item.out1),
                    Name = item.out2.ToString(),
                    Description = item.out3.ToString(),

                });
            }
            // older code 
            //var identityConnectionString = ConfigurationManager.ConnectionStrings["RCXidentity"].ConnectionString;
            //SqlDataReader reader = null;
            //List<DropdownItem> dropdownList1 = new List<DropdownItem>();
            //try

            //{
            //    // setup conncetion and command
            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand("rcsp_valuetypes_get", connection))
            //        {
            //            try
            //            {
            //                // define command type to be stored procedure
            //                command.CommandType = CommandType.StoredProcedure;
            //                command.Parameters.AddWithValue("@type_home", Area);
            //                // Open connection, execute the command
            //                connection.Open();
            //                reader = command.ExecuteReader();

            //                while (reader.Read())
            //                {
            //                    dropdownList.Add(new DropdownItem
            //                    {
            //                        Id = Convert.ToString(reader["type_id"]),
            //                        Name = reader["type_title"].ToString(),
            //                        Description = reader["type_value"].ToString(),

            //                    });
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                // return rtmList;
            //            }
            //            finally
            //            {
            //                reader.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // return rtmList;
            //}
            return dropdownList;

        }

        public static EnterpriseInfo GetEnterpriseInfo(Guid EnterpriseID)
        {
            EnterpriseInfo ReturnInfo = new EnterpriseInfo();
            var connectionString = common_services.BuildConnString("rcxidentity", true);//ConfigurationManager.ConnectionStrings["RCXidentity"].ToString();
            SqlDataReader reader = null;

            try
            {
                // setup conncetion and command
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("rcsp_enterprise_get", connection))
                    {
                        try
                        {
                            // define command type to be stored procedure
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("en_id", EnterpriseID);

                            // Open connection, execute the command
                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                ReturnInfo.DBconnectionString = reader["en_connstring"].ToString();
                                ReturnInfo.EnterpriseName = reader["en_name"].ToString();

                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return ReturnInfo;
        }

        public static DataTable GetUserProfile()
        {

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var user = HttpContext.Current.Session["UserEmail"].ToString();
            DataSet ds = new DataSet();

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_userProfile_get", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@email", user);
                            using (var sa = new SqlDataAdapter(command))
                            {
                                sa.Fill(ds);
                            }
                        }
                        catch (Exception ex)
                        {
                            // return rtmList;
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                                connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }

            return ds.Tables.Count > 0 ? ds.Tables[0] : null;

        }


        #region IV&V Methods

        #region IV&V General Information
        public static List<GeneralInfo> GetGeneralInfo()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<GeneralInfo> GeneralInfoData = new List<GeneralInfo>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_GetGeneralInfo", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@rm_projectID", System.Web.HttpContext.Current.Session["projectID"].ToString());
                            //command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);

                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {

                                GeneralInfoData.Add(new GeneralInfo
                                {
                                    GeneralInfoID = reader["ivv_id"].ToString(),
                                    StateName = reader["ivv_state"].ToString(),
                                    ProjectName = reader["ivv_project_name"].ToString(),
                                    ProgramName = reader["ivv_program_name"].ToString(),
                                    StatePrimaryPOC = reader["ivv_state_primary_poc"].ToString(),
                                    StatePrimaryPOCEmail = reader["ivv_state_primary_poc_email"].ToString(),
                                    SubmitterName = reader["ivv_submitter_name"].ToString(),
                                    SubmitterRole = reader["ivv_submitter_name"].ToString(),
                                    SubmitterEmail = reader["ivv_submitter_email"].ToString(),
                                    SubmitterPhone = reader["ivv_submitter_email"].ToString(),
                                    ConsultDate = reader["ivv_activity_1_consult_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["ivv_activity_1_consult_date"].ToString()).ToShortDateString(), // == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["bp_opendate"]),
                                    RFPReleaseDate = reader["ivv_rfp_release_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["ivv_rfp_release_date"].ToString()).ToShortDateString(),
                                    OnBoardDate = reader["ivv_onboard_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["ivv_onboard_date"].ToString()).ToShortDateString(),
                                    NextProgressDate = reader["ivv_nextprogress_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["ivv_nextprogress_date"].ToString()).ToShortDateString(),

                                    ProgressReportDate = reader["ivv_nextprogress_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["ivv_nextprogress_date"].ToString()).ToShortDateString(),
                                    ExecutiveSummary = reader["ivv_executive_summary"].ToString() == "" ? "" : reader["ivv_executive_summary"].ToString()

                                });

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return GeneralInfoData;

        }
        public static string NewGeneralInfo(GeneralInfo InsertGeneralInfo)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_NewGeneralInfo", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@StateName", InsertGeneralInfo.StateName);
                            command.Parameters.AddWithValue("@ProjectName", InsertGeneralInfo.ProjectName);
                            command.Parameters.AddWithValue("@ProgramName", InsertGeneralInfo.ProgramName == null ? "" : InsertGeneralInfo.ProgramName);
                            if (InsertGeneralInfo.ProgressReportDate == null) { command.Parameters.AddWithValue("@ProgressReportDate", DBNull.Value); } else { command.Parameters.AddWithValue("@ProgressReportDate", InsertGeneralInfo.ProgressReportDate); }
                            command.Parameters.AddWithValue("@StatePrimaryPOC", InsertGeneralInfo.StatePrimaryPOC == null ? "" : InsertGeneralInfo.StatePrimaryPOC);
                            if (InsertGeneralInfo.StatePrimaryPOCEmail == null) { command.Parameters.AddWithValue("@StatePrimaryPOCEmail", DBNull.Value); } else { command.Parameters.AddWithValue("@StatePrimaryPOCEmail", InsertGeneralInfo.StatePrimaryPOCEmail); }
                            if (InsertGeneralInfo.SubmitterName == null) { command.Parameters.AddWithValue("@SubmitterName", DBNull.Value); } else { command.Parameters.AddWithValue("@SubmitterName", InsertGeneralInfo.SubmitterName); }
                            if (InsertGeneralInfo.SubmitterRole == null) { command.Parameters.AddWithValue("@SubmitterRole", DBNull.Value); } else { command.Parameters.AddWithValue("@SubmitterRole", InsertGeneralInfo.SubmitterRole); }
                            if (InsertGeneralInfo.SubmitterEmail == null) { command.Parameters.AddWithValue("@SubmitterEmail", DBNull.Value); } else { command.Parameters.AddWithValue("@SubmitterEmail", InsertGeneralInfo.SubmitterEmail); }
                            if (InsertGeneralInfo.SubmitterPhone == null) { command.Parameters.AddWithValue("@SubmitterPhone", DBNull.Value); } else { command.Parameters.AddWithValue("@SubmitterPhone", InsertGeneralInfo.SubmitterPhone); }

                            if (InsertGeneralInfo.ConsultDate == null) { command.Parameters.AddWithValue("@ConsultDate", DBNull.Value); } else { command.Parameters.AddWithValue("@ConsultDate", InsertGeneralInfo.ConsultDate); }
                            if (InsertGeneralInfo.RFPReleaseDate == null) { command.Parameters.AddWithValue("@RFPReleaseDate", DBNull.Value); } else { command.Parameters.AddWithValue("@RFPReleaseDate", InsertGeneralInfo.RFPReleaseDate); }
                            if (InsertGeneralInfo.OnBoardDate == null) { command.Parameters.AddWithValue("@OnBoardDate", DBNull.Value); } else { command.Parameters.AddWithValue("@OnBoardDate", InsertGeneralInfo.OnBoardDate); }
                            if (InsertGeneralInfo.NextProgressDate == null) { command.Parameters.AddWithValue("@NextProgressDate", DBNull.Value); } else { command.Parameters.AddWithValue("@NextProgressDate", InsertGeneralInfo.NextProgressDate); }

                            command.Parameters.AddWithValue("@ExecutiveSummary", InsertGeneralInfo.ExecutiveSummary == null ? "" : InsertGeneralInfo.ExecutiveSummary);


                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Added";
        }
        public static string UpdateGeneralInfo(GeneralInfo UpdateGeneralInfo)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_UpdateGeneralInfo", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@GeneralInfoID", UpdateGeneralInfo.GeneralInfoID);
                            command.Parameters.AddWithValue("@StateName", UpdateGeneralInfo.StateName);
                            command.Parameters.AddWithValue("@ProjectName", UpdateGeneralInfo.ProjectName);
                            command.Parameters.AddWithValue("@ProgramName", UpdateGeneralInfo.ProgramName == null ? "" : UpdateGeneralInfo.ProgramName);
                            if (UpdateGeneralInfo.ProgressReportDate == null) { command.Parameters.AddWithValue("@ProgressReportDate", DBNull.Value); } else { command.Parameters.AddWithValue("@ProgressReportDate", UpdateGeneralInfo.ProgressReportDate); }
                            command.Parameters.AddWithValue("@StatePrimaryPOC", UpdateGeneralInfo.StatePrimaryPOC == null ? "" : UpdateGeneralInfo.StatePrimaryPOC);
                            if (UpdateGeneralInfo.StatePrimaryPOCEmail == null) { command.Parameters.AddWithValue("@StatePrimaryPOCEmail", DBNull.Value); } else { command.Parameters.AddWithValue("@StatePrimaryPOCEmail", UpdateGeneralInfo.StatePrimaryPOCEmail); }
                            if (UpdateGeneralInfo.SubmitterName == null) { command.Parameters.AddWithValue("@SubmitterName", DBNull.Value); } else { command.Parameters.AddWithValue("@SubmitterName", UpdateGeneralInfo.SubmitterName); }
                            if (UpdateGeneralInfo.SubmitterRole == null) { command.Parameters.AddWithValue("@SubmitterRole", DBNull.Value); } else { command.Parameters.AddWithValue("@SubmitterRole", UpdateGeneralInfo.SubmitterRole); }
                            if (UpdateGeneralInfo.SubmitterEmail == null) { command.Parameters.AddWithValue("@SubmitterEmail", DBNull.Value); } else { command.Parameters.AddWithValue("@SubmitterEmail", UpdateGeneralInfo.SubmitterEmail); }
                            if (UpdateGeneralInfo.SubmitterPhone == null) { command.Parameters.AddWithValue("@SubmitterPhone", DBNull.Value); } else { command.Parameters.AddWithValue("@SubmitterPhone", UpdateGeneralInfo.SubmitterPhone); }

                            if (UpdateGeneralInfo.ConsultDate == null) { command.Parameters.AddWithValue("@ConsultDate", DBNull.Value); } else { command.Parameters.AddWithValue("@ConsultDate", UpdateGeneralInfo.ConsultDate); }
                            if (UpdateGeneralInfo.RFPReleaseDate == null) { command.Parameters.AddWithValue("@RFPReleaseDate", DBNull.Value); } else { command.Parameters.AddWithValue("@RFPReleaseDate", UpdateGeneralInfo.RFPReleaseDate); }
                            if (UpdateGeneralInfo.OnBoardDate == null) { command.Parameters.AddWithValue("@OnBoardDate", DBNull.Value); } else { command.Parameters.AddWithValue("@OnBoardDate", UpdateGeneralInfo.OnBoardDate); }
                            if (UpdateGeneralInfo.NextProgressDate == null) { command.Parameters.AddWithValue("@NextProgressDate", DBNull.Value); } else { command.Parameters.AddWithValue("@NextProgressDate", UpdateGeneralInfo.NextProgressDate); }

                            command.Parameters.AddWithValue("@ExecutiveSummary", UpdateGeneralInfo.ExecutiveSummary == null ? "" : UpdateGeneralInfo.ExecutiveSummary);



                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Added";
        }
        public static string DeleteGeneralInfo(String GeneralInfoID)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_DeleteGeneralInfo", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@GeneralInfoID", GeneralInfoID);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "Sucessfully Deleted";
        }
        #endregion

        #region IV&V LifeCycle Status
        public static List<LifeCycleStatus> GetLifeCyclestatus()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<LifeCycleStatus> GeneralInfoData = new List<LifeCycleStatus>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_GetLifeCycleStatus", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@rm_projectID", System.Web.HttpContext.Current.Session["projectID"].ToString());
                            //command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);

                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {

                                GeneralInfoData.Add(new LifeCycleStatus
                                {
                                    LifeCycleStatusID = reader["lifecycle_status_id"].ToString(),
                                    Module = reader["lifecycle_status_module"].ToString(),
                                    ProjectName = reader["lifecycle_status_projectname"].ToString(),
                                    Project = reader["Project"].ToString(),
                                    Status = reader["lifecycle_status_project_status"].ToString(),
                                    IAPDApprovalDate = reader["lifecycle_status_iapd_approval_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["lifecycle_status_iapd_approval_date"].ToString()).ToShortDateString(),
                                    R1Date = reader["lifecycle_status_r1_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["lifecycle_status_r1_date"].ToString()).ToShortDateString(),
                                    R2Date = reader["lifecycle_status_r2_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["lifecycle_status_r2_date"].ToString()).ToShortDateString(),
                                    LiveDate = reader["lifecycle_status_live_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["lifecycle_status_live_date"].ToString()).ToShortDateString(),
                                    R3Date = reader["lifecycle_status-r3_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["lifecycle_status-r3_date"].ToString()).ToShortDateString(),
                                    DevelopmentStartDate = reader["lifecycle_status_devp_start_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["lifecycle_status_devp_start_date"].ToString()).ToShortDateString()

                                });

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return GeneralInfoData;

        }
        public static string NewLifeCycleStatus(LifeCycleStatus InsertLifeCycleStatus)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_NewLifeCycleStatus", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@lifecycle_status_module", InsertLifeCycleStatus.Module);
                            command.Parameters.AddWithValue("@lifecycle_status_projectname", InsertLifeCycleStatus.ProjectName);
                            command.Parameters.AddWithValue("@lifecycle_status_project_status", InsertLifeCycleStatus.Status == null ? "" : InsertLifeCycleStatus.Status);
                            command.Parameters.AddWithValue("@project", InsertLifeCycleStatus.Project == null ? "" : InsertLifeCycleStatus.Project);

                            if (InsertLifeCycleStatus.IAPDApprovalDate == null) { command.Parameters.AddWithValue("@lifecycle_status_iapd_approval_date", DBNull.Value); } else { command.Parameters.AddWithValue("@lifecycle_status_iapd_approval_date", InsertLifeCycleStatus.IAPDApprovalDate); }


                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Added";
        }
        public static string UpdateLifeCycleStatus(LifeCycleStatus UpdateLifeCycle)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            var user = HttpContext.Current.Session["UserEmail"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_updateLifeCycleStatus", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@lifecycle_status_id", UpdateLifeCycle.LifeCycleStatusID);
                            command.Parameters.AddWithValue("@lifecycle_status_module", UpdateLifeCycle.Module);
                            command.Parameters.AddWithValue("@lifecycle_status_projectname", UpdateLifeCycle.ProjectName);
                            command.Parameters.AddWithValue("@lifecycle_status_project_status", UpdateLifeCycle.Status == null ? "" : UpdateLifeCycle.Status);
                            command.Parameters.AddWithValue("@project", UpdateLifeCycle.Project == null ? "" : UpdateLifeCycle.Project);
                            if (UpdateLifeCycle.IAPDApprovalDate == null) { command.Parameters.AddWithValue("@lifecycle_status_iapd_approval_date", DBNull.Value); } else { command.Parameters.AddWithValue("@lifecycle_status_iapd_approval_date", UpdateLifeCycle.IAPDApprovalDate); }
                            command.Parameters.AddWithValue("@user", user);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Added";
        }
        public static string DeleteLifeCycleStatus(String LifecycleStatusID)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_DeleteLifeCycleStatus", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@LifeCycleStatusID", LifecycleStatusID);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "Sucessfully Deleted";
        }
        #endregion

        #region IV&V Risks PMO
        public static List<IVVRisks> GetIVVRisks()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<IVVRisks> iVVRisks = new List<IVVRisks>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_GetRisks", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@rm_projectID", System.Web.HttpContext.Current.Session["projectID"].ToString());
                            //command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);

                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {

                                iVVRisks.Add(new IVVRisks
                                {
                                    RisksID = reader["ivv_risks_id"].ToString(),
                                    UniqueID = reader["ivv_risks_uniqueid"].ToString(),
                                    Title = reader["ivv_risks_title"].ToString(),
                                    ResolutionDate = reader["ivv_risks_resolution_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["ivv_risks_resolution_date"].ToString()).ToShortDateString(),

                                    Probability = reader["ivv_risks_probability"].ToString(),
                                    Impact = reader["ivv_risks_impact"].ToString(),
                                    Status = Convert.ToBoolean(reader["ivv_risks_status"].ToString()),
                                    Description = reader["ivv_risks_description"].ToString()


                                });

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return iVVRisks;

        }
        public static string NewIVVRisks(IVVRisks InsertIVVRisks)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_NewRisks", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ivv_risks_uniqueid", InsertIVVRisks.UniqueID);
                            command.Parameters.AddWithValue("@ivv_risks_title", InsertIVVRisks.Title);
                            command.Parameters.AddWithValue("@ivv_risks_probability", InsertIVVRisks.Probability);
                            command.Parameters.AddWithValue("@ivv_risks_impact", InsertIVVRisks.Impact);
                            command.Parameters.AddWithValue("@ivv_risks_description", InsertIVVRisks.Description);

                            command.Parameters.AddWithValue("@ivv_risks_status", InsertIVVRisks.Status);

                            if (InsertIVVRisks.ResolutionDate == null) { command.Parameters.AddWithValue("@ivv_risks_resolution_date", DBNull.Value); } else { command.Parameters.AddWithValue("@ivv_risks_resolution_date", InsertIVVRisks.ResolutionDate); }



                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Added";
        }
        public static string UpdateIVVRisks(IVVRisks UpdateIVVRisks)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_UpdateRisks", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ivv_risks_id", UpdateIVVRisks.RisksID);
                            command.Parameters.AddWithValue("@ivv_risks_uniqueid", UpdateIVVRisks.UniqueID);
                            command.Parameters.AddWithValue("@ivv_risks_title", UpdateIVVRisks.Title);
                            command.Parameters.AddWithValue("@ivv_risks_probability", UpdateIVVRisks.Probability);
                            command.Parameters.AddWithValue("@ivv_risks_impact", UpdateIVVRisks.Impact);
                            command.Parameters.AddWithValue("@ivv_risks_description", UpdateIVVRisks.Description);

                            command.Parameters.AddWithValue("@ivv_risks_status", UpdateIVVRisks.Status);

                            if (UpdateIVVRisks.ResolutionDate == null) { command.Parameters.AddWithValue("@ivv_risks_resolution_date", DBNull.Value); } else { command.Parameters.AddWithValue("@ivv_risks_resolution_date", UpdateIVVRisks.ResolutionDate); }



                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Added";
        }
        public static string DeleteIVVRisks(String IVVRisksID)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_DeleteRisks", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ivv_risks_id", IVVRisksID);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "Sucessfully Deleted";
        }
        #endregion

        #region IV&V Recommendations PMO
        public static List<IVVRecommendations> GetIVVRecmmendations()
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            List<IVVRecommendations> ivvRecmmendations = new List<IVVRecommendations>();
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            SqlDataReader reader = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_GetRecomendations", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            //command.Parameters.AddWithValue("@rm_projectID", System.Web.HttpContext.Current.Session["projectID"].ToString());
                            //command.Parameters.AddWithValue("@enterprise", IncludeEnterprise);

                            connection.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {

                                ivvRecmmendations.Add(new IVVRecommendations
                                {
                                    RecommendationID = reader["ivv_recm_id"].ToString(),
                                    RecommendationId = reader["ivv_recm_uniqueid"].ToString(),
                                    Recommendation = reader["ivv_recm_recommendation"].ToString(),
                                    RecommendationDate = reader["ivv_recm_date"].ToString() == "" ? "" : Convert.ToDateTime(reader["ivv_recm_date"].ToString()).ToShortDateString(),
                                    Comments = reader["ivv_recm_description"].ToString(),
                                    Resolved = Convert.ToBoolean(reader["ivv_recm_resolved"].ToString())

                                });

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return ivvRecmmendations;

        }
        public static string NewIVVRecmmendations(IVVRecommendations recommendations)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_InsertRecomendations", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ivv_recm_uniqueid", recommendations.RecommendationId);
                            command.Parameters.AddWithValue("@ivv_recm_recommendation", recommendations.Recommendation);

                            command.Parameters.AddWithValue("@ivv_recm_description", recommendations.Comments);

                            command.Parameters.AddWithValue("@ivv_recm_resolved", recommendations.Resolved);

                            if (recommendations.RecommendationDate == null) { command.Parameters.AddWithValue("@ivv_recm_date", DBNull.Value); } else { command.Parameters.AddWithValue("@ivv_recm_date", recommendations.RecommendationDate); }


                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Added";
        }
        public static string UpdateIVVRecmmendations(IVVRecommendations UpdateRecommendations)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }

            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_UpdateRecomendations", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ivv_recm_id", UpdateRecommendations.RecommendationID);
                            command.Parameters.AddWithValue("@ivv_recm_uniqueid", UpdateRecommendations.RecommendationId);

                            command.Parameters.AddWithValue("@ivv_recm_recommendation", UpdateRecommendations.Recommendation);
                            command.Parameters.AddWithValue("@ivv_recm_description", UpdateRecommendations.Comments);

                            command.Parameters.AddWithValue("@ivv_recm_resolved", UpdateRecommendations.Resolved);

                            if (UpdateRecommendations.RecommendationDate == null) { command.Parameters.AddWithValue("@ivv_recm_date", DBNull.Value); } else { command.Parameters.AddWithValue("@ivv_recm_date", UpdateRecommendations.RecommendationDate); }



                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return "Sucessfully Added";
        }
        public static string DeleteIVVRecommendations(String RecommendationID)
        {
            if (System.Web.HttpContext.Current.Session["userConnString"] == null) { common_services.RefreshSession(); }
            var connectionString = System.Web.HttpContext.Current.Session["userConnString"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_rc_IV&V_DeleteRecomendations", connection))
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ivv_recm_id", RecommendationID);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // return rtmList;
            }
            return "Sucessfully Deleted";
        }
        #endregion

        #endregion
    }
}