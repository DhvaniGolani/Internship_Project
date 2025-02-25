﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project2021
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Project2021Entities : DbContext
    {
        public Project2021Entities()
            : base("name=Project2021Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AuditTable> AuditTables { get; set; }
        public virtual DbSet<mstAuditTeam> mstAuditTeams { get; set; }
        public virtual DbSet<mstObserverTeam> mstObserverTeams { get; set; }
        public virtual DbSet<ProjectForm> ProjectForms { get; set; }
        public virtual DbSet<Question_master> Question_master { get; set; }
        public virtual DbSet<QuesTransaction_table> QuesTransaction_table { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<SubQuestion> SubQuestions { get; set; }
        public virtual DbSet<mstMailMatrix> mstMailMatrices { get; set; }
        public virtual DbSet<mstProjectMaster> mstProjectMasters { get; set; }
        public virtual DbSet<tbl_Adminmaster> tbl_Adminmaster { get; set; }
        public virtual DbSet<tbl_Rolemaster> tbl_Rolemaster { get; set; }
        public virtual DbSet<HSE_details_tbl> HSE_details_tbl { get; set; }
        public virtual DbSet<HSE_transaction_tbl> HSE_transaction_tbl { get; set; }
        public virtual DbSet<mst_HSEQuest_tbl> mst_HSEQuest_tbl { get; set; }
        public virtual DbSet<NCReport_details> NCReport_details { get; set; }
        public virtual DbSet<Form4Details> Form4Details { get; set; }
        public virtual DbSet<mstAuditee> mstAuditees { get; set; }
    
        public virtual int formInsert(Nullable<int> pS_No, string name, string email, string phone_No)
        {
            var pS_NoParameter = pS_No.HasValue ?
                new ObjectParameter("PS_No", pS_No) :
                new ObjectParameter("PS_No", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phone_NoParameter = phone_No != null ?
                new ObjectParameter("Phone_No", phone_No) :
                new ObjectParameter("Phone_No", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("formInsert", pS_NoParameter, nameParameter, emailParameter, phone_NoParameter);
        }
    
        public virtual int insertAuditForm(string action, Nullable<int> auditID, string gridData, Nullable<System.DateTime> dateOfAudit, string siteName, string siteDetails, string auditTeam, string observerTeam, string strenghts, string majorNC, string minorNC, string oFIs, string audit_ID, string cBY, Nullable<System.DateTime> cON, string mBY, Nullable<System.DateTime> mON, Nullable<bool> isSubToObs)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var auditIDParameter = auditID.HasValue ?
                new ObjectParameter("AuditID", auditID) :
                new ObjectParameter("AuditID", typeof(int));
    
            var gridDataParameter = gridData != null ?
                new ObjectParameter("GridData", gridData) :
                new ObjectParameter("GridData", typeof(string));
    
            var dateOfAuditParameter = dateOfAudit.HasValue ?
                new ObjectParameter("dateOfAudit", dateOfAudit) :
                new ObjectParameter("dateOfAudit", typeof(System.DateTime));
    
            var siteNameParameter = siteName != null ?
                new ObjectParameter("siteName", siteName) :
                new ObjectParameter("siteName", typeof(string));
    
            var siteDetailsParameter = siteDetails != null ?
                new ObjectParameter("siteDetails", siteDetails) :
                new ObjectParameter("siteDetails", typeof(string));
    
            var auditTeamParameter = auditTeam != null ?
                new ObjectParameter("auditTeam", auditTeam) :
                new ObjectParameter("auditTeam", typeof(string));
    
            var observerTeamParameter = observerTeam != null ?
                new ObjectParameter("observerTeam", observerTeam) :
                new ObjectParameter("observerTeam", typeof(string));
    
            var strenghtsParameter = strenghts != null ?
                new ObjectParameter("strenghts", strenghts) :
                new ObjectParameter("strenghts", typeof(string));
    
            var majorNCParameter = majorNC != null ?
                new ObjectParameter("MajorNC", majorNC) :
                new ObjectParameter("MajorNC", typeof(string));
    
            var minorNCParameter = minorNC != null ?
                new ObjectParameter("MinorNC", minorNC) :
                new ObjectParameter("MinorNC", typeof(string));
    
            var oFIsParameter = oFIs != null ?
                new ObjectParameter("OFIs", oFIs) :
                new ObjectParameter("OFIs", typeof(string));
    
            var audit_IDParameter = audit_ID != null ?
                new ObjectParameter("Audit_ID", audit_ID) :
                new ObjectParameter("Audit_ID", typeof(string));
    
            var cBYParameter = cBY != null ?
                new ObjectParameter("CBY", cBY) :
                new ObjectParameter("CBY", typeof(string));
    
            var cONParameter = cON.HasValue ?
                new ObjectParameter("CON", cON) :
                new ObjectParameter("CON", typeof(System.DateTime));
    
            var mBYParameter = mBY != null ?
                new ObjectParameter("MBY", mBY) :
                new ObjectParameter("MBY", typeof(string));
    
            var mONParameter = mON.HasValue ?
                new ObjectParameter("MON", mON) :
                new ObjectParameter("MON", typeof(System.DateTime));
    
            var isSubToObsParameter = isSubToObs.HasValue ?
                new ObjectParameter("IsSubToObs", isSubToObs) :
                new ObjectParameter("IsSubToObs", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertAuditForm", actionParameter, auditIDParameter, gridDataParameter, dateOfAuditParameter, siteNameParameter, siteDetailsParameter, auditTeamParameter, observerTeamParameter, strenghtsParameter, majorNCParameter, minorNCParameter, oFIsParameter, audit_IDParameter, cBYParameter, cONParameter, mBYParameter, mONParameter, isSubToObsParameter);
        }
    
        public virtual ObjectResult<getData_Result> getData(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getData_Result>("getData", idParameter);
        }
    
        public virtual ObjectResult<getAuditDetails_Result> getAuditDetails(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAuditDetails_Result>("getAuditDetails", idParameter);
        }
    
        public virtual ObjectResult<getAuditObserverTeam_Result> getAuditObserverTeam(Nullable<int> projectid, string team)
        {
            var projectidParameter = projectid.HasValue ?
                new ObjectParameter("projectid", projectid) :
                new ObjectParameter("projectid", typeof(int));
    
            var teamParameter = team != null ?
                new ObjectParameter("team", team) :
                new ObjectParameter("team", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAuditObserverTeam_Result>("getAuditObserverTeam", projectidParameter, teamParameter);
        }
    
        public virtual int sp_AdminMaster(string action, Nullable<int> roleId, string pSNO, Nullable<bool> isDeleted)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("RoleId", roleId) :
                new ObjectParameter("RoleId", typeof(int));
    
            var pSNOParameter = pSNO != null ?
                new ObjectParameter("PSNO", pSNO) :
                new ObjectParameter("PSNO", typeof(string));
    
            var isDeletedParameter = isDeleted.HasValue ?
                new ObjectParameter("isDeleted", isDeleted) :
                new ObjectParameter("isDeleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AdminMaster", actionParameter, roleIdParameter, pSNOParameter, isDeletedParameter);
        }
    
        public virtual int sp_HSE_insert(string ic, string site, Nullable<System.DateTime> date, string fKAID, string cBY, Nullable<System.DateTime> cON, string mBY, Nullable<System.DateTime> mON)
        {
            var icParameter = ic != null ?
                new ObjectParameter("ic", ic) :
                new ObjectParameter("ic", typeof(string));
    
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var fKAIDParameter = fKAID != null ?
                new ObjectParameter("FKAID", fKAID) :
                new ObjectParameter("FKAID", typeof(string));
    
            var cBYParameter = cBY != null ?
                new ObjectParameter("CBY", cBY) :
                new ObjectParameter("CBY", typeof(string));
    
            var cONParameter = cON.HasValue ?
                new ObjectParameter("CON", cON) :
                new ObjectParameter("CON", typeof(System.DateTime));
    
            var mBYParameter = mBY != null ?
                new ObjectParameter("MBY", mBY) :
                new ObjectParameter("MBY", typeof(string));
    
            var mONParameter = mON.HasValue ?
                new ObjectParameter("MON", mON) :
                new ObjectParameter("MON", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_HSE_insert", icParameter, siteParameter, dateParameter, fKAIDParameter, cBYParameter, cONParameter, mBYParameter, mONParameter);
        }
    
        public virtual int sp_NCReport_insert(string sitename, string department, string auditee, string aCNo, string process, string auditorName, Nullable<System.DateTime> aperiod, string clause, string observerTeam, Nullable<bool> major, Nullable<bool> minor, string req, string observedNC, string evidence, Nullable<System.DateTime> proposedDate, Nullable<System.DateTime> actualDate, string resPerson, string correction, string rootCause, string actionresponse, string eviNC, Nullable<bool> cAA, Nullable<bool> nCD, string comments, string auditor, Nullable<System.DateTime> date, string fKAuditID, string cBY, Nullable<System.DateTime> cON, string mBY, Nullable<System.DateTime> mON)
        {
            var sitenameParameter = sitename != null ?
                new ObjectParameter("sitename", sitename) :
                new ObjectParameter("sitename", typeof(string));
    
            var departmentParameter = department != null ?
                new ObjectParameter("department", department) :
                new ObjectParameter("department", typeof(string));
    
            var auditeeParameter = auditee != null ?
                new ObjectParameter("auditee", auditee) :
                new ObjectParameter("auditee", typeof(string));
    
            var aCNoParameter = aCNo != null ?
                new ObjectParameter("ACNo", aCNo) :
                new ObjectParameter("ACNo", typeof(string));
    
            var processParameter = process != null ?
                new ObjectParameter("process", process) :
                new ObjectParameter("process", typeof(string));
    
            var auditorNameParameter = auditorName != null ?
                new ObjectParameter("auditorName", auditorName) :
                new ObjectParameter("auditorName", typeof(string));
    
            var aperiodParameter = aperiod.HasValue ?
                new ObjectParameter("aperiod", aperiod) :
                new ObjectParameter("aperiod", typeof(System.DateTime));
    
            var clauseParameter = clause != null ?
                new ObjectParameter("clause", clause) :
                new ObjectParameter("clause", typeof(string));
    
            var observerTeamParameter = observerTeam != null ?
                new ObjectParameter("ObserverTeam", observerTeam) :
                new ObjectParameter("ObserverTeam", typeof(string));
    
            var majorParameter = major.HasValue ?
                new ObjectParameter("Major", major) :
                new ObjectParameter("Major", typeof(bool));
    
            var minorParameter = minor.HasValue ?
                new ObjectParameter("Minor", minor) :
                new ObjectParameter("Minor", typeof(bool));
    
            var reqParameter = req != null ?
                new ObjectParameter("req", req) :
                new ObjectParameter("req", typeof(string));
    
            var observedNCParameter = observedNC != null ?
                new ObjectParameter("ObservedNC", observedNC) :
                new ObjectParameter("ObservedNC", typeof(string));
    
            var evidenceParameter = evidence != null ?
                new ObjectParameter("evidence", evidence) :
                new ObjectParameter("evidence", typeof(string));
    
            var proposedDateParameter = proposedDate.HasValue ?
                new ObjectParameter("proposedDate", proposedDate) :
                new ObjectParameter("proposedDate", typeof(System.DateTime));
    
            var actualDateParameter = actualDate.HasValue ?
                new ObjectParameter("actualDate", actualDate) :
                new ObjectParameter("actualDate", typeof(System.DateTime));
    
            var resPersonParameter = resPerson != null ?
                new ObjectParameter("resPerson", resPerson) :
                new ObjectParameter("resPerson", typeof(string));
    
            var correctionParameter = correction != null ?
                new ObjectParameter("correction", correction) :
                new ObjectParameter("correction", typeof(string));
    
            var rootCauseParameter = rootCause != null ?
                new ObjectParameter("rootCause", rootCause) :
                new ObjectParameter("rootCause", typeof(string));
    
            var actionresponseParameter = actionresponse != null ?
                new ObjectParameter("Actionresponse", actionresponse) :
                new ObjectParameter("Actionresponse", typeof(string));
    
            var eviNCParameter = eviNC != null ?
                new ObjectParameter("EviNC", eviNC) :
                new ObjectParameter("EviNC", typeof(string));
    
            var cAAParameter = cAA.HasValue ?
                new ObjectParameter("CAA", cAA) :
                new ObjectParameter("CAA", typeof(bool));
    
            var nCDParameter = nCD.HasValue ?
                new ObjectParameter("NCD", nCD) :
                new ObjectParameter("NCD", typeof(bool));
    
            var commentsParameter = comments != null ?
                new ObjectParameter("comments", comments) :
                new ObjectParameter("comments", typeof(string));
    
            var auditorParameter = auditor != null ?
                new ObjectParameter("auditor", auditor) :
                new ObjectParameter("auditor", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var fKAuditIDParameter = fKAuditID != null ?
                new ObjectParameter("FKAuditID", fKAuditID) :
                new ObjectParameter("FKAuditID", typeof(string));
    
            var cBYParameter = cBY != null ?
                new ObjectParameter("CBY", cBY) :
                new ObjectParameter("CBY", typeof(string));
    
            var cONParameter = cON.HasValue ?
                new ObjectParameter("CON", cON) :
                new ObjectParameter("CON", typeof(System.DateTime));
    
            var mBYParameter = mBY != null ?
                new ObjectParameter("MBY", mBY) :
                new ObjectParameter("MBY", typeof(string));
    
            var mONParameter = mON.HasValue ?
                new ObjectParameter("MON", mON) :
                new ObjectParameter("MON", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_NCReport_insert", sitenameParameter, departmentParameter, auditeeParameter, aCNoParameter, processParameter, auditorNameParameter, aperiodParameter, clauseParameter, observerTeamParameter, majorParameter, minorParameter, reqParameter, observedNCParameter, evidenceParameter, proposedDateParameter, actualDateParameter, resPersonParameter, correctionParameter, rootCauseParameter, actionresponseParameter, eviNCParameter, cAAParameter, nCDParameter, commentsParameter, auditorParameter, dateParameter, fKAuditIDParameter, cBYParameter, cONParameter, mBYParameter, mONParameter);
        }
    
        public virtual ObjectResult<HSE_getData_Result> HSE_getData(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HSE_getData_Result>("HSE_getData", idParameter);
        }
    
        public virtual int sp_insertForm4Details(Nullable<int> fK_AID, string aNO, Nullable<bool> isSentToObs, Nullable<bool> isApproved, string obsTeam)
        {
            var fK_AIDParameter = fK_AID.HasValue ?
                new ObjectParameter("FK_AID", fK_AID) :
                new ObjectParameter("FK_AID", typeof(int));
    
            var aNOParameter = aNO != null ?
                new ObjectParameter("ANO", aNO) :
                new ObjectParameter("ANO", typeof(string));
    
            var isSentToObsParameter = isSentToObs.HasValue ?
                new ObjectParameter("isSentToObs", isSentToObs) :
                new ObjectParameter("isSentToObs", typeof(bool));
    
            var isApprovedParameter = isApproved.HasValue ?
                new ObjectParameter("isApproved", isApproved) :
                new ObjectParameter("isApproved", typeof(bool));
    
            var obsTeamParameter = obsTeam != null ?
                new ObjectParameter("ObsTeam", obsTeam) :
                new ObjectParameter("ObsTeam", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertForm4Details", fK_AIDParameter, aNOParameter, isSentToObsParameter, isApprovedParameter, obsTeamParameter);
        }
    
        public virtual int sp_HSE_update(string ic, string site, Nullable<System.DateTime> date, string gridData, string mBY, Nullable<System.DateTime> mON, Nullable<int> hSEId)
        {
            var icParameter = ic != null ?
                new ObjectParameter("ic", ic) :
                new ObjectParameter("ic", typeof(string));
    
            var siteParameter = site != null ?
                new ObjectParameter("site", site) :
                new ObjectParameter("site", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var gridDataParameter = gridData != null ?
                new ObjectParameter("GridData", gridData) :
                new ObjectParameter("GridData", typeof(string));
    
            var mBYParameter = mBY != null ?
                new ObjectParameter("MBY", mBY) :
                new ObjectParameter("MBY", typeof(string));
    
            var mONParameter = mON.HasValue ?
                new ObjectParameter("MON", mON) :
                new ObjectParameter("MON", typeof(System.DateTime));
    
            var hSEIdParameter = hSEId.HasValue ?
                new ObjectParameter("HSEId", hSEId) :
                new ObjectParameter("HSEId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_HSE_update", icParameter, siteParameter, dateParameter, gridDataParameter, mBYParameter, mONParameter, hSEIdParameter);
        }
    
        public virtual int sp_NCReport_update(string sitename, string department, string auditee, string aCNo, string process, string auditorName, Nullable<System.DateTime> aperiod, string clause, string observerTeam, Nullable<bool> major, Nullable<bool> minor, string req, string observedNC, string evidence, Nullable<System.DateTime> proposedDate, Nullable<System.DateTime> actualDate, string resPerson, string correction, string rootCause, string actionresponse, string eviNC, Nullable<bool> cAA, Nullable<bool> nCD, string comments, string auditor, string mBY, Nullable<System.DateTime> mON, Nullable<int> aID, Nullable<System.DateTime> date)
        {
            var sitenameParameter = sitename != null ?
                new ObjectParameter("sitename", sitename) :
                new ObjectParameter("sitename", typeof(string));
    
            var departmentParameter = department != null ?
                new ObjectParameter("department", department) :
                new ObjectParameter("department", typeof(string));
    
            var auditeeParameter = auditee != null ?
                new ObjectParameter("auditee", auditee) :
                new ObjectParameter("auditee", typeof(string));
    
            var aCNoParameter = aCNo != null ?
                new ObjectParameter("ACNo", aCNo) :
                new ObjectParameter("ACNo", typeof(string));
    
            var processParameter = process != null ?
                new ObjectParameter("process", process) :
                new ObjectParameter("process", typeof(string));
    
            var auditorNameParameter = auditorName != null ?
                new ObjectParameter("auditorName", auditorName) :
                new ObjectParameter("auditorName", typeof(string));
    
            var aperiodParameter = aperiod.HasValue ?
                new ObjectParameter("aperiod", aperiod) :
                new ObjectParameter("aperiod", typeof(System.DateTime));
    
            var clauseParameter = clause != null ?
                new ObjectParameter("clause", clause) :
                new ObjectParameter("clause", typeof(string));
    
            var observerTeamParameter = observerTeam != null ?
                new ObjectParameter("ObserverTeam", observerTeam) :
                new ObjectParameter("ObserverTeam", typeof(string));
    
            var majorParameter = major.HasValue ?
                new ObjectParameter("Major", major) :
                new ObjectParameter("Major", typeof(bool));
    
            var minorParameter = minor.HasValue ?
                new ObjectParameter("Minor", minor) :
                new ObjectParameter("Minor", typeof(bool));
    
            var reqParameter = req != null ?
                new ObjectParameter("req", req) :
                new ObjectParameter("req", typeof(string));
    
            var observedNCParameter = observedNC != null ?
                new ObjectParameter("ObservedNC", observedNC) :
                new ObjectParameter("ObservedNC", typeof(string));
    
            var evidenceParameter = evidence != null ?
                new ObjectParameter("evidence", evidence) :
                new ObjectParameter("evidence", typeof(string));
    
            var proposedDateParameter = proposedDate.HasValue ?
                new ObjectParameter("proposedDate", proposedDate) :
                new ObjectParameter("proposedDate", typeof(System.DateTime));
    
            var actualDateParameter = actualDate.HasValue ?
                new ObjectParameter("actualDate", actualDate) :
                new ObjectParameter("actualDate", typeof(System.DateTime));
    
            var resPersonParameter = resPerson != null ?
                new ObjectParameter("resPerson", resPerson) :
                new ObjectParameter("resPerson", typeof(string));
    
            var correctionParameter = correction != null ?
                new ObjectParameter("correction", correction) :
                new ObjectParameter("correction", typeof(string));
    
            var rootCauseParameter = rootCause != null ?
                new ObjectParameter("rootCause", rootCause) :
                new ObjectParameter("rootCause", typeof(string));
    
            var actionresponseParameter = actionresponse != null ?
                new ObjectParameter("Actionresponse", actionresponse) :
                new ObjectParameter("Actionresponse", typeof(string));
    
            var eviNCParameter = eviNC != null ?
                new ObjectParameter("EviNC", eviNC) :
                new ObjectParameter("EviNC", typeof(string));
    
            var cAAParameter = cAA.HasValue ?
                new ObjectParameter("CAA", cAA) :
                new ObjectParameter("CAA", typeof(bool));
    
            var nCDParameter = nCD.HasValue ?
                new ObjectParameter("NCD", nCD) :
                new ObjectParameter("NCD", typeof(bool));
    
            var commentsParameter = comments != null ?
                new ObjectParameter("comments", comments) :
                new ObjectParameter("comments", typeof(string));
    
            var auditorParameter = auditor != null ?
                new ObjectParameter("auditor", auditor) :
                new ObjectParameter("auditor", typeof(string));
    
            var mBYParameter = mBY != null ?
                new ObjectParameter("MBY", mBY) :
                new ObjectParameter("MBY", typeof(string));
    
            var mONParameter = mON.HasValue ?
                new ObjectParameter("MON", mON) :
                new ObjectParameter("MON", typeof(System.DateTime));
    
            var aIDParameter = aID.HasValue ?
                new ObjectParameter("AID", aID) :
                new ObjectParameter("AID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_NCReport_update", sitenameParameter, departmentParameter, auditeeParameter, aCNoParameter, processParameter, auditorNameParameter, aperiodParameter, clauseParameter, observerTeamParameter, majorParameter, minorParameter, reqParameter, observedNCParameter, evidenceParameter, proposedDateParameter, actualDateParameter, resPersonParameter, correctionParameter, rootCauseParameter, actionresponseParameter, eviNCParameter, cAAParameter, nCDParameter, commentsParameter, auditorParameter, mBYParameter, mONParameter, aIDParameter, dateParameter);
        }
    }
}
